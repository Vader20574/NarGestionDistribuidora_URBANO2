Public Class FrmAcceso
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents LstSelec As System.Windows.Forms.ListBox
    Friend WithEvents LstDisp As System.Windows.Forms.ListBox
    Friend WithEvents BtnModulo As System.Windows.Forms.Button
    Friend WithEvents BtnProcesos As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents TxtCdNivel As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesNivel As System.Windows.Forms.TextBox
    Friend WithEvents BtnQuitaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno As System.Windows.Forms.Button
    Friend WithEvents LblTitSelec As System.Windows.Forms.Label
    Friend WithEvents LblTitDisp As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcceso))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCdNivel = New System.Windows.Forms.TextBox
        Me.TxtDesNivel = New System.Windows.Forms.TextBox
        Me.BtnModulo = New System.Windows.Forms.Button
        Me.BtnProcesos = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnQuitaTodo = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnQuitaUno = New System.Windows.Forms.Button
        Me.BtnPasaTodo = New System.Windows.Forms.Button
        Me.BtnPasaUno = New System.Windows.Forms.Button
        Me.LblTitSelec = New System.Windows.Forms.Label
        Me.LblTitDisp = New System.Windows.Forms.Label
        Me.LstSelec = New System.Windows.Forms.ListBox
        Me.LstDisp = New System.Windows.Forms.ListBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nivel: "
        '
        'TxtCdNivel
        '
        Me.TxtCdNivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCdNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCdNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCdNivel.Location = New System.Drawing.Point(88, 12)
        Me.TxtCdNivel.Name = "TxtCdNivel"
        Me.TxtCdNivel.Size = New System.Drawing.Size(120, 26)
        Me.TxtCdNivel.TabIndex = 2
        '
        'TxtDesNivel
        '
        Me.TxtDesNivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesNivel.Location = New System.Drawing.Point(232, 12)
        Me.TxtDesNivel.Name = "TxtDesNivel"
        Me.TxtDesNivel.Size = New System.Drawing.Size(378, 26)
        Me.TxtDesNivel.TabIndex = 4
        '
        'BtnModulo
        '
        Me.BtnModulo.Location = New System.Drawing.Point(12, 56)
        Me.BtnModulo.Name = "BtnModulo"
        Me.BtnModulo.Size = New System.Drawing.Size(338, 23)
        Me.BtnModulo.TabIndex = 6
        Me.BtnModulo.Text = "Modulos"
        '
        'BtnProcesos
        '
        Me.BtnProcesos.Location = New System.Drawing.Point(352, 56)
        Me.BtnProcesos.Name = "BtnProcesos"
        Me.BtnProcesos.Size = New System.Drawing.Size(354, 23)
        Me.BtnProcesos.TabIndex = 7
        Me.BtnProcesos.Text = "Procesos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnQuitaTodo)
        Me.GroupBox1.Controls.Add(Me.BtnQuitaUno)
        Me.GroupBox1.Controls.Add(Me.BtnPasaTodo)
        Me.GroupBox1.Controls.Add(Me.BtnPasaUno)
        Me.GroupBox1.Controls.Add(Me.LblTitSelec)
        Me.GroupBox1.Controls.Add(Me.LblTitDisp)
        Me.GroupBox1.Controls.Add(Me.LstSelec)
        Me.GroupBox1.Controls.Add(Me.LstDisp)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 264)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'BtnQuitaTodo
        '
        Me.BtnQuitaTodo.ImageIndex = 10
        Me.BtnQuitaTodo.ImageList = Me.ImageList1
        Me.BtnQuitaTodo.Location = New System.Drawing.Point(320, 190)
        Me.BtnQuitaTodo.Name = "BtnQuitaTodo"
        Me.BtnQuitaTodo.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo.TabIndex = 7
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
        'BtnQuitaUno
        '
        Me.BtnQuitaUno.ImageIndex = 8
        Me.BtnQuitaUno.ImageList = Me.ImageList1
        Me.BtnQuitaUno.Location = New System.Drawing.Point(320, 150)
        Me.BtnQuitaUno.Name = "BtnQuitaUno"
        Me.BtnQuitaUno.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno.TabIndex = 6
        '
        'BtnPasaTodo
        '
        Me.BtnPasaTodo.ImageIndex = 9
        Me.BtnPasaTodo.ImageList = Me.ImageList1
        Me.BtnPasaTodo.Location = New System.Drawing.Point(320, 110)
        Me.BtnPasaTodo.Name = "BtnPasaTodo"
        Me.BtnPasaTodo.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo.TabIndex = 5
        '
        'BtnPasaUno
        '
        Me.BtnPasaUno.ImageIndex = 7
        Me.BtnPasaUno.ImageList = Me.ImageList1
        Me.BtnPasaUno.Location = New System.Drawing.Point(320, 70)
        Me.BtnPasaUno.Name = "BtnPasaUno"
        Me.BtnPasaUno.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno.TabIndex = 4
        '
        'LblTitSelec
        '
        Me.LblTitSelec.AutoSize = True
        Me.LblTitSelec.Location = New System.Drawing.Point(390, 16)
        Me.LblTitSelec.Name = "LblTitSelec"
        Me.LblTitSelec.Size = New System.Drawing.Size(120, 13)
        Me.LblTitSelec.TabIndex = 3
        Me.LblTitSelec.Text = "Modulos Seleccionados"
        '
        'LblTitDisp
        '
        Me.LblTitDisp.AutoSize = True
        Me.LblTitDisp.Location = New System.Drawing.Point(16, 16)
        Me.LblTitDisp.Name = "LblTitDisp"
        Me.LblTitDisp.Size = New System.Drawing.Size(104, 13)
        Me.LblTitDisp.TabIndex = 2
        Me.LblTitDisp.Text = "Modulos Disponibles"
        '
        'LstSelec
        '
        Me.LstSelec.Location = New System.Drawing.Point(384, 40)
        Me.LstSelec.Name = "LstSelec"
        Me.LstSelec.Size = New System.Drawing.Size(310, 212)
        Me.LstSelec.TabIndex = 1
        '
        'LstDisp
        '
        Me.LstDisp.Location = New System.Drawing.Point(8, 40)
        Me.LstDisp.Name = "LstDisp"
        Me.LstDisp.Size = New System.Drawing.Size(302, 212)
        Me.LstDisp.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(380, 360)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(120, 30)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'btngrabar
        '
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngrabar.ImageIndex = 1
        Me.btngrabar.ImageList = Me.ImageList1
        Me.btngrabar.Location = New System.Drawing.Point(224, 360)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(112, 30)
        Me.btngrabar.TabIndex = 10
        Me.btngrabar.Text = "&Grabar"
        '
        'FrmAcceso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(730, 402)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnProcesos)
        Me.Controls.Add(Me.BtnModulo)
        Me.Controls.Add(Me.TxtDesNivel)
        Me.Controls.Add(Me.TxtCdNivel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAcceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Acceso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Variables"
    Private Tb_ModDisponible As New DataTable
    Private Tb_ModSelec As New DataTable
    Private Tb_ProcSelec As New DataTable
    Private Tb_ProcDisponible As New DataTable
    Public CDNIVEL As String = ""
    Private ACCESOMOD As Boolean


#End Region
#Region "Funciones del Formulario"

    Private Sub PasarUno()
        If ACCESOMOD = True Then
            Dim FILA As DataRow = Tb_ModSelec.NewRow
            FILA("CDMODULO") = LstDisp.SelectedValue.ToString.Trim
            FILA("DSMODULO") = LstDisp.Text.Trim
            Tb_ModSelec.Rows.Add(FILA)
            For F As Integer = 0 To Tb_ModDisponible.Rows.Count - 1
                If LstDisp.SelectedValue.ToString.Trim = Tb_ModDisponible.Rows(F)("CDMODULO").ToString.Trim Then
                    Tb_ModDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        Else
            Dim FILA As DataRow = Tb_ProcSelec.NewRow
            FILA("CDPROCESO") = LstDisp.SelectedValue.ToString.Trim
            FILA("DSPROCESO") = LstDisp.Text.Trim
            Tb_ProcSelec.Rows.Add(FILA)
            For F As Integer = 0 To Tb_ProcDisponible.Rows.Count - 1
                If LstDisp.SelectedValue.ToString.Trim = Tb_ProcDisponible.Rows(F)("CDPROCESO").ToString.Trim Then
                    Tb_ProcDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub PasarTodo()
        If ACCESOMOD = True Then

            For F As Integer = 0 To Tb_ModDisponible.Rows.Count - 1
                Dim FILA As DataRow = Tb_ModSelec.NewRow
                FILA("CDMODULO") = Tb_ModDisponible.Rows(F)("CDMODULO").tostring.Trim
                FILA("DSMODULO") = Tb_ModDisponible.Rows(F)("DSMODULO").tostring.Trim
                Tb_ModSelec.Rows.Add(FILA)
            Next
            Tb_ModDisponible.Rows.Clear()

        Else
            For F As Integer = 0 To Tb_ProcDisponible.Rows.Count - 1
                Dim FILA As DataRow = Tb_ProcSelec.NewRow
                FILA("CDPROCESO") = Tb_ProcDisponible.Rows(F)("CDPROCESO").tostring.Trim
                FILA("DSPROCESO") = Tb_ProcDisponible.Rows(F)("DSPROCESO").tostring.Trim
                Tb_ProcSelec.Rows.Add(FILA)
            Next
            Tb_ProcDisponible.Rows.Clear()
        End If
    End Sub
    Private Sub QuitarUno()
        If ACCESOMOD = True Then
            Dim FILA As DataRow = Tb_ModDisponible.NewRow
            FILA("CDMODULO") = LstSelec.SelectedValue.ToString.Trim
            FILA("DSMODULO") = LstSelec.Text.Trim
            Tb_ModDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_ModSelec.Rows.Count - 1
                If LstSelec.SelectedValue.ToString.Trim = Tb_ModSelec.Rows(F)("CDMODULO").ToString.Trim Then
                    Tb_ModSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        Else
            Dim FILA As DataRow = Tb_ProcDisponible.NewRow
            FILA("CDPROCESO") = LstSelec.SelectedValue.ToString.Trim
            FILA("DSPROCESO") = LstSelec.SelectedItem.ToString.Trim
            Tb_ProcDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_ProcSelec.Rows.Count - 1
                If LstSelec.SelectedValue.ToString.Trim = Tb_ProcSelec.Rows(F)("CDPROCESO").ToString.Trim Then
                    Tb_ProcSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub QuitarTodo()
        If ACCESOMOD = True Then
            For F As Integer = 0 To Tb_ModSelec.Rows.Count - 1
                Dim FILA As DataRow = Tb_ModDisponible.NewRow
                FILA("CDMODULO") = Tb_ModSelec.Rows(F)("CDMODULO").tostring.Trim
                FILA("DSMODULO") = Tb_ModSelec.Rows(F)("DSMODULO").tostring.Trim
                Tb_ModDisponible.Rows.Add(FILA)
            Next
            Tb_ModSelec.Rows.Clear()
        Else
            For F As Integer = 0 To Tb_ProcSelec.Rows.Count - 1
                Dim FILA As DataRow = Tb_ProcDisponible.NewRow
                FILA("CDPROCESO") = Tb_ProcSelec.Rows(F)("CDPROCESO").tostring.Trim
                FILA("DSPROCESO") = Tb_ProcSelec.Rows(F)("CDPROCESO").tostring.Trim
                Tb_ProcDisponible.Rows.Add(FILA)
            Next
            Tb_ProcSelec.Rows.Clear()
        End If
    End Sub



    Private Sub CargarTablas()
        Tb_ModDisponible = TmpListarDatos("NSP_ACCESO_X_NIVEL  '" & codempresa & "','" & CDNIVEL & "','0'")
        Tb_ModSelec = TmpListarDatos("NSP_ACCESO_X_NIVEL  '" & codempresa & "','" & CDNIVEL & "','1'")
        Tb_ProcDisponible = TmpListarDatos("NSP_ACCESOPROC_X_NIVEL  '" & codempresa & "','" & CDNIVEL & "','0'")
        Tb_ProcSelec = TmpListarDatos("NSP_ACCESOPROC_X_NIVEL  '" & codempresa & "','" & CDNIVEL & "','1'")
        If Tb_ModDisponible.Rows.Count = 0 And Tb_ModSelec.Rows.Count = 0 Then
            Tb_ModDisponible = TmpListarDatos("NSP_ACCESO  '" & codempresa & "'")
        End If
        If Tb_ProcDisponible.Rows.Count = 0 And Tb_ProcSelec.Rows.Count = 0 Then
            Tb_ProcDisponible = TmpListarDatos("NSP_ACCESOPROC  '" & codempresa & "'")
        End If
    End Sub
    Private Sub CargarModulo()
        LstDisp.DataSource = Tb_ModDisponible
        LstDisp.ValueMember = "CDMODULO"
        LstDisp.DisplayMember = "DSMODULO"

        LstSelec.DataSource = Tb_ModSelec
        LstSelec.ValueMember = "CDMODULO"
        LstSelec.DisplayMember = "DSMODULO"
    End Sub
    Private Sub CargarProceso()
        LstDisp.DataSource = Tb_ProcDisponible
        LstDisp.ValueMember = "CDPROCESO"
        LstDisp.DisplayMember = "DSPROCESO"

        LstSelec.DataSource = Tb_ProcSelec
        LstSelec.ValueMember = "CDPROCESO"
        LstSelec.DisplayMember = "DSPROCESO"
    End Sub

#End Region
    Private Sub FrmAcceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarTablas()
        BtnModulo_Click(sender, e)
    End Sub
    Private Sub BtnModulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModulo.Click
        LblTitDisp.Text = "Modulos Disponibles"
        LblTitSelec.Text = "Modulos Seleccionados"
        CargarModulo()
        ACCESOMOD = True
    End Sub

    Private Sub BtnProcesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesos.Click
        LblTitDisp.Text = "Procesos Disponibles"
        LblTitSelec.Text = "Procesos Seleccionados"
        CargarProceso()
        ACCESOMOD = False
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        For i As Integer = 0 To Tb_ModDisponible.Rows.Count - 1
            TmpInsertDatos("NSP_INS_ACCESO  '" & codempresa & "','" & CDNIVEL & "','" & Tb_ModDisponible.Rows(i)("CDMODULO").tostring.Trim & "','0'")
        Next
        For i As Integer = 0 To Tb_ModSelec.Rows.Count - 1
            TmpInsertDatos("NSP_INS_ACCESO  '" & codempresa & "','" & CDNIVEL & "','" & Tb_ModSelec.Rows(i)("CDMODULO").tostring.Trim & "','1'")
        Next
        For i As Integer = 0 To Tb_ProcDisponible.Rows.Count - 1
            TmpInsertDatos("NSP_INS_ACCESOPROC  '" & codempresa & "','" & CDNIVEL & "','" & Tb_ProcDisponible.Rows(i)("CDPROCESO").tostring.Trim & "','0'")
        Next
        For i As Integer = 0 To Tb_ProcSelec.Rows.Count - 1
            TmpInsertDatos("NSP_INS_ACCESOPROC  '" & codempresa & "','" & CDNIVEL & "','" & Tb_ProcSelec.Rows(i)("CDPROCESO").tostring.Trim & "','1'")
        Next
        MsgBox("SE GUARDO CORRECTAMENTE LOS REGISTRO...", MsgBoxStyle.Information, "NAR SISTEMAS SAC")
        Me.Close()
    End Sub

    Private Sub BtnPasaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno.Click
        PasarUno()

    End Sub

    Private Sub BtnQuitaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaUno.Click
        QuitarUno()

    End Sub

    Private Sub BtnPasaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo.Click
        PasarTodo()

    End Sub

    Private Sub BtnQuitaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaTodo.Click
        QuitarTodo()

    End Sub
End Class
