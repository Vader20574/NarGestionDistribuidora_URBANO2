Public Class FrmGridTPromocion
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
    Friend WithEvents TablaEstiloPromocion As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PRECIO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents FECHA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.TablaEstiloPromocion = New System.Windows.Forms.DataGridTableStyle
        Me.CODIGO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESCRIPCION = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PRECIO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.FECHA = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.AllowSorting = False
        Me.grid1.CaptionText = "Registro Promociones        DobleClik o Enter para Seleccionar"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(12, 60)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(524, 254)
        Me.grid1.TabIndex = 14
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloPromocion})
        '
        'TablaEstiloPromocion
        '
        Me.TablaEstiloPromocion.DataGrid = Me.grid1
        Me.TablaEstiloPromocion.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODIGO, Me.DESCRIPCION, Me.PRECIO, Me.FECHA})
        Me.TablaEstiloPromocion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloPromocion.ReadOnly = True
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
        Me.DESCRIPCION.Width = 300
        '
        'PRECIO
        '
        Me.PRECIO.Format = ""
        Me.PRECIO.FormatInfo = Nothing
        Me.PRECIO.HeaderText = "Precio"
        Me.PRECIO.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 46)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Dato : "
        '
        'txtdato
        '
        Me.txtdato.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(84, 16)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(230, 21)
        Me.txtdato.TabIndex = 10
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescripcion.Location = New System.Drawing.Point(414, 22)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(80, 16)
        Me.rbdescripcion.TabIndex = 9
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(342, 20)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 8
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'FECHA
        '
        Me.FECHA.Format = ""
        Me.FECHA.FormatInfo = Nothing
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Width = 75
        '
        'FrmGridPromocion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(540, 318)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmGridPromocion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promocion"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Fields"
    Public vie As frmPromoDet

    Public TIPO As String

#End Region


#Region "Funciones de Form"
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If grid1.Focus = True Then
                        pasadatos()
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If

    End Function





#End Region


    Private Sub FrmGridPromocion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    'Sub llena()
    '    Try
    '        Dim TablaFuerzaVenta As New DataTable
    '        TablaFuerzaVenta = CAyuda.ListarDatos("NSP_LISTAR_PROMOCIONES", codempresa, "%").Tables(0)
    '        TablaEstiloPromocion.MappingName = TablaFuerzaVenta.TableName
    '        TablaEstiloPromocion.GridColumnStyles(0).MappingName = "CODPROMO"
    '        TablaEstiloPromocion.GridColumnStyles(1).MappingName = "DESPROMO"
    '        TablaEstiloPromocion.GridColumnStyles(2).MappingName = "PRECIO_PROMO"
    '        grid1.TableStyles.Add(TablaEstiloPromocion)
    '        Me.grid1.DataSource = TablaFuerzaVenta
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Sub pasadatos()
        'Dim TablaAux As New DataTable
        'TablaAux = CAyuda.ListarDatos("Nsp_Sele_promocion_Tipofiltro", codempresa, grid1(grid1.CurrentRowIndex, 0)).Tables(0)
        vie.txtcodPromo.Text = grid1(grid1.CurrentRowIndex, 0)
        vie.txtdescPromo.Text = grid1(grid1.CurrentRowIndex, 1)
        Me.Close()
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        pasadatos()
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub grid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.CurrentCellChanged
        Me.grid1.Select(grid1.CurrentRowIndex)
    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        llena()
    End Sub

    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            If Me.rbcodigo.Checked = True Then

                Dim TablaFuerzaVenta As New DataTable
                Conecta("Nsp_Sele_promocion_Tipofiltro '','','" & codempresa & "','" & TIPO & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")

                TablaEstiloPromocion.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloPromocion.GridColumnStyles(0).MappingName = "CODPROMO"
                TablaEstiloPromocion.GridColumnStyles(1).MappingName = "DESPROMO"
                TablaEstiloPromocion.GridColumnStyles(2).MappingName = "PRECIO_PROMO"
                TablaEstiloPromocion.GridColumnStyles(3).MappingName = "FEC_INI"
                grid1.TableStyles.Add(TablaEstiloPromocion)
                Me.grid1.DataSource = TablaFuerzaVenta


            Else

                Dim TablaFuerzaVenta As New DataTable

                Conecta("Nsp_Sele_promocion_Tipofiltro '','','" & codempresa & "','" & TIPO & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")

                TablaEstiloPromocion.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloPromocion.GridColumnStyles(0).MappingName = "CODPROMO"
                TablaEstiloPromocion.GridColumnStyles(1).MappingName = "DESPROMO"
                TablaEstiloPromocion.GridColumnStyles(2).MappingName = "PRECIO_PROMO"
                grid1.TableStyles.Add(TablaEstiloPromocion)
                Me.grid1.DataSource = TablaFuerzaVenta

            End If
        Else
            If Me.rbcodigo.Checked = True Then

                Dim TablaFuerzaVenta As New DataTable

                Conecta("Nsp_Sele_promocion_Tipofiltro '" & Me.txtdato.Text.Trim & "','','" & codempresa & "','" & TIPO & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")

                TablaEstiloPromocion.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloPromocion.GridColumnStyles(0).MappingName = "CODPROMO"
                TablaEstiloPromocion.GridColumnStyles(1).MappingName = "DESPROMO"
                TablaEstiloPromocion.GridColumnStyles(2).MappingName = "PRECIO_PROMO"
                grid1.TableStyles.Add(TablaEstiloPromocion)
                Me.grid1.DataSource = TablaFuerzaVenta

            Else

                Dim TablaFuerzaVenta As New DataTable
                Conecta("Nsp_Sele_promocion_Tipofiltro '','" & Me.txtdato.Text.Trim & "','" & codempresa & "','" & TIPO & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")
                TablaEstiloPromocion.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloPromocion.GridColumnStyles(0).MappingName = "CODPROMO"
                TablaEstiloPromocion.GridColumnStyles(1).MappingName = "DESPROMO"
                TablaEstiloPromocion.GridColumnStyles(2).MappingName = "PRECIO_PROMO"
                grid1.TableStyles.Add(TablaEstiloPromocion)
                Me.grid1.DataSource = TablaFuerzaVenta

            End If
        End If


    End Sub


End Class
