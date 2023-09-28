Public Class FrmBuscarClieDepen
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbruc As System.Windows.Forms.RadioButton
    Friend WithEvents rbdireccion As System.Windows.Forms.RadioButton
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GridCli As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridCli = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbruc = New System.Windows.Forms.RadioButton()
        Me.rbdireccion = New System.Windows.Forms.RadioButton()
        Me.rbdescripcion = New System.Windows.Forms.RadioButton()
        Me.rbcodigo = New System.Windows.Forms.RadioButton()
        Me.txtdato = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GridCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridCli
        '
        Me.GridCli.BackgroundColor = System.Drawing.Color.White
        Me.GridCli.CaptionBackColor = System.Drawing.Color.Silver
        Me.GridCli.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCli.CaptionForeColor = System.Drawing.Color.Black
        Me.GridCli.CaptionText = "Registro de Clientes"
        Me.GridCli.DataMember = ""
        Me.GridCli.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridCli.Location = New System.Drawing.Point(12, 46)
        Me.GridCli.Name = "GridCli"
        Me.GridCli.ReadOnly = True
        Me.GridCli.Size = New System.Drawing.Size(703, 472)
        Me.GridCli.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbruc)
        Me.GroupBox1.Controls.Add(Me.rbdireccion)
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 42)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'rbruc
        '
        Me.rbruc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbruc.Location = New System.Drawing.Point(604, 20)
        Me.rbruc.Name = "rbruc"
        Me.rbruc.Size = New System.Drawing.Size(66, 20)
        Me.rbruc.TabIndex = 9
        Me.rbruc.Text = "Ruc"
        '
        'rbdireccion
        '
        Me.rbdireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdireccion.Location = New System.Drawing.Point(528, 20)
        Me.rbdireccion.Name = "rbdireccion"
        Me.rbdireccion.Size = New System.Drawing.Size(68, 19)
        Me.rbdireccion.TabIndex = 8
        Me.rbdireccion.Text = "Direccion"
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescripcion.Location = New System.Drawing.Point(434, 20)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(88, 20)
        Me.rbdescripcion.TabIndex = 7
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(360, 18)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 6
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(48, 14)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(264, 20)
        Me.txtdato.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'FrmBuscarClieDepen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(732, 540)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarClieDepen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente Dependiente"
        CType(Me.GridCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables"
    Dim TABLECLIENT As New DataTable
    Public DEVOLVER As Boolean

#End Region

#Region "Funciones"

    Private Sub CargarGridForm()
        TABLECLIENT = TmpListarDatos("SP_LISTAR_CLIENTE_DEPENDIENTE  '" & codempresa & "','" & 0 & "'")
        GridCli.DataSource = TABLECLIENT
    End Sub
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLECLIENT.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        End With

        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODCLIENTE"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 75
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DATOADJUNTO"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 350
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "DIRECCION"
            .HeaderText = "Direccion"
            .NullText = ""
            .Width = 350
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "RUC"
            .HeaderText = "Ruc"
            .NullText = ""
            .Width = 75
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4})
        GridCli.TableStyles.Add(TableStyle1)

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean


        Select Case KeyData
            Case Keys.Enter
                If TABLECLIENT.Rows.Count > 0 Then
                    If GridCli.Focus = True Then
                        DEVOLVER = True
                        Me.Close()
                    End If
                End If

            Case Keys.Escape
                Me.Close()
        End Select

    End Function


#End Region

    Private Sub FrmBuscarClieDepen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarGridForm()
        FormatoGrid()
    End Sub
    Private Sub CboFiltrar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarGridForm()

    End Sub



    Private Sub GridCli_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridCli.Navigate

    End Sub

    Private Sub GridCli_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCli.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub


    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        If Me.txtdato.Text.Trim = "" Then
            TABLECLIENT = TmpListarDatos("SP_LISTAR_CLIENTE_DEPENDIENTE  '" & codempresa & "','" & 0 & "'")
            GridCli.DataSource = TABLECLIENT
        Else

            If Me.rbcodigo.Checked = True Then
                TABLECLIENT = CAyuda.ListarDatos("SP_LISTAR_CLIENTE_DEPENDIENTE_FILTRO", codempresa.ToString(), 0, txtdato.Text).Tables(0)
                GridCli.DataSource = TABLECLIENT
            End If

            If Me.rbdescripcion.Checked = True Then
                TABLECLIENT = CAyuda.ListarDatos("SP_LISTAR_CLIENTE_DEPENDIENTE_FILTRO", codempresa.ToString(), 1, txtdato.Text).Tables(0)
                GridCli.DataSource = TABLECLIENT
            End If

            If Me.rbdireccion.Checked = True Then
                TABLECLIENT = CAyuda.ListarDatos("SP_LISTAR_CLIENTE_DEPENDIENTE_FILTRO", codempresa.ToString(), 2, txtdato.Text).Tables(0)
                GridCli.DataSource = TABLECLIENT
            End If

            If Me.rbruc.Checked = True Then
                TABLECLIENT = CAyuda.ListarDatos("SP_LISTAR_CLIENTE_DEPENDIENTE_FILTRO", codempresa.ToString(), 3, txtdato.Text).Tables(0)
                GridCli.DataSource = TABLECLIENT
            End If
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
