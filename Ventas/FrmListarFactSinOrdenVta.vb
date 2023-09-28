Public Class FrmListarFactSinOrdenVta
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LblCont As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtgDoc As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDesCli As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmListarFactSinOrdenVta))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LblCont = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtNroDoc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DtgDoc = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtDesCli = New System.Windows.Forms.TextBox
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DtgDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'LblCont
        '
        Me.LblCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCont.ForeColor = System.Drawing.Color.Blue
        Me.LblCont.Location = New System.Drawing.Point(18, 302)
        Me.LblCont.Name = "LblCont"
        Me.LblCont.Size = New System.Drawing.Size(360, 16)
        Me.LblCont.TabIndex = 155
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(514, 286)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 156
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(6, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNroDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 40)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        '
        'TxtNroDoc
        '
        Me.TxtNroDoc.Location = New System.Drawing.Point(8, 13)
        Me.TxtNroDoc.Name = "TxtNroDoc"
        Me.TxtNroDoc.Size = New System.Drawing.Size(144, 20)
        Me.TxtNroDoc.TabIndex = 0
        Me.TxtNroDoc.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "&Ingrese Nro de Documento :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(178, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "&Ingrese Nombre del Cliente :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtgDoc)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(576, 216)
        Me.GroupBox3.TabIndex = 154
        Me.GroupBox3.TabStop = False
        '
        'DtgDoc
        '
        Me.DtgDoc.BackgroundColor = System.Drawing.Color.White
        Me.DtgDoc.CaptionBackColor = System.Drawing.Color.Silver
        Me.DtgDoc.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgDoc.CaptionForeColor = System.Drawing.Color.DarkBlue
        Me.DtgDoc.CaptionText = "Doble Click Sobre el Registro Seleccioando"
        Me.DtgDoc.DataMember = ""
        Me.DtgDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgDoc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgDoc.Location = New System.Drawing.Point(8, 10)
        Me.DtgDoc.Name = "DtgDoc"
        Me.DtgDoc.ReadOnly = True
        Me.DtgDoc.Size = New System.Drawing.Size(560, 200)
        Me.DtgDoc.TabIndex = 49
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDesCli)
        Me.GroupBox2.Location = New System.Drawing.Point(178, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 40)
        Me.GroupBox2.TabIndex = 153
        Me.GroupBox2.TabStop = False
        '
        'TxtDesCli
        '
        Me.TxtDesCli.Location = New System.Drawing.Point(8, 13)
        Me.TxtDesCli.Name = "TxtDesCli"
        Me.TxtDesCli.Size = New System.Drawing.Size(396, 20)
        Me.TxtDesCli.TabIndex = 1
        Me.TxtDesCli.Text = ""
        '
        'FrmListarFactSinOrdenVta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(594, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblCont)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmListarFactSinOrdenVta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Facturas Sin OrdenVta"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DtgDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables form"
    Public DEVOLVER As Boolean
    Private oTabla As New DataTable

#End Region


#Region "Funciones"
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean

        Select Case KeyData
            Case Keys.Enter
                If oTabla.Rows.Count > 0 Then
                    If DtgDoc.Focus = True Then
                        DEVOLVER = True
                        Me.Close()
                    End If
                End If
            Case Keys.Escape
                Me.Close()
        End Select
    End Function
    Private Sub Formato_Grilla()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = oTabla.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "CODTIPODOC"
            .MappingName = "CODTIPODOC"
            .Width = 0
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "TIPO DOCUMENTO"
            .MappingName = "DSTIPODOC"
            .Width = 120
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "NUMERO"
            .MappingName = "NRODOCU"
            .Width = 75
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "FECHA"
            .MappingName = "FECDOCUM"
            .Width = 70
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "CODCLIENTE"
            .MappingName = "CODCLIENTE"
            .Width = 0
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "CLIENTE"
            .MappingName = "DESCLIENTE"
            .Width = 210
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "MONEDA"
            .MappingName = "CODMON"
            .Width = 0
        End With

        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "EST"
            .MappingName = "ESTADO"
            .Width = 25
            .Alignment = HorizontalAlignment.Center
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8})
        Me.DtgDoc.TableStyles.Add(grdTableStyle1)
    End Sub
    Private Sub Cargar_Grilla()
        Try
            oTabla = CAyuda.ListarDatos("USP_CONSULTAR_FactSinOrdenVta", codempresa).Tables(0)
            Me.DtgDoc.DataSource = oTabla
            Me.LblCont.Text = "Total de Registros Encontrados --->> " + oTabla.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Me.Close()
        End Try
    End Sub


#End Region



    Private Sub FrmListarFactSinOrdenVta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Grilla()
        Formato_Grilla()

    End Sub

    Private Sub DtgDoc_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DtgDoc.Navigate

    End Sub

    Private Sub DtgDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgDoc.DoubleClick
        If oTabla.Rows.Count > 0 Then
            DEVOLVER = True
            Me.Close()
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub
End Class
