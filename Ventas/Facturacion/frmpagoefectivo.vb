Imports System.Data.SqlClient

Public Class frmpagoefectivo
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmontobase As System.Windows.Forms.Label
    Friend WithEvents lblmontoextr As System.Windows.Forms.Label
    Friend WithEvents lblmontobas1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLcambio As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLMONBASE As System.Windows.Forms.Label
    Friend WithEvents LBLMONEXTR As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblsimbolotarj As System.Windows.Forms.Label
    Friend WithEvents AxCtrlNumber6 As AxMiControl.AxCtrlNumber
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblsimbolovale As System.Windows.Forms.Label
    Friend WithEvents ctrlacumuladovales As AxMiControl.AxCtrlNumber
    Friend WithEvents ctrlmontovales As AxMiControl.AxCtrlNumber
    Friend WithEvents ctrlnumerovale As AxMiControl.AxCtrlNumber
    Friend WithEvents cbomonevales As System.Windows.Forms.ComboBox
    Friend WithEvents cbotarjeta As System.Windows.Forms.ComboBox
    Friend WithEvents txtreferenciavale As System.Windows.Forms.TextBox
    Friend WithEvents ctrlacumuladotarjeta As AxMiControl.AxCtrlNumber
    Friend WithEvents ctrlmontotarjeta As AxMiControl.AxCtrlNumber
    Friend WithEvents ctrlnumerotarjeta As AxMiControl.AxCtrlNumber
    Friend WithEvents cbomonedatarjeta As System.Windows.Forms.ComboBox
    Friend WithEvents ctrlvuelto As AxMiControl.AxCtrlNumber
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnvuelto As System.Windows.Forms.Button
    Friend WithEvents ctrlefectivoextr As AxMiControl.AxCtrlNumber
    Friend WithEvents ctrlefectivobas As AxMiControl.AxCtrlNumber
    Friend WithEvents LBLMONEDAVUELTO As System.Windows.Forms.Label
    Friend WithEvents LBLSIMBOLOCAMBIO As System.Windows.Forms.Label
    Friend WithEvents LBLSIMBOLOTOTAL As System.Windows.Forms.Label
    Friend WithEvents Gridtarjeta As System.Windows.Forms.DataGrid
    Friend WithEvents gridvale As System.Windows.Forms.DataGrid
    Friend WithEvents frmvuelto As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmpagoefectivo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnvuelto = New System.Windows.Forms.Button
        Me.frmvuelto = New System.Windows.Forms.GroupBox
        Me.LBLMONEDAVUELTO = New System.Windows.Forms.Label
        Me.ctrlvuelto = New AxMiControl.AxCtrlNumber
        Me.AxCtrlNumber6 = New AxMiControl.AxCtrlNumber
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ctrlacumuladotarjeta = New AxMiControl.AxCtrlNumber
        Me.lblsimbolotarj = New System.Windows.Forms.Label
        Me.Gridtarjeta = New System.Windows.Forms.DataGrid
        Me.ctrlmontotarjeta = New AxMiControl.AxCtrlNumber
        Me.ctrlnumerotarjeta = New AxMiControl.AxCtrlNumber
        Me.cbomonedatarjeta = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbotarjeta = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtreferenciavale = New System.Windows.Forms.TextBox
        Me.ctrlacumuladovales = New AxMiControl.AxCtrlNumber
        Me.lblsimbolovale = New System.Windows.Forms.Label
        Me.gridvale = New System.Windows.Forms.DataGrid
        Me.ctrlmontovales = New AxMiControl.AxCtrlNumber
        Me.ctrlnumerovale = New AxMiControl.AxCtrlNumber
        Me.cbomonevales = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ctrlefectivoextr = New AxMiControl.AxCtrlNumber
        Me.LBLMONEXTR = New System.Windows.Forms.Label
        Me.ctrlefectivobas = New AxMiControl.AxCtrlNumber
        Me.LBLMONBASE = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LBLSIMBOLOTOTAL = New System.Windows.Forms.Label
        Me.LBLSIMBOLOCAMBIO = New System.Windows.Forms.Label
        Me.LBLcambio = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblmontobas1 = New System.Windows.Forms.Label
        Me.lblmontoextr = New System.Windows.Forms.Label
        Me.lblmontobase = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.frmvuelto.SuspendLayout()
        CType(Me.ctrlvuelto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCtrlNumber6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ctrlacumuladotarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridtarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrlmontotarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrlnumerotarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ctrlacumuladovales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridvale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrlmontovales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrlnumerovale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ctrlefectivoextr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrlefectivobas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.btnvuelto)
        Me.GroupBox1.Controls.Add(Me.frmvuelto)
        Me.GroupBox1.Controls.Add(Me.AxCtrlNumber6)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnaceptar)
        Me.GroupBox4.Controls.Add(Me.btnnuevo)
        Me.GroupBox4.Controls.Add(Me.btncancelar)
        Me.GroupBox4.Location = New System.Drawing.Point(273, 418)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(279, 51)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        '
        'btnaceptar
        '
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(5, 12)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(91, 31)
        Me.btnaceptar.TabIndex = 64
        Me.btnaceptar.Text = "&Aceptar (F7)"
        '
        'btnnuevo
        '
        Me.btnnuevo.Enabled = False
        Me.btnnuevo.Location = New System.Drawing.Point(96, 12)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(91, 31)
        Me.btnnuevo.TabIndex = 65
        Me.btnnuevo.Text = "&Nueva Venta"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(183, 12)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 31)
        Me.btncancelar.TabIndex = 66
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnvuelto
        '
        Me.btnvuelto.Location = New System.Drawing.Point(460, 435)
        Me.btnvuelto.Name = "btnvuelto"
        Me.btnvuelto.Size = New System.Drawing.Size(82, 24)
        Me.btnvuelto.TabIndex = 67
        Me.btnvuelto.Text = "Vuelto D/S"
        Me.btnvuelto.Visible = False
        '
        'frmvuelto
        '
        Me.frmvuelto.Controls.Add(Me.LBLMONEDAVUELTO)
        Me.frmvuelto.Controls.Add(Me.ctrlvuelto)
        Me.frmvuelto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmvuelto.Location = New System.Drawing.Point(9, 415)
        Me.frmvuelto.Name = "frmvuelto"
        Me.frmvuelto.Size = New System.Drawing.Size(259, 53)
        Me.frmvuelto.TabIndex = 63
        Me.frmvuelto.TabStop = False
        Me.frmvuelto.Text = "Vuelto"
        '
        'LBLMONEDAVUELTO
        '
        Me.LBLMONEDAVUELTO.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMONEDAVUELTO.Location = New System.Drawing.Point(66, 24)
        Me.LBLMONEDAVUELTO.Name = "LBLMONEDAVUELTO"
        Me.LBLMONEDAVUELTO.Size = New System.Drawing.Size(29, 19)
        Me.LBLMONEDAVUELTO.TabIndex = 1
        '
        'ctrlvuelto
        '
        Me.ctrlvuelto.ContainingControl = Me
        Me.ctrlvuelto.Enabled = True
        Me.ctrlvuelto.Location = New System.Drawing.Point(97, 17)
        Me.ctrlvuelto.Name = "ctrlvuelto"
        Me.ctrlvuelto.OcxState = CType(resources.GetObject("ctrlvuelto.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctrlvuelto.Size = New System.Drawing.Size(155, 28)
        Me.ctrlvuelto.TabIndex = 0
        '
        'AxCtrlNumber6
        '
        Me.AxCtrlNumber6.ContainingControl = Me
        Me.AxCtrlNumber6.Enabled = True
        Me.AxCtrlNumber6.Location = New System.Drawing.Point(442, 644)
        Me.AxCtrlNumber6.Name = "AxCtrlNumber6"
        Me.AxCtrlNumber6.OcxState = CType(resources.GetObject("AxCtrlNumber6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCtrlNumber6.Size = New System.Drawing.Size(135, 28)
        Me.AxCtrlNumber6.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(399, 645)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 29)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "S/."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(5, 147)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(544, 263)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.ctrlacumuladotarjeta)
        Me.TabPage1.Controls.Add(Me.lblsimbolotarj)
        Me.TabPage1.Controls.Add(Me.Gridtarjeta)
        Me.TabPage1.Controls.Add(Me.ctrlmontotarjeta)
        Me.TabPage1.Controls.Add(Me.ctrlnumerotarjeta)
        Me.TabPage1.Controls.Add(Me.cbomonedatarjeta)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cbotarjeta)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(536, 231)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "                    TARJETAS                        "
        '
        'ctrlacumuladotarjeta
        '
        Me.ctrlacumuladotarjeta.ContainingControl = Me
        Me.ctrlacumuladotarjeta.Enabled = True
        Me.ctrlacumuladotarjeta.Location = New System.Drawing.Point(413, 199)
        Me.ctrlacumuladotarjeta.Name = "ctrlacumuladotarjeta"
        Me.ctrlacumuladotarjeta.OcxState = CType(resources.GetObject("ctrlacumuladotarjeta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctrlacumuladotarjeta.Size = New System.Drawing.Size(118, 28)
        Me.ctrlacumuladotarjeta.TabIndex = 51
        '
        'lblsimbolotarj
        '
        Me.lblsimbolotarj.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsimbolotarj.Location = New System.Drawing.Point(351, 204)
        Me.lblsimbolotarj.Name = "lblsimbolotarj"
        Me.lblsimbolotarj.Size = New System.Drawing.Size(32, 24)
        Me.lblsimbolotarj.TabIndex = 50
        Me.lblsimbolotarj.Text = "S/."
        Me.lblsimbolotarj.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Gridtarjeta
        '
        Me.Gridtarjeta.BackgroundColor = System.Drawing.Color.White
        Me.Gridtarjeta.CaptionBackColor = System.Drawing.Color.Silver
        Me.Gridtarjeta.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gridtarjeta.CaptionForeColor = System.Drawing.Color.Black
        Me.Gridtarjeta.CaptionText = "                                                                        Eliminar " & _
        "Item [F3]"
        Me.Gridtarjeta.DataMember = ""
        Me.Gridtarjeta.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gridtarjeta.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Gridtarjeta.Location = New System.Drawing.Point(6, 61)
        Me.Gridtarjeta.Name = "Gridtarjeta"
        Me.Gridtarjeta.ReadOnly = True
        Me.Gridtarjeta.Size = New System.Drawing.Size(528, 136)
        Me.Gridtarjeta.TabIndex = 49
        '
        'ctrlmontotarjeta
        '
        Me.ctrlmontotarjeta.ContainingControl = Me
        Me.ctrlmontotarjeta.Enabled = True
        Me.ctrlmontotarjeta.Location = New System.Drawing.Point(416, 32)
        Me.ctrlmontotarjeta.Name = "ctrlmontotarjeta"
        Me.ctrlmontotarjeta.OcxState = CType(resources.GetObject("ctrlmontotarjeta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctrlmontotarjeta.Size = New System.Drawing.Size(110, 19)
        Me.ctrlmontotarjeta.TabIndex = 7
        '
        'ctrlnumerotarjeta
        '
        Me.ctrlnumerotarjeta.ContainingControl = Me
        Me.ctrlnumerotarjeta.Enabled = True
        Me.ctrlnumerotarjeta.Location = New System.Drawing.Point(270, 33)
        Me.ctrlnumerotarjeta.Name = "ctrlnumerotarjeta"
        Me.ctrlnumerotarjeta.OcxState = CType(resources.GetObject("ctrlnumerotarjeta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctrlnumerotarjeta.Size = New System.Drawing.Size(139, 19)
        Me.ctrlnumerotarjeta.TabIndex = 6
        '
        'cbomonedatarjeta
        '
        Me.cbomonedatarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomonedatarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbomonedatarjeta.Location = New System.Drawing.Point(154, 32)
        Me.cbomonedatarjeta.Name = "cbomonedatarjeta"
        Me.cbomonedatarjeta.Size = New System.Drawing.Size(114, 21)
        Me.cbomonedatarjeta.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(441, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Monto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(144, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Moneda"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbotarjeta
        '
        Me.cbotarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbotarjeta.Location = New System.Drawing.Point(2, 33)
        Me.cbotarjeta.Name = "cbotarjeta"
        Me.cbotarjeta.Size = New System.Drawing.Size(151, 21)
        Me.cbotarjeta.TabIndex = 56
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(15, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 18)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Tipo de Tarjeta"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(263, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 19)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Numero de Tarjeta"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtreferenciavale)
        Me.TabPage2.Controls.Add(Me.ctrlacumuladovales)
        Me.TabPage2.Controls.Add(Me.lblsimbolovale)
        Me.TabPage2.Controls.Add(Me.gridvale)
        Me.TabPage2.Controls.Add(Me.ctrlmontovales)
        Me.TabPage2.Controls.Add(Me.ctrlnumerovale)
        Me.TabPage2.Controls.Add(Me.cbomonevales)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(536, 231)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "                    VALES                               "
        '
        'txtreferenciavale
        '
        Me.txtreferenciavale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreferenciavale.Location = New System.Drawing.Point(8, 34)
        Me.txtreferenciavale.Name = "txtreferenciavale"
        Me.txtreferenciavale.Size = New System.Drawing.Size(150, 20)
        Me.txtreferenciavale.TabIndex = 63
        Me.txtreferenciavale.Text = ""
        '
        'ctrlacumuladovales
        '
        Me.ctrlacumuladovales.ContainingControl = Me
        Me.ctrlacumuladovales.Enabled = True
        Me.ctrlacumuladovales.Location = New System.Drawing.Point(411, 200)
        Me.ctrlacumuladovales.Name = "ctrlacumuladovales"
        Me.ctrlacumuladovales.OcxState = CType(resources.GetObject("ctrlacumuladovales.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctrlacumuladovales.Size = New System.Drawing.Size(123, 28)
        Me.ctrlacumuladovales.TabIndex = 62
        '
        'lblsimbolovale
        '
        Me.lblsimbolovale.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsimbolovale.Location = New System.Drawing.Point(366, 208)
        Me.lblsimbolovale.Name = "lblsimbolovale"
        Me.lblsimbolovale.Size = New System.Drawing.Size(32, 22)
        Me.lblsimbolovale.TabIndex = 61
        Me.lblsimbolovale.Text = "S/."
        Me.lblsimbolovale.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'gridvale
        '
        Me.gridvale.BackgroundColor = System.Drawing.Color.White
        Me.gridvale.CaptionBackColor = System.Drawing.Color.Silver
        Me.gridvale.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridvale.CaptionForeColor = System.Drawing.Color.Black
        Me.gridvale.CaptionText = "                                                                        Eliminar " & _
        "Item [F3]"
        Me.gridvale.DataMember = ""
        Me.gridvale.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridvale.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.gridvale.Location = New System.Drawing.Point(7, 60)
        Me.gridvale.Name = "gridvale"
        Me.gridvale.ReadOnly = True
        Me.gridvale.Size = New System.Drawing.Size(528, 140)
        Me.gridvale.TabIndex = 60
        '
        'ctrlmontovales
        '
        Me.ctrlmontovales.ContainingControl = Me
        Me.ctrlmontovales.Enabled = True
        Me.ctrlmontovales.Location = New System.Drawing.Point(423, 34)
        Me.ctrlmontovales.Name = "ctrlmontovales"
        Me.ctrlmontovales.OcxState = CType(resources.GetObject("ctrlmontovales.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctrlmontovales.Size = New System.Drawing.Size(109, 19)
        Me.ctrlmontovales.TabIndex = 59
        '
        'ctrlnumerovale
        '
        Me.ctrlnumerovale.ContainingControl = Me
        Me.ctrlnumerovale.Enabled = True
        Me.ctrlnumerovale.Location = New System.Drawing.Point(277, 35)
        Me.ctrlnumerovale.Name = "ctrlnumerovale"
        Me.ctrlnumerovale.OcxState = CType(resources.GetObject("ctrlnumerovale.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctrlnumerovale.Size = New System.Drawing.Size(139, 19)
        Me.ctrlnumerovale.TabIndex = 58
        '
        'cbomonevales
        '
        Me.cbomonevales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomonevales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbomonevales.Location = New System.Drawing.Point(161, 34)
        Me.cbomonevales.Name = "cbomonevales"
        Me.cbomonevales.Size = New System.Drawing.Size(114, 21)
        Me.cbomonevales.TabIndex = 57
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(448, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 16)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Monto"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(151, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 16)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Moneda"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(26, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Referencia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(271, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Numero Vale"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ctrlefectivoextr)
        Me.GroupBox3.Controls.Add(Me.LBLMONEXTR)
        Me.GroupBox3.Controls.Add(Me.ctrlefectivobas)
        Me.GroupBox3.Controls.Add(Me.LBLMONBASE)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 84)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(535, 56)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Efectivo"
        '
        'ctrlefectivoextr
        '
        Me.ctrlefectivoextr.ContainingControl = Me
        Me.ctrlefectivoextr.Enabled = True
        Me.ctrlefectivoextr.Location = New System.Drawing.Point(350, 21)
        Me.ctrlefectivoextr.Name = "ctrlefectivoextr"
        Me.ctrlefectivoextr.OcxState = CType(resources.GetObject("ctrlefectivoextr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctrlefectivoextr.Size = New System.Drawing.Size(135, 28)
        Me.ctrlefectivoextr.TabIndex = 6
        '
        'LBLMONEXTR
        '
        Me.LBLMONEXTR.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMONEXTR.Location = New System.Drawing.Point(315, 18)
        Me.LBLMONEXTR.Name = "LBLMONEXTR"
        Me.LBLMONEXTR.Size = New System.Drawing.Size(44, 33)
        Me.LBLMONEXTR.TabIndex = 5
        Me.LBLMONEXTR.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ctrlefectivobas
        '
        Me.ctrlefectivobas.ContainingControl = Me
        Me.ctrlefectivobas.Enabled = True
        Me.ctrlefectivobas.Location = New System.Drawing.Point(86, 19)
        Me.ctrlefectivobas.Name = "ctrlefectivobas"
        Me.ctrlefectivobas.OcxState = CType(resources.GetObject("ctrlefectivobas.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctrlefectivobas.Size = New System.Drawing.Size(135, 28)
        Me.ctrlefectivobas.TabIndex = 0
        '
        'LBLMONBASE
        '
        Me.LBLMONBASE.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMONBASE.Location = New System.Drawing.Point(50, 18)
        Me.LBLMONBASE.Name = "LBLMONBASE"
        Me.LBLMONBASE.Size = New System.Drawing.Size(44, 33)
        Me.LBLMONBASE.TabIndex = 4
        Me.LBLMONBASE.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBLSIMBOLOTOTAL)
        Me.GroupBox2.Controls.Add(Me.LBLSIMBOLOCAMBIO)
        Me.GroupBox2.Controls.Add(Me.LBLcambio)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblmontobas1)
        Me.GroupBox2.Controls.Add(Me.lblmontoextr)
        Me.GroupBox2.Controls.Add(Me.lblmontobase)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(534, 72)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monto a Pagar"
        '
        'LBLSIMBOLOTOTAL
        '
        Me.LBLSIMBOLOTOTAL.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLOTOTAL.Location = New System.Drawing.Point(17, 28)
        Me.LBLSIMBOLOTOTAL.Name = "LBLSIMBOLOTOTAL"
        Me.LBLSIMBOLOTOTAL.Size = New System.Drawing.Size(40, 32)
        Me.LBLSIMBOLOTOTAL.TabIndex = 6
        Me.LBLSIMBOLOTOTAL.Text = "S/."
        '
        'LBLSIMBOLOCAMBIO
        '
        Me.LBLSIMBOLOCAMBIO.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLOCAMBIO.Location = New System.Drawing.Point(406, 33)
        Me.LBLSIMBOLOCAMBIO.Name = "LBLSIMBOLOCAMBIO"
        Me.LBLSIMBOLOCAMBIO.Size = New System.Drawing.Size(18, 26)
        Me.LBLSIMBOLOCAMBIO.TabIndex = 5
        Me.LBLSIMBOLOCAMBIO.Text = "$"
        '
        'LBLcambio
        '
        Me.LBLcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLcambio.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLcambio.Location = New System.Drawing.Point(426, 29)
        Me.LBLcambio.Name = "LBLcambio"
        Me.LBLcambio.Size = New System.Drawing.Size(104, 33)
        Me.LBLcambio.TabIndex = 4
        Me.LBLcambio.Text = "3.43"
        Me.LBLcambio.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "T.C."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblmontobas1
        '
        Me.lblmontobas1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.lblmontobas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmontobas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblmontobas1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmontobas1.Location = New System.Drawing.Point(59, 23)
        Me.lblmontobas1.Name = "lblmontobas1"
        Me.lblmontobas1.Size = New System.Drawing.Size(181, 38)
        Me.lblmontobas1.TabIndex = 2
        Me.lblmontobas1.Text = "0.00"
        Me.lblmontobas1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblmontoextr
        '
        Me.lblmontoextr.BackColor = System.Drawing.Color.Yellow
        Me.lblmontoextr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmontoextr.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmontoextr.Location = New System.Drawing.Point(248, 24)
        Me.lblmontoextr.Name = "lblmontoextr"
        Me.lblmontoextr.Size = New System.Drawing.Size(72, 16)
        Me.lblmontoextr.TabIndex = 1
        Me.lblmontoextr.Text = "0.00"
        Me.lblmontoextr.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblmontoextr.Visible = False
        '
        'lblmontobase
        '
        Me.lblmontobase.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.lblmontobase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmontobase.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmontobase.Location = New System.Drawing.Point(248, 41)
        Me.lblmontobase.Name = "lblmontobase"
        Me.lblmontobase.Size = New System.Drawing.Size(71, 17)
        Me.lblmontobase.TabIndex = 0
        Me.lblmontobase.Text = "0.00"
        Me.lblmontobase.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblmontobase.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(637, 129)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'frmpagoefectivo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(562, 480)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmpagoefectivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago en Efectivo / con múltiples tarjetas / con múltiples vales / pago combinado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.frmvuelto.ResumeLayout(False)
        CType(Me.ctrlvuelto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCtrlNumber6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ctrlacumuladotarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridtarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrlmontotarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrlnumerotarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ctrlacumuladovales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridvale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrlmontovales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrlnumerovale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ctrlefectivoextr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrlefectivobas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public VIE As New FRMFACTURACION
    Public VIE2 As New frmfactservicio
    Public estado As Boolean

    Sub muestratotaldoc()
        lblmontobase.Text = VTotBas
        lblmontobas1.Text = VTotBas
        lblmontoextr.Text = VTotExt
        CAyuda.CargarDataCombo(cbomonedatarjeta, "nsp_sele_monefac '" & codempresa & "'", "Codigo", "Moneda")
        CAyuda.CargarDataCombo(cbomonevales, "nsp_sele_monefac '" & codempresa & "'", "Codigo", "Moneda")
        CAyuda.CargarDataCombo(cbotarjeta, "nsp_sele_tarjefac", "Codigo", "Tarjeta")
    End Sub

    Private Sub frmpagoefectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Minimized
        Call muestratotaldoc()
        Call iniciacontrolnumber()
        Call cargagrid()
        btnaceptar.Enabled = True
        btnnuevo.Enabled = False
        btncancelar.Enabled = True
        lblmontobase.Text = 0
        LBLcambio.Text = VCambioVta
        'btnaceptar_Click(sender, e)
    End Sub
    Sub iniciacontrolnumber()
        lblmontobase.Text = FACT_GFormatodeNumero(CDbl(lblmontobase.Text))
        lblmontoextr.Text = FACT_GFormatodeNumero(CDbl(lblmontoextr.Text))
        lblmontobas1.Text = FACT_GFormatodeNumero(CDbl(lblmontobas1.Text))
        LBLcambio.Text = FACT_GFormatodeNumero(CDbl(LBLcambio.Text))
        ctrlefectivobas.Enteros = 9
        ctrlefectivoextr.Enteros = 9
        ctrlmontotarjeta.Enteros = 9
        ctrlacumuladotarjeta.Enteros = 9
        ctrlmontovales.Enteros = 9
        ctrlacumuladovales.Enteros = 9
        ctrlnumerovale.Enteros = 20
        ctrlnumerotarjeta.Enteros = 20
        ctrlefectivobas.Decimales = DECIRESU
        ctrlefectivoextr.Decimales = DECIRESU
        ctrlmontotarjeta.Decimales = DECIRESU
        ctrlacumuladotarjeta.Decimales = DECIRESU
        ctrlmontovales.Decimales = DECIRESU
        ctrlacumuladovales.Decimales = DECIRESU
        ctrlefectivobas.ValorPorDefecto()
        ctrlefectivoextr.ValorPorDefecto()
        ctrlmontotarjeta.ValorPorDefecto()
        ctrlacumuladotarjeta.ValorPorDefecto()
        ctrlmontovales.ValorPorDefecto()
        ctrlacumuladovales.ValorPorDefecto()
        ctrlefectivobas.CtlText = FACT_GFormatodeNumero(ctrlefectivobas.CtlText)
        ctrlefectivoextr.CtlText = FACT_GFormatodeNumero(ctrlefectivoextr.CtlText)
        ctrlmontotarjeta.CtlText = FACT_GFormatodeNumero(ctrlmontotarjeta.CtlText)
        ctrlacumuladotarjeta.CtlText = FACT_GFormatodeNumero(ctrlacumuladotarjeta.CtlText)
        ctrlvuelto.CtlText = FACT_GFormatodeNumero(ctrlvuelto.CtlText)
        ctrlmontovales.CtlText = FACT_GFormatodeNumero(ctrlmontovales.CtlText)
        ctrlacumuladovales.CtlText = FACT_GFormatodeNumero(ctrlacumuladovales.CtlText)
        LBLMONBASE.Text = FACT_SIMBOLOMON
        LBLMONEDAVUELTO.Text = FACT_SIMBOLOMON
        LBLMONEXTR.Text = FACT_SIMBOLOMONEXTR
        LBLcambio.Text = FACT_GFormatodeNumero(VCambioVta)
        LBLSIMBOLOTOTAL.Text = FACT_SIMBOLOMON
        LBLSIMBOLOCAMBIO.Text = FACT_SIMBOLOMONEXTR
        ctrlefectivobas.CtlText = lblmontobase.Text
    End Sub
    Private Sub cbomonevales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomonevales.SelectedIndexChanged
    End Sub
    Sub cargagrid()
        FACT_Cargagridpagotarjeta(Gridtarjeta, "sp_sele_pago_tarjet " & VCorrelVta & "")
        FACT_Cargagridpagovale(gridvale, "sp_sele_pago_vale " & VCorrelVta & "")
    End Sub
    Private Sub ctrlefectivobas_KeyPressEvent(ByVal sender As Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent) Handles ctrlefectivobas.KeyPressEvent
        ctrlefectivobas.Focus()
        Dim b As Double
        If e.keyAscii = 13 Then
            Dim a As Double
            ctrlefectivoextr.CtlText = FACT_GFormatodeNumero(0)
            a = CDbl(ctrlefectivobas.CtlText) + CDbl(ctrlacumuladotarjeta.CtlText) + CDbl(ctrlacumuladovales.CtlText) + (CDbl(ctrlefectivoextr.CtlText) * CDbl(LBLcambio.Text))

            lblmontobase.Text = FACT_GFormatodeNumero(CDbl(lblmontobas1.Text) - a)

            ctrlefectivobas.CtlText = FACT_GFormatodeNumero(ctrlefectivobas.CtlText)

            If CDbl(lblmontobase.Text) <= 0 Then
                btnaceptar.Focus()
                ctrlvuelto.CtlText = FACT_GFormatodeNumero(CDbl(lblmontobase.Text))
                If ctrlvuelto.CtlText < 0 Then ctrlvuelto.CtlText = FACT_GFormatodeNumero(CDbl(ctrlvuelto.CtlText) * -1)
                'lblmontobase.Text = FACT_GFormatodeNumero(0)
                ctrlefectivoextr.CtlText = FACT_GFormatodeNumero(0)
                'aqui deveria aborrar las tarjetas y vales
            Else
                If CDbl(lblmontobase.Text) > 0 Then
                    b = ctrlefectivoextr.CtlText
                    ctrlefectivoextr.CtlText = FACT_GFormatodeNumero(b + CDbl(lblmontobase.Text) / CDbl((LBLcambio.Text)))
                    lblmontobase.Text = CDbl(lblmontobase.Text) - (CDbl(b) * CDbl(LBLcambio.Text))
                    ctrlvuelto.CtlText = FACT_GFormatodeNumero(CDbl(lblmontobase.Text))
                    ctrlefectivoextr.Focus()
                End If
            End If
        End If
        ponerlabel()
    End Sub
    Private Sub ctrlefectivoextr_KeyPressEvent(ByVal sender As Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent) Handles ctrlefectivoextr.KeyPressEvent
        ctrlefectivoextr.Focus()
        Dim b As Double = 0.0F
        If e.keyAscii = 13 Then
            Dim a As Double
            a = CDbl(ctrlefectivobas.CtlText) + CDbl(ctrlacumuladotarjeta.CtlText) + CDbl(ctrlacumuladovales.CtlText) + (CDbl(ctrlefectivoextr.CtlText) * CDbl(LBLcambio.Text))
            lblmontobase.Text = FACT_GFormatodeNumero(CDbl(lblmontobas1.Text) - a)
            ctrlefectivobas.CtlText = FACT_GFormatodeNumero(ctrlefectivobas.CtlText)
            If CDbl(lblmontobase.Text) <= 0 Then
                btnaceptar.Focus()
                ctrlvuelto.CtlText = FACT_GFormatodeNumero(CDbl(lblmontobase.Text) * -1)
            Else
                If CDbl(lblmontobase.Text) > 0 Then
                    ctrlvuelto.CtlText = FACT_GFormatodeNumero(CDbl(lblmontobase.Text) * -1)
                    cbotarjeta.Focus()
                End If
            End If
        End If
        ponerlabel()
    End Sub
    Private Sub cbotarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotarjeta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbomonedatarjeta.Focus()
        End If
    End Sub
    Private Sub cbomonedatarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbomonedatarjeta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ctrlnumerotarjeta.Focus()
        End If
    End Sub
    Private Sub ctrlnumerotarjeta_KeyPressEvent(ByVal sender As Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent) Handles ctrlnumerotarjeta.KeyPressEvent
        ctrlnumerotarjeta.Focus()
        If e.keyAscii = 13 Then
            ctrlmontotarjeta.Focus()
        End If
    End Sub
    Private Sub ctrlmontotarjeta_KeyPressEvent(ByVal sender As Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent) Handles ctrlmontotarjeta.KeyPressEvent
        If e.keyAscii = 13 Then

            If CDbl(ctrlmontotarjeta.CtlText) <= 0 Then
                MessageBox.Show("Ingrese Valor Valido", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If ctrlnumerotarjeta.CtlText = "" Or ctrlnumerotarjeta.CtlText = 0 Then
                MessageBox.Show("Ingrese numero de tarjeta Valido", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If



            Call INSERTA_TMP_TARJETA()
            ctrlmontovales.Focus()

            Dim a As Double
            a = CDbl(ctrlefectivobas.CtlText) + CDbl(ctrlacumuladotarjeta.CtlText) + CDbl(ctrlacumuladovales.CtlText) + (CDbl(ctrlefectivoextr.CtlText) * CDbl(LBLcambio.Text))
            lblmontobase.Text = FACT_GFormatodeNumero(CDbl(lblmontobas1.Text) - a)
            If CDbl(lblmontobase.Text) <= 0 Then
                btnaceptar.Focus()
                ctrlvuelto.CtlText = FACT_GFormatodeNumero(CDbl(lblmontobase.Text) * -1)
            Else
                If CDbl(lblmontobase.Text) > 0 Then
                    ctrlvuelto.CtlText = FACT_GFormatodeNumero(CDbl(lblmontobase.Text) * -1)
                    ctrlmontovales.Focus()
                End If
            End If
            ponerlabel()
        End If
    End Sub
    Sub ponerlabel()
        If CDbl(ctrlvuelto.CtlText) < 0 Then
            frmvuelto.Text = "Faltante"
        Else
            frmvuelto.Text = "Vuelto"
        End If
    End Sub
    Sub INSERTA_TMP_TARJETA()
        Try
            Dim DS As New DataSet
            Dim SQL As String
            Dim ITEM As Integer

            SQL = "sp_sele_pago_tarjet " & VCorrelVta & ""
            DS = CAyuda.ListarDatos(SQL)
            ITEM = DS.Tables(0).Rows.Count + 1
            SQL = "sp_insert_tmp_ventatarj '" & VCdTipoDoc & "'," & VNroDoc & "," & ITEM & ",'" & cbotarjeta.SelectedValue.ToString & "','" & cbomonedatarjeta.SelectedValue.ToString & "'," & ctrlnumerotarjeta.CtlText & "," & ctrlmontotarjeta.CtlText & ",'" & NROPTOVTA & "','" & CodUsuario & "','" & codempresa & "'," & LBLcambio.Text & ",'" & CDMONBASE & "'," & VCorrelVta & ""
            Call TmpInsertDatos(SQL)
            Call cargagrid()
            Call CALCULO()
        Catch ex As Exception
        End Try
    End Sub


    Sub INSERTA_TMP_VALE()
        Try
            Dim DS As New DataSet
            Dim SQL As String
            Dim ITEM As Integer

            SQL = " sp_sele_pago_vale " & VCorrelVta & ""
            DS = CAyuda.ListarDatos(SQL)
            ITEM = DS.Tables(0).Rows.Count + 1
            SQL = "sp_insert_tmp_ventavale '" & txtreferenciavale.Text & "', '" & VCdTipoDoc & "'," & VNroDoc & "," & ITEM & ",'" & cbomonevales.SelectedValue.ToString & "'," & ctrlnumerovale.CtlText & "," & ctrlmontovales.CtlText & ",'" & NROPTOVTA & "','" & CodUsuario & "','" & codempresa & "'," & LBLcambio.Text & ",'" & CDMONBASE & "'," & VCorrelVta & ""
            TmpInsertDatos(SQL)
            Call cargagrid()
            Call CALCULO()
        Catch ex As Exception
        End Try
    End Sub
    Sub CALCULO()
        Try
            Dim N, I As Integer
            Dim SQL As String
            Dim DS As New DataSet
            '---------------------------------TARJETA
            SQL = "sp_sele_pago_tarjet " & VCorrelVta & ""
            DS = CAyuda.ListarDatos(SQL)
            N = DS.Tables(0).Rows.Count - 1
            Dim TOTBAS, TOTEXT As Double
            For I = 0 To N
                If Trim(Gridtarjeta.Item(I, 3)) = Trim(CDMONBASE) Then
                    TOTBAS = CDbl(TOTBAS) + CDbl(Gridtarjeta.Item(I, 5))
                End If

                If Trim(Gridtarjeta.Item(I, 3)) <> Trim(CDMONBASE) Then
                    TOTEXT = CDbl(TOTEXT) + CDbl(Gridtarjeta.Item(I, 5))
                End If
            Next I
            ctrlacumuladotarjeta.CtlText = FACT_GFormatodeNumero(CDbl(TOTBAS) + FACT_GFormatodeNumero((CDbl(TOTEXT) * CDbl(LBLcambio.Text))))
            ctrlmontotarjeta.CtlText = FACT_GFormatodeNumero(0)
            '----
            TOTEXT = 0
            TOTBAS = 0
            N = 0
            '----
            '-------------------------------------VALE
            SQL = " sp_sele_pago_vale " & VCorrelVta & ""
            DS = CAyuda.ListarDatos(SQL)
            N = DS.Tables(0).Rows.Count - 1
            For I = 0 To N
                If Trim(gridvale.Item(I, 2)) = Trim(CDMONBASE) Then
                    TOTBAS = CDbl(TOTBAS) + CDbl(gridvale.Item(I, 4))
                End If

                If Trim(gridvale.Item(I, 2)) <> Trim(CDMONBASE) Then
                    TOTEXT = CDbl(TOTEXT) + CDbl(gridvale.Item(I, 4))
                End If

            Next I
            ctrlacumuladovales.CtlText = FACT_GFormatodeNumero(CDbl(TOTBAS) + FACT_GFormatodeNumero((CDbl(TOTEXT) * CDbl(LBLcambio.Text))))
            ctrlmontovales.CtlText = FACT_GFormatodeNumero(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Gridtarjeta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Gridtarjeta.KeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim SQL As String

                SQL = "SP_DELETE_TMP_VENTATARJ " & VCorrelVta & "," & Gridtarjeta.Item(Gridtarjeta.CurrentRowIndex, 0) & ""
                TmpInsertDatos(SQL)
                Call cargagrid()
                Call CALCULO()
                Dim a As Double
                a = CDbl(ctrlefectivobas.CtlText) + CDbl(ctrlacumuladotarjeta.CtlText) + CDbl(ctrlacumuladovales.CtlText) + (CDbl(ctrlefectivoextr.CtlText) * CDbl(LBLcambio.Text))
                lblmontobase.Text = CDbl(lblmontobas1.Text) - a
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtreferenciavale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreferenciavale.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbomonevales.Focus()
        End If
    End Sub
    Private Sub cbomonevales_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbomonevales.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ctrlnumerovale.Focus()
        End If
    End Sub
    Private Sub ctrlnumerovale_KeyPressEvent(ByVal sender As Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent) Handles ctrlnumerovale.KeyPressEvent
        If e.keyAscii = 13 Then
            ctrlmontovales.Focus()
        End If
    End Sub
    Private Sub ctrlmontovales_KeyPressEvent(ByVal sender As Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent) Handles ctrlmontovales.KeyPressEvent
        If e.keyAscii = 13 Then
            If CDbl(ctrlmontovales.CtlText) <= 0 Then
                MessageBox.Show("Ingrese Valor Valido", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If ctrlnumerovale.CtlText = "" Or ctrlnumerovale.CtlText = 0 Then
                MessageBox.Show("Ingrese numero de vale Valido", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If



            Call INSERTA_TMP_VALE()
            ctrlmontovales.Focus()

            Dim a As Double
            a = CDbl(ctrlefectivobas.CtlText) + CDbl(ctrlacumuladotarjeta.CtlText) + CDbl(ctrlacumuladovales.CtlText) + (CDbl(ctrlefectivoextr.CtlText) * CDbl(LBLcambio.Text))
            lblmontobase.Text = FACT_GFormatodeNumero(CDbl(lblmontobas1.Text) - a)
            If CDbl(lblmontobase.Text) <= 0 Then
                btnaceptar.Focus()
                ctrlvuelto.CtlText = FACT_GFormatodeNumero(CDbl(lblmontobase.Text) * -1)
            Else
                If CDbl(lblmontobase.Text) > 0 Then
                    ctrlvuelto.CtlText = FACT_GFormatodeNumero(CDbl(lblmontobase.Text) * -1)
                    ctrlmontovales.Focus()
                End If
            End If
            ponerlabel()
        End If
    End Sub
    Private Sub gridvale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridvale.KeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim SQL As String

                SQL = "SP_DELETE_TMP_VENTAVALES " & VCorrelVta & "," & gridvale.Item(gridvale.CurrentRowIndex, 0) & ""
                TmpInsertDatos(SQL)
                Call cargagrid()
                Call CALCULO()
                Dim a As Double
                a = CDbl(ctrlefectivobas.CtlText) + CDbl(ctrlacumuladotarjeta.CtlText) + CDbl(ctrlacumuladovales.CtlText) + (CDbl(ctrlefectivoextr.CtlText) * CDbl(LBLcambio.Text))
                lblmontobase.Text = CDbl(lblmontobas1.Text) - a
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim efectivo, tarjeta, vales As Double


        If CDbl(lblmontobase.Text) > 0 Then
            MessageBox.Show("Aun hay pendientes por Cancelar verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'VIE.CALCULO(True)
        'NTOTALDOCUM = CDbl(VIE.CTRLTOTAL.CtlText)
        btnaceptar.Enabled = False
        btnnuevo.Enabled = True

        'Dim fechadocum As String
        'fechadocum = Format(Now, "MM/dd/yyyy")
        Dim fechadocum As Date
        fechadocum = Format(CAyuda.ListarDatos("SP_DATE_HOUR").Tables(0).Rows(0)(0), "dd/MM/yyyy")

        '/*
        '@CODTIPOPAGO=2--SOLO TARJETA
        '@CODTIPOPAGO=3--SOLO CHEQUE
        '@CODTIPOPAGO=4--efectivos y tarjetas
        '@CODTIPOPAGO=5--efectivos y vales
        '@CODTIPOPAGO=6--tarjeta y vale
        '@CODTIPOPAGO=7-- vale
        '@CODTIPOPAGO=8--tarjeta y vale y efectivo
        '@CODTIPOPAGO=9--VENTA AL CREDITO
        '@CODTIPOPAGO=10--SOLO VALES
        '*/



        efectivo = CDbl(ctrlefectivobas.CtlText) + CDbl(ctrlefectivoextr.CtlText)
        tarjeta = CDbl(ctrlacumuladotarjeta.CtlText)
        vales = CDbl(ctrlacumuladovales.CtlText)

        'cuando es efectivo
        If efectivo > 0 And tarjeta <= 0 And vales <= 0 Then
            GRABAEFECTIVOS(VCdPagEfectivo, fechadocum)
            GoTo fin
        End If
        'cuando es  tarjeta
        If efectivo <= 0 And tarjeta > 0 And vales <= 0 Then
            GRABAEFECTIVOS(11, fechadocum)
            GoTo fin
        End If
        'cuando es efectivo y tarjeta
        If efectivo > 0 And tarjeta > 0 And vales <= 0 Then
            GRABAEFECTIVOS(4, fechadocum)
            GoTo fin
        End If
        'cuando es efectivo y vale
        If efectivo > 0 And tarjeta <= 0 And vales > 0 Then
            GRABAEFECTIVOS(5, fechadocum)
            GoTo fin
        End If
        'cuando es tarjeta  y vale
        If efectivo <= 0 And tarjeta > 0 And vales > 0 Then
            GRABAEFECTIVOS(6, fechadocum)
            GoTo fin
        End If
        'cuando es  vale
        If efectivo <= 0 And tarjeta <= 0 And vales > 0 Then
            GRABAEFECTIVOS(12, fechadocum)
            GoTo fin
        End If
        'cuando es  tarjeta y vale y efectivo
        If efectivo > 0 And tarjeta > 0 And vales > 0 Then
            GRABAEFECTIVOS(8, fechadocum)
            GoTo fin
        End If

fin:
        '        GRABAEFECTIVOS(8, fechadocum)
        If estado = True Then
            VIE.CANCELAR()
        Else
            VIE2.CANCELAR()
        End If
        VIE.txtcodclie.Text = ""
        VIE.txtruc.Text = ""
        VIE.txtcliente.Text = ""
        VIE.txtdireccion.Text = ""
        'VIE.TXTSERIEDOC.Text = ""
        'VIE.TXTNUMERODOC.Text = ""
        'VIE.txtnotapesada.Text = ""
        VIE.TxtTOTAL.Text = "0.00"
        'Me.Close()
        'Exit Sub
        btnnuevo.Select()
    End Sub


    Public Function GRABAEFECTIVOS(ByVal CODTIPOPAGO As String, ByVal fechadocum As Date) As Boolean
        If estado = True Then
            ' SQL = "sp_grabadocumento '" & VIE.txtnroguias.Text & "','" & VIE.txtnotapesada.Text & "','" & VIE.CHKIGV.Checked & "','" & fact_editnumero & "', " & FACT_NUMEROTRANSACCION & ",'" & FACT_clieprincipal & "'," & CODTIPOPAGO & ",'" & VCdTipoDoc & "'," & VNroDoc & ",'" & FACT_CDMONEDA & "'," & LBLcambio.Text & ",'" & FACT_codvendedor & "','" & fechadocum & "'," & IIf(CDMONBASE = FACT_CDMONEDA, VIE.CTRLTOTAL.CtlText, VIE.CTRLTOTAL.CtlText * LBLcambio.Text) & "," & FACT_pordescuento & "," & IIf(CDMONBASE = FACT_CDMONEDA, ctrlvuelto.CtlText, ctrlvuelto.CtlText * LBLcambio.Text) & "," & ctrlefectivobas.CtlText & "," & ctrlefectivoextr.CtlText & ",'" & FACT_codcliente & "','" & FACT_RUCCLIENTE & "','" & FACT_DESCLIENTE & "','" & FACT_DIRCLIENTE & "','" & CodUsuario & "','" & CodEmpresa & "','" & CDMONBASE & "','" & NroPtovta & "'," & VCorrelVta & ""
            'GRABAEFECTIVOS = FACT_Procesa(SQL)
            'Dim cmd As New SqlCommand("sp_grabadocumento", cn)
            'Dim afec As Integer

            Dim AFEC As Integer
            Try
                'TmpInsertDatos("sp_grabadocumento  '" & CStr(VIE.txtnroguias.Text) & "','" & CStr(VIE.txtnotapesada.Text) & "','" & CStr(VIE.CHKIGV.Checked) & "','" & CStr(fact_editnumero) & "','" & CInt(FACT_NUMEROTRANSACCION) & "','" & CStr(FACT_clieprincipal) & "','" & CODTIPOPAGO.Trim & "','" & CStr(VCdTipoDoc) & "','" & CStr(VNroDoc) & "','" & CStr(FACT_CDMONEDA) & "','" & CDec(LBLcambio.Text) & "','" & CStr(FACT_codvendedor) & "','" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & CDec(IIf(CDMONBASE = FACT_CDMONEDA, VIE.CTRLTOTAL.CtlText, VIE.CTRLTOTAL.CtlText * LBLcambio.Text)) & "','" & CDec(FACT_pordescuento) & "','" & CDec(IIf(CDMONBASE = FACT_CDMONEDA, ctrlvuelto.CtlText, ctrlvuelto.CtlText * LBLcambio.Text)) & "','" & CDec(ctrlefectivobas.CtlText) & "' ,'" & CDec(ctrlefectivoextr.CtlText) & "','" & CStr(FACT_codcliente) & "','" & CStr(FACT_RUCCLIENTE) & "','" & CStr(FACT_DESCLIENTE) & "','" & CStr(FACT_DIRCLIENTE) & "','" & CStr(CodUsuario) & "','" & CStr(CodEmpresa) & "' ,'" & CStr(FACT_CDMONEDA) & "','" & CStr(NROPTOVTA) & "','" & CInt(VCorrelVta) & "' ")
                Dim cn2 As New SqlConnection(STRCN)
                If cn2.State = ConnectionState.Open Then
                    cn2.Close()
                End If
                cn2.Open()
                Dim cmd2 As New SqlCommand("Nsp_grabadocumento", cn2)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.AddWithValue("NRODEGUIAS", CStr("")).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@NPESADA", CStr("")).SqlDbType = SqlDbType.VarChar

        
                cmd2.Parameters.AddWithValue("@Eigv", CStr(VIE.CHKIGV.Checked)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@actualizocorrelativo", CStr(fact_editnumero)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@NUMEROTRANS", CInt(FACT_NUMEROTRANSACCION)).SqlDbType = SqlDbType.Int
                cmd2.Parameters.AddWithValue("@CODDEP", CStr(VClieDep)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CODTIPOPAGO", CODTIPOPAGO.Trim).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CODTIPODOC", CStr(VCdTipoDoc)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@NRODOCU", CStr(VNroDoc)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@codmon", CStr(FACT_CDMONEDA)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CAMBIO", CDec(LBLcambio.Text)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@codvend", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@FECDOCUM", Me.DateTimePicker1.Value).SqlDbType = SqlDbType.DateTime
                cmd2.Parameters.AddWithValue("@TOTBAS", CDec(VIE.TxtTOTAL.Text)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@PORCENDESC1", CDec(VDescTotbas)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@TOTVUELTOBAS", CDec(ctrlvuelto.CtlText)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@TOTCASHBAS", CDec(ctrlefectivobas.CtlText)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@TOTCASHEXT", CDec(ctrlefectivoextr.CtlText)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@codcliente", CStr(VCodCliente)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@RUCCLIENTE", CStr(VRuc)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@DESCLIENTE", CStr(VDescliente)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@DIRCLIENTE", CStr(VDireccion)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@usuario", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CODEMPRESA", CStr(codempresa)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@MONEDABASE", CStr(FACT_CDMONEDA)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@NROPTOVTA", CStr(NROPTOVTA)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CORRELATIVO", CInt(VCorrelVta)).SqlDbType = SqlDbType.Int

                Try
                    AFEC = cmd2.ExecuteNonQuery()
                    ''MsgBox("se grabo ...")
                    cn2.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox(EX.ToString)

                End Try



            Catch ex As Exception
                MsgBox(ex.Message)

            End Try



            VIE.IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '','INSERT','FACTURACION','" & Format(System.DateTime.Now, "MM/dd/yyyy") & "','" & CodUsuario & "','" & codempresa & "'")

            'Dim obj As New ClsInterface
            'Try
            '    obj.gGrabarReg("INSERT_CLI_POST_VTA", codempresa, VCdTipoDoc.Trim, VNroDoc)
            'Catch ex As Exception
            'End Try
        Else
            Dim AFEC As Integer


            'Dim SQL As String
            ' SQL = "sp_grabadocumento_otro '" & VIE2.txtnroguias.Text & "','" & VIE2.txtnotapesada.Text & "','" & VIE2.CHKIGV.Checked & "','" & fact_editnumero & "', " & FACT_NUMEROTRANSACCION & ",'" & FACT_clieprincipal & "'," & CODTIPOPAGO & ",'" & VCdTipoDoc & "'," & VNroDoc & ",'" & FACT_CDMONEDA & "'," & LBLcambio.Text & ",'" & FACT_codvendedor & "','" & fechadocum & "'," & IIf(CDMONBASE = FACT_CDMONEDA, VIE2.CTRLTOTAL.CtlText, VIE2.CTRLTOTAL.CtlText * LBLcambio.Text) & "," & FACT_pordescuento & "," & ctrlvuelto.CtlText & "," & IIf(CDMONBASE = FACT_CDMONEDA, ctrlvuelto.CtlText, ctrlvuelto.CtlText * LBLcambio.Text) & "," & ctrlefectivoextr.CtlText & ",'" & FACT_codcliente & "','" & FACT_RUCCLIENTE & "','" & FACT_DESCLIENTE & "','" & FACT_DIRCLIENTE & "','" & CodUsuario & "','" & CodEmpresa & "','" & CDMONBASE & "','" & NroPtovta & "'," & VCorrelVta & ""
            'GRABAEFECTIVOS = FACT_Procesa(SQL)
            Try

                Dim cn2 As New SqlConnection(STRCN)
                If cn2.State = ConnectionState.Open Then
                    cn2.Close()
                End If
                cn2.Open()
                Dim cmd2 As New SqlCommand("sp_grabadocumento_otro", cn2)
                cmd2.CommandType = CommandType.StoredProcedure

                cmd2.Parameters.AddWithValue("@NRODEGUIAS", CStr(VIE2.txtnroguias.Text)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@NPESADA", CStr(VIE2.txtnotapesada.Text)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@Eigv", CStr(VIE2.CHKIGV.Checked)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@actualizocorrelativo", CStr(fact_editnumero)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@NUMEROTRANS", CInt(FACT_NUMEROTRANSACCION)).SqlDbType = SqlDbType.Int
                cmd2.Parameters.AddWithValue("@CODDEP", CStr(VClieDep)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CODTIPOPAGO", CODTIPOPAGO.Trim).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CODTIPODOC", CStr(VCdTipoDoc)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@NRODOCU", CStr(VNroDoc)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@codmon", CStr(FACT_CDMONEDA)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CAMBIO", CDec(LBLcambio.Text)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@codvend", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@FECDOCUM", CDate(Me.DateTimePicker1.Text)).SqlDbType = SqlDbType.Date
                cmd2.Parameters.AddWithValue("@TOTBAS", CDec(IIf(CDMONBASE = FACT_CDMONEDA, VIE2.CTRLTOTAL.CtlText, VIE2.CTRLTOTAL.CtlText * LBLcambio.Text))).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@PORCENDESC1", CDec(VDescTotbas)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@TOTVUELTOBAS", CDec(ctrlvuelto.CtlText)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@TOTCASHBAS", CDec(IIf(CDMONBASE = FACT_CDMONEDA, ctrlvuelto.CtlText, ctrlvuelto.CtlText * LBLcambio.Text))).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@TOTCASHEXT", CDec(ctrlefectivoextr.CtlText)).SqlDbType = SqlDbType.Decimal
                cmd2.Parameters.AddWithValue("@codcliente", CStr(VCodCliente)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@RUCCLIENTE", CStr(VRuc)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@DESCLIENTE", CStr(VDescliente)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@DIRCLIENTE", CStr(VDireccion)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@usuario", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CODEMPRESA", CStr(codempresa)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@MONEDABASE", CStr(CDMONBASE)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@NROPTOVTA", CStr(NROPTOVTA)).SqlDbType = SqlDbType.VarChar
                cmd2.Parameters.AddWithValue("@CORRELATIVO", CInt(VCorrelVta)).SqlDbType = SqlDbType.Int

                Try
                    AFEC = cmd2.ExecuteNonQuery()
                    ''MsgBox("se grabo ...")
                    cn2.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox(EX.ToString)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            VIE2.IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
            'Dim obj As New ClsInterface
            Try
                CAyuda.Ejecutar("INSERT_CLI_POST_VTA", codempresa, VIE.VarTipoDoc.ToString.Trim, VNroDoc)
            Catch ex As Exception
            End Try
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '','INSERT','FACTURACION','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            VIE2.cbomoneda.Enabled = True
        End If
    End Function
    Sub grabaefectivosydolares()
        Dim sql As String
        Dim fechadocum As String
        Dim FECHA As DateTime
        Dim ds As New DataSet
        Dim NDOCUMENTO As Double
        Dim status As Boolean
        Dim N, I As Integer
        Dim NTOTALDOCUM As Double

        Dim tot As Double


        If estado = True Then
            VIE.CALCULO(True)
            NTOTALDOCUM = CDbl(VIE.CTRLTOTAL.CtlText)
        Else
            VIE2.CALCULO(True)
            NTOTALDOCUM = CDbl(VIE2.CTRLTOTAL.CtlText)
        End If

        lblmontobas1.Text = FACT_GFormatodeNumero(NTOTALDOCUM)
        lblmontobase.Text = FACT_GFormatodeNumero(NTOTALDOCUM)
        lblmontoextr.Text = FACT_GFormatodeNumero(CDbl(NTOTALDOCUM) / CDbl(LBLcambio.Text))
        FECHA = Now
        fechadocum = Format(FECHA, "MM/dd/yyyy")
        sql = "sp_sele_TMP_VENTADET" & VCorrelVta & ",'" & codempresa & "'"
        ds = CAyuda.ListarDatos(sql)
        N = ds.Tables(0).Rows.Count  ' OBTENGO EL NUMERO DEL DETALLE
        If VRuc = "" Then
            NDOCUMENTO = Math.Ceiling(N / ITEMDEBOLETA)
        End If
        If VRuc <> "" Then
            NDOCUMENTO = Math.Ceiling(N / ITEMDEFACT)
        End If
        ' obtengo el numero de documentos a generar

        If NDOCUMENTO = 1 Then
            status = GRABAEFECTIVOS(1, fechadocum)
            If FACT_GUIA = True Then
                'Dim FRMX As New FRMGUIASFACT
                'FRMX.PROCESAGUIA(VNroDoc)
                'FRMX.vie3 = Me
            End If

            If estado = True Then
            Else
                VIE2.NUMERODOCUMENTO()
                VIE2.NUEVO()
            End If

            Me.Close()
        End If

        Dim montoext As Double
        montoext = CDbl(ctrlefectivoextr.CtlText)

        If NDOCUMENTO > 1 Then
            For I = 1 To NDOCUMENTO
                If estado = True Then
                    NTOTALDOCUM = CDbl(VIE.CTRLTOTAL.CtlText)
                Else
                    NTOTALDOCUM = CDbl(VIE2.CTRLTOTAL.CtlText)
                End If

                tot = CDbl(ctrlefectivobas.CtlText) + (CDbl(ctrlefectivoextr.CtlText) * CDbl(LBLcambio.Text))
                If CDbl(NTOTALDOCUM) > CDbl(tot) And ctrlefectivobas.CtlText <> 0 Then
                    ctrlefectivobas.CtlText = CDbl(NTOTALDOCUM)
                    ctrlefectivoextr.CtlText = 0
                Else
                    ctrlefectivobas.CtlText = CDbl(NTOTALDOCUM)
                    ctrlefectivoextr.CtlText = 0
                End If
                'sql = 
                status = GRABAEFECTIVOS(1, fechadocum)
                'ctrlefectivobas.CtlText = CDbl(NTOTALDOCUM) - CDbl(ctrlefectivobas.CtlText)
                ctrlefectivoextr.CtlText = CDbl(montoext) + (CDbl(ctrlefectivobas.CtlText) / CDbl(LBLcambio.Text))
                'ctrlefectivobas.CtlText = CDbl(0)
                If status = True Then
                    If FACT_GUIA = True Then
                        'Dim FRMX As New FRMGUIASFACT
                        'FRMX.PROCESAGUIA(VNroDoc)
                        'FRMX.vie3 = Me
                    End If


                    If estado = True Then
                        btnaceptar.Enabled = False
                        btncancelar.Enabled = False
                        VIE.CALCULO(True)
                        NTOTALDOCUM = CDbl(VIE.CTRLTOTAL.CtlText)
                    Else
                        VIE2.NUEVO()
                        btnaceptar.Enabled = False
                        btncancelar.Enabled = False
                        VIE2.CALCULO(True)
                        NTOTALDOCUM = CDbl(VIE2.CTRLTOTAL.CtlText)
                    End If

                    lblmontobase.Text = FACT_GFormatodeNumero(NTOTALDOCUM)
                    lblmontoextr.Text = FACT_GFormatodeNumero(CDbl(NTOTALDOCUM) / CDbl(LBLcambio.Text))
                End If
                If CDbl(lblmontobase.Text) = 0 Then
                    If estado = True Then
                        VIE.OBTENERCORRELATIVO()
                    Else
                        VIE2.OBTENERCORRELATIVO()
                    End If

                    Me.Close()
                    Exit Sub
                End If
            Next I
        End If
    End Sub
    Public Sub grabatarjetasvarias(ByVal CODTIPOPAGO As Integer)
        Dim sql As String
        Dim fechadocum As String
        Dim FECHA As DateTime
        Dim ds As New DataSet
        Dim NDOCUMENTO As Double
        Dim status As Boolean
        Dim N, I As Integer
        Dim NTOTALDOCUM As Double
        Dim IT As Integer
        Dim tot, j, MONTOITEMTAR As Double
        Dim SALDO As Double
        Dim tot2 As Double

        If estado = True Then
            VIE.CALCULO(True)
            NTOTALDOCUM = CDbl(VIE.CTRLTOTAL.CtlText)
        Else
            VIE2.CALCULO(True)
            NTOTALDOCUM = CDbl(VIE2.CTRLTOTAL.CtlText)
        End If

        FECHA = Now
        fechadocum = Format(FECHA, "MM/dd/yyyy")
        sql = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
        ds = CAyuda.ListarDatos(sql)
        N = ds.Tables(0).Rows.Count  ' OBTENGO EL NUMERO DEL DETALLE
        If VRuc = "" Then
            NDOCUMENTO = Math.Ceiling(N / ITEMDEBOLETA)
        End If
        If VRuc <> "" Then
            NDOCUMENTO = Math.Ceiling(N / ITEMDEFACT)
        End If
        'NDOCUMENTO ' OBTENGO EL NUMERO DE DOCUMENTOS A GENERAR
        If NDOCUMENTO = 1 Then
            sql = "sp_upda_tmptarjvale " & VCorrelVta & ""
            TmpInsertDatos(sql)
            status = GRABAEFECTIVOS(CODTIPOPAGO, fechadocum)
            If FACT_GUIA = True Then
                'Dim FRMX As New FRMGUIASFACT
                'FRMX.PROCESAGUIA(VNroDoc)
                'FRMX.vie3 = Me
            End If

            If estado = True Then
            Else
                VIE2.NUMERODOCUMENTO()
            End If

            Me.Close()
        End If
        If NDOCUMENTO > 1 Then
            For I = 1 To NDOCUMENTO
                If CODTIPOPAGO = 8 Then    ''''''''  tarjeta 
                    While tot <= NTOTALDOCUM
                        Try
                            tot = tot + Gridtarjeta.Item(j, 5)
                            MONTOITEMTAR = Gridtarjeta.Item(j, 5)
                            'MsgBox(tot)
                            IT = j + 1
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        If CDbl(tot) >= CDbl(NTOTALDOCUM) Then ' el monto completo 
                            sql = "SP_UPDATE_TMP_VENTATARJ " & LBLcambio.Text & "," & NTOTALDOCUM & ", " & VCorrelVta & "," & IT & ",1"
                            TmpInsertDatos(sql)
                            Call cargagrid()
                            GoTo GRABAUNAVUELTA
SIGUEGRABANDO:
                            SALDO = tot - NTOTALDOCUM
                            sql = "SP_UPDATE_TMP_VENTATARJ " & LBLcambio.Text & "," & SALDO & ", " & VCorrelVta & "," & IT & ",0"
                            TmpInsertDatos(sql)
                            Call cargagrid()
                            GoTo SIGUIENTE
                        Else
                            sql = "SP_UPDATE_TMP_VENTATARJ " & LBLcambio.Text & "," & 0 & ", " & VCorrelVta & "," & IT & ",0"
                            TmpInsertDatos(sql)
                            Call cargagrid()
                            j = j + 1
                        End If
                    End While
                End If
GRABAUNAVUELTA:
                status = GRABAEFECTIVOS(CODTIPOPAGO, fechadocum)
                If estado = True Then
                Else
                    VIE2.NUMERODOCUMENTO()
                End If

                GoTo SIGUEGRABANDO
                Call iniciacontrolnumber()
SIGUIENTE:
                If estado = True Then
                    VIE.CALCULO(True)
                    tot2 = tot
                    tot = 0
                    MONTOITEMTAR = 0
                    If CDbl(tot2) = CDbl(NTOTALDOCUM) Then
                        j = j + 1
                    Else
                        If CDbl(tot2) > CDbl(NTOTALDOCUM) Then
                            j = j - 1
                        End If
                        If j = -1 Then j = 0
                    End If
                    '------------------------------------------------------------------------------
                    NTOTALDOCUM = CDbl(VIE.CTRLTOTAL.CtlText)
                Else
                    VIE2.CALCULO(True)
                    tot2 = tot
                    tot = 0
                    MONTOITEMTAR = 0
                    If CDbl(tot2) = CDbl(NTOTALDOCUM) Then
                        j = j + 1
                    Else
                        If CDbl(tot2) > CDbl(NTOTALDOCUM) Then
                            j = j - 1
                        End If
                        If j = -1 Then j = 0
                    End If
                    '------------------------------------------------------------------------------
                    NTOTALDOCUM = CDbl(VIE2.CTRLTOTAL.CtlText)
                End If

            Next I
        End If
        If status = True Then
            If FACT_GUIA = True Then
                'Dim FRMX As New FRMGUIASFACT
                'FRMX.PROCESAGUIA(VNroDoc)
                'FRMX.vie3 = Me

            End If

            If estado = True Then
                btnaceptar.Enabled = False
                btnnuevo.Enabled = True
                btncancelar.Enabled = False
                'status = FACT_Procesa("LIMPIA_TMP_VENTA " & CORRELATIVO & "")
                btnnuevo.Focus()
                VIE.OBTENERCORRELATIVO()
            Else
                VIE2.NUEVO()
                btnaceptar.Enabled = False
                btnnuevo.Enabled = True
                btncancelar.Enabled = False
                'status = FACT_Procesa("LIMPIA_TMP_VENTA " & CORRELATIVO & "")
                btnnuevo.Focus()
                VIE2.OBTENERCORRELATIVO()
            End If

        End If
    End Sub

    Public Sub grabavalesvarios(ByVal CODTIPOPAGO As Integer)
        Dim sql As String
        Dim fechadocum As String
        Dim FECHA As DateTime
        Dim ds As New DataSet
        Dim NDOCUMENTO As Double
        Dim status As Boolean
        Dim N, I, J As Integer
        Dim NTOTALDOCUM As Double
        Dim IT As Integer
        Dim tot, MONTOITEMTAR As Double
        Dim SALDO As Double
        Dim tot2 As Double

        If estado = True Then
            VIE.CALCULO(True)
            NTOTALDOCUM = CDbl(VIE.CTRLTOTAL.CtlText)
        Else
            VIE2.CALCULO(True)
            NTOTALDOCUM = CDbl(VIE2.CTRLTOTAL.CtlText)
        End If

        FECHA = Now
        fechadocum = Format(FECHA, "MM/dd/yyyy")
        sql = "sp_sele_TMP_VENTADET" & VCorrelVta & ",'" & codempresa & "'"
        ds = CAyuda.ListarDatos(sql)
        N = ds.Tables(0).Rows.Count  ' OBTENGO EL NUMERO DEL DETALLE
        If VRuc = "" Then
            NDOCUMENTO = Math.Ceiling(N / ITEMDEBOLETA)
        End If
        If VRuc <> "" Then
            NDOCUMENTO = Math.Ceiling(N / ITEMDEFACT)
        End If
        'NDOCUMENTO ' OBTENGO EL NUMERO DE DOCUMENTOS A GENERAR
        If NDOCUMENTO = 1 Then
            sql = "sp_upda_tmptarjvale " & VCorrelVta & ""
            TmpInsertDatos(sql)
            status = GRABAEFECTIVOS(CODTIPOPAGO, fechadocum)
            If FACT_GUIA = True Then
                'Dim FRMX As New FRMGUIASFACT
                'FRMX.PROCESAGUIA(VNroDoc)
                'FRMX.vie3 = Me
            End If

            If estado = True Then
                VIE.IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
            Else
                VIE2.IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
                VIE2.NUMERODOCUMENTO()
            End If

            Me.Close()
        End If
        If NDOCUMENTO > 1 Then
            For I = 1 To NDOCUMENTO
                If CODTIPOPAGO = 8 Then    '''''''' VALES
                    While tot <= NTOTALDOCUM
                        Try
                            tot = tot + gridvale.Item(J, 4)
                            MONTOITEMTAR = gridvale.Item(J, 4)
                            'MsgBox(tot)
                            IT = J + 1
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        If CDbl(tot) >= CDbl(NTOTALDOCUM) Then ' el monto completo 
                            sql = "SP_UPDATE_TMP_VENTAVALES " & LBLcambio.Text & "," & NTOTALDOCUM & ", " & VCorrelVta & "," & IT & ",1"
                            TmpInsertDatos(sql)
                            Call cargagrid()
                            GoTo GRABAUNAVUELTA
SIGUEGRABANDO:
                            SALDO = tot - NTOTALDOCUM
                            sql = "SP_UPDATE_TMP_VENTAVALES " & LBLcambio.Text & "," & SALDO & ", " & VCorrelVta & "," & IT & ",0"
                            TmpInsertDatos(sql)
                            Call cargagrid()
                            GoTo SIGUIENTE
                        Else
                            sql = "SP_UPDATE_TMP_VENTAVALES " & LBLcambio.Text & "," & 0 & ", " & VCorrelVta & "," & IT & ",0"
                            TmpInsertDatos(sql)
                            Call cargagrid()
                            J = J + 1
                        End If
                    End While
                End If
GRABAUNAVUELTA:
                status = GRABAEFECTIVOS(CODTIPOPAGO, fechadocum)
                If estado = True Then
                Else
                    VIE2.NUMERODOCUMENTO()
                End If

                GoTo SIGUEGRABANDO
                Call iniciacontrolnumber()
SIGUIENTE:
                If estado = True Then
                    VIE.CALCULO(True)
                Else
                    VIE2.CALCULO(True)
                End If

                tot2 = tot
                tot = 0
                MONTOITEMTAR = 0
                If CDbl(tot2) = CDbl(NTOTALDOCUM) Then
                    J = J + 1
                Else
                    If CDbl(tot2) > CDbl(NTOTALDOCUM) Then
                        J = J - 1
                    End If
                    If J = -1 Then J = 0
                End If
                '------------------------------------------------------------------------------
                If estado = True Then
                    NTOTALDOCUM = CDbl(VIE.CTRLTOTAL.CtlText)
                Else
                    NTOTALDOCUM = CDbl(VIE2.CTRLTOTAL.CtlText)
                End If

            Next I
        End If
        If status = True Then
            If FACT_GUIA = True Then
                'Dim FRMX As New FRMGUIASFACT
                'FRMX.PROCESAGUIA(VNroDoc)
                'FRMX.vie3 = Me
            End If

            If estado = True Then
            Else
                VIE2.NUEVO()
            End If

            btnaceptar.Enabled = False
            btnnuevo.Enabled = True
            btncancelar.Enabled = False
            'status = FACT_Procesa("LIMPIA_TMP_VENTA " & CORRELATIVO & "")
            btnnuevo.Focus()
            If estado = True Then
                VIE.OBTENERCORRELATIVO()
            Else
                VIE2.OBTENERCORRELATIVO()
            End If

        End If
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.Close()
    End Sub
End Class
