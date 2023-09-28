Public Class FrmBusqComprasAProveedor
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents DtFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridCompras As System.Windows.Forms.DataGrid
    Friend WithEvents CboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboFiltrar As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridCompras = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboTipoDoc = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.DtFecFin = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtFecIni = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CboFiltrar = New System.Windows.Forms.ComboBox
        CType(Me.GridCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridCompras
        '
        Me.GridCompras.CaptionText = "                                       SELECCIONAR --> [ENTER]   O  DOBLE CLICK"
        Me.GridCompras.DataMember = ""
        Me.GridCompras.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridCompras.Location = New System.Drawing.Point(12, 148)
        Me.GridCompras.Name = "GridCompras"
        Me.GridCompras.ReadOnly = True
        Me.GridCompras.Size = New System.Drawing.Size(660, 256)
        Me.GridCompras.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDato)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CboFiltrar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 40)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(48, 10)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(138, 20)
        Me.TxtDato.TabIndex = 2
        Me.TxtDato.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Dato :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboTipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.DtFecFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtFecIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 84)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'CboTipoDoc
        '
        Me.CboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDoc.Location = New System.Drawing.Point(64, 18)
        Me.CboTipoDoc.Name = "CboTipoDoc"
        Me.CboTipoDoc.Size = New System.Drawing.Size(158, 21)
        Me.CboTipoDoc.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TipoDoc :"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(334, 48)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(82, 23)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Filtrar"
        '
        'DtFecFin
        '
        Me.DtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtFecFin.Location = New System.Drawing.Point(218, 52)
        Me.DtFecFin.Name = "DtFecFin"
        Me.DtFecFin.Size = New System.Drawing.Size(90, 20)
        Me.DtFecFin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta :"
        '
        'DtFecIni
        '
        Me.DtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtFecIni.Location = New System.Drawing.Point(64, 50)
        Me.DtFecIni.Name = "DtFecIni"
        Me.DtFecIni.Size = New System.Drawing.Size(90, 20)
        Me.DtFecIni.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Filtrar :"
        '
        'CboFiltrar
        '
        Me.CboFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFiltrar.Items.AddRange(New Object() {"Nro Movimiento", "NroDocumento", "Proveedor", "Monto"})
        Me.CboFiltrar.Location = New System.Drawing.Point(268, 14)
        Me.CboFiltrar.Name = "CboFiltrar"
        Me.CboFiltrar.Size = New System.Drawing.Size(160, 21)
        Me.CboFiltrar.TabIndex = 7
        '
        'FrmBusqComprasAProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 454)
        Me.Controls.Add(Me.GridCompras)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqComprasAProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Compras A Proveedor"
        CType(Me.GridCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Form"

    Private TAB_COMPRAS As New DataTable
    Public DEVOLVER As Boolean
    Dim rand As Integer


#End Region

#Region "Funciones Form "
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If TAB_COMPRAS.Rows.Count > 0 Then
                        If GridCompras.Focus = True Then
                            DEVOLVER = True
                            Me.Close()
                        End If
                    End If

                Case Keys.Escape
                    Me.Close()

            End Select



        End If



    End Function



    Private Sub CargarGrid()


        TmpInsertDatos("Delete from TMP_MOVIPROVEE where correl=" & rand)


        Dim meses As Integer
        meses = Val(DateDiff("m", Format(DtFecIni.Value, "dd/MM/yyyy"), DtFecFin.Value))
        Dim MesAct, Anio As String
        Dim VentaC, VentD, MoviD, MoviC As String


        For i As Integer = 0 To meses
            MesAct = Format(DateAdd("m", i, DtFecIni.Value), "MM")
            Anio = Format(DateAdd("m", i, DtFecIni.Value), "yyyy")
            VentaC = "VENTC" & Anio & MesAct
            VentD = "VENTD" & Anio & MesAct
            MoviD = "MOVID" & Anio & MesAct
            MoviC = "MOVIC" & Anio & MesAct
            If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                TmpInsertDatos("SP_ListarCOMPRASxPROVEE  '" & codempresa & "','" & IIf(IsNothing(CboTipoDoc.SelectedValue), "", CboTipoDoc.SelectedValue) & "','" & Format(CDate(DtFecIni.Value), "dd/MM/yyyy") & "' ,'" & Format(CDate(DtFecFin.Value), "dd/MM/yyyy") & "','" & MoviC & "','" & MoviD & "','1','" & rand & "'")
            End If
        Next


        TmpListarDatos("SP_ListarCOMPRASxPROVEE  '" & codempresa & "','" & IIf(IsNothing(CboTipoDoc.SelectedValue), "", CboTipoDoc.SelectedValue) & "','" & Format(CDate(DtFecIni.Value), "dd/MM/yyyy") & "' ,'" & Format(CDate(DtFecFin.Value), "dd/MM/yyyy") & "','','','0','" & rand & "'")

        TAB_COMPRAS = TmpListarDatos("SELECT *  from TMP_MOVIPROVEE where correl= '" & rand & "'  ORDER BY FECDOCUM")
        GridCompras.DataSource = TAB_COMPRAS

    End Sub

    Private Function VERIFICA_HISTORICOVENT(ByVal StrHistorico As String) As Boolean
        Try
            Dim StrSql As String
            Dim rs As New DataTable
            StrSql = " EXEC   VERIFICA_HISTORICOVENT    '" & StrHistorico & "','" & codempresa & "'"
            rs = TmpListarDatos(StrSql)

            If rs.Rows.Count = 0 Then
                VERIFICA_HISTORICOVENT = False
            Else
                VERIFICA_HISTORICOVENT = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " VERIFICA_HISTORICOVENT")
        End Try

    End Function


    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_COMPRAS.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CDALMACEN"
            .HeaderText = "Almacen"
            .NullText = ""
            .Width = 40
        End With

        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "CDTIPOMOV"
            .HeaderText = "TipoMov"
            .NullText = ""
            .Width = 40
        End With

        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "NROMOVI"
            .HeaderText = "NroMovimiento"
            .NullText = ""
            .Width = 75
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "DSTIPOMOV"
            .HeaderText = "Tipo Movimiento"
            .NullText = ""
            .Width = 150
        End With

        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "CDTIPODOC"
            .HeaderText = "CdTipoDoc"
            .NullText = ""
            .Width = 0
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "DSTIPODOC"
            .HeaderText = "Tipo Documento"
            .NullText = ""
            .Width = 150
        End With
        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "NRODOC"
            .HeaderText = "NroDocumento"
            .NullText = ""
            .Width = 75
        End With
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "FECDOCUM"
            .HeaderText = "Fecha Documento"
            .Format = "dd/MM/yyyy"
            .NullText = ""
            .Width = 75
        End With
        Dim Column9 As New DataGridTextBoxColumn
        With Column9
            .MappingName = "CDPROVEE"
            .HeaderText = "CdProveedor"
            .NullText = ""
            .Width = 0
        End With

        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "DESPROVEEDOR"
            .HeaderText = "Proveedor"
            .NullText = ""
            .Width = 150
        End With
        Dim Column11 As New DataGridTextBoxColumn
        With Column11
            .MappingName = "TOTBAS"
            .HeaderText = "Monto"
            .NullText = ""
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
            .Width = 100
        End With

        Dim Column12 As New DataGridTextBoxColumn
        With Column12
            .MappingName = "MOVICAB"
            .HeaderText = "MOVICAB"
            .NullText = ""
            .Width = 50
        End With

        Dim Column13 As New DataGridTextBoxColumn
        With Column13
            .MappingName = "MOVIDET"
            .HeaderText = "MOVIDET"
            .NullText = ""
            .Width = 50
        End With




        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13})
        GridCompras.TableStyles.Add(TableStyle1)

    End Sub


#End Region


    Private Sub FrmBusqComprasAProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValorRan()

        CAyuda.CargarDataCombo(CboTipoDoc, "ListarTIPODOC_PARA_NTACRED  '" & codempresa & "'", "CODTIPODOC", "DSTIPODOC")
        CboTipoDoc.SelectedValue = VCdTipoDoc
        DtFecIni.Value = DateAdd(DateInterval.Day, -7, Date.Now)
        CargarGrid()
        FormatoGrid()
        CboFiltrar.SelectedIndex = 0

    End Sub


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function



    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        CargarGrid()
        ' FormatoGrid()

    End Sub

   
    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged

        For i As Integer = 0 To TAB_COMPRAS.Rows.Count - 1

            Select Case CboFiltrar.SelectedIndex
                Case 0
                    If CStr(GridCompras.Item(i, 2)).Trim.Length >= TxtDato.Text.Trim.Length Then
                        If CStr(Mid(GridCompras.Item(i, 2), 1, TxtDato.Text.Trim.Length)).ToUpper = TxtDato.Text.Trim.ToUpper Then
                            GridCompras.CurrentRowIndex = i
                            Exit For
                        End If
                    End If


                Case 1
                    If CStr(GridCompras.Item(i, 6)).Trim.Length >= TxtDato.Text.Trim.Length Then
                        If CStr(Mid(GridCompras.Item(i, 6), 1, TxtDato.Text.Trim.Length)).ToUpper = TxtDato.Text.Trim.ToUpper Then
                            GridCompras.CurrentRowIndex = i
                            Exit For
                        End If
                    End If
                Case 2
                    If CStr(GridCompras.Item(i, 9)).Trim.Length >= TxtDato.Text.Trim.Length Then
                        If CStr(Mid(GridCompras.Item(i, 9), 1, TxtDato.Text.Trim.Length)).ToUpper = TxtDato.Text.Trim.ToUpper Then
                            GridCompras.CurrentRowIndex = i
                            Exit For
                        End If
                    End If
                Case 3
                    If CStr(GridCompras.Item(i, 10)).Trim.Length >= TxtDato.Text.Trim.Length Then
                        If CStr(Mid(GridCompras.Item(i, 10), 1, TxtDato.Text.Trim.Length)).ToUpper = TxtDato.Text.Trim.ToUpper Then
                            GridCompras.CurrentRowIndex = i
                            Exit For
                        End If
                    End If


            End Select
        Next



    End Sub

    Private Sub GridCompras_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridCompras.Navigate

    End Sub

    Private Sub GridCompras_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCompras.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub               
End Class
