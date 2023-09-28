Public Class Frm_Grid_TipoAnulacion
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
    Friend WithEvents TablaEstiloZV As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents estado As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.TablaEstiloZV = New System.Windows.Forms.DataGridTableStyle
        Me.CODIGO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESCRIPCION = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtDato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.estado = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.AllowSorting = False
        Me.grid1.CaptionText = "Registro TIpo Anulacion"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(10, 58)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(524, 260)
        Me.grid1.TabIndex = 12
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloZV})
        '
        'TablaEstiloZV
        '
        Me.TablaEstiloZV.DataGrid = Me.grid1
        Me.TablaEstiloZV.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODIGO, Me.DESCRIPCION, Me.estado})
        Me.TablaEstiloZV.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'CODIGO
        '
        Me.CODIGO.Format = ""
        Me.CODIGO.FormatInfo = Nothing
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Width = 75
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Format = ""
        Me.DESCRIPCION.FormatInfo = Nothing
        Me.DESCRIPCION.HeaderText = "Descripción"
        Me.DESCRIPCION.Width = 250
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbmedida)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtDato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 46)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(418, 22)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(88, 16)
        Me.rbmedida.TabIndex = 5
        Me.rbmedida.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(346, 20)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(46, 18)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(228, 20)
        Me.txtDato.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato :"
        '
        'estado
        '
        Me.estado.Format = ""
        Me.estado.FormatInfo = Nothing
        Me.estado.Width = 75
        '
        'Frm_Grid_TipoAnulacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(742, 334)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Grid_TipoAnulacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Zona de Venta"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Public vie As FRM_MANTENIMIENTO_TIPOANULACION
    Dim TablaFuerzaVenta As New DataTable
#End Region


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDON As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If ((MSG.Msg = WD_KEYDON) Or (MSG.Msg = WD_SYSTEM)) Then
            Select Case KeyData
                Case Keys.Enter
                    If TablaFuerzaVenta.Rows.Count > 0 Then
                        If grid1.Focus = True Then
                            pasadatos()
                        End If
                    End If

                Case Keys.Escape
                    Me.Close()
            End Select
        End If

    End Function


    Private Sub FrmGridZonaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()

    End Sub

    Sub llena()
        Try
            TablaFuerzaVenta = CAyuda.ListarDatos("NSP_LISTAR_TIPOANULACION2", codempresa).Tables(0)
            TablaEstiloZV.MappingName = TablaFuerzaVenta.TableName
            TablaEstiloZV.GridColumnStyles(0).MappingName = "CODIGO"
            TablaEstiloZV.GridColumnStyles(1).MappingName = "DESCRIPCION"
            TablaEstiloZV.GridColumnStyles(2).MappingName = "estado"
            grid1.TableStyles.Add(TablaEstiloZV)
            Me.grid1.DataSource = TablaFuerzaVenta
        Catch ex As Exception
        End Try
    End Sub

    Sub pasadatos()
        vie.txtCodigo.Text = grid1(grid1.CurrentRowIndex, 0).ToString.Trim
        vie.txtDescripcion.Text = grid1(grid1.CurrentRowIndex, 1).ToString.Trim
        vie.ckactivo.Checked = grid1(grid1.CurrentRowIndex, 2).ToString.Trim
        Me.Close()
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        pasadatos()
    End Sub


    Private Sub txtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDato.TextChanged
        llena2()
    End Sub


    Sub llena2()
        If Me.txtDato.Text.Trim = "" Then
            If Me.rbcodigo.Checked = True Then

     
                TablaFuerzaVenta = TmpListarDatos("Nsp_Sele_TIPOANULFACT '','','" & codempresa & "'")
                TablaEstiloZV.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloZV.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloZV.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloZV)
                Me.grid1.DataSource = TablaFuerzaVenta

            Else

                TablaFuerzaVenta = TmpListarDatos("Nsp_Sele_TIPOANULFACT '','','" & codempresa & "'")
                TablaEstiloZV.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloZV.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloZV.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloZV)
                Me.grid1.DataSource = TablaFuerzaVenta

            End If
        Else
            If Me.rbcodigo.Checked = True Then
     

                TablaFuerzaVenta = TmpListarDatos("Nsp_Sele_TIPOANULFACT '" & Me.txtDato.Text.Trim & "','','" & codempresa & "'")
                TablaEstiloZV.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloZV.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloZV.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloZV)
                Me.grid1.DataSource = TablaFuerzaVenta

            Else
           

                TablaFuerzaVenta = TmpListarDatos("Nsp_Sele_TIPOANULFACT '','" & Me.txtDato.Text.Trim & "','" & codempresa & "'")
                TablaEstiloZV.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloZV.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloZV.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloZV)
                Me.grid1.DataSource = TablaFuerzaVenta

            End If
        End If
    End Sub




    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
