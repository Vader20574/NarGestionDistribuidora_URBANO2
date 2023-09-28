Public Class FrmTransfDocA_Letras
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnCargar As System.Windows.Forms.Button
    Friend WithEvents DgCompCred As System.Windows.Forms.DataGrid
    Friend WithEvents TxtTotalSelec As System.Windows.Forms.TextBox
    Friend WithEvents GrpProvee As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransfDocA_Letras))
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboProveedor = New System.Windows.Forms.ComboBox
        Me.GrpProvee = New System.Windows.Forms.GroupBox
        Me.BtnCargar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DgCompCred = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtTotalSelec = New System.Windows.Forms.TextBox
        Me.GrpProvee.SuspendLayout()
        CType(Me.DgCompCred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor : "
        '
        'CboProveedor
        '
        Me.CboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProveedor.Location = New System.Drawing.Point(84, 14)
        Me.CboProveedor.Name = "CboProveedor"
        Me.CboProveedor.Size = New System.Drawing.Size(307, 24)
        Me.CboProveedor.TabIndex = 1
        '
        'GrpProvee
        '
        Me.GrpProvee.Controls.Add(Me.BtnCargar)
        Me.GrpProvee.Controls.Add(Me.CboProveedor)
        Me.GrpProvee.Controls.Add(Me.Label1)
        Me.GrpProvee.Enabled = False
        Me.GrpProvee.Location = New System.Drawing.Point(22, 14)
        Me.GrpProvee.Name = "GrpProvee"
        Me.GrpProvee.Size = New System.Drawing.Size(544, 51)
        Me.GrpProvee.TabIndex = 2
        Me.GrpProvee.TabStop = False
        '
        'BtnCargar
        '
        Me.BtnCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCargar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCargar.ImageIndex = 4
        Me.BtnCargar.ImageList = Me.ImageList1
        Me.BtnCargar.Location = New System.Drawing.Point(403, 14)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(135, 29)
        Me.BtnCargar.TabIndex = 11
        Me.BtnCargar.Text = "      &Cargar Datos"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        '
        'DgCompCred
        '
        Me.DgCompCred.CaptionText = "               Para  Seleccinar= [Enter]  ó  Doble Click"
        Me.DgCompCred.DataMember = ""
        Me.DgCompCred.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgCompCred.Location = New System.Drawing.Point(24, 74)
        Me.DgCompCred.Name = "DgCompCred"
        Me.DgCompCred.ReadOnly = True
        Me.DgCompCred.Size = New System.Drawing.Size(538, 316)
        Me.DgCompCred.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Location = New System.Drawing.Point(566, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 159)
        Me.GroupBox2.TabIndex = 154
        Me.GroupBox2.TabStop = False
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(7, 12)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(120, 32)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(7, 46)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(120, 32)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "  _ &Transformar  a  Letra"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCELAR.Enabled = False
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(7, 81)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(120, 32)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "  &Cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCERRAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 13
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(7, 118)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(120, 32)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Salir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(254, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 17)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Importe Seleccionado :  "
        '
        'TxtTotalSelec
        '
        Me.TxtTotalSelec.BackColor = System.Drawing.Color.White
        Me.TxtTotalSelec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalSelec.Location = New System.Drawing.Point(415, 399)
        Me.TxtTotalSelec.Name = "TxtTotalSelec"
        Me.TxtTotalSelec.ReadOnly = True
        Me.TxtTotalSelec.Size = New System.Drawing.Size(120, 30)
        Me.TxtTotalSelec.TabIndex = 156
        Me.TxtTotalSelec.Text = "0.00"
        Me.TxtTotalSelec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmTransfDocA_Letras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(727, 380)
        Me.Controls.Add(Me.TxtTotalSelec)
        Me.Controls.Add(Me.DgCompCred)
        Me.Controls.Add(Me.GrpProvee)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmTransfDocA_Letras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transformacion de Documentos a Letras"
        Me.GrpProvee.ResumeLayout(False)
        Me.GrpProvee.PerformLayout()
        CType(Me.DgCompCred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Funciones Form"
    Private Sub SelecODeSelec()
        If DgCompCred.Item(DgCompCred.CurrentRowIndex, 5) = False Then
            DgCompCred.Item(DgCompCred.CurrentRowIndex, 5) = True
        Else
            DgCompCred.Item(DgCompCred.CurrentRowIndex, 5) = False
        End If

        TxtTotalSelec.Text = "0.00"
        For i As Integer = 0 To TB_COMPRASCRED.Rows.Count - 1
            If TB_COMPRASCRED.Rows(i)("SELEC") = True Then
                TxtTotalSelec.Text = Format(CDbl(TxtTotalSelec.Text) + CDbl(TB_COMPRASCRED.Rows(i)("TOTALBAS")), "#######0.00")
            End If
        Next

    End Sub

    Private Sub CargarCombos()
        CAyuda.CargarDataCombo(CboProveedor, "Nsp_sel_Proveedor2 '" & codempresa & "'", "codproveedor", "desproveedor")
    End Sub


    Private Sub FormatoGrid()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TB_COMPRASCRED.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "FECINGRESO"
            .HeaderText = "Fecha"
            .Format = "dd/MM/yyyy"
            .Width = 75
        End With

        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "TIPODOCU"
            .HeaderText = "TIPODOCU"
            .Width = 0
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "DSTIPODOC"
            .HeaderText = "Documento"
            .Width = 120
        End With
        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "NRODOCUM"
            .HeaderText = "Nro Docum"
            .Width = 75
        End With

        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "TOTALBAS"
            .HeaderText = "Importe"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = "######0.00"
        End With
        Dim Column6 As New DataGridBoolColumn
        With Column6
            .MappingName = "SELEC"
            .HeaderText = "Selec"
            ''.FalseValue = "0"
            ''.TrueValue = "1"
            .Alignment = HorizontalAlignment.Center
            .Width = 50
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5})
        TableStyle1.GridColumnStyles.AddRange(New DataGridBoolColumn() {Column6})
        DgCompCred.TableStyles.Clear()
        DgCompCred.TableStyles.Add(TableStyle1)


    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    SelecODeSelec()


            End Select
        End If
    End Function


#End Region

#Region "Variables"
    Private TB_COMPRASCRED As New DataTable


#End Region
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim VNroRefe As String


        If CDbl(TxtTotalSelec.Text) = 0 Then
            MsgBox("NO HAY FILA SELECCIONADAS...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        Dim FrmLet As New FrmIngresarLetra
        FrmLet.LblMontoTotBas.Text = TxtTotalSelec.Text
        For i As Integer = 0 To TB_COMPRASCRED.Rows.Count - 1
            If TB_COMPRASCRED.Rows(i)("SELEC") = "1" Then

                VCdTipoDoc = CStr(TB_COMPRASCRED.Rows(i)("TIPODOCU")).Trim
                VNroDoc = CStr(TB_COMPRASCRED.Rows(i)("NRODOCUM"))
                If FrmLet.VNroRefe = String.Empty Then
                    FrmLet.VNroRefe = VCdTipoDoc & "-" & VNroDoc
                Else
                    FrmLet.VNroRefe = FrmLet.VNroRefe + "," & VCdTipoDoc & "-" & VNroDoc
                End If

            End If
        Next
        FrmLet.VCodProveedor = CboProveedor.SelectedValue
        FrmLet.VDesProveedor = CboProveedor.Text
        FrmLet.ShowDialog()
        If FrmLet.DEVOLVER = False Then
            Exit Sub
        End If
        If CAyuda.Ejecutar("InsLETRACOMPRAxProc", codempresa, VCorrelInv, CodUsuario) > 1 Then
            Dim NROREFE() As String
            Dim NRODOC() As String

            VNroRefe = FrmLet.VNroRefe
            NROREFE = VNroRefe.Split(",")
            For i As Integer = 0 To NROREFE.Length - 1
                NRODOC = CStr(NROREFE.GetValue(i)).Split("-")
                For a As Integer = 0 To NRODOC.Length - 1
                    VCdTipoDoc = NRODOC.GetValue(a)
                    VNroDoc = NRODOC.GetValue(a + 1)
                    a += 1
                    CAyuda.Ejecutar("Sp_CancelarPagoxDoc", codempresa, VCdTipoDoc, VNroDoc)
                Next
            Next
            MsgBox("SE GUARDO CORRECTAMENTE LAS LETRAS...", MsgBoxStyle.Information, "")
            BTNCANCELAR_Click(sender, e)
        End If


    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub
    Private Sub FrmTransfDocA_Letras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombos()
    End Sub
    Private Sub BtnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCargar.Click
        CAyuda.Ejecutar("InsTMP_COMPRASCRED_LETRASxProc", codempresa, CboProveedor.SelectedValue, VCorrelInv)
        TB_COMPRASCRED = TmpListarDatos("ListarDocCOMPRASCREDSinLetra  '" & codempresa & "','" & VCorrelInv & "'")
        DgCompCred.DataSource = TB_COMPRASCRED
        FormatoGrid()
    End Sub
    Private Sub DgCompCred_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgCompCred.Navigate
    End Sub
    Private Sub DgCompCred_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgCompCred.DoubleClick
        SelecODeSelec()
    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        GrpProvee.Enabled = True
        BTNCANCELAR.Enabled = True
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        TB_COMPRASCRED.Rows.Clear()
        GrpProvee.Enabled = False
        BTNCANCELAR.Enabled = False


    End Sub
End Class
