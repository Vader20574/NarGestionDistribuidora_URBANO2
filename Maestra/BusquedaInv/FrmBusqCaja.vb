Public Class FrmBusqCaja
    Inherits System.Windows.Forms.Form
    Private TAB_TIPODOC As New DataTable
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TablaEstiloCaja As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODCAJA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESC1CAJA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESC2CAJA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCaja As System.Windows.Forms.DataGrid
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents rbpais As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.dgCaja = New System.Windows.Forms.DataGrid
        Me.TablaEstiloCaja = New System.Windows.Forms.DataGridTableStyle
        Me.CODCAJA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESC1CAJA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESC2CAJA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.rbpais = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbpais)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.dgCaja)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Location = New System.Drawing.Point(112, 18)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(180, 20)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.Text = ""
        '
        'dgCaja
        '
        Me.dgCaja.DataMember = ""
        Me.dgCaja.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCaja.Location = New System.Drawing.Point(10, 42)
        Me.dgCaja.Name = "dgCaja"
        Me.dgCaja.ReadOnly = True
        Me.dgCaja.Size = New System.Drawing.Size(398, 196)
        Me.dgCaja.TabIndex = 0
        Me.dgCaja.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloCaja})
        '
        'TablaEstiloCaja
        '
        Me.TablaEstiloCaja.DataGrid = Me.dgCaja
        Me.TablaEstiloCaja.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODCAJA, Me.DESC1CAJA, Me.DESC2CAJA})
        Me.TablaEstiloCaja.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloCaja.MappingName = ""
        Me.TablaEstiloCaja.ReadOnly = True
        '
        'CODCAJA
        '
        Me.CODCAJA.Format = ""
        Me.CODCAJA.FormatInfo = Nothing
        Me.CODCAJA.HeaderText = "Código"
        Me.CODCAJA.MappingName = ""
        Me.CODCAJA.Width = 75
        '
        'DESC1CAJA
        '
        Me.DESC1CAJA.Format = ""
        Me.DESC1CAJA.FormatInfo = Nothing
        Me.DESC1CAJA.HeaderText = "Descripción"
        Me.DESC1CAJA.MappingName = ""
        Me.DESC1CAJA.Width = 200
        '
        'DESC2CAJA
        '
        Me.DESC2CAJA.Format = ""
        Me.DESC2CAJA.FormatInfo = Nothing
        Me.DESC2CAJA.MappingName = ""
        Me.DESC2CAJA.Width = 0
        '
        'rbpais
        '
        Me.rbpais.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbpais.Location = New System.Drawing.Point(378, 20)
        Me.rbpais.Name = "rbpais"
        Me.rbpais.Size = New System.Drawing.Size(82, 16)
        Me.rbpais.TabIndex = 5
        Me.rbpais.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(308, 20)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 20)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'FrmBusqCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(484, 254)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqCaja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Caja"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public TablaDatCaja As New DataTable
    Public FrmPadre As FrmCaja
    Private Sub FrmBusqCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarFormularios(Me)
        CargarGrid()
        txtBusqueda.Focus()
    End Sub
    Private Sub CargarGrid()
        Conecta("SELECT CODCAJA, DESC1CAJA, DESC2CAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "'", "DTG")
        TablaDatCaja = ds.Tables("DTG")
        TablaEstiloCaja.MappingName = TablaDatCaja.TableName
        TablaEstiloCaja.GridColumnStyles(0).MappingName = "CODCAJA"
        TablaEstiloCaja.GridColumnStyles(1).MappingName = "DESC1CAJA"
        TablaEstiloCaja.GridColumnStyles(2).MappingName = "DESC2CAJA"
        Me.dgCaja.TableStyles.Add(TablaEstiloCaja)
        Me.dgCaja.DataSource = TablaDatCaja
    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged


        llena()

    End Sub


    Sub llena()

        If Me.txtBusqueda.Text.Trim = "" Then
            If Me.rbcodigo.Checked = True Then


                Conecta("Nsp_Sele_Caja '',''", "DTG")
                TablaDatCaja = ds.Tables("DTG")
                TablaEstiloCaja.MappingName = TablaDatCaja.TableName
                TablaEstiloCaja.GridColumnStyles(0).MappingName = "CODCAJA"
                TablaEstiloCaja.GridColumnStyles(1).MappingName = "DESC1CAJA"
                TablaEstiloCaja.GridColumnStyles(2).MappingName = "DESC2CAJA"
                Me.dgCaja.TableStyles.Add(TablaEstiloCaja)
                Me.dgCaja.DataSource = TablaDatCaja


            Else
                Conecta("Nsp_Sele_Caja '',''", "DTG")
                TablaDatCaja = ds.Tables("DTG")
                TablaEstiloCaja.MappingName = TablaDatCaja.TableName
                TablaEstiloCaja.GridColumnStyles(0).MappingName = "CODCAJA"
                TablaEstiloCaja.GridColumnStyles(1).MappingName = "DESC1CAJA"
                TablaEstiloCaja.GridColumnStyles(2).MappingName = "DESC2CAJA"
                Me.dgCaja.TableStyles.Add(TablaEstiloCaja)
                Me.dgCaja.DataSource = TablaDatCaja
            End If
        Else
            If Me.rbcodigo.Checked = True Then


                Conecta("Nsp_Sele_Caja '" & Me.txtBusqueda.Text.Trim & "',''", "DTG")
                TablaDatCaja = ds.Tables("DTG")
                TablaEstiloCaja.MappingName = TablaDatCaja.TableName
                TablaEstiloCaja.GridColumnStyles(0).MappingName = "CODCAJA"
                TablaEstiloCaja.GridColumnStyles(1).MappingName = "DESC1CAJA"
                TablaEstiloCaja.GridColumnStyles(2).MappingName = "DESC2CAJA"
                Me.dgCaja.TableStyles.Add(TablaEstiloCaja)
                Me.dgCaja.DataSource = TablaDatCaja

            Else
                Conecta("Nsp_Sele_Caja '','" & Me.txtBusqueda.Text.Trim & "'", "DTG")
                TablaDatCaja = ds.Tables("DTG")
                TablaEstiloCaja.MappingName = TablaDatCaja.TableName
                TablaEstiloCaja.GridColumnStyles(0).MappingName = "CODCAJA"
                TablaEstiloCaja.GridColumnStyles(1).MappingName = "DESC1CAJA"
                TablaEstiloCaja.GridColumnStyles(2).MappingName = "DESC2CAJA"
                Me.dgCaja.TableStyles.Add(TablaEstiloCaja)
                Me.dgCaja.DataSource = TablaDatCaja
            End If
        End If



    End Sub


    Private Sub dgCaja_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgCaja.Navigate

    End Sub

    Private Sub dgCaja_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCaja.DoubleClick
        FrmPadre.LLenarValores(Me.dgCaja(Me.dgCaja.CurrentRowIndex, 0))
        Me.Close()
    End Sub

    Private Sub rbcodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcodigo.CheckedChanged






    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
