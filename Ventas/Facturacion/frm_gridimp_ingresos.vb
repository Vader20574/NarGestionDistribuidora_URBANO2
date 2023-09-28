Public Class frm_gridimp_ingresos
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents dtfa As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfs As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tnroimportacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tnrocompra As System.Windows.Forms.TextBox
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    'Friend WithEvents Dsreporte1 As mantenimiento.dsreporte
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.dtfa = New System.Windows.Forms.DateTimePicker
        Me.dtfs = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tproveedor = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tnroimportacion = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tnrocompra = New System.Windows.Forms.TextBox
        Me.grid1 = New System.Windows.Forms.DataGrid
        'Me.Dsreporte1 = New mantenimiento.dsreporte
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Dsreporte1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.dtfa)
        Me.GroupBox3.Controls.Add(Me.dtfs)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(356, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 84)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtro por Fechas"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(16, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.Text = "Por Fechas"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todos"
        '
        'dtfa
        '
        Me.dtfa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfa.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtfa.Location = New System.Drawing.Point(152, 26)
        Me.dtfa.Name = "dtfa"
        Me.dtfa.Size = New System.Drawing.Size(88, 21)
        Me.dtfa.TabIndex = 6
        '
        'dtfs
        '
        Me.dtfs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfs.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtfs.Location = New System.Drawing.Point(152, 50)
        Me.dtfs.Name = "dtfs"
        Me.dtfs.Size = New System.Drawing.Size(88, 21)
        Me.dtfs.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Desde :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Hasta :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tproveedor)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tnroimportacion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tnrocompra)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 104)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de Filtro"
        '
        'tproveedor
        '
        Me.tproveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tproveedor.Location = New System.Drawing.Point(112, 71)
        Me.tproveedor.Name = "tproveedor"
        Me.tproveedor.Size = New System.Drawing.Size(208, 21)
        Me.tproveedor.TabIndex = 15
        Me.tproveedor.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Proveedor  :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tnroimportacion
        '
        Me.tnroimportacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnroimportacion.Location = New System.Drawing.Point(112, 46)
        Me.tnroimportacion.Name = "tnroimportacion"
        Me.tnroimportacion.Size = New System.Drawing.Size(128, 21)
        Me.tnroimportacion.TabIndex = 13
        Me.tnroimportacion.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nro Importación :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nro Orden :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tnrocompra
        '
        Me.tnrocompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnrocompra.Location = New System.Drawing.Point(112, 21)
        Me.tnrocompra.Name = "tnrocompra"
        Me.tnrocompra.Size = New System.Drawing.Size(128, 21)
        Me.tnrocompra.TabIndex = 11
        Me.tnrocompra.Text = ""
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid1.DataMember = ""
        'Me.grid1.DataSource = Me.Dsreporte1.reporte
        Me.grid1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(12, 122)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(736, 288)
        Me.grid1.TabIndex = 29
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Dsreporte1
        '
        'Me.Dsreporte1.DataSetName = "dsreporte"
        'Me.Dsreporte1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "reporte"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Nro Orden"
        Me.DataGridTextBoxColumn1.MappingName = "nrocompra"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nro Importación"
        Me.DataGridTextBoxColumn2.MappingName = "nroimportacion"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 130
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn3.MappingName = "fechaorden"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 85
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Proveedor"
        Me.DataGridTextBoxColumn4.MappingName = "desproveedor"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 280
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Origen"
        Me.DataGridTextBoxColumn5.MappingName = "origen"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'frm_gridimp_ingresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(762, 416)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grid1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(768, 448)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(768, 448)
        Me.Name = "frm_gridimp_ingresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Importaciones Transferidas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Dsreporte1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public vie As New frm_guiaing_otros
    'Public oIng As New FrmIngreso_Inventario
    Dim incpeso, incbulto As Double
    'Dim ClsInter As New ClsInterface
    Private Sub FrmBusquedaCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conecta("select porincpeso,incbulto from configinv where codempresa='" & CodEmpresa & "'", "llena")
        If ds.Tables("llena").Rows.Count > 0 Then
            incpeso = ds.Tables("llena").Rows(0)(0)
            incbulto = ds.Tables("llena").Rows(0)(1)
        End If
        Call Llena()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.dtfa.Enabled = False
            Me.dtfs.Enabled = False
        Else
            Me.dtfa.Enabled = True
            Me.dtfs.Enabled = True
        End If
    End Sub
    Private Sub tnrocompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnrocompra.KeyPress, tnroimportacion.KeyPress, tproveedor.KeyPress, dtfa.KeyPress, dtfs.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Llena()
        End If
    End Sub
    Sub Llena()
        Try
            'Me.Dsreporte1.Clear()

            If vie.CheckBox1.Text.Trim = "Con Importación" Then
                If Me.RadioButton1.Checked = True Then
                    Conecta("nsp_cons_ing_local_importacion 0,'01','" & codempresa & "','" & Me.tnrocompra.Text & "','" & Me.tnroimportacion.Text & "','" & Me.tproveedor.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtfa.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtfs.Value), "MM/dd/yy") & "'," & incpeso & "," & incbulto & "", "llena")
                Else
                    Conecta("nsp_cons_ing_local_importacion 1,'01','" & codempresa & "','" & Me.tnrocompra.Text & "','" & Me.tnroimportacion.Text & "','" & Me.tproveedor.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtfa.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtfs.Value), "MM/dd/yy") & "'," & incpeso & "," & incbulto & "", "llena")
                End If

                DataGridTextBoxColumn2.HeaderText = "Nro Importación"
            Else
                If Me.RadioButton1.Checked = True Then
                    Conecta("nsp_cons_ing_local_importacion 2,'02','" & codempresa & "','" & Me.tnrocompra.Text & "','" & Me.tnroimportacion.Text & "','" & Me.tproveedor.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtfa.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtfs.Value), "MM/dd/yy") & "'," & incpeso & "," & incbulto & "", "llena")
                Else
                    Conecta("nsp_cons_ing_local_importacion 3,'02','" & codempresa & "','" & Me.tnrocompra.Text & "','" & Me.tnroimportacion.Text & "','" & Me.tproveedor.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtfa.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtfs.Value), "MM/dd/yy") & "'," & incpeso & "," & incbulto & "", "llena")
                End If
                DataGridTextBoxColumn2.HeaderText = "Nro Compra Local"
            End If

            'oda.Fill(Me.Dsreporte1.reporte)
            Me.grid1.Refresh()
            'ocn.Close()

        Catch x As Exception
            'MsgBox(x.Message)
            'MessageBox.Show("Falta configurar la fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub Llenagrid()
        conecta("select codproveedor,detcomimp.nroimportacion from cabcomimp INNER JOIN detcomimp on cabcomimp.NROCOMPRA= detcomimp.NROCOMPRA where  cabcomimp.nrocompra='" & grid1.Item(grid1.CurrentRowIndex, 0) & "' and detcomimp.nroimportacion='" & grid1.Item(grid1.CurrentRowIndex, 1) & "'", "llena")
        Dim ds1 As New DataSet
        oda.Fill(ds1, "llena")

        If ds1.Tables("llena").Rows.Count > 0 Then
            vie.tcodproveedor.Text = Trim(ds.Tables("llena").Rows(0)(0))
            vie.timportacion.Text = Trim(ds.Tables("llena").Rows(0)(1))
            vie.llenaproveedor()
        End If
        Me.Close()
    End Sub
    Sub otraLlenagrid()
        Conecta("Select PEDIDO.codprove,RIGHT('000000' + CAST(pediDO.NROPEDIDO AS VARCHAR(6)),6)+'/'+pediDO.F1 from pedido , pedi_pro where pedido.nropedido= pedi_pro.nropedido and RIGHT('000000'+CAST(pediDO.NROPEDIDO AS VARCHAR(6)),6)+'/'+pediDO.F1='" & grid1.Item(grid1.CurrentRowIndex, 0) & "' and RIGHT('000000'+CAST(pediDO.NROPEDIDO AS VARCHAR(6)),6)+'/'+pEDIDO.F1 ='" & grid1.Item(grid1.CurrentRowIndex, 1) & "'", "llena")
        Dim ds1 As New DataSet
        oda.Fill(ds1, "llena")

        If ds1.Tables("llena").Rows.Count > 0 Then
            vie.tcodproveedor.Text = Trim(ds.Tables("llena").Rows(0)(0))
            vie.timportacion.Text = Trim(ds.Tables("llena").Rows(0)(1))
            vie.llenaproveedor()
        End If
        Me.Close()
    End Sub
    Dim Selec As String
    Dim origen As String
    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        Try
            Selec = grid1.Item(grid1.CurrentRowIndex, 0)
            If vie.CheckBox1.Text.Trim = "Con Importación" Then
                origen = ""
            Else
                origen = grid1.Item(grid1.CurrentRowIndex, 4)
                vie.OrgMerca = grid1.Item(grid1.CurrentRowIndex, 4)
                vie.Destinos = True
            End If


            'Dim CTCOLUN, CTROWS As Integer

            'CTCOLUN = ClsInter.ListarDatos("USP_BUSCAR_NROCOMPRA", Selec).Tables(0).Columns.Count()
            'CTROWS = ClsInter.ListarDatos("USP_BUSCAR_NROCOMPRA", Selec).Tables(0).Rows.Count
            If origen = "PEDIDO" Then
                'TipoCompra = ClsInter.ListarDatos("USP_BUSCAR_NROCOMPRA2", Selec).Tables(0).Rows(0).Item("NROPEDIDO")
                vie.Destinos = True
                Call otraLlenagrid()

            Else
                'TipoCompra = ClsInter.ListarDatos("USP_BUSCAR_NROCOMPRA", Selec).Tables(0).Rows(0).Item("CODTIPOCOMPRA")
                vie.Destinos = False
                Call Llenagrid()
            End If
            'TipoCompra = ClsInter.ListarDatos("USP_BUSCAR_NROCOMPRA", Selec).Tables(0).Rows(0).Item("CODTIPOCOMPRA")
            vie.ordenn = grid1.Item(grid1.CurrentRowIndex, 0)

            'If oIng.Label7.Text = "Nro de Importacion :" Then
            '    oIng.TxtNroImp.Text = grid1.Item(grid1.CurrentRowIndex, 1)
            'Else
            '    oIng.TxtNroImp.Text = grid1.Item(grid1.CurrentRowIndex, 0)
            'End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
