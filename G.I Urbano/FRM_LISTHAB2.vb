Public Class FRM_LISTHAB2
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
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    'Friend WithEvents Dsgridbanco1 As mantenimiento.dsgridbanco
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.CaptionText = "Registro de Vendedores"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(16, 64)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(536, 202)
        Me.grid1.TabIndex = 7
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "pa"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "codigo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Vendedor"
        Me.DataGridTextBoxColumn2.MappingName = "DESCRIPCION"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 360
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbmedida)
        Me.GroupBox2.Controls.Add(Me.rbcodigo)
        Me.GroupBox2.Controls.Add(Me.txtdato)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 40)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(336, 16)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(104, 16)
        Me.rbmedida.TabIndex = 3
        Me.rbmedida.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(256, 16)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(43, 14)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(205, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dato : "
        '
        'FRM_LISTHAB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(570, 348)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grid1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(576, 376)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(576, 376)
        Me.Name = "FRM_LISTHAB"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Vendedores"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public vie As frm_SolicitudServi
    Public vie4 As FrmCrearPlanillaCobros
    Public vie1 As New frm_choferes2
    Public vie2 As frm_choferes3
    Public vie3 As FrmPedido
    Public bol As New Boolean
    Private Dsgridbanco1 As New DataTable

    'Private Obj As New ClsInterface
    Private Sub frm_gridclie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean

        Const SYS_KEYDOWN As Integer = &H100
        Const SYSTEM_KEY As Integer = &H104
        If ((MSG.Msg = SYS_KEYDOWN) Or (MSG.Msg = SYSTEM_KEY)) Then
            Select Case KeyData
                Case Keys.Enter
                    If grid1.Focus = True Then
                        Dim sender As Object = Nothing
                        Dim e As System.EventArgs = Nothing
                        grid1_DoubleClick(sender, e)
                        'EnviarDatos(GridDespacho.Item(GridDespacho.CurrentRowIndex, 1).ToString.Trim, GridDespacho.Item(GridDespacho.CurrentRowIndex, 3).ToString.Trim, GridDespacho.Item(GridDespacho.CurrentRowIndex, 2).ToString.Trim, CDbl(GridDespacho.Item(GridDespacho.CurrentRowIndex, 10).ToString.Trim), CDbl(GridDespacho(GridDespacho.CurrentRowIndex, 11).ToString.Trim))
                    End If
            End Select
        End If
    End Function


    Sub cargadatos()
        Call Cargagrid(grid1, "Nsp_Select_CHOFERES '" & codempresa & "'")
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        If Not vie3 Is Nothing Then
            vie3.CboVended.SelectedValue = grid1.Item(grid1.CurrentRowIndex, 0).ToString.Trim
            Me.Close()
            Exit Sub
        End If
        If Not vie4 Is Nothing Then
            vie4.txtCobrador.Text = grid1.Item(grid1.CurrentRowIndex, 0).ToString.Trim
            vie4.lbCobrador.Text = grid1.Item(grid1.CurrentRowIndex, 1).ToString.Trim
            Me.Close()
            Exit Sub
        End If
        If Not vie2 Is Nothing Then
            PasaDatosCuotasLinea()
        Else
            pasadatos()
        End If

    End Sub
    Private Sub pasaDatosFromPedidos()
        Dim TablaVend As New DataTable
        'TablaVend = Obj.ListarDatos("NSP_LISTAR_VENDEDOR", CodEmpresa, grid1.Item(grid1.CurrentRowIndex, 0)).Tables(0)
        vie3.CboVended.SelectedValue = grid1.Item(grid1.CurrentRowIndex, 0).ToString.Trim
    End Sub

    Private Sub PasaDatosCuotasLinea()
        'Dim TablaVend As New DataTable
        'TablaVend = CAyuda.ListarDatos("NSP_LISTAR_VENDEDOR", codempresa, grid1.Item(grid1.CurrentRowIndex, 0)).Tables(0)
        'vie2.txtCodigo.Text = TablaVend.Rows(0)(1)
        'vie2.txtVendedor.Text = TablaVend.Rows(0)(2)
        '''''''''''''''''''''''''''
        'vie2.TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, grid1.Item(grid1.CurrentRowIndex, 0).ToString.Trim).Tables(0)
        'vie2.CodVendedor = grid1.Item(grid1.CurrentRowIndex, 0).ToString.Trim
        'vie2.dgCuotaLinea.DataSource = vie2.TablaCuotasLinea
        'vie2.FORMATO_GRID()
        Dim TablaVend As New DataTable
        TablaVend = CAyuda.ListarDatos("NSP_LISTAR_CHOFERES", codempresa, grid1.Item(grid1.CurrentRowIndex, 0)).Tables(0)


        If TablaVend.Rows.Count > 0 Then
            vie2.txt_Chofer.Text = TablaVend.Rows(0)("CODVEND")

        End If


        Me.Close()
    End Sub


    Sub pasadatos()
        If Me.grid1.VisibleColumnCount = 0 Then
            Exit Sub
        End If
        ' Conecta("select c.codvend,c.dsvend,c.codciudad,c.codzona,e.razonsocial,c.cuotat,c.cuotas,c.cuotad,c.nroptovta, c.cod_fv, c.cod_zv, c.cod_rv from vendedor c,empresa e where  c.CODEMPRESA=e.codempresa and c.codempresa='" & CodEmpresa & "' and c.estado=0 and e.estado=0 and c.codVEND='" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "pa")
        Dim TablaVend As New DataTable
        TablaVend = CAyuda.ListarDatos("NSP_LISTAR_HABITACION", codempresa, grid1.Item(grid1.CurrentRowIndex, 0)).Tables(0)
        If bol = True Then
            If TablaVend.Rows.Count > 0 Then
                vie.txtCodHab.Text = TablaVend.Rows(0)("CODHAB")
                vie.tdescripHab.Text = TablaVend.Rows(0)("DESCRIPCION")
                'vie.txttipo.Text = TablaVend.Rows(0)("TIPO")
                'vie.txtmedidas.Text = TablaVend.Rows(0)("MEDIDAS")
                'vie.txtAnexo.Text = TablaVend.Rows(0)("ANEXO")
                'vie.TxtOtros1.Text = TablaVend.Rows(0)("OTROS1")
                'vie.TxtOtros2.Text = TablaVend.Rows(0)("OTROS2")
                'vie.TxtOtros3.Text = TablaVend.Rows(0)("OTROS3")
                'vie.TxtOtros4.Text = TablaVend.Rows(0)("OTROS4")

                Try
                    'vie.TablaCuotaslineaVendedor = CAyuda.ListarDatos("NSP_SELECT_RUTA_VENDEDOR", codempresa.Trim, grid1.Item(grid1.CurrentRowIndex, 0).ToString.Trim, "%").Tables(0)
                    'vie.TablaEstiloCuotaLinea.MappingName = vie.TablaCuotaslineaVendedor.TableName
                    'vie.TablaEstiloCuotaLinea.GridColumnStyles(0).MappingName = "CODRUTA"
                    'vie.TablaEstiloCuotaLinea.GridColumnStyles(1).MappingName = "DESCRIPCION"
                    'vie.dgCuotasLinea.TableStyles.Add(vie.TablaEstiloCuotaLinea)
                    'vie.dgCuotasLinea.DataSource = vie.TablaCuotaslineaVendedor
                Catch ex As Exception
                End Try
                'Dim TablaCuotasLinea As DataTable
                'TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, TablaVend.Rows(0)("CODVEND").ToString).Tables(0)
                'vie.dgCuotaLinea.DataSource = TablaCuotasLinea
                'vie.FORMATO_GRID()



            End If
        Else

            vie1.txt_chofer.Text = TablaVend.Rows(0)("CODVEND")
            vie1.lbl_Chofer.Text = TablaVend.Rows(0)("DSVEND")


        End If
        Me.Close()
    End Sub


    Sub llena()
        Try

            If Me.txtdato.Text.Trim = "" Then

                Me.Dsgridbanco1.Clear()
                Conecta("select CODHAB as codigo,DESCRIPCION as descripcion from HABITACION where codempresa='" & codempresa & "'", "pa")
                Me.grid1.DataSource = ds.Tables(0)

            Else
                If Me.rbcodigo.Checked = True Then

                    Me.Dsgridbanco1.Clear()
                    Conecta("select CODHAB as codigo,DESCRIPCION as descripcion from HABITACION where (CODHAB  like '" & Me.txtdato.Text.Trim & "%' and codempresa='" & codempresa & "') ", "pa")
                    Me.grid1.DataSource = ds.Tables(0)

                Else

                    Me.Dsgridbanco1.Clear()
                    Conecta("select CODHAB as codigo,DESCRIPCION as descripcion from HABITACION where (DESCRIPCION like '" & Me.txtdato.Text.Trim & "%' and codempresa='" & codempresa & "') ", "pa")
                    Me.grid1.DataSource = ds.Tables(0)

                End If


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub tcodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            llena()
            grid1.Focus()
        End If
    End Sub

    Private Sub tcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tvendedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llena()
    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        llena()
    End Sub





    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
