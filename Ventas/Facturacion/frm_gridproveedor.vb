Public Class frm_gridproveedor
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
        Me.grid1.CaptionText = "  Registro de Proveedores"
        Me.grid1.DataMember = ""
        'Me.grid1.DataSource = Me.Ds_gridclie21.cliente
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(14, 62)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(620, 303)
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
        Me.DataGridTextBoxColumn1.Width = 110
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Proveedor"
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
        Me.DataGridTextBoxColumn3.Width = 110
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.truc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tcodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 46)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'truc
        '
        Me.truc.Location = New System.Drawing.Point(501, 16)
        Me.truc.Name = "truc"
        Me.truc.Size = New System.Drawing.Size(96, 21)
        Me.truc.TabIndex = 5
        Me.truc.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RUC :"
        '
        'tcliente
        '
        Me.tcliente.Location = New System.Drawing.Point(229, 16)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.Size = New System.Drawing.Size(192, 21)
        Me.tcliente.TabIndex = 3
        Me.tcliente.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Proveedor :"
        '
        'tcodigo
        '
        Me.tcodigo.Location = New System.Drawing.Point(69, 17)
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(72, 21)
        Me.tcodigo.TabIndex = 1
        Me.tcodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código :"
        '
        'frm_gridproveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(648, 366)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(654, 398)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(654, 398)
        Me.Name = "frm_gridproveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Proveedores"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Ds_gridclie21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public vie As New frm_guiaing_otros
    Public vie2 As New frm_guiasal_otros
    Public boingresoprov As Boolean

    Private Sub frm_gridclie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call quita_maxi_min_form(Me)
        cargadatos()

    End Sub

    Sub cargadatos()
        Try
            'Me.Ds_gridclie21.Clear()
            conecta("select codproveedor as codigo,desproveedor as apellidop,ruc as razon from proveedor where codempresa='" & CodEmpresa & "' and estado=0 and codproveedor like '" & Me.tcodigo.Text & "%' and desproveedor like '" & Me.tcliente.Text & "%' and ruc like '" & Me.truc.Text & "%'", "pa")
            'oda.Fill(Me.Ds_gridclie21.cliente)
            'Me.grid1.DataSource = Me.Ds_gridclie21.cliente
        Catch x As Exception
        End Try

    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        pasadatos()
    End Sub

    Sub pasadatos()
        Try
            Conecta("select codproveedor,desproveedor,ruc,direccion from proveedor where codempresa='" & codempresa & "'and estado=0 and codproveedor='" & CType(grid1.Item(grid1.CurrentRowIndex, 0), String) & "'", "pa")

            If ds.Tables("pa").Rows.Count > 0 Then
                If boingresoprov = True Then
                    vie.tcodproveedor.Text = Trim(ds.Tables("pa").Rows(0)(0).ToString)
                    vie.tproveedor.Text = Trim(ds.Tables("pa").Rows(0)(1).ToString)
                    vie.INICIAS = True
                Else
                    vie2.tcodproveedor.Text = Trim(ds.Tables("pa").Rows(0)(0).ToString)
                    vie2.tproveedor.Text = Trim(ds.Tables("pa").Rows(0)(1).ToString)
                    vie2.INICIAS = True
                End If
            End If

            Me.Close()

        Catch x As Exception
        End Try
    End Sub

    Private Sub tcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodigo.KeyPress, tcliente.KeyPress, truc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cargadatos()
        End If
    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
