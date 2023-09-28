Public Class FrmBuscArticuloxZona
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
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GridArt = New System.Windows.Forms.DataGrid
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 40)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtdato
        '
        Me.txtdato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdato.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(43, 14)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(339, 20)
        Me.txtdato.TabIndex = 0
        Me.txtdato.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
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
        Me.GridArt.Location = New System.Drawing.Point(6, 56)
        Me.GridArt.Name = "GridArt"
        Me.GridArt.ReadOnly = True
        Me.GridArt.Size = New System.Drawing.Size(673, 267)
        Me.GridArt.TabIndex = 3
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescripcion.Location = New System.Drawing.Point(570, 14)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(80, 16)
        Me.rbdescripcion.TabIndex = 11
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(498, 12)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 10
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'FrmBuscArticuloxZona
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 336)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridArt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscArticuloxZona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Articulo "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables"
    Dim TABLEART As New DataTable
    Public DEVOLVER As Boolean
    Public CODZONA As String
    Public DESZONA As String

    Private tblImp As New DataTable

#End Region

#Region "Funciones"

    Private Sub CargarGridForm()
        TABLEART = TmpListarDatos("SP_LISTA_ARTICULO_FACT  '" & codempresa & "','" & CODZONA & "','" & 0 & "'")
        GridArt.DataSource = TABLEART
    End Sub
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLEART.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

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
            .Width = 350
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "CDALMACEN"
            .HeaderText = "CDALMACEN"
            .NullText = ""
            .Width = 0
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3})
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


    Private Sub FrmBuscArticuloxZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "  en la Zona " & DESZONA

        CargarGridForm()
        FormatoGrid()

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




        If Me.rbcodigo.Checked = True Then
            TABLEART = TmpListarDatos("SP_LISTA_ARTICULO_FACT_FILTRO  '" & codempresa & "','" & CODZONA & "','" & 0 & "','" & txtdato.Text & "'")
            GridArt.DataSource = TABLEART
        Else
            TABLEART = TmpListarDatos("SP_LISTA_ARTICULO_FACT_FILTRO  '" & codempresa & "','" & CODZONA & "','" & 1 & "','" & txtdato.Text & "'")
            GridArt.DataSource = TABLEART
        End If


    End Sub


    Private Sub rbcodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcodigo.CheckedChanged

    End Sub

    Private Sub rbdescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdescripcion.CheckedChanged

    End Sub

    Private Sub GridArt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridArt.KeyPress

    End Sub
End Class
