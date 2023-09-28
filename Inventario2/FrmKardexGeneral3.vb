Public Class FrmKardexGeneral3
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
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LstCat1 As System.Windows.Forms.ListBox
    Friend WithEvents LstCat2 As System.Windows.Forms.ListBox
    Friend WithEvents BtnRegresaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnRegresaUno As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbval As System.Windows.Forms.RadioButton
    Friend WithEvents btnpassizt As System.Windows.Forms.Button
    Friend WithEvents btnpassiz As System.Windows.Forms.Button
    Friend WithEvents btnpasde As System.Windows.Forms.Button
    Friend WithEvents btnpasdet As System.Windows.Forms.Button
    Friend WithEvents lbvende2 As System.Windows.Forms.ListBox
    Friend WithEvents lbvende1 As System.Windows.Forms.ListBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKardexGeneral3))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnRegresaTodo = New System.Windows.Forms.Button
        Me.BtnRegresaUno = New System.Windows.Forms.Button
        Me.BtnPasaTodo = New System.Windows.Forms.Button
        Me.BtnPasaUno = New System.Windows.Forms.Button
        Me.LstCat2 = New System.Windows.Forms.ListBox
        Me.LstCat1 = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnGenerar = New System.Windows.Forms.Button
        Me.Rpt1 = New AxCrystal.AxCrystalReport
        Me.CboAlmacen = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbval = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnpassizt = New System.Windows.Forms.Button
        Me.btnpassiz = New System.Windows.Forms.Button
        Me.btnpasde = New System.Windows.Forms.Button
        Me.btnpasdet = New System.Windows.Forms.Button
        Me.lbvende2 = New System.Windows.Forms.ListBox
        Me.lbvende1 = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnRegresaTodo)
        Me.GroupBox1.Controls.Add(Me.BtnRegresaUno)
        Me.GroupBox1.Controls.Add(Me.BtnPasaTodo)
        Me.GroupBox1.Controls.Add(Me.BtnPasaUno)
        Me.GroupBox1.Controls.Add(Me.LstCat2)
        Me.GroupBox1.Controls.Add(Me.LstCat1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 374)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione Categorias"
        '
        'BtnRegresaTodo
        '
        Me.BtnRegresaTodo.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BtnRegresaTodo.Location = New System.Drawing.Point(250, 212)
        Me.BtnRegresaTodo.Name = "BtnRegresaTodo"
        Me.BtnRegresaTodo.Size = New System.Drawing.Size(75, 28)
        Me.BtnRegresaTodo.TabIndex = 5
        Me.BtnRegresaTodo.Text = "<<"
        '
        'BtnRegresaUno
        '
        Me.BtnRegresaUno.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BtnRegresaUno.Location = New System.Drawing.Point(250, 178)
        Me.BtnRegresaUno.Name = "BtnRegresaUno"
        Me.BtnRegresaUno.Size = New System.Drawing.Size(75, 28)
        Me.BtnRegresaUno.TabIndex = 4
        Me.BtnRegresaUno.Text = "<"
        '
        'BtnPasaTodo
        '
        Me.BtnPasaTodo.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BtnPasaTodo.Location = New System.Drawing.Point(250, 98)
        Me.BtnPasaTodo.Name = "BtnPasaTodo"
        Me.BtnPasaTodo.Size = New System.Drawing.Size(75, 28)
        Me.BtnPasaTodo.TabIndex = 3
        Me.BtnPasaTodo.Text = ">>"
        '
        'BtnPasaUno
        '
        Me.BtnPasaUno.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPasaUno.Location = New System.Drawing.Point(250, 64)
        Me.BtnPasaUno.Name = "BtnPasaUno"
        Me.BtnPasaUno.Size = New System.Drawing.Size(75, 28)
        Me.BtnPasaUno.TabIndex = 2
        Me.BtnPasaUno.Text = ">"
        '
        'LstCat2
        '
        Me.LstCat2.Location = New System.Drawing.Point(336, 24)
        Me.LstCat2.Name = "LstCat2"
        Me.LstCat2.Size = New System.Drawing.Size(232, 277)
        Me.LstCat2.TabIndex = 1
        '
        'LstCat1
        '
        Me.LstCat1.Location = New System.Drawing.Point(6, 26)
        Me.LstCat1.Name = "LstCat1"
        Me.LstCat1.Size = New System.Drawing.Size(232, 277)
        Me.LstCat1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtFechaIni)
        Me.GroupBox2.Controls.Add(Me.DtFechaFin)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 86)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fecha"
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(56, 20)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaIni.TabIndex = 3
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(56, 54)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaFin.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desde :"
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
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        Me.ImageList1.Images.SetKeyName(15, "")
        Me.ImageList1.Images.SetKeyName(16, "")
        Me.ImageList1.Images.SetKeyName(17, "")
        Me.ImageList1.Images.SetKeyName(18, "")
        Me.ImageList1.Images.SetKeyName(19, "")
        Me.ImageList1.Images.SetKeyName(20, "")
        Me.ImageList1.Images.SetKeyName(21, "")
        Me.ImageList1.Images.SetKeyName(22, "")
        Me.ImageList1.Images.SetKeyName(23, "")
        Me.ImageList1.Images.SetKeyName(24, "")
        Me.ImageList1.Images.SetKeyName(25, "")
        Me.ImageList1.Images.SetKeyName(26, "")
        Me.ImageList1.Images.SetKeyName(27, "")
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(112, 342)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "    &Salir"
        '
        'BtnGenerar
        '
        Me.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGenerar.ImageIndex = 11
        Me.BtnGenerar.ImageList = Me.ImageList1
        Me.BtnGenerar.Location = New System.Drawing.Point(10, 342)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerar.TabIndex = 9
        Me.BtnGenerar.Text = "&Generar"
        Me.BtnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(812, 120)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 11
        '
        'CboAlmacen
        '
        Me.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAlmacen.Location = New System.Drawing.Point(4, 20)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(172, 21)
        Me.CboAlmacen.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.BtnGenerar)
        Me.GroupBox3.Controls.Add(Me.BtnCancelar)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(602, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 374)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbval)
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 268)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(182, 60)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo"
        '
        'rbval
        '
        Me.rbval.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbval.Location = New System.Drawing.Point(36, 12)
        Me.rbval.Name = "rbval"
        Me.rbval.Size = New System.Drawing.Size(104, 24)
        Me.rbval.TabIndex = 0
        Me.rbval.Text = "Valorizado"
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(36, 34)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No Valorizado"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CboAlmacen)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(184, 52)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Almacen"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnpassizt
        '
        Me.btnpassizt.Location = New System.Drawing.Point(210, 531)
        Me.btnpassizt.Name = "btnpassizt"
        Me.btnpassizt.Size = New System.Drawing.Size(65, 23)
        Me.btnpassizt.TabIndex = 52
        Me.btnpassizt.Text = "<<"
        Me.btnpassizt.UseVisualStyleBackColor = True
        '
        'btnpassiz
        '
        Me.btnpassiz.Location = New System.Drawing.Point(210, 496)
        Me.btnpassiz.Name = "btnpassiz"
        Me.btnpassiz.Size = New System.Drawing.Size(65, 23)
        Me.btnpassiz.TabIndex = 54
        Me.btnpassiz.Text = "<"
        Me.btnpassiz.UseVisualStyleBackColor = True
        '
        'btnpasde
        '
        Me.btnpasde.Location = New System.Drawing.Point(210, 461)
        Me.btnpasde.Name = "btnpasde"
        Me.btnpasde.Size = New System.Drawing.Size(65, 23)
        Me.btnpasde.TabIndex = 55
        Me.btnpasde.Text = ">"
        Me.btnpasde.UseVisualStyleBackColor = True
        '
        'btnpasdet
        '
        Me.btnpasdet.Location = New System.Drawing.Point(210, 426)
        Me.btnpasdet.Name = "btnpasdet"
        Me.btnpasdet.Size = New System.Drawing.Size(65, 23)
        Me.btnpasdet.TabIndex = 53
        Me.btnpasdet.Text = ">>"
        Me.btnpasdet.UseVisualStyleBackColor = True
        '
        'lbvende2
        '
        Me.lbvende2.FormattingEnabled = True
        Me.lbvende2.Location = New System.Drawing.Point(321, 415)
        Me.lbvende2.Name = "lbvende2"
        Me.lbvende2.Size = New System.Drawing.Size(155, 121)
        Me.lbvende2.TabIndex = 50
        '
        'lbvende1
        '
        Me.lbvende1.FormattingEnabled = True
        Me.lbvende1.Location = New System.Drawing.Point(20, 415)
        Me.lbvende1.Name = "lbvende1"
        Me.lbvende1.Size = New System.Drawing.Size(155, 134)
        Me.lbvende1.TabIndex = 51
        '
        'FrmKardexGeneral3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(967, 714)
        Me.Controls.Add(Me.btnpassizt)
        Me.Controls.Add(Me.btnpassiz)
        Me.Controls.Add(Me.btnpasde)
        Me.Controls.Add(Me.btnpasdet)
        Me.Controls.Add(Me.lbvende2)
        Me.Controls.Add(Me.lbvende1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Rpt1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmKardexGeneral3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Kardex  General"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region




#Region "Fields Form"
    Private Tb_Categ1 As New DataTable
    Private Tb_Categ2 As New DataTable
    Dim MstrFechaIni As String
    Dim MstrFechaFin As String
    Dim MstrFechaFinRec As String
    Dim CierreIgual As Boolean = False
    Dim CadenaCateg As String = ""
    Dim Todo_Cate As Int16


    Dim rand As Integer


#End Region
#Region "Function Form"

    Private Function VERIFICA_HISTORICOVENT(ByVal StrHistorico As String) As Boolean
        Try
            Dim StrSql As String
            Dim rs As New DataTable
            StrSql = " EXEC   VERIFICA_HISTORICOVENT    '" & StrHistorico & "','" & codempresa & "'"
            rs = TmpListarDatos(StrSql)

            If rs.Rows.Count = 0 Then
                VERIFICA_HISTORICOVENT = False
            Else
                VERIFICA_HISTORICOVENT = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " VERIFICA_HISTORICOVENT")
        End Try

    End Function

    Private Sub PasaUno(ByVal CtrlOrigen As DataTable, ByVal CtrlDestino As DataTable, ByVal CodCateg As String)
        For i As Integer = 0 To CtrlOrigen.Rows.Count - 1
            If CodCateg = CtrlOrigen.Rows(i)("CODLINEA") Then
                Dim FILA As DataRow = CtrlDestino.NewRow
                FILA("CODLINEA") = CtrlOrigen.Rows(i)("CODLINEA")
                FILA("DESLINEA") = CtrlOrigen.Rows(i)("DESLINEA")
                CtrlDestino.Rows.Add(FILA)
                CtrlOrigen.Rows.RemoveAt(i)
                LstCat2.Refresh()
                LstCat1.Refresh()
                Exit For
            End If
        Next

    End Sub

    Private Sub PasaTodo(ByVal CtrlOrigen As DataTable, ByVal CtrlDestino As DataTable)
        For i As Integer = 0 To CtrlOrigen.Rows.Count - 1
            Dim FILA As DataRow = CtrlDestino.NewRow
            FILA("CODLINEA") = CtrlOrigen.Rows(i)("CODLINEA")
            FILA("DESLINEA") = CtrlOrigen.Rows(i)("DESLINEA")
            CtrlDestino.Rows.Add(FILA)
        Next
        CtrlOrigen.Rows.Clear()
        LstCat2.Refresh()
        LstCat1.Refresh()
    End Sub


#End Region


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub FrmKardexGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CAyuda.CargarDataCombo(CboAlmacen, "SELECT  CODALMACEN,DESALMACEN FROM ALMACEN  WHERE  CODEMPRESA='" & codempresa & "'", "CODALMACEN", "DESALMACEN")

        Tb_Categ1 = TmpListarDatos("SELECT  CODLINEA,DESLINEA  FROM LINEA  WHERE   CODEMPRESA='" & codempresa & "'")
        LstCat1.DataSource = Tb_Categ1
        LstCat1.ValueMember = "CODLINEA"
        LstCat1.DisplayMember = "DESLINEA"

        Tb_Categ2.Columns.Add("CODLINEA")
        Tb_Categ2.Columns.Add("DESLINEA")
        LstCat2.DataSource = Tb_Categ2
        LstCat2.ValueMember = "CODLINEA"
        LstCat2.DisplayMember = "DESLINEA"


        Dim dt As New DataTable

        dt = CAyuda.ListarDatos("SP_LISTAR_DOCUMENTOS", codempresa).Tables(0)
        ListaV = LLenar(dt)
        lbvende1.DataSource = ListaV



        Dim dt2 As New DataTable

        dt2 = CAyuda.ListarDatos("SELEC_CIERRE_MES", codempresa).Tables(0)
        Dim AÑO As String
        Dim MES As String
        AÑO = dt2.Rows(0)(0)
        MES = dt2.Rows(0)(1)


        Dim Fecharf As Date

        Dim Table_Correlativo2 As DataTable
        Table_Correlativo2 = CAyuda.ListarDatos("SP_EXTRADIA", AÑO, MES).Tables(0)
        DtFechaIni.Value = CDate(Table_Correlativo2.Rows(0)(0).ToString)


        Fecharf = DateAdd("d", +1, DtFechaIni.Value)

        DtFechaIni.Value = Fecharf


    End Sub

    Private Function LLenar(ByVal dt As DataTable) As List(Of ReporteVentaE)
        Dim lista As New List(Of ReporteVentaE)
        For Each dr As DataRow In dt.Rows
            Dim o As New ReporteVentaE
            o.CODIGO = dr.Item(0).ToString
            o.DESCRIPCION = dr.Item(1).ToString
            lista.Add(o)
        Next
        Return lista
    End Function


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub

    Private Sub BtnPasaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno.Click
        Try
            PasaUno(Tb_Categ1, Tb_Categ2, Trim(LstCat1.SelectedValue))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub BtnRegresaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresaUno.Click
        Try
            PasaUno(Tb_Categ2, Tb_Categ1, Trim(LstCat2.SelectedValue))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnPasaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo.Click
        Try
            PasaTodo(Tb_Categ1, Tb_Categ2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnRegresaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresaTodo.Click
        Try
            PasaTodo(Tb_Categ2, Tb_Categ1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Validar() As Boolean
        MstrFechaFinRec = Format(DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value), "dd/MM/yyyy")
        If LstCat2.Items.Count = 0 Then
            MsgBox("Seleccionar Categorias.", MsgBoxStyle.Information, DesEmpresa)
            Return False
        End If

        If CDate(DtFechaIni.Value.ToShortDateString) > CDate(DtFechaFin.Value.ToShortDateString) Then
            MsgBox("Fechas fuera de Rango.", MsgBoxStyle.Information, DesEmpresa)
            Return False
        End If
        Return True
    End Function

    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click

        ValorRan()

        Dim SQL As String
        SQL = "DELETE_TMP_TIPO_DOC " & rand
        If TmpInsertDatos(SQL) = True Then
        End If

        For k As Integer = 0 To ListaV2.Count - 1
            ListaV.Add(ListaV2.Item(k))

            SQL = "INSERT_TMP_TIPO_DOC '" & ListaV2.Item(k).CODIGO.ToString & "','" & rand & "'"
            If TmpInsertDatos(SQL) = True Then
            End If
        Next

        'GenerarReporte()
        If Validar() = False Then Exit Sub
        Generar_NewReporte()
        With Rpt1
            If rbval.Checked = True Then
                .ReportFileName = RutaRptInv & "RptKardexGeneralVal.rpt"
            Else
                .ReportFileName = RutaRptInv & "RptKardexGeneral.rpt"
            End If
            .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
            .set_Formulas(1, "Usuario='" & DesUsuario & "'")
            .set_Formulas(2, "FecIni='" & Format(CDate(DtFechaIni.Value), "dd/MM/yyyy") & "'")
            .set_Formulas(3, "FecFin='" & Format(CDate(DtFechaFin.Value), "dd/MM/yyyy") & "'")
            .set_StoredProcParam(0, rand)
            .WindowState = Crystal.WindowStateConstants.crptMaximized
            .Destination = Crystal.DestinationConstants.crptToWindow
            .Action = 1
            .Reset()

        End With



    End Sub
    Sub Generar_NewReporte()
        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String
        Dim fecini As Date

        Dim Fechari As Date, Fecharf As Date

        If LstCat1.Items.Count = 0 Then
            Todo_Cate = 1
        Else
            Todo_Cate = 0
        End If
        CadenaCateg = ""
        For a As Integer = 0 To Tb_Categ2.Rows.Count - 1
            If CadenaCateg = "" Then
                CadenaCateg = Trim(Tb_Categ2.Rows(a)("CODLINEA"))
            Else
                CadenaCateg = CadenaCateg & "," & Trim(Tb_Categ2.Rows(a)("CODLINEA"))
            End If
        Next


        CierreIgual = False
        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)
        dt = SelectFechCiere(Fech, True, CboAlmacen.SelectedValue.ToString)
        If dt.Rows.Count > 0 Then
            FECHCIERRE = Date.Parse(dt.Rows(0)("FECHA"))
            If CDate(FECHCIERRE) > CDate(DtFechaIni.Value.ToShortDateString) Then
                CierreIgual = True
                MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy")
                MstrFechaFin = Format(DtFechaFin.Value, "dd/MM/yyyy")
                Procesar_Saldo(FECHCIERRE)
            Else
                dt = SelectFechCiere(Fech, False, CboAlmacen.SelectedValue.ToString)
                FECHCIERRE = Date.Parse(dt.Rows(0)("FECHA"))
                Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
                Fecharf = DateAdd("d", -1, DtFechaIni.Value)

                MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
                MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
                Procesar_Saldo(FECHCIERRE)
            End If
            'CierreIgual = True

        Else 'OBTENIENDO LA FECHA DE CIERRE MAS CERCANO
            dt = SelectFechCiere(Fech, False, CboAlmacen.SelectedValue.ToString)
            FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
            Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
            Fecharf = DateAdd("d", -1, DtFechaIni.Value)

            MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
            MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
            fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

            Procesar_Saldo(FECHCIERRE)
        End If

        ' CALCULAR PRESENTACION

        Dim Equival, Saldo1, SaldoArt As Double
        Dim CodArti, DsPresent, Cadena As String
        Dim CodPres As String = ""

        Dim Tmp_Datos As New DataTable

        Tmp_Datos = TmpListarDatos("SELECT  CDARTI, ISNULL(((SALDOFIN + CANTINGRC + CANTINGRO ) - (CANTSALIV + CANTSALIO)),0) AS SALDOART   FROM KARDEX_TMP WHERE CORREL= " & rand)
        For a As Integer = 0 To Tmp_Datos.Rows.Count - 1
            Cadena = ""
            Equival = 0
            CodArti = Trim(Tmp_Datos.Rows(a)("CDARTI"))
            SaldoArt = FormatoMonto(CDbl(Tmp_Datos.Rows(a)("SALDOART")), DECIRESU)
            Dim Cont As Integer = 0, Cont2 As Integer = 0
Recal:
            Dim Tmp_Artipres As New DataTable
            If Equival = 0 Then
                Tmp_Artipres = TmpListarDatos("SELECT  CODPRES,EQUIVALENCIA FROM ARTIPRESENT WHERE  CODEMPRESA='" & codempresa & "' AND CODARTI='" & CodArti & "'  ORDER BY  EQUIVALENCIA DESC")
                If Tmp_Artipres.Rows.Count <> 0 Then
                    Equival = FormatoMonto(CDbl(Tmp_Artipres.Rows(0)("EQUIVALENCIA")), DECIRESU)
                    CodPres = Trim(Tmp_Artipres.Rows(0)("CODPRES"))
                Else

                    MsgBox(String.Format("El articulo : {0} no tiene una presentación, verificar.", CodArti), MsgBoxStyle.Information, "NARSISTEMAS")
                    Exit Sub
                End If

            Else
RegEquiv:
                Tmp_Artipres = TmpListarDatos("SELECT  CODPRES,EQUIVALENCIA FROM ARTIPRESENT WHERE  CODEMPRESA='" & codempresa & "' AND CODARTI='" & CodArti & "' AND  EQUIVALENCIA<" & Equival & "  ORDER BY  EQUIVALENCIA DESC")
                If Tmp_Artipres.Rows.Count <> 0 Then
                    Equival = FormatoMonto(CDbl(Tmp_Artipres.Rows(0)("EQUIVALENCIA")), DECIRESU)
                    CodPres = Trim(Tmp_Artipres.Rows(0)("CODPRES"))
                    If SaldoArt < Equival Then
                        If Cont2 < 10 Then
                            Cont2 += 1
                            GoTo RegEquiv
                        End If
                    End If
                End If

            End If
            DsPresent = TmpListarDatos("SELECT  DESPRES  FROM  PRESENTACION  WHERE  CODEMPRESA='" & codempresa & "'  AND CODPRES='" & CodPres & "'").Rows(0)("DESPRES")
            Saldo1 = TmpListarDatos("SELECT  " & SaldoArt & "/" & Equival & "").Rows(0)(0)
            SaldoArt = SaldoArt - (Saldo1 * Equival)

            If Cadena = "" Then
                Cadena = CStr(Saldo1) + " " + DsPresent
            Else
                Cadena = Cadena + " + " + CStr(Saldo1) + " " + DsPresent
            End If
            If SaldoArt > 0 Then
                If Cont < 10 Then
                    Cont += 1
                    GoTo Recal
                End If
            End If
            TmpInsertDatos("UPDATE  KARDEX_TMP  SET  PRESENTACION='" & Cadena & "'  WHERE  CDARTI='" & CodArti & "' AND CORREL=" & rand)
        Next


    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function



    Sub Procesar_Saldo(ByVal fechaCierre As String)



        Dim meses As Integer
        Dim Fecinicial, Fecfinal As String
        Dim MesAct, Anio As String
        Dim VentaC, VentD, MoviD, MoviC As String

        TmpInsertDatos("Delete from TMp_kardex WHERE CORREL =" & rand)


        If CierreIgual = True Then
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")
            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CboAlmacen.SelectedValue.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")

            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CboAlmacen.SelectedValue.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")
                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CboAlmacen.SelectedValue.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next

        Else

            'meses = Val(DateDiff("m", CDate(MstrFechaIni), CDate(MstrFechaFin)))
            ' ''SELECCIONO INVENTARIO INICIAL - INGRESOS -  SALIDAS
            'Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            'Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            '' TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSALJ '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CboAlmacen.SelectedValue.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','MOVIDET',0,'" & rand & "'")

            ' ''SELECCIONO LAS VENTAS
            'For i As Integer = 0 To meses
            '    MesAct = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "MM")
            '    Anio = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "yyyy")
            '    VentaC = "VENTC" & Anio & MesAct
            '    VentD = "VENTD" & Anio & MesAct
            '    MoviD = "MOVID" & Anio & MesAct
            '    MoviC = "MOVIC" & Anio & MesAct


            '    If VERIFICA_HISTORICOVENT(VentaC) = True Then
            '        If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & MoviC & "','" & codempresa & "'").Rows.Count <> 0 Then
            '            TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CboAlmacen.SelectedValue.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & MoviD & "',1,'" & rand & "'")
            '        End If
            '        TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_VENTAS '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CboAlmacen.SelectedValue.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & VentD & "','" & VentaC & "','" & rand & "'")

            '    End If
            'Next


            ''SELECCIONO LOS INGRESOS Y SALIDAS DEL RANGO DEL KARDEX
            MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy")
            MstrFechaFin = Format(DtFechaFin.Value, "dd/MM/yyyy")

            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")


            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CboAlmacen.SelectedValue.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")
            '' SELECCIONO LAS VENTAS
            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            ''Registros del Histórico
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentD = "VENTD" & Anio & MesAct
                VentaC = "VENTC" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CboAlmacen.SelectedValue.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")
                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CboAlmacen.SelectedValue.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next
        End If

        'TmpInsertDatos("UPDATE TMp_kardex SET SALDOFIN=0,COMPRASF=0,INGAJUSTEF=0,INGTRANSFF=0,INGOTROSF=0,VENTASF=0,SALAJUSTEF=0,SALTRANSFF=0,SALOTROSF=0,SALDOFINF=0 WHERE SALDOFIN IS NULL AND CODEMPRESA='" & codempresa & "'")

        If CierreIgual = True Then
            INSERTCIERREALDIA(MstrFechaFinRec)
            MstrFechaIni = Format(Me.DtFechaIni.Value, "dd/MM/yyyy")
        Else
            'INSERTO SALDO INICIAL
            INSERTCIERREALDIA(fechaCierre)
        End If


        TmpInsertDatos("DELETE FROM TMP_SUMKARDEX2 WHERE CORREL = '" & rand & "'")
        TmpInsertDatos("INSERT INTO TMP_SUMKARDEX2 (CORREL,CDALMA,CDG01,CDARTI,STOCKINI,STOCKREC,COMPRAS,INGAJUSTE,INGTRANSF, INGOTROS,VENTAS,SALAJUSTE,SALTRANSF,SALOTROS,SALDOFIN, COMPRASF,INGAJUSTEF,INGTRANSFF, INGOTROSF,VENTASF,SALAJUSTEF,SALTRANSFF,SALOTROSF,SALDOFINF)" & "select  " & rand & ",cdalma,cdg01,cdarti,sum(stockini) as stockini,0 as stockrec,sum(compras)as compras, sum(INGAJUSTE) as IngAjuste,sum(INGTRANSF) as INGTransf,sum(INGOTROS) as INGotros, sum(VENTAS) as Ventas,sum(SALAJUSTE)as Salajuste,sum(SALTRANSF) as Saltransf, sum(sALOTROS) as Salotros,0 AS SALDOFIN, sum(comprasf)as comprasF,  sum(INGAJUSTEf) as IngAjusteF,sum(INGTRANSFF) as INGTransfF,sum(INGOTROSF) as INGotrosF, sum(VENTASF) as VentasF,sum(SALAJUSTEF)as SalajusteF,sum(SALTRANSFF) as SaltransfF, sum(SalotrosF) As SalotrosF ,0 AS SALDOFINF from TMp_kardex WHERE CORREL= " & rand & "  group by cdalma,cdarti,CDG01")
        TmpInsertDatos("DELETE FROM KARDEX_TMP WHERE CORREL='" & rand & "'")
        'TmpInsertDatos("INSERT INTO KARDEX_TMP (CDALMA,DSALMA,CDARTI,DSARTI,CDG01,DSG01,SALDOFIN,CANTINGRC,CANTINGRO,CANTSALIV,CANTSALIO,COSTO)  SELECT T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA , SUM(T.STOCKINI- T.VENTASF- T.SALAJUSTEF - T.SALTRANSFF - T.SALOTROSF + T.COMPRASF + T.INGAJUSTEF + T.INGTRANSFF + T.INGOTROSF) AS SALDOINIF, SUM(T.COMPRAS) AS COMPRAS,SUM(T.INGAJUSTE + T.INGTRANSF + T.INGOTROS) AS INGOTROS,SUM(T.VENTAS) AS VENTAS, SUM(T.SALAJUSTE + T.SALTRANSF + T.SALOTROS) As SALOTROS,AR.COSTOBAS FROM TMP_SUMKARDEX2 T   INNER  JOIN LINEA G ON T.CDG01 = G.CODLINEA  AND G.CODEMPRESA='" & codempresa & "' INNER JOIN  ARTICULO AR  ON T.CDARTI=AR.CODARTI  AND AR.CODEMPRESA='" & codempresa & "' INNER JOIN  ALMACEN A  ON  T.CDALMA = A.CODALMACEN  AND A.CODEMPRESA='" & codempresa & "' GROUP BY T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA,AR.COSTOBAS")
        TmpInsertDatos("SP_INS_KARDEX_TMPJ '" & codempresa & "','" & rand & "'")




    End Sub


    Private Sub INSERTCIERREALDIA(ByVal FechaCierre As Date)
        If Todo_Cate = 1 Then
            TmpInsertDatos("INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS )  SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,RESUKDX.CODARTI,SALDO AS STKINICIO,0,0,0,0,0,0,0,0,0  FROM RESUKDX,ARTICULO WHERE RESUKDX.CODARTI=ARTICULO.CODARTI AND ARTICULO.FORMU = 0 AND RESUKDX.ALMACEN ='" & Trim(CboAlmacen.SelectedValue) & "'  AND FECHA='" & FechaCierre & "'")
        Else
            TmpInsertDatos(" INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS ) " & _
                             " SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,RESUKDX.CODARTI,SALDO AS STKINICIO,0,0,0,0,0,0,0,0,0 " & _
                             " FROM RESUKDX,ARTICULO WHERE  ARTICULO.FORMU = 0  AND  RESUKDX.CODARTI=ARTICULO.CODARTI AND ARTICULO.CODLINEA IN(" & CadenaCateg & ")  AND RESUKDX.ALMACEN ='" & Trim(CboAlmacen.SelectedValue) & "'  AND FECHA='" & Format(FechaCierre, "dd/MM/yyyy") & "'")
        End If
    End Sub
    Private Function SelectFechCiere(ByVal fecha As Date, ByVal HizoCierre As Boolean, ByVal StrAlmacen As String) As DataTable
        Dim dt As New DataTable
        If HizoCierre = True Then
            dt = TmpListarDatos("select * from resukdx where fecha='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
        Else
            dt = TmpListarDatos("SELECT max (fechA) AS FECHA from resukdx where fechA <= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
        End If

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("Fecha") Is DBNull.Value Then
                dt = TmpListarDatos("SELECT mIN (fechA) AS FECHa from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
            End If
        Else
            dt = TmpListarDatos("SELECT distinct FECHA=max(fecha) from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'   AND ALMACEN ='" & StrAlmacen & "'  group by CODARTI")
        End If

        Return dt
    End Function



    Private Sub LstCat1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LstCat1.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnPasaUno_Click(sender, e)
        End If
    End Sub


    Private Sub LstCat2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LstCat2.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegresaUno_Click(sender, e)
        End If
    End Sub


    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)
    Dim i As Integer

    Private Sub btnpasdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasdet.Click
        For k As Integer = 0 To ListaV.Count - 1
            ListaV2.Add(ListaV.Item(k))
        Next
        ListaV.Clear()
        Actualizar(1)

    End Sub

    Private Sub btnpasde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasde.Click

        i = Me.lbvende1.SelectedIndex
        If i < 0 Then Exit Sub
        ListaV2.Add(ListaV.Item(i))
        ListaV.RemoveAt(i)
        Actualizar(1)

    End Sub


    Private Sub Actualizar(ByVal a As Int16)
        Select Case a
            Case 0
                'Me.lbfuerza1.DataSource = Nothing
                'Me.lbfuerza2.DataSource = Nothing
                'Me.lbfuerza1.DataSource = ListaF
                'Me.lbfuerza2.DataSource = ListaF2
            Case 1
                Me.lbvende1.DataSource = Nothing
                Me.lbvende2.DataSource = Nothing
                Me.lbvende1.DataSource = ListaV
                Me.lbvende2.DataSource = ListaV2
            Case 2

        End Select
    End Sub


    Private Sub btnpassiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpassiz.Click

        i = Me.lbvende2.SelectedIndex
        If i < 0 Then Exit Sub
        ListaV.Add(ListaV2.Item(i))
        ListaV2.RemoveAt(i)
        Actualizar(1)

    End Sub

    Private Sub btnpassizt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpassizt.Click

        For k As Integer = 0 To ListaV2.Count - 1
            ListaV.Add(ListaV2.Item(k))
        Next
        ListaV2.Clear()
        Actualizar(1)

    End Sub
End Class
