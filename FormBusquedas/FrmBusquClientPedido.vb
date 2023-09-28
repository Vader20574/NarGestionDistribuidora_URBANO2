Public Class FrmBusquClientPedido
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
    Friend WithEvents DgCliente As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DgCliente = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboCriterio = New System.Windows.Forms.ComboBox
        Me.txtDatos = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgCliente
        '
        Me.DgCliente.DataMember = ""
        Me.DgCliente.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgCliente.Location = New System.Drawing.Point(14, 42)
        Me.DgCliente.Name = "DgCliente"
        Me.DgCliente.ReadOnly = True
        Me.DgCliente.Size = New System.Drawing.Size(628, 380)
        Me.DgCliente.TabIndex = 2
        Me.DgCliente.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DgCliente
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn1.MappingName = ""
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Apell./Razon Social"
        Me.DataGridTextBoxColumn2.MappingName = ""
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 350
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Ruc"
        Me.DataGridTextBoxColumn3.MappingName = ""
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(398, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Criterio : "
        '
        'CboCriterio
        '
        Me.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCriterio.Location = New System.Drawing.Point(450, 14)
        Me.CboCriterio.Name = "CboCriterio"
        Me.CboCriterio.Size = New System.Drawing.Size(166, 21)
        Me.CboCriterio.TabIndex = 1
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(70, 16)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(198, 20)
        Me.txtDatos.TabIndex = 0
        Me.txtDatos.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dato :"
        '
        'FrmBusquClientPedido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 436)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDatos)
        Me.Controls.Add(Me.CboCriterio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmBusquClientPedido"
        Me.Text = "Busqueda Cliente Pedido"
        CType(Me.DgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private TMP_BUSQCLIENTE As New DataTable
    Public DEVOLVER As Boolean
    Private FilaSelect As Integer
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keydata As Keys) As Boolean

        Const Wd_KeyDonw As Integer = &H100
        Const Wd_SysKeydonw As Integer = &H104

        If ((msg.Msg = Wd_KeyDonw) Or (msg.Msg = Wd_SysKeydonw)) Then
            Select Case (keydata)
                Case Keys.Enter
                    If DgCliente.Focus = True Then
                        DEVOLVER = True
                        Me.Close()
                    End If
                    DgCliente.Select(FilaSelect)
                Case Keys.Escape
                    Me.Close()
            End Select
        End If

    End Function



    Private Sub FrmBusquClientPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboCriterio.Items.Add("Codigo")
        CboCriterio.Items.Add("DATOADJUNTO")
        CboCriterio.Items.Add("RUC")

        TMP_BUSQCLIENTE = CAyuda.ListarDatos("NSP_BUSQCLIENTE", codempresa).Tables(0)
        DgCliente.DataSource = TMP_BUSQCLIENTE
        DataGridTableStyle1.MappingName = TMP_BUSQCLIENTE.TableName
        DataGridTableStyle1.GridColumnStyles(0).MappingName = "CODCLIENTE"
        DataGridTableStyle1.GridColumnStyles(1).MappingName = "DATOADJUNTO"
        DataGridTableStyle1.GridColumnStyles(2).MappingName = "RUC"
        DgCliente.TableStyles.Add(DataGridTableStyle1)

        CboCriterio.SelectedIndex = 0


    End Sub

    Private Sub txtDatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatos.TextChanged
        For a As Integer = 0 To TMP_BUSQCLIENTE.Rows.Count - 1
            DgCliente.UnSelect(a)
        Next
        Select Case CboCriterio.SelectedIndex
            Case 0
                For i As Integer = 0 To TMP_BUSQCLIENTE.Rows.Count - 1
                    If Mid(TMP_BUSQCLIENTE.Rows(i)("CODCLIENTE").ToString, 1, txtDatos.Text.Trim.Length) = txtDatos.Text.Trim Then
                        DgCliente.Select(i)
                        FilaSelect = i
                        Exit Sub
                    End If
                Next
            Case 1
                For i As Integer = 0 To TMP_BUSQCLIENTE.Rows.Count - 1
                    If Mid(TMP_BUSQCLIENTE.Rows(i)("DATOADJUNTO").ToString, 1, txtDatos.Text.Trim.Length) = txtDatos.Text.Trim Then
                        DgCliente.Select(i)
                        FilaSelect = i
                        Exit Sub
                    End If
                Next
            Case 2
                For i As Integer = 0 To TMP_BUSQCLIENTE.Rows.Count - 1
                    If Mid(TMP_BUSQCLIENTE.Rows(i)("RUC").ToString, 1, txtDatos.Text.Trim.Length) = txtDatos.Text.Trim Then
                        DgCliente.Select(i)
                        FilaSelect = i
                        Exit Sub
                    End If
                Next
        End Select
    End Sub
End Class
