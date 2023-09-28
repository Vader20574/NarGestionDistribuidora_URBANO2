Public Class frm_transportista
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
    Friend WithEvents truc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents Ds_gridclie21 As mantenimiento.ds_gridclie2
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        'Me.Ds_gridclie21 = New mantenimiento.ds_gridclie2
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.truc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tcliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tcodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Ds_gridclie21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.CaptionBackColor = System.Drawing.Color.Silver
        Me.grid1.CaptionForeColor = System.Drawing.Color.Black
        Me.grid1.CaptionText = "  Registro de Transportista"
        Me.grid1.DataMember = ""
        'Me.grid1.DataSource = Me.Ds_gridclie21.cliente
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(16, 63)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(640, 320)
        Me.grid1.TabIndex = 9
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Ds_gridclie21
        '
        'Me.Ds_gridclie21.DataSetName = "ds_gridclie2"
        'Me.Ds_gridclie21.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
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
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "Nombre"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn2.MappingName = "apellidop"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 320
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "RUC"
        Me.DataGridTextBoxColumn3.MappingName = "razon"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.truc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tcodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 46)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'truc
        '
        Me.truc.Location = New System.Drawing.Point(531, 17)
        Me.truc.Name = "truc"
        Me.truc.Size = New System.Drawing.Size(88, 21)
        Me.truc.TabIndex = 5
        Me.truc.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(491, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RUC :"
        '
        'tcliente
        '
        Me.tcliente.Location = New System.Drawing.Point(235, 17)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.Size = New System.Drawing.Size(232, 21)
        Me.tcliente.TabIndex = 3
        Me.tcliente.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre :"
        '
        'tcodigo
        '
        Me.tcodigo.Location = New System.Drawing.Point(67, 17)
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(80, 21)
        Me.tcodigo.TabIndex = 1
        Me.tcodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código :"
        '
        'frm_transportista
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(672, 382)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(680, 416)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(680, 416)
        Me.Name = "frm_transportista"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta por Transportistas"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Ds_gridclie21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public AFrmGuiaDir As New frmObsGuia
    Public AFrmGuiaTrans As New FrmObsGuiaTrans
    Public v As Boolean
    Public vie2 As New frm_guiaing_otros
    'Public AObjBus As New ClsInterface
    Dim Ayuda As New ClsAyuda

    Private Sub frm_gridclie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call quita_maxi_min_form(Me)
        llena()
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        pasadatos()
    End Sub

    Dim i As Int32
    Dim ATblVehi As New DataTable
    Sub pasadatos()
        Try
            VAR1 = grid1.Item(grid1.CurrentRowIndex, 0)

            conecta("select codtranspor,destranspor,ruc,brevete from transportista where (codempresa='" & CodEmpresa & "'  and codtranspor='" & grid1.Item(grid1.CurrentRowIndex, 0) & "') ", "pa")

            If ds.Tables("pa").Rows.Count > 0 Then
                If v = True Then
                    If AFrmGuiaTrans.AIntValor = 1 Then
                        AFrmGuiaTrans.tcodchofer.Text = Trim(ds.Tables("pa").Rows(0)(0))
                        AFrmGuiaTrans.tchofer.Text = Trim(ds.Tables("pa").Rows(0)(1))
                        AFrmGuiaTrans.trucchofer.Text = Trim(ds.Tables("pa").Rows(0)(2))
                        AFrmGuiaTrans.tbrevete.Text = Trim(ds.Tables("pa").Rows(0)(3))
                        'CAyuda.CargarDataCombo(AFrmGuiaTrans.txtmarca, "NSP_SELECT_LISTA_TRANSPORTISTA_VEHICULO   '" & grid1.Item(grid1.CurrentRowIndex, 0) & "','" & codempresa & "'", "CODIGO", "DESCRIPCION")
                        'ATblVehi = AObjBus.ListarDatos("NSP_SELECT_LISTA_VEHICULO", AFrmGuiaTrans.cboplaca.SelectedValue.ToString(), codempresa).Tables(0)
                        ' AFrmGuiaTrans.txtpalca.Text = ATblVehi.Rows(0)("PLACA")
                        'AFrmGuiaTrans.txtnrocert.Text = ATblVehi.Rows(0)("CERTIFICADO")

                        CAyuda.CargarDataCombo(AFrmGuiaTrans.CboConductor, "sp_obt_conductor_empresa '" & AFrmGuiaTrans.tcodchofer.Text & "'", "brevete", "conductor")
                        If AFrmGuiaTrans.CboConductor.Items.Count < 1 Then
                            AFrmGuiaTrans.tbrevete.Text = ""
                        End If

                        AFrmGuiaTrans.tbrevete.Text = AFrmGuiaTrans.CboConductor.SelectedValue

                        CAyuda.CargarDataCombo(AFrmGuiaTrans.cboplaca, "USP_LISTAR_PLACA '" & AFrmGuiaTrans.tcodchofer.Text & "'", "CODTRANSPOR", "PLACA")
                        Dim TblPlaca As New DataTable
                        If TblPlaca.Rows.Count = 0 Then
                            AFrmGuiaTrans.txtmarca.Text = ""
                        End If
                        TblPlaca = CAyuda.ListarDatos("USP_LISTAR_MARCA", AFrmGuiaTrans.cboplaca.Text.Trim).Tables(0)
                        AFrmGuiaTrans.txtmarca.Text = TblPlaca.Rows(0).Item("MARCA")

                    Else
                        AFrmGuiaDir.tCboCodVehiculo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                        AFrmGuiaDir.txtDesEmpresa.Text = Trim(ds.Tables("pa").Rows(0)(1))
                        AFrmGuiaDir.trucchofer.Text = Trim(ds.Tables("pa").Rows(0)(2))

                        'CAyuda.CargarDataCombo(AFrmGuiaDir.cboconductor, "sp_obt_conductor_empresa '" & AFrmGuiaDir.tCboCodVehiculo.Text & "'", "brevete", "conductor")
                        'If AFrmGuiaDir.cboconductor.Items.Count < 1 Then
                        '    AFrmGuiaDir.tbrevete.Text = ""
                        'End If

                        'AFrmGuiaDir.tbrevete.Text = AFrmGuiaDir.cboconductor.SelectedValue

                        'CAyuda.CargarDataCombo(AFrmGuiaDir.cboplaca, "USP_LISTAR_PLACA '" & AFrmGuiaDir.tCboCodVehiculo.Text & "'", "CODTRANSPOR", "PLACA")
                        'Dim TblPlaca As New DataTable
                        'If TblPlaca.Rows.Count = 0 Then
                        '    AFrmGuiaDir.txtmarca.Text = ""
                        'End If
                        'TblPlaca = CAyuda.ListarDatos("USP_LISTAR_MARCA", AFrmGuiaDir.cboplaca.Text.Trim).Tables(0)
                        'AFrmGuiaDir.txtmarca.Text = TblPlaca.Rows(0).Item("MARCA")
                        'Jostin = True
                    End If
                End If
            End If

            Me.Close()
        Catch
            Me.Close()
        End Try
    End Sub

    Sub llena()
        'Me.Ds_gridclie21.Clear()
        conecta("select codtranspor as codigo,destranspor as apellidop,ruc as razon from transportista where codempresa='" & CodEmpresa & "'  and codtranspor like '" & Me.tcodigo.Text.Trim & "%' and ruc like '" & Me.truc.Text.Trim & "%' and destranspor like '" & Me.tcliente.Text.Trim & "%'", "pa")
        'oda.Fill(Me.Ds_gridclie21.cliente)

        'Me.grid1.DataSource = Me.Ds_gridclie21.cliente
    End Sub

    Private Sub tcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodigo.KeyPress, tcliente.KeyPress, truc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                         ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If Grid1.Focus = True Then
                        pasadatos()
                        Me.Close()
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
