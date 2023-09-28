
Public Class FrmListarArticuloReFactxSubEmp

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
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridArt As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbdescripcion = New System.Windows.Forms.RadioButton()
        Me.rbcodigo = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdato = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridArt = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Checked = True
        Me.rbdescripcion.Location = New System.Drawing.Point(597, 16)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(82, 15)
        Me.rbdescripcion.TabIndex = 9
        Me.rbdescripcion.TabStop = True
        Me.rbdescripcion.Text = "Descripcion "
        '
        'rbcodigo
        '
        Me.rbcodigo.Location = New System.Drawing.Point(523, 15)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(78, 15)
        Me.rbcodigo.TabIndex = 8
        Me.rbcodigo.Text = "Codigo "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filtrar : "
        '
        'txtdato
        '
        Me.txtdato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdato.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(43, 14)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(403, 20)
        Me.txtdato.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'GridArt
        '
        Me.GridArt.BackgroundColor = System.Drawing.Color.White
        Me.GridArt.CaptionBackColor = System.Drawing.Color.Silver
        Me.GridArt.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridArt.CaptionForeColor = System.Drawing.Color.Black
        Me.GridArt.CaptionText = "Registro de Articulos"
        Me.GridArt.DataMember = ""
        Me.GridArt.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridArt.Location = New System.Drawing.Point(6, 54)
        Me.GridArt.Name = "GridArt"
        Me.GridArt.ReadOnly = True
        Me.GridArt.Size = New System.Drawing.Size(710, 358)
        Me.GridArt.TabIndex = 1
        Me.GridArt.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridArt
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "CODARTI"
        Me.DataGridTextBoxColumn1.Width = 130
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "DESCRIPCIÓN"
        Me.DataGridTextBoxColumn2.MappingName = "DESARTI"
        Me.DataGridTextBoxColumn2.Width = 350
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "MARCA"
        Me.DataGridTextBoxColumn3.MappingName = "DESARTI2"
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'FrmListarArticuloReFactxSubEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 426)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridArt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListarArticuloReFactxSubEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de  Articulo Refact X SubEmpresa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim TABLEART As New DataTable
    Public DEVOLVER As Boolean
    Dim Tabl_temp As New DataTable
    Public codsubempresa As String
#End Region

#Region "Funciones"

    Private Sub CargarGridForm()

        TABLEART = TmpListarDatos("SP_LISTA_ARTICULO_REFACTXSUBEMPRESA  '" & codempresa & "','" & CDZONA & "','" & 0 & "','" & codsubempresa & "'")
        'TABLEART = TmpListarDatos("SP_LISTA_ARTICULO_FACT_FILTRO ", codempresa, CDZONA, txtdato.Text.Trim, txtdato.Text.Trim, CboFiltrar.SelectedIndex)
        GridArt.DataSource = Nothing
        GridArt.DataSource = TABLEART
    End Sub
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLEART.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        End With

        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODARTI"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 100
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DESARTI"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 400
        End With
        'Dim Column3 As New DataGridTextBoxColumn
        'With Column3
        '    .MappingName = "CDALMACEN"
        '    .HeaderText = "CDALMACEN"
        '    .NullText = ""
        '    .Width = 0
        'End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2})
        GridArt.TableStyles.Add(TableStyle1)


    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean


        Select Case KeyData
            Case Keys.Enter
                If TABLEART.Rows.Count > 0 Then
                    If GridArt.Focus = True Then
                        DEVOLVER = True
                        Me.Close()
                    End If
                End If

            Case Keys.Escape
                Me.Close()
        End Select

    End Function


#End Region

    Private Sub FrmListarArticuloFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarGridForm()
        'FormatoGrid()

    End Sub

    Private Sub GridArt_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridArt.Navigate

    End Sub

    Private Sub GridArt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridArt.DoubleClick
        DEVOLVER = True
        Me.Close()

    End Sub

    Private Sub CboFiltrar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarGridForm()

    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        If Me.txtdato.Text.Trim.Length = 0 Then
            CargarGridForm()
        Else
            If rbcodigo.Checked = True Then
                Tabl_temp = CAyuda.ListarDatos("SP_LISTA_ARTICULO_REFACTSUBEMP_FILTRO", codempresa, CDZONA, 0, txtdato.Text.Trim, codsubempresa).Tables(0)
                GridArt.DataSource = Nothing
                GridArt.DataSource = Tabl_temp
            End If

            If rbdescripcion.Checked = True Then
                Tabl_temp = CAyuda.ListarDatos("SP_LISTA_ARTICULO_REFACTSUBEMP_FILTRO", codempresa, CDZONA, 1, txtdato.Text.Trim, codsubempresa).Tables(0)
                GridArt.DataSource = Nothing
                GridArt.DataSource = Tabl_temp
            End If

        End If




    End Sub

    Private Sub rbcodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbcodigo.CheckedChanged

    End Sub
End Class
