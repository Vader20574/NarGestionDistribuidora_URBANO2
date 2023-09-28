Public Class frm_gridclie1
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents tcliente As System.Windows.Forms.TextBox
    Friend WithEvents truc As System.Windows.Forms.TextBox

    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Dsgridclie1 As NarGestionDistribuidora.dsgridclie
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.Dsgridclie1 = New NarGestionDistribuidora.dsgridclie
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.truc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tcliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tcodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsgridclie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.CaptionText = "  Registro de Clientes"
        Me.grid1.DataMember = ""
        Me.grid1.DataSource = Me.Dsgridclie1.cliente
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(16, 64)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(808, 448)
        Me.grid1.TabIndex = 1
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Dsgridclie1
        '
        Me.Dsgridclie1.DataSetName = "dsgridclie"
        Me.Dsgridclie1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "cliente"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "codigo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "A Paterno"
        Me.DataGridTextBoxColumn2.MappingName = "apellidop"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "A Materno"
        Me.DataGridTextBoxColumn3.MappingName = "apellidom"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nombre "
        Me.DataGridTextBoxColumn4.MappingName = "nombre"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Razón Social"
        Me.DataGridTextBoxColumn5.MappingName = "razon"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "RUC"
        Me.DataGridTextBoxColumn6.MappingName = "ruc"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 110
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.truc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tcodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'truc
        '
        Me.truc.Location = New System.Drawing.Point(656, 17)
        Me.truc.Name = "truc"
        Me.truc.Size = New System.Drawing.Size(128, 21)
        Me.truc.TabIndex = 5
        Me.truc.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(616, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RUC :"
        '
        'tcliente
        '
        Me.tcliente.Location = New System.Drawing.Point(296, 17)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.Size = New System.Drawing.Size(264, 21)
        Me.tcliente.TabIndex = 2
        Me.tcliente.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cliente/Razon Social :"
        '
        'tcodigo
        '
        Me.tcodigo.Location = New System.Drawing.Point(72, 17)
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(80, 21)
        Me.tcodigo.TabIndex = 1
        Me.tcodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código :"
        '
        'frm_gridclie1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(840, 525)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_gridclie1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Clientes"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsgridclie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public vie As New frm_clie
    'Public vie1 As New cuota_cliente
    Public vie2 As New FrmNotaCredito
    Public vie3 As New FrmPedido
    'Public vie4 As FrmAmarrarClientes
    Public bol As Integer
    Public SwNodoClie As Integer = 0
    Private Obj As New ClsAyuda
    Public DEVOLVER As Boolean


    Private Sub frm_gridclie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call quita_maxi_min_form(Me)
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

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        pasadatos()
    End Sub

    Dim i As Int32
    Sub pasadatos()
        If Dsgridclie1.cliente.Rows.Count = 0 Then
            Exit Sub
        End If
        DEVOLVER = True
        Me.Close()

        'Exit Sub

        VAR1 = grid1.Item(grid1.CurrentRowIndex, 0)
        If bol = 0 Then
            Conecta("SP_TraerClienteMaest '" & codempresa & "','" & grid1.Item(grid1.CurrentRowIndex, 0) & "','" & CodUsuario & "'", "pa")

            If ds.Tables("pa").Rows.Count > 0 Then
                vie.ASTRCODCLI = grid1.Item(grid1.CurrentRowIndex, 0)
                vie.tcodigo.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(0)))
                vie.tmaterno.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(1)))
                vie.tpaterno.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(2)))
                vie.tnombre.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(3)))
                vie.trazon.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(4)))
                vie.tdni.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(5)))
                'vie.tcuotat.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(6)))
                'vie.tcuotas.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(7)))
                'vie.tcuotad.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(8)))
                vie.tdescuento.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(9)))
                vie.tctaanticipo.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(9)))
                vie.tctaletra.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(10)))
                vie.tctaanticipo.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(11)))
                vie.tctaventa.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(12)))
                'vie.tsaldo.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(13)))
                'vie.tcredito.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(14)))
                vie.ttelefono.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(15)))
                vie.truc.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(16)))
                vie.tdireccion.Text = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(17)))
                vie.ctipopago.SelectedValue = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(18)))
                vie.ctipoclie.SelectedValue = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(19)))
                vie.cbopais.SelectedValue = GValidarNulos(ds.Tables("pa").Rows(0)(26))
                vie.cdepa.SelectedValue = GValidarNulos(ds.Tables("pa").Rows(0)(28))
                vie.cciud.SelectedValue = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(20)))
                vie.txtctaBanca.SelectedValue = Trim(GValidarNulos(ds.Tables("pa").Rows(0)(23)))
                vie.CmbForPago.SelectedValue = GValidarNulos(ds.Tables("pa").Rows(0)(24))
                vie.cmbmoneda.SelectedValue = GValidarNulos(ds.Tables("pa").Rows(0)(25))
                vie.cdistrito.SelectedValue = GValidarNulos(ds.Tables("pa").Rows(0)(27))
                vie.tmail.Text = GValidarNulos(ds.Tables("pa").Rows(0)(30))
                vie.txtcontacto.Text = GValidarNulos(ds.Tables("pa").Rows(0)(31))
                vie.txttelefonoc.Text = GValidarNulos(ds.Tables("pa").Rows(0)(32))
                vie.txtcelularc.Text = GValidarNulos(ds.Tables("pa").Rows(0)(33))
                vie.txtemailc.Text = GValidarNulos(ds.Tables("pa").Rows(0)(34))
                vie.txtfax.Text = GValidarNulos(ds.Tables("pa").Rows(0)("FAXCLIENTE"))
                vie.CboRutaDep.SelectedValue = GValidarNulos(ds.Tables("pa").Rows(0)("RUTA"))
                vie.CboTipoNegocio.SelectedValue = GValidarNulos(ds.Tables("pa").Rows(0)("TIPONEGOCIO"))
                vie.CboTipoprecio.SelectedValue = GValidarNulos(ds.Tables("pa").Rows(0)("CODTIPOPRE"))

                vie.dTablaFuerzaVenta = Obj.ListarDatos("NSP_LISTAR_CLIE_FUERZA", codempresa, vie.tcodigo.Text.Trim).Tables(0)

                vie.TablaEstiloFV.MappingName = vie.dTablaFuerzaVenta.TableName
                vie.TablaEstiloFV.GridColumnStyles(0).MappingName = "CODFUERZA"
                vie.TablaEstiloFV.GridColumnStyles(1).MappingName = "DESCRIPCION"
                vie.TablaEstiloFV.GridColumnStyles(2).MappingName = "CREDITO_F"
                vie.TablaEstiloFV.GridColumnStyles(3).MappingName = "SALDO_CREDF"
                vie.dgMatrizFuerzas.TableStyles.Add(vie.TablaEstiloFV)
                vie.dgMatrizFuerzas.DataSource = vie.dTablaFuerzaVenta
                vie.tsaldo.ReadOnly = True
                vie.CargarGridCliDep()
                ' vie.FormatoGridCliDep()
                vie.CargarGridPtoLlegad()
                vie.FormatoGridPtoLlegad()
                If Trim(ds.Tables("pa").Rows(0)(29)) = False Then
                    vie.CheckBox2.Checked = False
                Else
                    vie.CheckBox2.Checked = True
                End If

            End If

            If vie.trazon.Text.Trim = "" Then
                vie.CheckBox1.Checked = False
            Else
                vie.CheckBox1.Checked = True
            End If

            'vie.ListView1.Items.Clear()
            'vie.ListView2.Items.Clear()
            'vie.ListView3.Items.Clear()

            Conecta("select d.coddep,c.razonsocial from dependienteclie d,cliente c where (d.coddep=c.codcliente and d.empresa='" & codempresa & "' and c.codempresa='" & codempresa & "' and  d.estado=0 and c.estado=0 and d.codcliente='" & grid1.Item(grid1.CurrentRowIndex, 0) & "' and c.razonsocial<>'')", "clie")
            If ds.Tables("clie").Rows.Count > 0 Then
                For i = 0 To ds.Tables("clie").Rows.Count - 1
                    Dim m As New ListViewItem
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(0)))
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(1)))
                    'vie.ListView1.Items.Add(m)
                Next
            End If

            'Conecta("SELECT CODCLIEnTE, CODDIRCLI,DIRCLI, CODRUTA from CLIDIR where codempresa='" & codempresa & "' and  estado=0 and codcliente='" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "clie")
            Dim TablaTemp As New DataTable
            TablaTemp = Obj.ListarDatos("NSP_LISTAR_DIRECCION_CLIENTE", codempresa, grid1.Item(grid1.CurrentRowIndex, 0).ToString.Trim).Tables(0)

            'vie.TablaEstilo.MappingName = TablaTemp.TableName
            'vie.TablaEstilo.GridColumnStyles(0).MappingName = "CODDIRCLI"
            'vie.TablaEstilo.GridColumnStyles(1).MappingName = "NOMCLI"
            'vie.TablaEstilo.GridColumnStyles(2).MappingName = "RUC_DNI"
            'vie.TablaEstilo.GridColumnStyles(3).MappingName = "DIRCLI"
            'vie.TablaEstilo.GridColumnStyles(4).MappingName = "CODRUTA"
            'vie.TablaEstilo.GridColumnStyles(5).MappingName = "DESCRIPCION"
            'vie.dgDirCli.TableStyles.Add(vie.TablaEstilo)
            'vie.dgDirCli.DataSource = TablaTemp
            vie.TablaDircli = TablaTemp

            Conecta("select d.coddep,c.paterno,c.materno,c.nombres,c.ruc from dependienteclie d,cliente c where (d.coddep=c.codcliente and d.empresa='" & codempresa & "' and c.codempresa='" & codempresa & "' and  d.estado=0 and c.estado=0 and d.codcliente='" & grid1.Item(grid1.CurrentRowIndex, 0) & "' and c.razonsocial='')", "clie")
            If ds.Tables("clie").Rows.Count > 0 Then
                For i = 0 To ds.Tables("clie").Rows.Count - 1
                    Dim m As New ListViewItem
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(0)))
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(1)) + " " + Trim(ds.Tables("clie").Rows(i)(2)) + "," + Trim(ds.Tables("clie").Rows(i)(3)))
                    'vie.ListView1.Items.Add(m)
                Next
            End If

            Conecta("SELECT dbo.CLIENTE_PTOVTA.NROPTOVTA, dbo.TIENDAPTOVTA.DESPTOVTA, dbo.CLIENTE_PTOVTA.codvend, dbo.Vendedor.DSVEND,dbo.CLIENTE_PTOVTA.CUOTAT,dbo.CLIENTE_PTOVTA.CUOTAS,dbo.CLIENTE_PTOVTA.CUOTAD FROM dbo.CLIENTE_PTOVTA INNER JOIN dbo.TIENDAPTOVTA ON dbo.CLIENTE_PTOVTA.NROPTOVTA = dbo.TIENDAPTOVTA.NROPTOVTA INNER JOIN dbo.Vendedor ON dbo.CLIENTE_PTOVTA.codvend = dbo.Vendedor.codvend  where dbo.CLIENTE_PTOVTA.codempresa='" & codempresa & "'  and codcliente='" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "clie")
            If ds.Tables("clie").Rows.Count > 0 Then
                For i = 0 To ds.Tables("clie").Rows.Count - 1
                    Dim m As New ListViewItem
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(1)))
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(0)))
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(3)))
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(2)))
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(4)))
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(5)))
                    m.SubItems.Add(Trim(ds.Tables("clie").Rows(i)(6)))
                    'vie.ListView3.Items.Add(m)
                Next
            End If
        ElseIf bol = 1 Then
            'vie1.tvendedor.Text = grid1.Item(grid1.CurrentRowIndex, 0)///////comentado por var vie1 comentado
            'If Trim(grid1.Item(grid1.CurrentRowIndex, 4)) = "" Then
            '    vie1.TextBox1.Text = CType(grid1.Item(grid1.CurrentRowIndex, 1), String) + " " + CType(grid1.Item(grid1.CurrentRowIndex, 2), String) + "," + CType(grid1.Item(grid1.CurrentRowIndex, 3), String)
            'Else
            '    vie1.TextBox1.Text = grid1.Item(grid1.CurrentRowIndex, 4)
            'End If

        ElseIf bol = 2 Then
            'If Trim(grid1.Item(grid1.CurrentRowIndex, 4)) <> "" Then
            '    vie.cbocliente.Text = Trim(grid1.Item(grid1.CurrentRowIndex, 4))
            'Else
            '    vie.cbocliente.Text = Trim(grid1.Item(grid1.CurrentRowIndex, 1)) + " " + Trim(grid1.Item(grid1.CurrentRowIndex, 2)) + "," + Trim(grid1.Item(grid1.CurrentRowIndex, 3))
            'End If
        ElseIf bol = 3 Then

            Conecta("select codcliente,razon=case razonsocial when '' then paterno+' '+materno+','+nombres else razonsocial end,direccion,ruc from cliente where codempresa='" & codempresa & "' and codcliente='" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "llena")

            If ds.Tables("llena").Rows.Count > 0 Then
                vie2.txtcodcli.Text = Trim(ds.Tables("llena").Rows(0)(0))
                vie2.txtnombre.Text = Trim(ds.Tables("llena").Rows(0)(1))
                vie2.txtruc.Text = Trim(ds.Tables("llena").Rows(0)(3))
                vie2.txtdireccion.Text = Trim(ds.Tables("llena").Rows(0)(2))
            End If
        ElseIf bol = 4 Then
            Conecta("select codcliente,razon=case razonsocial when '' then paterno+' '+materno+','+nombres else razonsocial end,direccion,ruc, RUTA, CODTIPOPRE, CODTIPOPAGO from cliente where codempresa='" & codempresa & "' and codcliente='" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                vie3.lblCliente.Text = Trim(ds.Tables("llena").Rows(0)(0))
                '  vie3.CodRuta = Trim(ds1.Tables("llena").Rows(0)("RUTA"))
                vie3.CodTipoPrecio = Trim(ds.Tables("llena").Rows(0)("CODTIPOPRE"))
                vie3.lblCliente.Text = Trim(ds.Tables("llena").Rows(0)(1))
                '                vie3.cbTipoPago.SelectedValue = Trim(ds1.Tables("llena").Rows(0)("CODTIPOPAGO"))
                vie3.cbTipoPago.SelectedValue = "01"
                If Trim(ds.Tables("llena").Rows(0)("CODTIPOPAGO")) = "01" Then
                    vie3.cbTipoPago.Enabled = False
                Else
                    vie3.cbTipoPago.Enabled = True
                End If
            End If
        End If
        'If Not vie4 Is Nothing Then//////////comentado xq vie4 no existe
        '    Conecta("select codcliente,razon=case razonsocial when '' then paterno+' '+materno+','+nombres else razonsocial end,direccion,ruc, RUTA from cliente where codempresa='" & codempresa & "' and codcliente='" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "llena2")
        '    If SwNodoClie = 1 Then
        '        vie4.txtCodClie1.Text = ds.Tables("llena2").Rows(0)(0)
        '        vie4.lbDesCliente1.Text = ds.Tables("llena2").Rows(0)(1)
        '    ElseIf SwNodoClie = 2 Then
        '        vie4.txtCodClie2.Text = ds.Tables("llena2").Rows(0)(0)
        '        vie4.lbDesCliente2.Text = ds.Tables("llena2").Rows(0)(1)
        '    End If
        'End If
        Me.Close()
    End Sub

    Sub llena()
        Me.Dsgridclie1.Clear()
        conecta1("select codcliente as codigo,paterno as apellidop,materno as apellidom,nombres as nombre,razonsocial as razon,ruc as ruc from cliente where (codempresa='" & codempresa & "' and estado=0 and codcliente like '" & Me.tcodigo.Text.Trim & "%' and ruc like '" & Me.truc.Text.Trim & "%' and (paterno like '%" & Me.tcliente.Text.Trim & "%' or materno like '%" & Me.tcliente.Text.Trim & "%' or nombres like '" & Me.tcliente.Text.Trim & "%' or razonsocial like '" & Me.tcliente.Text.Trim & "%')) ", "pa")
        oda.Fill(Me.Dsgridclie1.cliente)
        Me.grid1.DataSource = Me.Dsgridclie1.cliente
    End Sub

    Private Sub tcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodigo.KeyPress, tcliente.KeyPress, truc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub


    Private Sub tcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcodigo.TextChanged

    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
