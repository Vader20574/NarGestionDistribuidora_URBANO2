Public Class FRMARTICULOGUIA
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
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.White
        Me.Grid1.CaptionBackColor = System.Drawing.Color.Silver
        Me.Grid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.CaptionForeColor = System.Drawing.Color.Black
        Me.Grid1.CaptionText = "Registro de Articulos"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(8, 48)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(673, 267)
        Me.Grid1.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 40)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Checked = True
        Me.rbdescripcion.Location = New System.Drawing.Point(469, 18)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(125, 16)
        Me.rbdescripcion.TabIndex = 3
        Me.rbdescripcion.TabStop = True
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Location = New System.Drawing.Point(397, 15)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdato.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(43, 14)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(339, 20)
        Me.txtdato.TabIndex = 1
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
        'FRMARTICULOGUIA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 326)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMARTICULOGUIA"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros de Articulos"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Guia As New FRMGUIADIRECTA
    'Private ObjInter As New ClsInterface
    Dim r, f As String
    Dim Tabla As New DataTable
    Private Sub Carga_Grilla(ByVal pCodArti As String, ByVal pDesArti As String)
        Try
            'Tabla = CAyuda.ListarDatos("USP_ARTICULO_FACTURA", NROPTOVTA, codempresa.Trim, pCodArti, pDesArti).Tables(0)
            Tabla = CAyuda.ListarDatos("SP_LISTA_ARTICULO_FACT",codempresa,CDZONA,rbcodigo.checked).tables(0)
            Me.Grid1.DataSource = Tabla
        Catch ex As Exception
            MsgBox(ex.Message & Chr(13) & "Consulte a su Proveedor", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
            Me.Close()
        End Try
    End Sub
    Private Sub Formato_Grilla()
        'Call Conecta("CONFIGGRID '" & NROPTOVTA & "','" & codempresa.Trim & "'", "x")
        'FACT_CONFIGGRID = Trim(ds.Tables("x").Rows(0).Item("CONFIGGRID").ToString())

        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = Tabla.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim CODIGO As New DataGridTextBoxColumn
        With CODIGO
            .HeaderText = "CODIGO"
            .MappingName = "CODARTI"
            .Width = 100
        End With

        Dim DESCRIPCION As New DataGridTextBoxColumn
        With DESCRIPCION
            .HeaderText = "DESCRIPCION"
            .MappingName = "DESARTI"
            .Width = 400
        End With

        'If FACT_CONFIGGRID = "01" Then
        '    grdTableStyle1.GridColumnStyles.AddRange _
        '    (New DataGridColumnStyle() _
        '    {CODIGO, DESCRIPCION, UNIDAD, PRECIO_UNIDAD, CODMON, CODUMED})

        'ElseIf FACT_CONFIGGRID = "10" Then
        '    grdTableStyle1.GridColumnStyles.AddRange _
        '    (New DataGridColumnStyle() _
        '    {CODIGO, DESCRIPCION, MEDIDA, PRESENTACION, PRECIO_MEDIDA, CODMON, CODUMED})

        'ElseIf FACT_CONFIGGRID = "11" Then
        '    grdTableStyle1.GridColumnStyles.AddRange _
        '    (New DataGridColumnStyle() _
        '    {CODIGO, DESCRIPCION, MEDIDA, PRECIO_MEDIDA, UNIDAD, PRECIO_UNIDAD, CODMON, CODUMED})

        'End If
        grdTableStyle1.GridColumnStyles.AddRange(New DataGridColumnStyle() _
                {CODIGO, DESCRIPCION})

        Me.Grid1.TableStyles.Add(grdTableStyle1)
    End Sub
    Private Sub Devuelve()
        Try
            With Me.Grid1
                VCodArti = Trim(Grid1.Item(Grid1.CurrentRowIndex, 0).ToString())
                'VPrecioVta = Trim(Grid1.Item(Grid1.CurrentRowIndex, 3).ToString())
                'CDMONBASE = Trim(Grid1.Item(Grid1.CurrentRowIndex, 4).ToString())
                'Guia.TxtMedida.Text = Trim(Grid1.Item(Grid1.CurrentRowIndex, 5).ToString())
                'Guia.TxtMedida.Text = Grid1.Item(Grid1.CurrentRowIndex, FilasAyudaG - 1)
            End With
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & Chr(13) & "Consulte a su Proveedor", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
        End Try
    End Sub
    'Evento del Formulario
    Private Sub FRMARTICULOGUIA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Guia.TXTLOTE.Visible = True Then
            CAyuda.CargagridARTICULOPRECIO(Grid1, "NSP_ARTICULOPRECIOFAC '" & NROPTOVTA & "','" & codempresa & "',0,'','" & Guia.TXTLOTE.Text.Trim & "'," & 0 & "")
        Else
            Call Carga_Grilla("", "")
        End If
        Call Formato_Grilla()

    End Sub
    Private Sub FRMARTICULOGUIA_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.txtdato.Focus()
    End Sub
    Private Sub FRMARTICULOGUIA_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Tabla.Dispose()
        Tabla = Nothing
        'ObjInter = Nothing
    End Sub
    Private Sub txtdato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdato.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.rbcodigo.Checked = True Then
                Call Carga_Grilla(Me.txtdato.Text.Trim, "")
            Else
                Carga_Grilla("", Me.txtdato.Text.Trim)
            End If
            Me.txtdato.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            Me.Grid1.Focus()
        End If
    End Sub
    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate
        Try
            Grid1.Select(Grid1.CurrentRowIndex)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        Try
            If Me.Grid1.CurrentRowIndex <> -1 Then
                Call Devuelve()
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub txtdato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdato.KeyPress
    '    If Asc(e.KeyChar) = 13 Then
    '        Dim TIPO As Integer

    '        If rbcodigo.Checked = True Then TIPO = 1
    '        If rbdescripcion.Checked = True Then TIPO = 2
    '        FACT_CargagridARTICULOPRECIO(Grid1, "NSP_ARTICULOPRECIOFAC '" & nroptovta & "','" & FACT_codempresa & "'," & TIPO & ",'" & txtdato.Text.Trim & "','" & Guia.TXTLOTE.Text.Trim & "'," & Reos & "")
    '        txtdato.Focus()
    '    End If
    'End Sub
    'Private Sub Grid1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Grid1.KeyPress
    '    Try
    '        Grid1.Select(Grid1.CurrentRowIndex)
    '        If Asc(e.KeyChar) = 13 Then
    '            Try
    '                Dim x As Integer
    '                VCodArti = Grid1.Item(Grid1.CurrentRowIndex, 0)
    '                VPrecioVta = Grid1.Item(Grid1.CurrentRowIndex, 3)
    '                FACT_CODMONARTI = Grid1.Item(Grid1.CurrentRowIndex, 4)

    '                If Reos = 1 Then
    '                    Guia.TxtMedida.Text = Grid1.Item(Grid1.CurrentRowIndex, FilasAyudaG - 1)
    '                Else
    '                    r = Mid(Grid1.Item(Grid1.CurrentRowIndex, FilasAyudaG - 1), 3, 3)
    '                    f = Mid(Grid1.Item(Grid1.CurrentRowIndex, FilasAyudaG - 1), 12, 4)
    '                    xASTRNROIMPORTACION = r & f
    '                    Guia.TxtMedida.Text = Grid1.Item(Grid1.CurrentRowIndex, FilasAyudaG - 2)
    '                End If
    '            Catch ex As Exception
    '            End Try
    '            Me.Close()
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                            ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If Grid1.Focus = True Then
                        Try
                            If Me.Grid1.CurrentRowIndex <> -1 Then
                                Call Devuelve()
                            End If
                        Catch ex As Exception
                        End Try
                    End If

                Case Keys.Escape
                    Me.Close()
            End Select
        End If
        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
