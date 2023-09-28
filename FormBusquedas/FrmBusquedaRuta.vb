Public Class FrmBusquedaRuta
    Inherits System.Windows.Forms.Form
    Dim m As FrmCargarPedido_a_Camion
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents CboCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgRuta As System.Windows.Forms.DataGrid
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SeleccionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LstDispRuta As System.Windows.Forms.ListBox
    Friend WithEvents LstSelecRuta As System.Windows.Forms.ListBox
    Friend WithEvents BtnQuitaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnaddall As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DgRuta = New System.Windows.Forms.DataGrid
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeleccionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDatos = New System.Windows.Forms.TextBox
        Me.CboCriterio = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnaddall = New System.Windows.Forms.Button
        Me.LstDispRuta = New System.Windows.Forms.ListBox
        Me.LstSelecRuta = New System.Windows.Forms.ListBox
        Me.BtnQuitaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnQuitaUno_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaUno_Ruta = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        CType(Me.DgRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DgRuta
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DgRuta
        '
        Me.DgRuta.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DgRuta.DataMember = ""
        Me.DgRuta.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgRuta.Location = New System.Drawing.Point(755, 158)
        Me.DgRuta.Name = "DgRuta"
        Me.DgRuta.ReadOnly = True
        Me.DgRuta.Size = New System.Drawing.Size(71, 119)
        Me.DgRuta.TabIndex = 4
        Me.DgRuta.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarToolStripMenuItem, Me.TodosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 48)
        '
        'SeleccionarToolStripMenuItem
        '
        Me.SeleccionarToolStripMenuItem.Name = "SeleccionarToolStripMenuItem"
        Me.SeleccionarToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SeleccionarToolStripMenuItem.Text = "Seleccionar"
        '
        'TodosToolStripMenuItem
        '
        Me.TodosToolStripMenuItem.Name = "TodosToolStripMenuItem"
        Me.TodosToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.TodosToolStripMenuItem.Text = "Todos"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "COD_RUTA"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "RUTA - CALLE"
        Me.DataGridTextBoxColumn2.MappingName = "DESCRIPCION"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 300
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(768, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dato :"
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(762, 52)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(74, 20)
        Me.txtDatos.TabIndex = 0
        '
        'CboCriterio
        '
        Me.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCriterio.Location = New System.Drawing.Point(755, 16)
        Me.CboCriterio.Name = "CboCriterio"
        Me.CboCriterio.Size = New System.Drawing.Size(62, 21)
        Me.CboCriterio.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(778, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Criterio : "
        '
        'btnaddall
        '
        Me.btnaddall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaddall.Location = New System.Drawing.Point(637, 314)
        Me.btnaddall.Name = "btnaddall"
        Me.btnaddall.Size = New System.Drawing.Size(86, 26)
        Me.btnaddall.TabIndex = 5
        Me.btnaddall.Text = "Cerrar"
        '
        'LstDispRuta
        '
        Me.LstDispRuta.Location = New System.Drawing.Point(7, 3)
        Me.LstDispRuta.Name = "LstDispRuta"
        Me.LstDispRuta.Size = New System.Drawing.Size(302, 160)
        Me.LstDispRuta.TabIndex = 17
        '
        'LstSelecRuta
        '
        Me.LstSelecRuta.Location = New System.Drawing.Point(398, 3)
        Me.LstSelecRuta.Name = "LstSelecRuta"
        Me.LstSelecRuta.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecRuta.TabIndex = 18
        '
        'BtnQuitaTodo_Ruta
        '
        Me.BtnQuitaTodo_Ruta.ImageIndex = 10
        Me.BtnQuitaTodo_Ruta.Location = New System.Drawing.Point(325, 124)
        Me.BtnQuitaTodo_Ruta.Name = "BtnQuitaTodo_Ruta"
        Me.BtnQuitaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo_Ruta.TabIndex = 25
        Me.BtnQuitaTodo_Ruta.Text = "<<"
        '
        'BtnQuitaUno_Ruta
        '
        Me.BtnQuitaUno_Ruta.ImageIndex = 8
        Me.BtnQuitaUno_Ruta.Location = New System.Drawing.Point(325, 84)
        Me.BtnQuitaUno_Ruta.Name = "BtnQuitaUno_Ruta"
        Me.BtnQuitaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno_Ruta.TabIndex = 24
        Me.BtnQuitaUno_Ruta.Text = "<"
        '
        'BtnPasaTodo_Ruta
        '
        Me.BtnPasaTodo_Ruta.ImageIndex = 9
        Me.BtnPasaTodo_Ruta.Location = New System.Drawing.Point(325, 44)
        Me.BtnPasaTodo_Ruta.Name = "BtnPasaTodo_Ruta"
        Me.BtnPasaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo_Ruta.TabIndex = 23
        Me.BtnPasaTodo_Ruta.Text = ">>"
        '
        'BtnPasaUno_Ruta
        '
        Me.BtnPasaUno_Ruta.ImageIndex = 7
        Me.BtnPasaUno_Ruta.Location = New System.Drawing.Point(325, 4)
        Me.BtnPasaUno_Ruta.Name = "BtnPasaUno_Ruta"
        Me.BtnPasaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno_Ruta.TabIndex = 22
        Me.BtnPasaUno_Ruta.Text = ">"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(577, 190)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(116, 35)
        Me.btnAceptar.TabIndex = 26
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FrmBusquedaRuta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(735, 264)
        Me.Controls.Add(Me.LstSelecRuta)
        Me.Controls.Add(Me.txtDatos)
        Me.Controls.Add(Me.BtnQuitaTodo_Ruta)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.BtnQuitaUno_Ruta)
        Me.Controls.Add(Me.BtnPasaTodo_Ruta)
        Me.Controls.Add(Me.BtnPasaUno_Ruta)
        Me.Controls.Add(Me.DgRuta)
        Me.Controls.Add(Me.LstDispRuta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnaddall)
        Me.Controls.Add(Me.CboCriterio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusquedaRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Ruta de Pedido"
        CType(Me.DgRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "FIELDS"
    Public TMP_RUTA As New DataTable
    Public DEVOLVER As Boolean
    Public FilaSeleccion As Integer
    Public FullItem As Boolean


    Private Tb_RutaDisponible As New DataTable
    Public Tb_RutaModSelec As New DataTable

    Dim form1 As FrmCargarPedido_a_Camion

#End Region
#Region "FUNCIONES"
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal keydata As Keys) As Boolean
        Const Wd_KeyDown As Integer = &H100
        Const Wd_SysKeyDown As Integer = &H104
        If ((MSG.Msg = Wd_KeyDown) Or (MSG.Msg = Wd_SysKeyDown)) Then
            Select Case (keydata)
                Case Keys.Enter
                    If DgRuta.Focus = True Then
                        DEVOLVER = True
                        Me.Close()
                    End If
                    DgRuta.Select(FilaSeleccion)
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function

    Sub CARGARGRID()
        'CAyuda.CargarDataCombo(cboRuta, "NSP_LISTAR_RUTA_CARGPED  '" & codempresa & "'", "CODIGO", "DESCRIPCION")
        'chktodos.Checked = True
        TMP_RUTA = CAyuda.ListarDatos("NSP_BUSQ_RUTA_PEDIDO", codempresa).Tables(0)
        DgRuta.DataSource = TMP_RUTA

        'DataGridTableStyle1.GridColumnStyles(0).MappingName = "COD_RUTA"
        'DataGridTableStyle1.GridColumnStyles(1).MappingName = "DESCRIPCION"
        'DgRuta.TableStyles.Add(DataGridTableStyle1)
    End Sub
#End Region

    Private Sub FrmBusquedaRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_RutaDisponible = TmpListarDatos("Nsp_Sele_Ruta_filtro '','','" & codempresa & "'")
        Tb_RutaModSelec = TmpListarDatos("Nsp_Sele_Ruta_filtro '','','" & 254 & "'")

        CargarModulo()

        CARGARGRID()
        CboCriterio.Items.Add("Codigo")
        CboCriterio.Items.Add("Ruta")
        CboCriterio.SelectedIndex = 0
    End Sub

    Private Sub CargarModulo()


        LstDispRuta.DataSource = Tb_RutaDisponible
        LstDispRuta.ValueMember = "Codigo"
        LstDispRuta.DisplayMember = "Descripcion"

        LstSelecRuta.DataSource = Tb_RutaModSelec
        LstSelecRuta.ValueMember = "Codigo"
        LstSelecRuta.DisplayMember = "Descripcion"



    End Sub




    Private Sub txtDatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatos.TextChanged
        For i As Integer = 0 To TMP_RUTA.Rows.Count - 1
            DgRuta.UnSelect(i)
        Next
        Select Case CboCriterio.SelectedIndex
            Case 0
                For i As Integer = 0 To TMP_RUTA.Rows.Count - 1
                    If Mid(TMP_RUTA.Rows(i)("COD_RUTA").ToString.Trim.ToUpper, 1, txtDatos.Text.Trim.Length) = txtDatos.Text.Trim.ToUpper Then
                        DgRuta.Select(i)
                        DgRuta.CurrentRowIndex = i
                        FilaSeleccion = i
                        Exit Sub
                    End If
                Next
            Case 1
                For i As Integer = 0 To TMP_RUTA.Rows.Count - 1
                    If Mid(TMP_RUTA.Rows(i)("DESCRIPCION").ToString.Trim.ToUpper, 1, txtDatos.Text.Trim.Length) = txtDatos.Text.Trim.ToUpper Then
                        DgRuta.Select(i)
                        DgRuta.CurrentRowIndex = i
                        FilaSeleccion = i
                        Exit Sub
                    End If
                Next
        End Select
    End Sub

    Private Sub DgRuta_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgRuta.CurrentCellChanged
        FilaSeleccion = DgRuta.CurrentRowIndex
    End Sub

    Private Sub DgRuta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgRuta.DoubleClick
        FilaSeleccion = DgRuta.CurrentRowIndex
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FilaSeleccion = TMP_RUTA.Rows.Count
        FullItem = True
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub btnaddall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddall.Click
        FullItem = False
        DEVOLVER = False
        Me.Close()
    End Sub


    Private Sub SeleccionarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarToolStripMenuItem.Click
        FilaSeleccion = DgRuta.CurrentRowIndex
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub TodosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodosToolStripMenuItem.Click
        FullItem = True
        FilaSeleccion = DgRuta.CurrentRowIndex
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub BtnPasaUno_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno_Ruta.Click

        PasarUno_Ruta()


    End Sub

    Private Sub BtnPasaTodo_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo_Ruta.Click
        PasarTodo_Ruta()
    End Sub

    Private Sub BtnQuitaUno_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaUno_Ruta.Click
        QuitarUno_Ruta()
    End Sub

    Private Sub BtnQuitaTodo_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaTodo_Ruta.Click
        QuitarTodo_Ruta()
    End Sub




    Private Sub PasarUno_Ruta()
        If Tb_RutaDisponible.Rows.Count > 0 Then

            Dim FILA As DataRow = Tb_RutaModSelec.NewRow
            FILA("Codigo") = LstDispRuta.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstDispRuta.Text.Trim
            Tb_RutaModSelec.Rows.Add(FILA)

            For F As Integer = 0 To Tb_RutaDisponible.Rows.Count - 1
                If LstDispRuta.SelectedValue.ToString.Trim = Tb_RutaDisponible.Rows(F)("Codigo").ToString.Trim Then
                    Tb_RutaDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub PasarTodo_Ruta()

        For F As Integer = 0 To Tb_RutaDisponible.Rows.Count - 1
            Dim FILA As DataRow = Tb_RutaModSelec.NewRow
            FILA("Codigo") = Tb_RutaDisponible.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_RutaDisponible.Rows(F)("Descripcion").ToString.Trim
            Tb_RutaModSelec.Rows.Add(FILA)
        Next
        Tb_RutaDisponible.Rows.Clear()
    End Sub


    Private Sub QuitarUno_Ruta()
        If Tb_RutaModSelec.Rows.Count > 0 Then
            Dim FILA As DataRow = Tb_RutaDisponible.NewRow
            FILA("Codigo") = LstSelecRuta.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstSelecRuta.Text.Trim
            Tb_RutaDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
                If LstSelecRuta.SelectedValue.ToString.Trim = Tb_RutaModSelec.Rows(F)("Codigo").ToString.Trim Then
                    Tb_RutaModSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub QuitarTodo_Ruta()

        For F As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Dim FILA As DataRow = Tb_RutaDisponible.NewRow
            FILA("Codigo") = Tb_RutaModSelec.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_RutaModSelec.Rows(F)("Descripcion").ToString.Trim
            Tb_RutaDisponible.Rows.Add(FILA)
        Next
        Tb_RutaModSelec.Rows.Clear()

    End Sub





    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
      
        'form1.cmbcalle.DataSource = Nothing

        'form1.cmbcalle.DataSource = Tb_RutaModSelec
        'form1.cmbcalle.DisplayMember = "Descripcion"
        'form1.cmbcalle.ValueMember = "Codigo"


        DEVOLVER = True
        Me.Close()



    End Sub

    Private Sub DgRuta_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgRuta.Navigate

    End Sub
End Class
