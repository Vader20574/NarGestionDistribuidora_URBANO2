Public Class FrmGridTipoNegocio
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
    Friend WithEvents TablaEstiloTN As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.TablaEstiloTN = New System.Windows.Forms.DataGridTableStyle
        Me.CODIGO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESCRIPCION = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.AllowSorting = False
        Me.grid1.CaptionText = "Registro Tipo Negocio"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(12, 60)
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(524, 260)
        Me.grid1.TabIndex = 12
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloTN})
        '
        'TablaEstiloTN
        '
        Me.TablaEstiloTN.DataGrid = Me.grid1
        Me.TablaEstiloTN.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODIGO, Me.DESCRIPCION})
        Me.TablaEstiloTN.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloTN.MappingName = ""
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 46)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(94, 20)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(188, 20)
        Me.txtdato.TabIndex = 1
        Me.txtdato.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato :"
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescripcion.Location = New System.Drawing.Point(398, 24)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(86, 16)
        Me.rbdescripcion.TabIndex = 5
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(326, 22)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'FrmGridTipoNegocio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(556, 328)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmGridTipoNegocio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Tipo Negocio"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Public vie As FrmTipoNegocio
#End Region



    Private Sub FrmGridTipoNegocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    'Sub llena()
    '    Try
    '        'Dim obj As New ClsInterface
    '        Dim TablaFuerzaVenta As New DataTable
    '        TablaFuerzaVenta = CAyuda.ListarDatos("NSP_LISTAR_TIPONEGOCIO", codempresa, "%").Tables(0)
    '        TablaEstiloTN.MappingName = TablaFuerzaVenta.TableName
    '        TablaEstiloTN.GridColumnStyles(0).MappingName = "CODIGO"
    '        TablaEstiloTN.GridColumnStyles(1).MappingName = "DESCRIPCION"
    '        grid1.TableStyles.Add(TablaEstiloTN)
    '        Me.grid1.DataSource = TablaFuerzaVenta
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Sub pasadatos()
        vie.txtCodigo.Text = grid1(grid1.CurrentRowIndex, 0).ToString.Trim
        vie.txtDescripcion.Text = grid1(grid1.CurrentRowIndex, 1).ToString.Trim
        Me.Close()
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        pasadatos()
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdato.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged


        llena()


    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub llena()

        If Me.txtdato.Text.Trim = "" Then
            If Me.rbcodigo.Checked = True Then

                Dim TablaFuerzaVenta As New DataTable
                Conecta("Nsp_Sele_tipoNegocio_filtro '','','" & codempresa & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")

                TablaEstiloTN.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloTN.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloTN.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloTN)
                Me.grid1.DataSource = TablaFuerzaVenta

            Else

                Dim TablaFuerzaVenta As New DataTable

                Conecta("Nsp_Sele_tipoNegocio_filtro '','','" & codempresa & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")

                TablaEstiloTN.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloTN.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloTN.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloTN)
                Me.grid1.DataSource = TablaFuerzaVenta

            End If
        Else
            If Me.rbcodigo.Checked = True Then

                Dim TablaFuerzaVenta As New DataTable

                Conecta("Nsp_Sele_tipoNegocio_filtro '" & Me.txtdato.Text.Trim & "','','" & codempresa & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")

                TablaEstiloTN.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloTN.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloTN.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloTN)
                Me.grid1.DataSource = TablaFuerzaVenta

            Else

                Dim TablaFuerzaVenta As New DataTable
                Conecta("Nsp_Sele_tipoNegocio_filtro '','" & Me.txtdato.Text.Trim & "','" & codempresa & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")
                TablaEstiloTN.MappingName = TablaFuerzaVenta.TableName
                TablaEstiloTN.GridColumnStyles(0).MappingName = "CODIGO"
                TablaEstiloTN.GridColumnStyles(1).MappingName = "DESCRIPCION"
                grid1.TableStyles.Add(TablaEstiloTN)
                Me.grid1.DataSource = TablaFuerzaVenta

            End If
        End If
    End Sub


End Class
