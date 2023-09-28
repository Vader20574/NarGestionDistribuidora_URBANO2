Public Class FrmDocumentosNoImprimidos
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridDocumento As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents LblDocumento As System.Windows.Forms.Label
    Friend WithEvents LblNroDesp As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentosNoImprimidos))
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.GridDocumento = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblDocumento = New System.Windows.Forms.Label
        Me.LblNroDesp = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.GridDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridDocumento
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'GridDocumento
        '
        Me.GridDocumento.CaptionText = "[Enter para seleccionar]  o Doble clik"
        Me.GridDocumento.DataMember = ""
        Me.GridDocumento.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridDocumento.Location = New System.Drawing.Point(10, 81)
        Me.GridDocumento.Name = "GridDocumento"
        Me.GridDocumento.ReadOnly = True
        Me.GridDocumento.Size = New System.Drawing.Size(415, 339)
        Me.GridDocumento.TabIndex = 159
        Me.GridDocumento.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CodEmpresa"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "#Orden Despacho"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 125
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = "dd/MM/yyyy"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "FecDocum"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 85
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "CodTipoDoc"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = "0##-#######"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "NroDocu"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(427, 342)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(87, 83)
        Me.GroupBox5.TabIndex = 163
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(10, 14)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(70, 62)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Nro Documento:"
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(125, 9)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(204, 22)
        Me.txtNroDoc.TabIndex = 161
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(427, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 256)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "DOCUMENTO"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtNroDoc)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 43)
        Me.Panel1.TabIndex = 165
        '
        'LblDocumento
        '
        Me.LblDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDocumento.Location = New System.Drawing.Point(300, 2)
        Me.LblDocumento.Name = "LblDocumento"
        Me.LblDocumento.Size = New System.Drawing.Size(214, 33)
        Me.LblDocumento.TabIndex = 166
        Me.LblDocumento.Text = "NOTA DE PEDIDO"
        Me.LblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNroDesp
        '
        Me.LblNroDesp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNroDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroDesp.Location = New System.Drawing.Point(12, 2)
        Me.LblNroDesp.Name = "LblNroDesp"
        Me.LblNroDesp.Size = New System.Drawing.Size(281, 33)
        Me.LblNroDesp.TabIndex = 167
        Me.LblNroDesp.Text = "NroDespacho:"
        Me.LblNroDesp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 33)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmDocumentosNoImprimidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(531, 437)
        Me.Controls.Add(Me.LblNroDesp)
        Me.Controls.Add(Me.LblDocumento)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GridDocumento)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentosNoImprimidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos No  Imprimidos"
        CType(Me.GridDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "FIELDS"
    Public DEVOLVER As Boolean
    Private TABLA_DOC As New DataTable
    Public NRODESPACHO As String = ""
    Public CODTIPODOC As String = ""
    Private FILASELEC As Integer
    Public GUIAD As String
#End Region
#Region "FUNCIONES"

    Sub CargarDatos()
        TABLA_DOC = TmpListarDatos("NSP_DOCUMENTO_NO_IMPRESO    '" & codempresa & "','" & NRODESPACHO & "','" & CODTIPODOC.ToString.Trim & "','" & GUIAD & "'")
        GridDocumento.DataSource = TABLA_DOC

        DataGridTableStyle1.MappingName = TABLA_DOC.TableName
        DataGridTableStyle1.GridColumnStyles(0).MappingName = "CODEMPRESA"
        DataGridTableStyle1.GridColumnStyles(1).MappingName = "NRODESPACHO"
        DataGridTableStyle1.GridColumnStyles(2).MappingName = "FECDOCUM"
        DataGridTableStyle1.GridColumnStyles(3).MappingName = "CODTIPODOC"
        DataGridTableStyle1.GridColumnStyles(4).MappingName = "NRODOCFACT"

        GridDocumento.TableStyles.Add(DataGridTableStyle1)


    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_CONST As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If ((MSG.Msg = WD_CONST) Or (MSG.Msg = WD_SYSTEM)) Then
            Select Case KeyData
                Case Keys.Enter
                    If GridDocumento.Focus = True Then
                        GridDocumento.Select(FILASELEC)
                        DEVOLVER = True
                        Me.Close()
                    End If
            End Select
        End If

    End Function


#End Region

    Private Sub FrmDocumentosNoImprimidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
        LblNroDesp.Text = LblNroDesp.Text & "  " & NRODESPACHO.Trim

    End Sub

    Private Sub txtNroDoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDoc.TextChanged

        For i As Integer = 0 To TABLA_DOC.Rows.Count - 1
            GridDocumento.UnSelect(i)
        Next

        For a As Integer = 0 To TABLA_DOC.Rows.Count - 1
            If Mid(GridDocumento.Item(GridDocumento.CurrentRowIndex, 4).ToString.Trim, 1, txtNroDoc.Text.Trim.Length) = txtNroDoc.Text.Trim Then
                FILASELEC = a
                GridDocumento.Select(a)
                Exit For
            End If


        Next


    End Sub

    Private Sub GridDocumento_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridDocumento.Navigate

    End Sub

    Private Sub GridDocumento_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDocumento.CurrentCellChanged
        FILASELEC = GridDocumento.CurrentRowIndex
    End Sub

    Private Sub GridDocumento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDocumento.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub
End Class
