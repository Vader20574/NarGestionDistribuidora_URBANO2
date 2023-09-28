Imports System.Data.SqlClient

Public Class FrmIngresarLetra
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents DtFecVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNroLetra As System.Windows.Forms.TextBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LstCargaLetra As System.Windows.Forms.ListView
    Friend WithEvents LblMontoTotBas As System.Windows.Forms.Label
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents LblFormaPag As System.Windows.Forms.Label
    Friend WithEvents CboFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtFechaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecVenc As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmIngresarLetra))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtFechaDoc = New System.Windows.Forms.DateTimePicker
        Me.CboFormaPago = New System.Windows.Forms.ComboBox
        Me.BtnQuitar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.LblTotal = New System.Windows.Forms.Label
        Me.TxtImporte = New System.Windows.Forms.TextBox
        Me.TxtNroLetra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LstCargaLetra = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtFecVenc = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblFormaPag = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblMontoTotBas = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.LblFecVenc = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblFecVenc)
        Me.GroupBox1.Controls.Add(Me.DtFechaDoc)
        Me.GroupBox1.Controls.Add(Me.CboFormaPago)
        Me.GroupBox1.Controls.Add(Me.BtnQuitar)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Controls.Add(Me.TxtImporte)
        Me.GroupBox1.Controls.Add(Me.TxtNroLetra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LstCargaLetra)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DtFecVenc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblFormaPag)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 312)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DtFechaDoc
        '
        Me.DtFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtFechaDoc.Location = New System.Drawing.Point(306, 12)
        Me.DtFechaDoc.Name = "DtFechaDoc"
        Me.DtFechaDoc.Size = New System.Drawing.Size(94, 20)
        Me.DtFechaDoc.TabIndex = 171
        '
        'CboFormaPago
        '
        Me.CboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFormaPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFormaPago.Location = New System.Drawing.Point(122, 36)
        Me.CboFormaPago.Name = "CboFormaPago"
        Me.CboFormaPago.Size = New System.Drawing.Size(214, 22)
        Me.CboFormaPago.TabIndex = 169
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuitar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitar.ImageIndex = 3
        Me.BtnQuitar.ImageList = Me.ImageList1
        Me.BtnQuitar.Location = New System.Drawing.Point(198, 124)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(82, 25)
        Me.BtnQuitar.TabIndex = 168
        Me.BtnQuitar.Text = "    &Quitar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.ImageIndex = 13
        Me.BtnAgregar.ImageList = Me.ImageList1
        Me.BtnAgregar.Location = New System.Drawing.Point(68, 124)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(82, 25)
        Me.BtnAgregar.TabIndex = 167
        Me.BtnAgregar.Text = "     &Agregar"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.White
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(264, 270)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(86, 26)
        Me.LblTotal.TabIndex = 166
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(122, 92)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(78, 20)
        Me.TxtImporte.TabIndex = 2
        Me.TxtImporte.Text = "0.00"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNroLetra
        '
        Me.TxtNroLetra.Location = New System.Drawing.Point(122, 10)
        Me.TxtNroLetra.Name = "TxtNroLetra"
        Me.TxtNroLetra.Size = New System.Drawing.Size(92, 20)
        Me.TxtNroLetra.TabIndex = 0
        Me.TxtNroLetra.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Nro Letra : "
        '
        'LstCargaLetra
        '
        Me.LstCargaLetra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LstCargaLetra.FullRowSelect = True
        Me.LstCargaLetra.GridLines = True
        Me.LstCargaLetra.Location = New System.Drawing.Point(6, 150)
        Me.LstCargaLetra.MultiSelect = False
        Me.LstCargaLetra.Name = "LstCargaLetra"
        Me.LstCargaLetra.Size = New System.Drawing.Size(344, 114)
        Me.LstCargaLetra.TabIndex = 158
        Me.LstCargaLetra.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nro Letra"
        Me.ColumnHeader1.Width = 122
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fecha Vencimiento"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Monto"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 87
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Monto : "
        '
        'DtFecVenc
        '
        Me.DtFecVenc.CalendarForeColor = System.Drawing.Color.White
        Me.DtFecVenc.CalendarMonthBackground = System.Drawing.Color.White
        Me.DtFecVenc.CalendarTitleBackColor = System.Drawing.Color.White
        Me.DtFecVenc.CalendarTitleForeColor = System.Drawing.Color.White
        Me.DtFecVenc.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.DtFecVenc.Enabled = False
        Me.DtFecVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtFecVenc.Location = New System.Drawing.Point(122, 66)
        Me.DtFecVenc.Name = "DtFecVenc"
        Me.DtFecVenc.Size = New System.Drawing.Size(94, 20)
        Me.DtFecVenc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Fecha Vencimiento : "
        '
        'LblFormaPag
        '
        Me.LblFormaPag.AutoSize = True
        Me.LblFormaPag.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormaPag.Location = New System.Drawing.Point(32, 40)
        Me.LblFormaPag.Name = "LblFormaPag"
        Me.LblFormaPag.Size = New System.Drawing.Size(93, 16)
        Me.LblFormaPag.TabIndex = 170
        Me.LblFormaPag.Text = "Forma de Pago: "
        Me.LblFormaPag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Total : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Fecha Let : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LblMontoTotBas)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 130)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(146, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 48)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "TOTAL MONTO  DE LETRAS A CREAR"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblMontoTotBas
        '
        Me.LblMontoTotBas.BackColor = System.Drawing.Color.White
        Me.LblMontoTotBas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMontoTotBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoTotBas.Location = New System.Drawing.Point(148, 74)
        Me.LblMontoTotBas.Name = "LblMontoTotBas"
        Me.LblMontoTotBas.Size = New System.Drawing.Size(112, 30)
        Me.LblMontoTotBas.TabIndex = 8
        Me.LblMontoTotBas.Text = "0.00"
        Me.LblMontoTotBas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "S/."
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(236, 468)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(95, 25)
        Me.BTNCANCELAR.TabIndex = 7
        Me.BTNCANCELAR.Text = "  &Cancelar"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(94, 468)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(96, 25)
        Me.BTNGUARDAR.TabIndex = 6
        Me.BTNGUARDAR.Text = "  &Guardar"
        '
        'LblFecVenc
        '
        Me.LblFecVenc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecVenc.Location = New System.Drawing.Point(216, 68)
        Me.LblFecVenc.Name = "LblFecVenc"
        Me.LblFecVenc.Size = New System.Drawing.Size(188, 23)
        Me.LblFecVenc.TabIndex = 173
        Me.LblFecVenc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmIngresarLetra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(426, 506)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIngresarLetra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Letra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones"

  
    

    Private Sub CargarLetra()
        LblTotal.Text = "0.00"
        LstCargaLetra.Items.Clear()

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Cn.Open()
        Dim Cmd As New SqlCommand("SelecTMP_LETRACOMPRAxProc  '" & codempresa & "','" & VCorrelInv & "'", Cn)
        Cmd.CommandType = CommandType.Text
        Dim lee As SqlDataReader = Nothing
        Try
            lee = Cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        While lee.Read
            Dim y As Integer = LstCargaLetra.Items.Count
            LstCargaLetra.Items.Add(lee.Item("NROLETRA"))
            LstCargaLetra.Items(y).SubItems.Add(CStr(lee.Item("FECHAVENC")))
            LstCargaLetra.Items(y).SubItems.Add(FormatoMonto(lee.Item("TOTBAS"), DECIRESU))
            LblTotal.Text = CDbl(LblTotal.Text) + CDbl(lee.Item("TOTBAS"))
        End While
        LblTotal.Text = FormatoMonto(CDbl(LblTotal.Text), DECIRESU)

    End Sub

#End Region
#Region "Variables"
    Public DEVOLVER As Boolean
    Public TAB_LETRAS As New DataTable
    Public VNroRefe As String
    Public VCodProveedor As String
    Public VDesProveedor As String
    Private ActEvtCMB As Boolean

#End Region
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Me.Close()
    End Sub

    Private Sub FrmIngresarLetra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(CboFormaPago, "Nsp_sel_TipCredF '" & codempresa & "'", "Codigo", "Descripcion")
        ActEvtCMB = True
        CboFormaPago_SelectedIndexChanged(sender, e)
        TmpInsertDatos("DELETE  FROM TMP_LETRACOMPRA  WHERE CODEMPRESA='" & codempresa & "' AND CORRNBR='" & VCorrelInv & "'")

    End Sub

    Private Sub TxtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImporte.TextChanged

    End Sub

    Private Sub TxtImporte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtImporte.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAgregar_Click(sender, e)
        End If
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If CDbl(LblTotal.Text) > CDbl(LblMontoTotBas.Text) Then
            MsgBox("EL TOTAL NO PUEDE SER MAYOR AL MONTO DE LETRAS A CREAR ..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If CDbl(LblTotal.Text) < CDbl(LblMontoTotBas.Text) Then
            MsgBox("EL TOTAL NO PUEDE SER MENOR AL MONTO DE LETRAS A CREAR ..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        DEVOLVER = True
        Me.Close()

    End Sub

    Private Sub TxtNroLetra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNroLetra.TextChanged

    End Sub

    Private Sub TxtNroLetra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNroLetra.KeyDown
        If e.KeyCode = Keys.Enter Then
            DtFechaDoc.Focus()
        End If
    End Sub

    Private Sub DtFecVenc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtFecVenc.ValueChanged
        LblFecVenc.Text = DtFecVenc.Value.ToLongDateString
    End Sub

    Private Sub DtFecVenc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtFecVenc.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtImporte.Focus()
        End If

    End Sub

    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click

        If LstCargaLetra.Items.Count > 0 And LstCargaLetra.SelectedIndices.Count > 0 Then
            CAyuda.Ejecutar("EliTMP_LETRACOMPRAxProc", codempresa, VCorrelInv, LstCargaLetra.SelectedItems(0).Text)
            CargarLetra()
        End If



    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If TxtNroLetra.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR NRO DE LETRA..", MsgBoxStyle.Exclamation, "")
            TxtNroLetra.Focus()
            Exit Sub
        End If
        If CDate(DtFecVenc.Value) = CDate(DtFechaDoc.Value) Then
            MsgBox("FALTA INDICAR LA FECHA DE VENCIMIENTO ..", MsgBoxStyle.Exclamation, "")
            DtFecVenc.Focus()
            Exit Sub
        End If
        If TxtImporte.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL IMPORTE..", MsgBoxStyle.Exclamation, "")
            TxtImporte.Focus()
            Exit Sub
        End If
        If CDbl(TxtImporte.Text) = 0 Then
            MsgBox("EL IMPORTE NO PUEDE SER CERO..", MsgBoxStyle.Exclamation, "")
            TxtImporte.Focus()
            Exit Sub
        End If

        If CDbl(TmpListarDatos("SELECT  COUNT(*) FROM LETRACOMPRA  WHERE CODEMPRESA='" & codempresa & "' AND  NROLETRA='" & TxtNroLetra.Text.Trim & "' AND  CODPROVEEDOR='" & VCodProveedor & "'").Rows(0)(0)) > 0 Then
            MsgBox("YA EXISTE LA LETRA GUARDADA EN LA CUENTA DEL PROVEEDOR..", MsgBoxStyle.Exclamation, "")
            TxtNroLetra.Focus()
            Exit Sub
        End If

        CAyuda.Ejecutar("InsTMP_LETRACOMPRAxProc", codempresa, VCorrelInv, TxtNroLetra.Text.Trim, VNroRefe, CDMONBASE, VCambioCompra, Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy"), CDbl(TxtImporte.Text), FormatoMonto(CDbl(TxtImporte.Text) / VCambioCompra, DECIRESU), VCodProveedor.Trim, VDesProveedor.Trim, CboFormaPago.SelectedValue)
        CargarLetra()
        TxtImporte.Text = "0.00"
        TxtNroLetra.Text = ""
        TxtNroLetra.Focus()


    End Sub

    Private Sub CboFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboFormaPago.SelectedIndexChanged
        If ActEvtCMB = True Then
            Dim tab As New DataTable
            tab = TmpListarDatos("SelecTIPCREDFxCod  '" & codempresa & "','" & CboFormaPago.SelectedValue & "'")
            If tab.Rows.Count > 0 Then
                DtFecVenc.Value = CDate(DtFechaDoc.Value).AddDays(tab.Rows(0)("NRDIAS"))
            End If
        End If




    End Sub

    Private Sub DtFechaDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtFechaDoc.ValueChanged

    End Sub

    Private Sub DtFechaDoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtFechaDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboFormaPago.Focus()

        End If
    End Sub

    Private Sub CboFormaPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboFormaPago.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtImporte.Focus()
        End If
    End Sub
End Class
