Public Class FrmRepArticulo
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
    Friend WithEvents GpbCabecrea As System.Windows.Forms.GroupBox
    Friend WithEvents CboLin As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LstLin As System.Windows.Forms.ListBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LstCod As System.Windows.Forms.ListBox
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAgregarTodo As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarTodo As System.Windows.Forms.Button
    Friend WithEvents OptPara As System.Windows.Forms.RadioButton
    Friend WithEvents OptTodo As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Acr As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepArticulo))
        Me.GpbCabecrea = New System.Windows.Forms.GroupBox
        Me.BtnQuitar = New System.Windows.Forms.Button
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.LstLin = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CboLin = New System.Windows.Forms.ComboBox
        Me.LstCod = New System.Windows.Forms.ListBox
        Me.Acr = New AxCrystal.AxCrystalReport
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnQuitarTodo = New System.Windows.Forms.Button
        Me.BtnAgregarTodo = New System.Windows.Forms.Button
        Me.OptPara = New System.Windows.Forms.RadioButton
        Me.OptTodo = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GpbCabecrea.SuspendLayout()
        CType(Me.Acr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpbCabecrea
        '
        Me.GpbCabecrea.Controls.Add(Me.BtnQuitar)
        Me.GpbCabecrea.Controls.Add(Me.BtnAgregar)
        Me.GpbCabecrea.Controls.Add(Me.LstLin)
        Me.GpbCabecrea.Controls.Add(Me.Label3)
        Me.GpbCabecrea.Controls.Add(Me.CboLin)
        Me.GpbCabecrea.Controls.Add(Me.LstCod)
        Me.GpbCabecrea.Location = New System.Drawing.Point(59, 12)
        Me.GpbCabecrea.Name = "GpbCabecrea"
        Me.GpbCabecrea.Size = New System.Drawing.Size(212, 234)
        Me.GpbCabecrea.TabIndex = 1
        Me.GpbCabecrea.TabStop = False
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Location = New System.Drawing.Point(104, 201)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(96, 24)
        Me.BtnQuitar.TabIndex = 5
        Me.BtnQuitar.Text = "Quitar >>"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(8, 201)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(96, 24)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "<< Agregar"
        '
        'LstLin
        '
        Me.LstLin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstLin.ItemHeight = 14
        Me.LstLin.Location = New System.Drawing.Point(8, 56)
        Me.LstLin.Name = "LstLin"
        Me.LstLin.Size = New System.Drawing.Size(192, 144)
        Me.LstLin.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Seleccione Linea"
        '
        'CboLin
        '
        Me.CboLin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLin.Location = New System.Drawing.Point(8, 32)
        Me.CboLin.Name = "CboLin"
        Me.CboLin.Size = New System.Drawing.Size(192, 22)
        Me.CboLin.TabIndex = 0
        '
        'LstCod
        '
        Me.LstCod.Location = New System.Drawing.Point(112, 56)
        Me.LstCod.Name = "LstCod"
        Me.LstCod.Size = New System.Drawing.Size(83, 108)
        Me.LstCod.TabIndex = 6
        Me.LstCod.Visible = False
        '
        'Acr
        '
        Me.Acr.Enabled = True
        Me.Acr.Location = New System.Drawing.Point(8, 200)
        Me.Acr.Name = "Acr"
        Me.Acr.OcxState = CType(resources.GetObject("Acr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Acr.Size = New System.Drawing.Size(28, 28)
        Me.Acr.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnAceptar)
        Me.GroupBox2.Location = New System.Drawing.Point(106, 318)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(72, 64)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAceptar.ImageIndex = 2
        Me.BtnAceptar.ImageList = Me.ImageList1
        Me.BtnAceptar.Location = New System.Drawing.Point(8, 11)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(56, 45)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnSalir)
        Me.GroupBox3.Location = New System.Drawing.Point(182, 318)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(72, 64)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 3
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(6, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(56, 44)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnQuitarTodo)
        Me.GroupBox4.Controls.Add(Me.BtnAgregarTodo)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 56)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'BtnQuitarTodo
        '
        Me.BtnQuitarTodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnQuitarTodo.ImageIndex = 5
        Me.BtnQuitarTodo.ImageList = Me.ImageList1
        Me.BtnQuitarTodo.Location = New System.Drawing.Point(150, 11)
        Me.BtnQuitarTodo.Name = "BtnQuitarTodo"
        Me.BtnQuitarTodo.Size = New System.Drawing.Size(138, 37)
        Me.BtnQuitarTodo.TabIndex = 1
        Me.BtnQuitarTodo.Text = "&Quitar Todo"
        Me.BtnQuitarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnAgregarTodo
        '
        Me.BtnAgregarTodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAgregarTodo.ImageIndex = 4
        Me.BtnAgregarTodo.ImageList = Me.ImageList1
        Me.BtnAgregarTodo.Location = New System.Drawing.Point(8, 11)
        Me.BtnAgregarTodo.Name = "BtnAgregarTodo"
        Me.BtnAgregarTodo.Size = New System.Drawing.Size(138, 37)
        Me.BtnAgregarTodo.TabIndex = 0
        Me.BtnAgregarTodo.Text = "&Agregar Todo"
        Me.BtnAgregarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'OptPara
        '
        Me.OptPara.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPara.Location = New System.Drawing.Point(40, 23)
        Me.OptPara.Name = "OptPara"
        Me.OptPara.Size = New System.Drawing.Size(104, 16)
        Me.OptPara.TabIndex = 1
        Me.OptPara.Text = "&Con Rangos"
        '
        'OptTodo
        '
        Me.OptTodo.Checked = True
        Me.OptTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTodo.Location = New System.Drawing.Point(160, 23)
        Me.OptTodo.Name = "OptTodo"
        Me.OptTodo.Size = New System.Drawing.Size(96, 16)
        Me.OptTodo.TabIndex = 0
        Me.OptTodo.TabStop = True
        Me.OptTodo.Text = "&Todo"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Imprimir Reporte"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.OptTodo)
        Me.GroupBox5.Controls.Add(Me.OptPara)
        Me.GroupBox5.Location = New System.Drawing.Point(368, 213)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(296, 48)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        '
        'FrmRepArticulo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(333, 462)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Acr)
        Me.Controls.Add(Me.GpbCabecrea)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRepArticulo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Articulo "
        Me.GpbCabecrea.ResumeLayout(False)
        Me.GpbCabecrea.PerformLayout()
        CType(Me.Acr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmRepArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(Me.CboLin, "NSP_Select_Listado_Linea '" & codempresa & "'", "Código", "Descripción")
    End Sub
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim i As Int16
        For i = 0 To Me.LstLin.Items.Count - 1
            If Me.LstLin.Items.Item(i) = Me.CboLin.Text Then
                MsgBox("La Linea " & Me.LstLin.Items.Item(i) & " ya Fue Agregada a la Lista" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                Exit Sub
            End If
        Next
        Me.LstLin.Items.Add(Me.CboLin.Text.Trim)
        Me.LstCod.Items.Add(Me.CboLin.SelectedValue)
    End Sub
    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        If Me.LstLin.SelectedIndex = -1 Then
            MsgBox("Seleccione una Linea Por Favor Para Eliminar" + Chr(13) + "Gracias ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
        Else
            Me.LstCod.Items.RemoveAt(Me.LstLin.SelectedIndex)
            Me.LstLin.Items.RemoveAt(Me.LstLin.SelectedIndex)
        End If
    End Sub
    Private Sub BtnAgregarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarTodo.Click
        Dim Tabla As New DataTable
        Dim i As Integer
        Tabla = CAyuda.ListarDatos("NSP_Select_Listado_Linea", "01").Tables(0)
        Me.LstLin.Items.Clear()
        Me.LstCod.Items.Clear()
        For i = 0 To Tabla.Rows.Count - 1
            Me.LstLin.Items.Add(Tabla.Rows(i)(1))
            Me.LstCod.Items.Add(Tabla.Rows(i)(0))
        Next
    End Sub
    Private Sub BtnQuitarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarTodo.Click
        Me.LstLin.Items.Clear()
        Me.LstCod.Items.Clear()
    End Sub
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim i As Long

        'Reporte sin Rango

        Me.OptTodo.Checked = False
        If Me.OptTodo.Checked = True Then
            Try
                Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                Acr.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
                Acr.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                Acr.set_StoredProcParam(0, codempresa)
                Acr.WindowShowExportBtn = True
                Acr.WindowShowPrintBtn = True
                Acr.WindowShowPrintSetupBtn = True
                Acr.ReportFileName = rutareporte + CType("Reporte_Articulo_Todo.rpt", String)
                Acr.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                Acr.WindowState = Crystal.WindowStateConstants.crptMaximized
                Acr.Action = 1
                Acr.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'Reporte con Rangos

            If Me.LstCod.Items.Count = 0 Then
                MsgBox("Llene La Lista con La Linea que Desea Reportar" + Chr(13) + "Gracias ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
                Me.CboLin.Focus()
                Exit Sub
            End If

            ''  Acr.set_Formulas(4, codempresa)


            Try
                For i = 0 To Me.LstLin.Items.Count - 1
                    TmpInsertDatos("USP_LLENA_REPORTE_ARTICULO_LOCAL '" & Me.LstLin.Items.Item(i) & "','" & CodUsuario & "','" & codempresa & "'")
                Next

                Acr.WindowShowExportBtn = True
                Acr.WindowShowPrintBtn = True
                Acr.WindowShowPrintSetupBtn = True
                Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                Acr.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
                Acr.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                Acr.set_StoredProcParam(0, CodUsuario)
                Acr.set_Formulas(2, "FechaIni='" & " " & "'")
                Acr.set_Formulas(3, "FechaF='" & " " & "'")


                Acr.ReportFileName = rutareporte + CType("Reporte_Articulo_Local.rpt", String)
                Acr.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

                Acr.WindowState = Crystal.WindowStateConstants.crptMaximized
                Acr.Action = 1
                Acr.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                TmpInsertDatos("USP_TMP_REPORTE_ARTICULO_LOCAL '" & CodUsuario & "'")
            End Try
        End If
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub DtpIni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    Me.DtpFin.Focus()
        'End If
    End Sub
End Class
