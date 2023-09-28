Public Class FRM_REPORT_COSTO_VENTA_PROD
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents calmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents l2 As System.Windows.Forms.ListView
    Friend WithEvents l1 As System.Windows.Forms.ListView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_REPORT_COSTO_VENTA_PROD))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.calmacen = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.l2 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.l1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.RadioButton9 = New System.Windows.Forms.RadioButton
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(281, 354)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(209, 48)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dispositivo"
        '
        'RadioButton5
        '
        Me.RadioButton5.Location = New System.Drawing.Point(112, 24)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Impresora"
        '
        'RadioButton4
        '
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(36, 24)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(64, 16)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Pantalla"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton7)
        Me.GroupBox5.Controls.Add(Me.RadioButton6)
        Me.GroupBox5.Location = New System.Drawing.Point(108, 408)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(207, 48)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Mostrar por"
        Me.GroupBox5.Visible = False
        '
        'RadioButton7
        '
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Location = New System.Drawing.Point(16, 24)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(88, 16)
        Me.RadioButton7.TabIndex = 24
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Por Medida"
        '
        'RadioButton6
        '
        Me.RadioButton6.Location = New System.Drawing.Point(112, 24)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton6.TabIndex = 25
        Me.RadioButton6.Text = "Por Unidad"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.calmacen)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(696, 56)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        '
        'calmacen
        '
        Me.calmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.calmacen.Location = New System.Drawing.Point(440, 22)
        Me.calmacen.Name = "calmacen"
        Me.calmacen.Size = New System.Drawing.Size(232, 21)
        Me.calmacen.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Almacén :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(232, 22)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(112, 21)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Al :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 21)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Del :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(527, 410)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(168, 24)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "&Cancelar"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(343, 410)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(168, 24)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "&Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 48)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mostrar por Líneas"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(195, 22)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(64, 16)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Artículo"
        Me.RadioButton3.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(139, 22)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "SubLínea"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(49, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Línea"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.l2)
        Me.GroupBox1.Controls.Add(Me.l1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 288)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'l2
        '
        Me.l2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.l2.FullRowSelect = True
        Me.l2.Location = New System.Drawing.Point(392, 16)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(288, 232)
        Me.l2.TabIndex = 15
        Me.l2.UseCompatibleStateImageBehavior = False
        Me.l2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = ""
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = ""
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = ""
        Me.ColumnHeader6.Width = 255
        '
        'l1
        '
        Me.l1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.l1.FullRowSelect = True
        Me.l1.Location = New System.Drawing.Point(16, 16)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(288, 232)
        Me.l1.TabIndex = 14
        Me.l1.UseCompatibleStateImageBehavior = False
        Me.l1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = ""
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = ""
        Me.ColumnHeader3.Width = 255
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 256)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 21)
        Me.TextBox1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(320, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = ">>"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(320, 170)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 24)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "<<"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(320, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 24)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "<"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(320, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = ">"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Busqueda Rápida :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton8)
        Me.GroupBox6.Controls.Add(Me.RadioButton9)
        Me.GroupBox6.Location = New System.Drawing.Point(501, 354)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(208, 48)
        Me.GroupBox6.TabIndex = 43
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo de Moneda"
        '
        'RadioButton8
        '
        Me.RadioButton8.Location = New System.Drawing.Point(120, 24)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(64, 16)
        Me.RadioButton8.TabIndex = 24
        Me.RadioButton8.Text = "Dólar"
        '
        'RadioButton9
        '
        Me.RadioButton9.Checked = True
        Me.RadioButton9.Location = New System.Drawing.Point(24, 24)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton9.TabIndex = 25
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Nuevo Sol"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(30, 472)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 44
        '
        'FRM_REPORT_COSTO_VENTA_PROD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(716, 439)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_REPORT_COSTO_VENTA_PROD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Costo de Ventas por Producto"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cod, cod2 As New ArrayList
    Public bol As Int16
    Dim sql As String

    Private Sub frm_calcdifinventarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        dt = CAyuda.ListarDatos("sp_almacenesdes", codempresa).Tables(0)
        calmacen.DataSource = dt
        calmacen.DisplayMember = "desalmacen"
        calmacen.ValueMember = "CODALMACEN"
        calmacen.SelectedIndex = 0

        Linea(l1, cod, "")

    End Sub

    Sub Linea(ByVal lista As ListView, ByVal c As ArrayList, ByVal valor As String)
        sql = String.Format("select codlinea,deslinea from linea where estado=0 and codempresa='{0}' and deslinea like '{1}%' ", codempresa, valor.Trim)
        LLena_Lista(lista, c, sql)
    End Sub
    Sub Sublinea(ByVal lista As ListView, ByVal c As ArrayList, ByVal valor As String)
        sql = "select codsublinea,dessublinea from sublinea where estado=0 and codempresa='" & codempresa & "' and dessublinea like '" & valor.Trim & "%'"
        LLena_Lista(lista, c, sql)
    End Sub
    Sub Articulo(ByVal lista As ListView, ByVal c As ArrayList, ByVal valor As String)
        sql = "select codarti,desarti from articulo where estado=0 and codempresa='" & codempresa & "' and desarti like '" & valor.Trim & "%'"
        LLena_Lista(lista, c, sql)
    End Sub


    Sub LLena_Lista(ByVal l1 As ListView, ByVal c As ArrayList, ByVal sql As String)
        c.Clear()
        l1.Items.Clear()
        Dim dt_ta As New DataTable
        dt_ta = TmpListarDatos(sql)
        For Each dr As DataRow In dt_ta.Rows
            Dim i As New ListViewItem
            i.SubItems.Add(dr.Item(0).ToString.ToUpper)
            i.SubItems.Add(dr.Item(1).ToString.ToUpper)
            l1.Items.Add(i)
        Next
    End Sub

    Dim cad As Short
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            cad = 1
            l2.Items.Clear()
            Linea(l1, cod, Me.TextBox1.Text.Trim)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked = True Then
            cad = 2
            l2.Items.Clear()
            Sublinea(l1, cod, Me.TextBox1.Text.Trim)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If Me.RadioButton3.Checked = True Then
            cad = 3
            l2.Items.Clear()
            Articulo(l1, cod, Me.TextBox1.Text.Trim)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.RadioButton1.Checked = True Then
            Linea(l2, cod2, "")
        ElseIf Me.RadioButton2.Checked = True Then
            Sublinea(l2, cod2, "")
        ElseIf Me.RadioButton3.Checked = True Then
            Articulo(l2, cod2, "")
        End If
        cod.Clear()
        l1.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.RadioButton1.Checked = True Then
            Linea(l1, cod, "")
        ElseIf Me.RadioButton2.Checked = True Then
            Sublinea(l1, cod, "")
        ElseIf Me.RadioButton3.Checked = True Then
            Articulo(l1, cod, "")
        End If
        cod2.Clear()
        l2.Items.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        llena_uno(l2, cod2, l1, cod)
        'Me.Text = cod2.Count
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        llena_uno(l1, cod, l2, cod2)
    End Sub

    Sub llena_uno(ByVal l1 As ListView, ByVal cod As ArrayList, ByVal l2 As ListView, ByVal cod2 As ArrayList)
        Try
            If l2.Items.Count = 0 Then
                Exit Sub
            End If
            Dim m As New ListViewItem
            m.SubItems.Add(l2.Items(l2.FocusedItem.Index).SubItems(1).Text)
            m.SubItems.Add(l2.Items(l2.FocusedItem.Index).SubItems(2).Text)
            l1.Items.Add(m)
            l2.Items.RemoveAt(l2.FocusedItem.Index)
        Catch x As Exception
            MessageBox.Show("Seleccione el Registro que desee Trasladar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Dim i, j As Integer
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If l2.Items.Count = 0 Then
            MsgBox("PRIMERO SELECCIONE ITEMS.", MsgBoxStyle.Information, DesEmpresa)
            Exit Sub
        End If

        Try
            Dim Nromeses As Integer
            Dim fechaini, fechahas As Date
            Dim NomTablaC, NomTablaD As String
            Dim AA As Date
            AA = DateAdd(DateInterval.Day, 1, Me.DateTimePicker2.Value)

            fechaini = String.Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            fechahas = String.Format(Me.DateTimePicker2.Value, "dd/MM/yyyy")
            Nromeses = DateDiff("m", fechaini, fechahas)

            TmpInsertDatos("delete from TMP_COSTO_DE_VENTAS where NROPUNTO='" & Environment.MachineName & "'")

            For j = 0 To l2.Items.Count - 1

                If cad = 1 Then
                    If Me.RadioButton9.Checked = True Then
                        TmpInsertDatos("nsp_llena_costo_venta_prod_linea_1 '" & Environment.MachineName & "','" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',0")

                        For i = 0 To Nromeses
                            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
                            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

                            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                                TmpInsertDatos("nsp_llena_costo_venta_prod_linea_histo_1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',0,'" & Environment.MachineName & "','" & NomTablaD & "'")
                            End If
                        Next
                    Else
                        TmpInsertDatos("nsp_llena_costo_venta_prod_linea_1 '" & Environment.MachineName & "','" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',1")

                        For i = 0 To Nromeses
                            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
                            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

                            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                                TmpInsertDatos("nsp_llena_costo_venta_prod_linea_histo_1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',1,'" & Environment.MachineName & "','" & NomTablaD & "'")
                            End If
                        Next
                    End If
                ElseIf cad = 2 Then
                    If Me.RadioButton9.Checked = True Then
                        TmpInsertDatos("nsp_llena_costo_venta_prod_sublinea_1 '" & Environment.MachineName & "','" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',0")

                        For i = 0 To Nromeses
                            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
                            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

                            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                                TmpInsertDatos("nsp_llena_costo_venta_prod_sublinea_histo_1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',0,'" & Environment.MachineName & "','" & NomTablaD & "'")
                            End If
                        Next
                    Else
                        TmpInsertDatos("nsp_llena_costo_venta_prod_sublinea_1 '" & Environment.MachineName & "','" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',1")

                        For i = 0 To Nromeses
                            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
                            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

                            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                                TmpInsertDatos("nsp_llena_costo_venta_prod_sublinea_histo_1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',1,'" & Environment.MachineName & "','" & NomTablaD & "'")
                            End If
                        Next
                    End If
                ElseIf cad = 3 Then
                    'If Me.RadioButton9.Checked = True Then
                    '    TmpInsertDatos("nsp_llena_costo_venta_prod_arti '" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',0,'" & Environment.MachineName & "'")
                    '    TmpInsertDatos("nsp_llena_costo_venta_prod_articulo_histo '" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',0,'" & Environment.MachineName & "'")
                    'Else
                    '    TmpInsertDatos("nsp_llena_costo_venta_prod_arti '" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',1,'" & Environment.MachineName & "'")
                    '    TmpInsertDatos("nsp_llena_costo_venta_prod_articulo_histo '" & Me.calmacen.SelectedValue.ToString & "','" & Me.l2.Items(j).SubItems(1).Text.Trim.ToUpper & "','" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "dd/MM/yyyy") & "',1,'" & Environment.MachineName & "'")
                    'End If
                End If
            Next

            Dim a1, b1 As String
            a1 = Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            b1 = Format(Me.DateTimePicker2.Value, "dd/MM/yyyy")
            AxCrystalReport1.set_StoredProcParam(0, Environment.MachineName)
            'AxCrystalReport1.set_StoredProcParam(1, a1)
            'AxCrystalReport1.set_StoredProcParam(2, b1)

            AxCrystalReport1.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
            AxCrystalReport1.set_Formulas(1, "Fecha1='" & a1 & "'")
            AxCrystalReport1.set_Formulas(2, "Fecha2='" & b1 & "'")

            If RadioButton1.Checked = True Then
                AxCrystalReport1.set_Formulas(3, "Filtro='LINEA'")
            Else
                AxCrystalReport1.set_Formulas(3, "Filtro='SUBLINEA'")
            End If

            If Me.RadioButton9.Checked = True Then
                AxCrystalReport1.set_Formulas(4, "Moneda='S/.'")
            Else
                AxCrystalReport1.set_Formulas(4, "Moneda='U$'")
            End If

            AxCrystalReport1.set_Formulas(5, "Usuario='" & DesUsuario & "'")

            AxCrystalReport1.ReportFileName = rutareporte + CType("Rpt_VentasxCostos.rpt", String)
            AxCrystalReport1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            'axcrt2.ReportFileName = rutareporte + CType("COSTO DE VENTAS POR PRODUCTO.rpt", String)

            If Me.RadioButton4.Checked = True Then
                AxCrystalReport1.Destination = Crystal.DestinationConstants.crptToWindow
                AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            Else
                AxCrystalReport1.Destination = Crystal.DestinationConstants.crptToPrinter
            End If
            AxCrystalReport1.Action = 1
            AxCrystalReport1.Reset()

        Catch x As Exception

            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Me.RadioButton1.Checked = True Then
            cad = 1
            l2.Items.Clear()
            Linea(l1, cod2, Me.TextBox1.Text.Trim)
        ElseIf Me.RadioButton2.Checked = True Then
            cad = 2
            l2.Items.Clear()
            Sublinea(l1, cod2, Me.TextBox1.Text.Trim)
        ElseIf Me.RadioButton3.Checked = True Then
            cad = 3
            l2.Items.Clear()
            Articulo(l1, cod2, Me.TextBox1.Text.Trim)
        End If
    End Sub



End Class
