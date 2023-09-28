
IMPORTS System.Collections.Generic
Public Class FrmRetenEmiProvCab
    Inherits System.Windows.Forms.Form
    Dim lista As New List(Of RetencProvDetE)
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtserienum As System.Windows.Forms.TextBox
    Dim Total As Decimal
    Friend WithEvents BTNCONSULTA As System.Windows.Forms.Button
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TIPODOCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CORRELATIVODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAEMISIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTOPAGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTOPEXTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTERETENIDODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTEREEXTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Dim Tmp_Present As DataTable

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
    Friend WithEvents btnbuscarProve As System.Windows.Forms.Button
    Friend WithEvents lblcodproveedor As System.Windows.Forms.Label
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblcambio As System.Windows.Forms.Label
    Friend WithEvents cmbdocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents BTNANULAR As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtDoc1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDoc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtmontop As System.Windows.Forms.TextBox
    Friend WithEvents txtimporte As System.Windows.Forms.TextBox
    Friend WithEvents txtcorrel As System.Windows.Forms.TextBox
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRetenEmiProvCab))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnbuscarProve = New System.Windows.Forms.Button()
        Me.lblcodproveedor = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.lblruc = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmontop = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcorrel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbdocu = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.lblcambio = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNCONSULTA = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNANULAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDoc1 = New System.Windows.Forms.TextBox()
        Me.TxtDoc2 = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtserienum = New System.Windows.Forms.TextBox()
        Me.crRpt = New AxCrystal.AxCrystalReport()
        Me.dgvlista = New System.Windows.Forms.DataGridView()
        Me.TIPODOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORRELATIVODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAEMISIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTOPAGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTOPEXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTERETENIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTEREEXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ruc:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(359, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Seria :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtserie
        '
        Me.txtserie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtserie.Location = New System.Drawing.Point(402, 16)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(72, 20)
        Me.txtserie.TabIndex = 11
        Me.txtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(111, 88)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(168, 20)
        Me.dtpfecha.TabIndex = 12
        '
        'btnbuscarProve
        '
        Me.btnbuscarProve.Location = New System.Drawing.Point(365, 13)
        Me.btnbuscarProve.Name = "btnbuscarProve"
        Me.btnbuscarProve.Size = New System.Drawing.Size(48, 24)
        Me.btnbuscarProve.TabIndex = 26
        Me.btnbuscarProve.Text = "...."
        '
        'lblcodproveedor
        '
        Me.lblcodproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodproveedor.Location = New System.Drawing.Point(429, 15)
        Me.lblcodproveedor.Name = "lblcodproveedor"
        Me.lblcodproveedor.Size = New System.Drawing.Size(111, 20)
        Me.lblcodproveedor.TabIndex = 27
        '
        'txtproveedor
        '
        Me.txtproveedor.Enabled = False
        Me.txtproveedor.Location = New System.Drawing.Point(111, 15)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(245, 20)
        Me.txtproveedor.TabIndex = 28
        '
        'lblruc
        '
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(111, 40)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(168, 20)
        Me.lblruc.TabIndex = 29
        '
        'lbldireccion
        '
        Me.lbldireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldireccion.Location = New System.Drawing.Point(111, 64)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(168, 20)
        Me.lbldireccion.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtmontop)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtcorrel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbdocu)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtserie)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtimporte)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 72)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(570, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Importe Retenido :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(330, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Monto Pago :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtmontop
        '
        Me.txtmontop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmontop.Location = New System.Drawing.Point(402, 42)
        Me.txtmontop.Name = "txtmontop"
        Me.txtmontop.Size = New System.Drawing.Size(152, 20)
        Me.txtmontop.TabIndex = 16
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(98, 42)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(184, 20)
        Me.DateTimePicker2.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha Emision:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcorrel
        '
        Me.txtcorrel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcorrel.Location = New System.Drawing.Point(674, 16)
        Me.txtcorrel.Name = "txtcorrel"
        Me.txtcorrel.Size = New System.Drawing.Size(120, 20)
        Me.txtcorrel.TabIndex = 13
        Me.txtcorrel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(599, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Correlativo :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbdocu
        '
        Me.cmbdocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdocu.Location = New System.Drawing.Point(98, 16)
        Me.cmbdocu.Name = "cmbdocu"
        Me.cmbdocu.Size = New System.Drawing.Size(184, 21)
        Me.cmbdocu.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(40, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo Doc:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtimporte
        '
        Me.txtimporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtimporte.Location = New System.Drawing.Point(674, 42)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(120, 20)
        Me.txtimporte.TabIndex = 33
        '
        'lblcambio
        '
        Me.lblcambio.Location = New System.Drawing.Point(454, 115)
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.Size = New System.Drawing.Size(86, 16)
        Me.lblcambio.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BTNCONSULTA)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNANULAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(832, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 260)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 1
        Me.Button1.Location = New System.Drawing.Point(11, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "&Impresion"
        '
        'BTNCONSULTA
        '
        Me.BTNCONSULTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNCONSULTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCONSULTA.Location = New System.Drawing.Point(11, 164)
        Me.BTNCONSULTA.Name = "BTNCONSULTA"
        Me.BTNCONSULTA.Size = New System.Drawing.Size(75, 23)
        Me.BTNCONSULTA.TabIndex = 42
        Me.BTNCONSULTA.Text = "&Consullta"
        Me.BTNCONSULTA.UseVisualStyleBackColor = True
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.Location = New System.Drawing.Point(11, 135)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.Location = New System.Drawing.Point(11, 193)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Cerrar"
        '
        'BTNANULAR
        '
        Me.BTNANULAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNANULAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNANULAR.ImageIndex = 2
        Me.BTNANULAR.Location = New System.Drawing.Point(11, 77)
        Me.BTNANULAR.Name = "BTNANULAR"
        Me.BTNANULAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNANULAR.TabIndex = 3
        Me.BTNANULAR.Text = "&Anular"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.Location = New System.Drawing.Point(11, 106)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "&Eliminar"
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.Location = New System.Drawing.Point(11, 19)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(75, 23)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(11, 48)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(427, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "TC:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(32, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Serie Numero :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtDoc1
        '
        Me.TxtDoc1.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDoc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDoc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc1.Location = New System.Drawing.Point(111, 112)
        Me.TxtDoc1.MaxLength = 3
        Me.TxtDoc1.Name = "TxtDoc1"
        Me.TxtDoc1.Size = New System.Drawing.Size(57, 20)
        Me.TxtDoc1.TabIndex = 36
        Me.TxtDoc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDoc2
        '
        Me.TxtDoc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDoc2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc2.Location = New System.Drawing.Point(170, 112)
        Me.TxtDoc2.MaxLength = 7
        Me.TxtDoc2.Name = "TxtDoc2"
        Me.TxtDoc2.Size = New System.Drawing.Size(100, 20)
        Me.TxtDoc2.TabIndex = 37
        Me.TxtDoc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.White
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(696, 428)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(100, 20)
        Me.lbltotal.TabIndex = 39
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(657, 432)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Total :"
        '
        'txtserienum
        '
        Me.txtserienum.Location = New System.Drawing.Point(273, 112)
        Me.txtserienum.Name = "txtserienum"
        Me.txtserienum.Size = New System.Drawing.Size(83, 20)
        Me.txtserienum.TabIndex = 40
        Me.txtserienum.Visible = False
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(774, 40)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 42
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoGenerateColumns = False
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPODOCDataGridViewTextBoxColumn, Me.SERIEDataGridViewTextBoxColumn, Me.CORRELATIVODataGridViewTextBoxColumn, Me.FECHAEMISIONDataGridViewTextBoxColumn, Me.MONTOPAGODataGridViewTextBoxColumn, Me.MONTOPEXTDataGridViewTextBoxColumn, Me.IMPORTERETENIDODataGridViewTextBoxColumn, Me.IMPORTEREEXTDataGridViewTextBoxColumn})
        Me.dgvlista.DataSource = Me.BindingSource1
        Me.dgvlista.Location = New System.Drawing.Point(12, 221)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.Size = New System.Drawing.Size(813, 201)
        Me.dgvlista.TabIndex = 45
        '
        'TIPODOCDataGridViewTextBoxColumn
        '
        Me.TIPODOCDataGridViewTextBoxColumn.DataPropertyName = "TIPODOC"
        Me.TIPODOCDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.TIPODOCDataGridViewTextBoxColumn.HeaderText = "TIPODOC"
        Me.TIPODOCDataGridViewTextBoxColumn.Name = "TIPODOCDataGridViewTextBoxColumn"
        Me.TIPODOCDataGridViewTextBoxColumn.Width = 150
        '
        'SERIEDataGridViewTextBoxColumn
        '
        Me.SERIEDataGridViewTextBoxColumn.DataPropertyName = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn.HeaderText = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn.Name = "SERIEDataGridViewTextBoxColumn"
        '
        'CORRELATIVODataGridViewTextBoxColumn
        '
        Me.CORRELATIVODataGridViewTextBoxColumn.DataPropertyName = "CORRELATIVO"
        Me.CORRELATIVODataGridViewTextBoxColumn.HeaderText = "CORRELATIVO"
        Me.CORRELATIVODataGridViewTextBoxColumn.Name = "CORRELATIVODataGridViewTextBoxColumn"
        '
        'FECHAEMISIONDataGridViewTextBoxColumn
        '
        Me.FECHAEMISIONDataGridViewTextBoxColumn.DataPropertyName = "FECHAEMISION"
        Me.FECHAEMISIONDataGridViewTextBoxColumn.HeaderText = "FECHAEMISION"
        Me.FECHAEMISIONDataGridViewTextBoxColumn.Name = "FECHAEMISIONDataGridViewTextBoxColumn"
        '
        'MONTOPAGODataGridViewTextBoxColumn
        '
        Me.MONTOPAGODataGridViewTextBoxColumn.DataPropertyName = "MONTOPAGO"
        Me.MONTOPAGODataGridViewTextBoxColumn.HeaderText = "MONTO PAGO"
        Me.MONTOPAGODataGridViewTextBoxColumn.Name = "MONTOPAGODataGridViewTextBoxColumn"
        Me.MONTOPAGODataGridViewTextBoxColumn.Width = 150
        '
        'MONTOPEXTDataGridViewTextBoxColumn
        '
        Me.MONTOPEXTDataGridViewTextBoxColumn.DataPropertyName = "MONTOPEXT"
        Me.MONTOPEXTDataGridViewTextBoxColumn.HeaderText = "MONTOPEXT"
        Me.MONTOPEXTDataGridViewTextBoxColumn.Name = "MONTOPEXTDataGridViewTextBoxColumn"
        Me.MONTOPEXTDataGridViewTextBoxColumn.Visible = False
        '
        'IMPORTERETENIDODataGridViewTextBoxColumn
        '
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.DataPropertyName = "IMPORTERETENIDO"
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.HeaderText = "IMPORTE RETENIDO"
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.Name = "IMPORTERETENIDODataGridViewTextBoxColumn"
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.Width = 150
        '
        'IMPORTEREEXTDataGridViewTextBoxColumn
        '
        Me.IMPORTEREEXTDataGridViewTextBoxColumn.DataPropertyName = "IMPORTEREEXT"
        Me.IMPORTEREEXTDataGridViewTextBoxColumn.HeaderText = "IMPORTEREEXT"
        Me.IMPORTEREEXTDataGridViewTextBoxColumn.Name = "IMPORTEREEXTDataGridViewTextBoxColumn"
        Me.IMPORTEREEXTDataGridViewTextBoxColumn.Visible = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(NarGestionDistribuidora.RetencProvDetE)
        '
        'FrmRetenEmiProvCab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(933, 458)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.txtserienum)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtDoc1)
        Me.Controls.Add(Me.TxtDoc2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblcambio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblruc)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.lblcodproveedor)
        Me.Controls.Add(Me.btnbuscarProve)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRetenEmiProvCab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Emision de Comprobante De Retencion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarProve.Click
        Dim frmb As New FrmConsProv
        frmb.objIngOPer2 = Me
        frmb.ShowDialog()
        dtpfecha.Focus()
    End Sub

    Private Sub FrmRetenEmiProvCab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblcambio.Text = FACT_GFormatodeNumero(CDbl(VCambioVta))
        CAyuda.CargarDataCombo(Me.cmbdocu, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")

        Call BOTONES(True, False, False, True, False, False)
        Call Bloqueatextbox(Me)


        Me.dtpfecha.Enabled = False
        Me.DateTimePicker2.Enabled = False


        Me.dtpfecha.Value = Format(vFechaActual, "dd/MM/yyyy")

    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click


        Limpiar()
        Call BOTONES(False, True, False, False, True, False)
        Call desbloqueatextbox(Me)
        'txtproveedor.Focus()
        dgvlista.Enabled = True
        lista.Clear()
        dgvlista.DataSource = Nothing

        Me.dtpfecha.Enabled = True
        Me.DateTimePicker2.Enabled = True

        Me.dtpfecha.Value = Format(vFechaActual, "dd/MM/yyyy")

        btnbuscarProve.Focus()



    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean, ByVal BUSCAR_PROV As Boolean, ByVal ANULAR As Boolean)

        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        ' BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        BTNCONSULTA.Enabled = BUSCAR
        btnbuscarProve.Enabled = BUSCAR_PROV
        BTNANULAR.Enabled = ANULAR

    End Sub


    Sub Limpiar()

        txtproveedor.Text = ""
        lblcodproveedor.Text = ""
        lblruc.Text = ""
        lbldireccion.Text = ""

        TxtDoc1.Text = ""
        TxtDoc2.Text = ""
        txtserienum.Text = ""
        lbltotal.Text = ""

        Me.dtpfecha.Value = Now
        Me.DateTimePicker2.Value = Now


        cmbdocu.SelectedIndex = 0
        txtserie.Text = ""
        txtcorrel.Text = ""
        txtmontop.Text = ""
        txtimporte.Text = ""


    End Sub


    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        If TxtDoc1.Text.Length < 4 Then

            MsgBox("EL NUMERO DE DIGITOS DE LA SERIE TIENE QUE SER 4")
            TxtDoc1.Focus()
            Exit Sub
        End If

        If TxtDoc2.Text.Length < 7 Then

            MsgBox("EL NUMERO DE DIGITOS DEL NUMERO TIENE QUE SER 7")
            TxtDoc2.Focus()

            Exit Sub
        End If




        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = dtpfecha.Value.Year
        MES = dtpfecha.Value.Month


        Select Case MES
            Case 1
                DESMES = "ENERO"
            Case 2
                DESMES = "FEBRERO"
            Case 3
                DESMES = "MARZO"
            Case 4
                DESMES = "ABRIL"
            Case 5
                DESMES = "MAYO"
            Case 6
                DESMES = "JUNIO"
            Case 7
                DESMES = "JULIO"
            Case 8
                DESMES = "AGOSTO"
            Case 9
                DESMES = "SETIEMBRE"
            Case 10
                DESMES = "OCTUBRE"
            Case 11
                DESMES = "NOVIEMBRE"
            Case 12
                DESMES = "DECIEMBRE"
        End Select

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If
        '************************************************************************************************







        Dim totalbase, totalext As Decimal
        txtserienum.Text = TxtDoc1.Text.ToString & TxtDoc2.Text.ToString

        If lblcodproveedor.Text.Trim.Length = 0 Then
            MessageBox.Show("Seleccione un Proveedor ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblcodproveedor.Focus()
            Exit Sub
        End If

        If TxtDoc1.Text.Trim.Length = 0 Then
            MessageBox.Show("Falta numero Serie de cabecera ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtDoc1.Focus()
            Exit Sub
        End If

        If TxtDoc2.Text.Trim.Length = 0 Then
            MessageBox.Show("Falta numero correlativo de cabecera ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtDoc2.Focus()
            Exit Sub
        End If

        If lista.Count = 0 Then
            MsgBox("- No hay Documentos Ingresados.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        If TmpListarDatos("SELECT * FROM RETENEMIPROVCAB where CODEMPRESA='" & codempresa & "' AND  NRONTARETEN= '" & CInt(TxtDoc1.Text.Trim) & TxtDoc2.Text.Trim & "' ").Rows.Count > 0 Then
            MsgBox("EL NUMERO DOCUMENTO YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            TxtDoc1.Focus()
            Exit Sub
        End If


        Dim t_consulta As DataTable
        For Each i As RetencProvDetE In lista
            t_consulta = TmpListarDatos("SP_BUSCAR_DOCRETEN '" & i.TIPODOC.CODIGO & "','" & i.SERIE & i.CORRELATIVO & "'")

            If t_consulta.Rows.Count > 0 Then
                Dim t_TAB As DataTable
                t_TAB = TmpListarDatos("NSP_SELECT_LISTATIPODOC_R '" & codempresa & "','" & i.TIPODOC.CODIGO & "'")
                MsgBox("Ya existe el documento " & t_TAB.Rows(0)("Descripción").ToString & " SERIE " & i.SERIE & " CORRELATIVO " & i.CORRELATIVO)
                Exit Sub
            Else

            End If


        Next



        Dim var = True
        For Each i As RetencProvDetE In lista
            CAyuda.Ejecutar("SP_REG_RETENEMIPROVDET", codempresa, txtserienum.Text.Trim, i.TIPODOC.CODIGO, i.SERIE, i.SERIE & i.CORRELATIVO, i.FECHAEMISION, Trim(FACT_CDMONEDA), "", i.MONTOPAGO, i.MONTOPEXT, i.IMPORTERETENIDO, i.IMPORTEREEXT)
            totalbase = totalbase + i.IMPORTERETENIDO
            totalext = totalext + i.IMPORTEREEXT
        Next


        If CAyuda.Ejecutar("SP_REG_RETENEMIPROVCAB", codempresa, txtserienum.Text.Trim, Trim(FACT_CDMONEDA), CDbl(Me.lblcambio.Text), VCODRETENCION, "", dtpfecha.Value.ToShortDateString, FECHAPROC, totalbase, totalext, lblcodproveedor.Text.Trim, lblruc.Text.Trim, txtproveedor.Text.Trim, lbldireccion.Text.Trim, CodUsuario, DBNull.Value) <> 0 Then
            MsgBox("- SE GUARDO CON EXITO.", MsgBoxStyle.Information, "NARSISTEMAS")
            'Bloqueo(False)
        End If


        REPORTE()
        CargarGridFact()
        Limpiar()
        Call Bloqueatextbox(Me)
        Call BOTONES(True, False, False, True, False, False)

        Me.dtpfecha.Enabled = False
        Me.DateTimePicker2.Enabled = False

    End Sub

    Private Sub TxtDoc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDoc1.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub TxtDoc1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc1.TextChanged

    End Sub

    Private Sub TxtDoc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDoc1.KeyDown

        If e.KeyCode = Keys.Enter Then
            TxtDoc1.Text = "0000" & TxtDoc1.Text.Trim
            TxtDoc1.Text = Mid(TxtDoc1.Text, TxtDoc1.Text.Length - 3)
            TxtDoc2.Focus()
        End If

    End Sub

    Private Sub TxtDoc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDoc2.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If


    End Sub

    Private Sub TxtDoc2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc2.TextChanged

    End Sub

    Private Sub TxtDoc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDoc2.KeyDown

        If e.KeyCode = Keys.Enter Then
            TxtDoc2.Text = "0000000" & TxtDoc2.Text.Trim
            TxtDoc2.Text = Mid(TxtDoc2.Text, TxtDoc2.Text.Length - 6)
            cmbdocu.Focus()
            'If TmpListarDatos("NSP_BUSCAR_DOCUMEN_MOVICAB  '" & codempresa & "','" & IIf(cbProveedor.Enabled = True, cbProveedor.SelectedValue.ToString.Trim, "") & "' ,'" & cbotipo.SelectedValue.ToString.Trim & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "' ").Rows.Count > 0 Then
            '    MsgBox("YA EXISTE ESTE DOCUMENTO REGISTRADO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            'End If
        End If

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtimporte.TextChanged

    End Sub

    Private Function Valida_Existe(ByVal o As RetencProvDetE) As Boolean
        If o.SERIE = Me.txtserie.Text.Trim AndAlso o.CORRELATIVO = Me.txtcorrel.Text.Trim Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtimporte.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then

            Dim monto, importe As Decimal
            If Decimal.TryParse(Me.txtmontop.Text, monto) = False Then
                Me.txtmontop.SelectAll()
                Me.txtmontop.Focus()
                Exit Sub
            End If
            If Decimal.TryParse(Me.txtimporte.Text, importe) = False Then
                Me.txtimporte.SelectAll()
                Me.txtimporte.Focus()
                Exit Sub
            End If





            Dim d As New RetencProvDetE
            Dim t As New TipoDocE


            t.TIPODOCUMENTO = Me.cmbdocu.Text
            t.CODIGO = Me.cmbdocu.SelectedValue.ToString
            d.TIPODOC = t
            d.FECHAEMISION = Me.DateTimePicker2.Value.ToShortDateString
            d.SERIE = Me.txtserie.Text
            d.MONTOPAGO = monto
            d.MONTOPEXT = d.MONTOPAGO / Convert.ToDecimal(lblcambio.Text)
            d.CORRELATIVO = txtcorrel.Text
            d.IMPORTERETENIDO = importe
            d.IMPORTEREEXT = d.IMPORTERETENIDO / Convert.ToDecimal(lblcambio.Text)
            lista.Add(d)

            Calcula_Total()

            txtserie.Text = ""
            txtcorrel.Text = ""
            txtmontop.Text = ""
            txtimporte.Text = ""

            cmbdocu.Focus()

        End If





        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtimporte.KeyDown


    End Sub


    Private Sub Calcula_Total()


        Me.dgvlista.DataSource = Nothing
        Me.dgvlista.DataSource = lista


        Total = 0
        For x As Integer = 0 To lista.Count - 1
            Total = Total + lista.Item(x).IMPORTERETENIDO
        Next
        Me.lbltotal.Text = Total.ToString("c")

    End Sub

    Private Sub txtserie_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtserie.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtserie.Text = "0000" & txtserie.Text.Trim
            txtserie.Text = Mid(txtserie.Text, txtserie.Text.Length - 3)
            txtcorrel.Focus()
        End If

    End Sub

    Private Sub txtserie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtserie.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If


    End Sub


    Private Sub txtserie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtserie.TextChanged

    End Sub

    Private Sub cmbdocu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdocu.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtserie.Focus()
        End If

    End Sub

    Private Sub DateTimePicker2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker2.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtmontop.Focus()
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub txtcorrel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcorrel.KeyDown



        If e.KeyCode = Keys.Enter Then
            txtcorrel.Text = "0000000" & txtcorrel.Text.Trim
            txtcorrel.Text = Mid(txtcorrel.Text, txtcorrel.Text.Length - 6)
            DateTimePicker2.Focus()
            'If TmpListarDatos("NSP_BUSCAR_DOCUMEN_MOVICAB  '" & codempresa & "','" & IIf(cbProveedor.Enabled = True, cbProveedor.SelectedValue.ToString.Trim, "") & "' ,'" & cbotipo.SelectedValue.ToString.Trim & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "' ").Rows.Count > 0 Then
            '    MsgBox("YA EXISTE ESTE DOCUMENTO REGISTRADO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            'End If

            If lista.Exists(AddressOf Valida_Existe) = True Then
                MsgBox("- El Documento ya fue Ingresado.", MsgBoxStyle.Information, "NARSISTEMAS")
                txtcorrel.Text = ""
                txtcorrel.Focus()
                Exit Sub
            Else
                DateTimePicker2.Focus()
            End If


        End If



    End Sub

    Private Sub txtcorrel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorrel.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If




        If Keyascii = 13 Then
            DateTimePicker2.Focus()
        End If

    End Sub


    Private Sub txtcorrel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcorrel.TextChanged

    End Sub

    Private Sub txtmontop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmontop.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtimporte.Focus()
        End If


        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If




    End Sub

    Private Sub txtmontop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmontop.TextChanged

    End Sub

    Private Sub dtpfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfecha.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            TxtDoc1.Focus()
        End If

    End Sub



    Private Sub dtpfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfecha.ValueChanged

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F3
                If Me.dgvlista.Focused = True Then
                    Dim i = Me.dgvlista.RowCount
                    If i > 0 Then
                        lista.RemoveAt(dgvlista.CurrentRow.Index)
                        Calcula_Total()
                    End If
                End If
        End Select

    End Function



    Private Sub CargarGridFact()
        'Tmp_Present = TmpListarDatos("NSP_SELECT_TMP_RETENEMIPROVDET")
        'dgvlista.DataSource = Tmp_Present

        CargagridRETENEMIPROVDET(dgvlista, "NSP_SELECT_TMP_RETENEMIPROVDET")

    End Sub

    Private Sub dgvlista_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

    Private Sub BTNCONSULTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCONSULTA.Click


        Dim Tmp_Present As DataTable
        Tmp_Present = TmpListarDatos("NSP_SELECT_RETENEMIPROVCAB '" & codempresa & "'")
        If Tmp_Present.Rows.Count = 0 Then
            MsgBox("NO HAY DATOS ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        Dim FRMX As New FrmConsultaEmisionRet
        'FRMX.CODPEDIDO = Grid1.Item(Grid1.CurrentRowIndex, 0)
        FRMX.objRetenEmiProvCab = Me
        FRMX.ShowDialog()

        If txtserienum.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        ' CargagridRETENEMIPROVDET(dgvlista, "NSP_SELECT_RETENEMIPROVDET '" & codempresa & "','" & txtserienum.Text & "'")

        Dim t_consulta As DataTable
        t_consulta = TmpListarDatos("NSP_SELECT_RETENEMIPROVDET '" & codempresa & "','" & txtserienum.Text & "'")
        lista.Clear()
        For Each dr2 As DataRow In t_consulta.Rows
            Dim d As New RetencProvDetE
            Dim t As New TipoDocE
            t.TIPODOCUMENTO = dr2.Item(1).ToString
            t.CODIGO = dr2.Item(0).ToString
            d.TIPODOC = t
            d.FECHAEMISION = dr2.Item(4).ToString
            d.SERIE = dr2.Item(2).ToString
            d.MONTOPAGO = dr2.Item(7).ToString
            d.MONTOPEXT = dr2.Item(8).ToString
            d.CORRELATIVO = dr2.Item(3).ToString
            d.IMPORTERETENIDO = dr2.Item(9).ToString
            d.IMPORTEREEXT = dr2.Item(10).ToString
            lista.Add(d)
        Next

        Me.dgvlista.DataSource = Nothing
        Me.dgvlista.DataSource = lista

        TxtDoc1.Text = txtserienum.Text.Substring(0, txtserienum.Text.Trim.Length - 7)
        TxtDoc1.Text = "0000" & TxtDoc1.Text
        TxtDoc1.Text = Mid(TxtDoc1.Text, TxtDoc1.Text.Length - 3)

        TxtDoc2.Text = Microsoft.VisualBasic.Right(txtserienum.Text, 7)

        Call BOTONES(True, False, True, True, False, True)

        If TmpListarDatos("SELECT * FROM RETENEMIPROVCAB where CODEMPRESA='" & codempresa & "' AND  NRONTARETEN= '" & CInt(TxtDoc1.Text.Trim) & TxtDoc2.Text.Trim & "' AND estado='A'").Rows.Count > 0 Then
            MsgBox("EL DOCUMENTO YA ESTA ANULADO ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        dgvlista.Enabled = False

    End Sub

    Sub REPORTE()

        Dim Tmp_Present As DataTable

        If TxtDoc1.Text.Trim.Length = 0 Then
            MsgBox("SELECCIONE UN DOCUMENTO PARA EL REPORTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        If TxtDoc2.Text.Trim.Length = 0 Then
            MsgBox("SELECCIONE UN DOCUMENTO PARA EL REPORTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        Tmp_Present = TmpListarDatos("NSP_SELECT_RETENEMIPROVCAB_XNUM '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim) & TxtDoc2.Text.Trim & "'")

        If Tmp_Present.Rows.Count = 0 Then
            MsgBox("SELECCIONE UN DOCUMENTO PARA EL REPORTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        Dim formTotLetrasDoc As String
        formTotLetrasDoc = FACT_TotalLetras(lbltotal.Text, "NUEVOS SOLES")
        ' StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString), "NUEVOS SOLES")

        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Reporte_Reten_Emision.rpt"

            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, CInt(TxtDoc1.Text.Trim) & TxtDoc2.Text.Trim)
            crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            'crRpt.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click



        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            Dim PROCESO As Boolean
            Dim sql As String

            sql = "SP_DEL_RETENEMIPROVCAB '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim) & TxtDoc2.Text.Trim & "'"
            PROCESO = TmpInsertDatos(sql)

            If PROCESO = False Then
                Exit Sub
            Else
                MsgBox("SE ELIMINO CORRECTAMENTE EL  REGISTRO...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            End If

            sql = "SP_DEL_RETENEMIPROVDET '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim) & TxtDoc2.Text.Trim & "'"
            PROCESO = TmpInsertDatos(sql)



            BOTONES(True, False, False, True, False, False)
            Call Bloqueatextbox(Me)
            Limpiar()
            CargarGridFact()

            Me.dtpfecha.Enabled = False
            Me.DateTimePicker2.Enabled = False


        End If


    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Limpiar()
        Call BOTONES(True, False, False, True, False, False)
        Call Bloqueatextbox(Me)
        CAyuda.Ejecutar("NSP_DELETE_TMP_RETENEMIPROVDET")
        CargarGridFact()

        Me.dtpfecha.Enabled = False
        Me.DateTimePicker2.Enabled = False

    End Sub

    Private Sub BTNANULAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNANULAR.Click

        If MsgBox("Desea Anular Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            CAyuda.Ejecutar("SP_UPDATE_ANULAR_RETENEMIPROVCAB ", codempresa, CInt(TxtDoc1.Text.Trim) & TxtDoc2.Text.Trim)
            CAyuda.Ejecutar("SP_UPDATE_ANULAR_RETENEMIPROVDET ", codempresa, CInt(TxtDoc1.Text.Trim) & TxtDoc2.Text.Trim)
            MsgBox("SE ANULO EL DOCUMENTO ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

            CAyuda.Ejecutar("NSP_DELETE_TMP_RETENEMIPROVDET")
            CargarGridFact()
            Limpiar()
            Call Bloqueatextbox(Me)
            Call BOTONES(True, False, False, True, False, False)

            Me.dtpfecha.Enabled = False
            Me.DateTimePicker2.Enabled = False

        End If




    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub txtproveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtproveedor.KeyPress


        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Dim frmb As New FrmConsProv
            frmb.objIngOPer2 = Me
            frmb.ShowDialog()
            dtpfecha.Focus()
        End If


    End Sub

    Private Sub txtproveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtproveedor.TextChanged

    End Sub

    Private Sub BtnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim Tmp_Present As DataTable

        If TxtDoc1.Text.Trim.Length = 0 Then
            MsgBox("SELECCIONE UN DOCUMENTO PARA EL REPORTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        If TxtDoc2.Text.Trim.Length = 0 Then
            MsgBox("SELECCIONE UN DOCUMENTO PARA EL REPORTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        Tmp_Present = TmpListarDatos("NSP_SELECT_RETENEMIPROVCAB_XNUM '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim) & TxtDoc2.Text.Trim & "'")

        If Tmp_Present.Rows.Count = 0 Then
            MsgBox("SELECCIONE UN DOCUMENTO PARA EL REPORTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If



        Dim formTotLetrasDoc As String
        formTotLetrasDoc = FACT_TotalLetras(lbltotal.Text, "NUEVOS SOLES")
        ' StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString), "NUEVOS SOLES")


        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Reporte_Reten_Emision.rpt"
            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, txtserienum.Text)
            crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            'crRpt.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            With crRpt
                .set_StoredProcParam(0, codempresa)
                .set_StoredProcParam(1, txtserienum.Text)
                '.set_StoredProcParam(2, CStr(VNroDoc))
                '.set_StoredProcParam(3, Format(CDate(Me.dtpfechadoc.Value), "dd/MM/yyyy"))
                .set_Formulas(1, "formTotLetras='" & meTotalLetras(CDbl(lbltotal.Text), "Nuevos Soles") & "'")
                '.set_Formulas(2, "formnundoc='" & CStr(VNroDoc) & "'")
                .ReportFileName = rutareporte + CType("Rpt_reten.rpt", String)
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
                Exit Sub
            End With



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Public Function meTotalLetras(ByVal nume As Double, ByVal TMONEDA As String) As String
        '------------------------------------
        '  nume    : Cifra (incluye decimales)
        '  TMONEDA : Texto que debe indicar la moneda ("Nuevos Soles","Dolares")
        '------------------------------------

        Dim c1 As String = String.Empty
        Dim c2 As String = String.Empty
        Dim c3 As String = String.Empty
        Dim c4 As String = String.Empty
        Dim z1 As String = String.Empty
        Dim xdec As String = String.Empty
        Dim xcad_dec As String = String.Empty
        Dim z As String = String.Empty
        Dim s As String = String.Empty
        Dim u As String = String.Empty
        Dim d As String = String.Empty
        Dim c As String = String.Empty
        Dim sys As String = String.Empty
        Dim cifra As String = String.Empty
        Dim xlg As Double
        Dim K, Y, N As Integer
        xlg = 12 - Len(Trim(CStr(Int(nume))))
        z1 = Space(xlg) & Trim(CStr(Int(nume)))
        xdec = Microsoft.VisualBasic.Right(Format(nume - Int(nume), "#0.00"), 2)
        xcad_dec = " Y " + xdec + "/100"

        K = 1
        Y = 10
        N = 3
        Do While K <= 4
            z = Mid(z1, Y, 3)
            s = Mid(z, N, 1)
            If s = "1" Then
                u = "UNO"
                If K = 2 Or K = 3 Then
                    u = "UN"
                End If
            Else
                u = IIf(s = "2", "DOS", IIf(s = "3", "TRES", IIf(s = "4", "CUATRO",
                    IIf(s = "5", "CINCO", IIf(s = "6", "SEIS", IIf(s = "7", "SIETE",
                    IIf(s = "8", "OCHO", IIf(s = "9", "NUEVE", ""))))))))
            End If

            If Mid(z, N - 1, 1) = "1" Then
                If Mid(z, N, 1) = "0" Then
                    d = "DIEZ"
                Else
                    If Mid(z, N, 1) = "1" Then
                        d = "ONCE"
                        u = ""
                    Else
                        If Mid(z, N, 1) = "2" Then
                            d = "DOCE"
                            u = ""
                        Else
                            If Mid(z, N, 1) = "3" Then
                                d = "TRECE"
                                u = ""
                            Else
                                If Mid(z, N, 1) = "4" Then
                                    d = "CATORCE"
                                    u = ""
                                Else
                                    If Mid(z, N, 1) = "5" Then
                                        d = "QUINCE"
                                        u = ""
                                    Else
                                        d = "DIECI"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                If Mid(z, N - 1, 1) = "2" Then
                    If Mid(z, N, 1) = "0" Then
                        d = "VEINTE"
                    Else
                        d = "VEINTE Y "
                    End If
                Else
                    If Mid(z, N - 1, 1) = "3" Then
                        If Mid(z, N, 1) = "0" Then
                            d = "TREINTA"
                        Else
                            d = "TREINTA Y "
                        End If
                    Else
                        If Mid(z, N - 1, 1) = "4" Then
                            If Mid(z, N, 1) = "0" Then
                                d = "CUARENTA"
                            Else
                                d = "CUARENTA Y "
                            End If
                        Else
                            If Mid(z, N - 1, 1) = "5" Then
                                If Mid(z, N, 1) = "0" Then
                                    d = "CINCUENTA"
                                Else
                                    d = "CINCUENTA Y "
                                End If
                            Else
                                If Mid(z, N - 1, 1) = "6" Then
                                    If Mid(z, N, 1) = "0" Then
                                        d = "SESENTA"
                                    Else
                                        d = "SESENTA Y "
                                    End If
                                Else
                                    If Mid(z, N - 1, 1) = "7" Then
                                        If Mid(z, N, 1) = "0" Then
                                            d = "SETENTA"
                                        Else
                                            d = "SETENTA Y "
                                        End If
                                    Else
                                        If Mid(z, N - 1, 1) = "8" Then
                                            If Mid(z, N, 1) = "0" Then
                                                d = "OCHENTA"
                                            Else
                                                d = "OCHENTA Y "
                                            End If
                                        Else
                                            If Mid(z, N - 1, 1) = "9" Then
                                                If Mid(z, N, 1) = "0" Then
                                                    d = "NOVENTA"
                                                Else
                                                    d = "NOVENTA Y "
                                                End If
                                            Else
                                                d = ""
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If Mid(z, N - 2, 1) = "1" Then
                If Mid(z, N - 1, 1) = "0" And Mid(z, N, 1) = "0" Then
                    c = "CIEN"
                Else
                    c = "CIENTO"
                End If
            Else
                If Mid(z, N - 2, 1) = "2" Then
                    c = "DOSCIENTOS"
                Else
                    If Mid(z, N - 2, 1) = "3" Then
                        c = "TRESCIENTOS"
                    Else
                        If Mid(z, N - 2, 1) = "4" Then
                            c = "CUATROCIENTOS"
                        Else
                            If Mid(z, N - 2, 1) = "5" Then
                                c = "QUINIENTOS"
                            Else
                                If Mid(z, N - 2, 1) = "6" Then
                                    c = "SEISCIENTOS"
                                Else
                                    If Mid(z, N - 2, 1) = "7" Then
                                        c = "SETECIENTOS"
                                    Else
                                        If Mid(z, N - 2, 1) = "8" Then
                                            c = "OCHOCIENTOS"
                                        Else
                                            If Mid(z, N - 2, 1) = "9" Then
                                                c = "NOVECIENTOS"
                                            Else
                                                c = ""
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Select Case K
                Case 1
                    c1 = c + " " + d + u
                Case 2
                    c2 = c + " " + d + u
                Case 3
                    c3 = c + " " + d + u
                Case 4
                    c4 = c + " " + d + u
            End Select
            K = K + 1
            Y = Y - 3
        Loop
        If (Len(c4) - 1) <> 0 Then
            If c4 = "UN" Then
                sys = " MILLON "
            Else
                sys = " MILLONES "
            End If
            cifra = c4 + " MIL " + c3 + sys + c2 + " MIL " + c1
        Else
            If (Len(c3) - 1) <> 0 Then
                If c3 = "UN" Then
                    sys = " MILLON "
                Else
                    sys = " MILLONES "
                End If
                cifra = c3 + sys + c2 + " MIL " + c1
            Else
                If (Len(c2) - 1) <> 0 Then
                    cifra = c2 + " MIL " + c1
                Else
                    If Len(c1) <> 0 Then
                        cifra = c1
                    End If
                End If
            End If
        End If
        TMONEDA = " " + TMONEDA

        meTotalLetras = Trim(cifra + xcad_dec + TMONEDA)
    End Function

    Private Sub dgvlista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub
End Class
