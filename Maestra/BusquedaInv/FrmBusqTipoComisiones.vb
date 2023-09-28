Public Class FrmBusqTipoComisiones
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgTipo As System.Windows.Forms.DataGrid
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbdescrip As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DgTipo = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.rbdescrip = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        CType(Me.DgTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgTipo
        '
        Me.DgTipo.DataMember = ""
        Me.DgTipo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgTipo.Location = New System.Drawing.Point(14, 58)
        Me.DgTipo.Name = "DgTipo"
        Me.DgTipo.ReadOnly = True
        Me.DgTipo.Size = New System.Drawing.Size(462, 214)
        Me.DgTipo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdescrip)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.TxtDato)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 42)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(44, 12)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(208, 20)
        Me.TxtDato.TabIndex = 4
        Me.TxtDato.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dato : "
        '
        'rbdescrip
        '
        Me.rbdescrip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescrip.Location = New System.Drawing.Point(360, 13)
        Me.rbdescrip.Name = "rbdescrip"
        Me.rbdescrip.Size = New System.Drawing.Size(92, 16)
        Me.rbdescrip.TabIndex = 6
        Me.rbdescrip.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(292, 12)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 5
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'FrmBusqTipoProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 286)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgTipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqTipoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Tipo de Proveedor"
        CType(Me.DgTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Form"
    Public DEVOLVER As Boolean
    Private TABLE_TIPO As New DataTable
#End Region

#Region "Funciones Form"
    Private Sub CargarGrid()
        TABLE_TIPO = TmpListarDatos("SELECT  CODEMPRESA,CDTIPOPROV,DSTIPOPROV  FROM TIPOPROVEE  WHERE  CODEMPRESA='" & codempresa & "' ORDER BY DSTIPOPROV ")
        DgTipo.DataSource = TABLE_TIPO
    End Sub
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_TIPO.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CDTIPOPROV"
            .HeaderText = "Codigo"
            .Width = 50
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DSTIPOPROV"
            .HeaderText = "Descripcion"
            .Width = 250
        End With
        DgTipo.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2})
        DgTipo.TableStyles.Add(TableStyle1)

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If TABLE_TIPO.Rows.Count > 0 Then
                        If DgTipo.Focus = True Then
                            DEVOLVER = True
                            Me.Close()

                        End If

                    End If

                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function

#End Region


    Private Sub FrmBusqTipoProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        llena()

    End Sub
    Sub llena()
        If Me.TxtDato.Text.Trim = "" Then
            If Me.rbcodigo.Checked = True Then
                CargagridTipoProveedores(DgTipo, "Nsp_Sele_TipoComision '','','" & codempresa & "'")
            Else
                CargagridTipoProveedores(DgTipo, "Nsp_Sele_TipoComision '','','" & codempresa & "'")
            End If
        Else
            If Me.rbcodigo.Checked = True Then
                CargagridTipoProveedores(DgTipo, "Nsp_Sele_TipoComision '" & Me.TxtDato.Text.Trim & "','','" & codempresa & "'")
            Else
                CargagridTipoProveedores(DgTipo, "Nsp_Sele_TipoComision '','" & Me.TxtDato.Text.Trim & "','" & codempresa & "'")
            End If
        End If
    End Sub



    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged
        llena()

    End Sub

    Private Sub DgTipo_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgTipo.Navigate

    End Sub

    Private Sub DgTipo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgTipo.DoubleClick



        DEVOLVER = True
        Me.Close()



    End Sub
End Class
