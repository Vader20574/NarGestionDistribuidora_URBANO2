Public Class FrmGridFuerzaVenta
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
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TablaEstiloFV As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbpais As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbpais = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.TablaEstiloFV = New System.Windows.Forms.DataGridTableStyle
        Me.CODIGO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESCRIPCION = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbpais)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 46)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'rbpais
        '
        Me.rbpais.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbpais.Location = New System.Drawing.Point(425, 20)
        Me.rbpais.Name = "rbpais"
        Me.rbpais.Size = New System.Drawing.Size(101, 16)
        Me.rbpais.TabIndex = 7
        Me.rbpais.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(358, 20)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 6
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(101, 18)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(230, 21)
        Me.txtdato.TabIndex = 5
        Me.txtdato.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dato : "
        '
        'grid1
        '
        Me.grid1.AllowSorting = False
        Me.grid1.CaptionText = "Registro Fuerza de Venta"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(12, 58)
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(524, 260)
        Me.grid1.TabIndex = 10
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloFV})
        '
        'TablaEstiloFV
        '
        Me.TablaEstiloFV.DataGrid = Me.grid1
        Me.TablaEstiloFV.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODIGO, Me.DESCRIPCION})
        Me.TablaEstiloFV.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloFV.MappingName = ""
        '
        'CODIGO
        '
        Me.CODIGO.Format = ""
        Me.CODIGO.FormatInfo = Nothing
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.MappingName = ""
        Me.CODIGO.Width = 75
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Format = ""
        Me.DESCRIPCION.FormatInfo = Nothing
        Me.DESCRIPCION.HeaderText = "Descripción"
        Me.DESCRIPCION.MappingName = ""
        Me.DESCRIPCION.Width = 250
        '
        'FrmGridFuerzaVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(548, 336)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmGridFuerzaVenta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Fuerza Venta"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Public vie As FrmFuerzaVenta
    'Private obj As New ClsInterface

#End Region

    Private Sub FrmGridFuerzaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    'Sub llena()
    '    Try
    '        Dim TablaFuerzaVenta As New DataTable
    '        TablaFuerzaVenta = CAyuda.ListarDatos("NSP_LISTAR_FUERZAVENTA", codempresa, "%").Tables(0)
    '        TablaEstiloFV.MappingName = TablaFuerzaVenta.TableName
    '        TablaEstiloFV.GridColumnStyles(0).MappingName = "CODIGO"
    '        TablaEstiloFV.GridColumnStyles(1).MappingName = "DESCRIPCION"
    '        grid1.TableStyles.Add(TablaEstiloFV)
    '        Me.grid1.DataSource = TablaFuerzaVenta
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Sub pasadatos()
        vie.txtCodigo.Text = grid1(grid1.CurrentRowIndex, 0).ToString.Trim
        vie.txtDescripcion.Text = grid1(grid1.CurrentRowIndex, 1).ToString.Trim
        'Dim TableCateg As New DataTable
        vie.TableCateg = CAyuda.ListarDatos("NSP_LISTAR_CATEG_X_FZAVTA", codempresa, grid1(grid1.CurrentRowIndex, 0).ToString.Trim).Tables(0)
        vie.dgCateg.DataSource = vie.TableCateg
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

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        llena()

    End Sub

    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            If Me.rbcodigo.Checked = True Then

                Dim TablaFuerzaVenta As New DataTable
                Conecta("Nsp_LISTAR_FUERZAVENTA_FILTRO '','','" & codempresa & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")
                TablaEstiloFV.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloFV.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloFV.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloFV)
                Me.grid1.DataSource = TablaFuerzaVenta

            Else

                Dim TablaFuerzaVenta As New DataTable
                Conecta("Nsp_LISTAR_FUERZAVENTA_FILTRO '','','" & codempresa & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")
                TablaEstiloFV.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloFV.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloFV.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloFV)
                Me.grid1.DataSource = TablaFuerzaVenta

            End If
        Else
            If Me.rbcodigo.Checked = True Then

                Dim TablaFuerzaVenta As New DataTable
                Conecta("Nsp_LISTAR_FUERZAVENTA_FILTRO '" & Me.txtdato.Text.Trim & "','','" & codempresa & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")
                TablaEstiloFV.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloFV.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloFV.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloFV)
                Me.grid1.DataSource = TablaFuerzaVenta

            Else

                Dim TablaFuerzaVenta As New DataTable
                Conecta("Nsp_LISTAR_FUERZAVENTA_FILTRO '','" & Me.txtdato.Text.Trim & "','" & codempresa & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")
                TablaEstiloFV.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloFV.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloFV.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloFV)
                Me.grid1.DataSource = TablaFuerzaVenta

            End If
        End If
    End Sub




    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
