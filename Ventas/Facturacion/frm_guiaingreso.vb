Public Class frm_guiaingreso
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
    'Friend WithEvents Mercaderia1 As mantenimiento.mercaderia
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tdoc As System.Windows.Forms.TextBox
    Friend WithEvents tmov As System.Windows.Forms.TextBox
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New System.Windows.Forms.DataGrid
        'Me.Mercaderia1 = New mantenimiento.mercaderia
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tdoc = New System.Windows.Forms.TextBox
        Me.tmov = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Mercaderia1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.DataMember = ""
        'Me.Grid1.DataSource = Me.Mercaderia1.mercaderia
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(16, 104)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(744, 408)
        Me.Grid1.TabIndex = 0
        Me.Grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Mercaderia1
        '
        'Me.Mercaderia1.DataSetName = "mercaderia"
        'Me.Mercaderia1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "mercaderia"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Nro Mov"
        Me.DataGridTextBoxColumn1.MappingName = "iditem"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nro Doc"
        Me.DataGridTextBoxColumn2.MappingName = "marca"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn3.MappingName = "fecha"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 90
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nro Doc. Referencial"
        Me.DataGridTextBoxColumn4.MappingName = "codart"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 170
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Tipo Ingreso"
        Me.DataGridTextBoxColumn5.MappingName = "bulto"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 170
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tdoc)
        Me.GroupBox1.Controls.Add(Me.tmov)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 78)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro por Documentos"
        '
        'tdoc
        '
        Me.tdoc.Location = New System.Drawing.Point(96, 48)
        Me.tdoc.Name = "tdoc"
        Me.tdoc.Size = New System.Drawing.Size(248, 21)
        Me.tdoc.TabIndex = 5
        Me.tdoc.Text = ""
        '
        'tmov
        '
        Me.tmov.Location = New System.Drawing.Point(96, 21)
        Me.tmov.Name = "tmov"
        Me.tmov.Size = New System.Drawing.Size(248, 21)
        Me.tmov.TabIndex = 4
        Me.tmov.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro Doc :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Mov :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(408, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 80)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro por Fechas"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(152, 46)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker2.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(152, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(127, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Al :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Del :"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(24, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Por rangos"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todos"
        '
        'frm_guiaingreso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(776, 518)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(782, 550)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(782, 550)
        Me.Name = "frm_guiaingreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta por Registros de Movimientos"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Mercaderia1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public vie As New frm_guiaing_otros
    Public vie2 As New frm_guiasal_otros
    Public boingresoguiaing As Boolean
    Dim p As String
    Public Mercaderia1 As New DataSet

    Private Sub frm_guiaingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llena()
    End Sub
    Sub Llena()
        Me.Mercaderia1.Clear()

        If boingresoguiaing = True Then
            If Me.RadioButton1.Checked = True Then
                p = "select c.nromovi as iditem,c.nrodoc as marca,c.fecdocum as fecha,c.nroref as codart,m.dstipomov as bulto from movicab c,tipodoc d,tipomovi m where c.cdtipodoc=d.codtipodoc and c.cdtipomov=m.cdtipomov   and c.nromovi like '" & Me.tmov.Text.Trim & "%' and c.nrodoc like '" & Me.tdoc.Text.Trim & "%' and c.inout=1 and cdalmacen = '" & Trim(vie.calmacen.SelectedValue) & "' order by c.nromovi"
            Else
                p = "select c.nromovi as iditem,c.nrodoc as marca,c.fecdocum as fecha,c.nroref as codart,m.dstipomov as bulto from movicab c,tipodoc d,tipomovi m where c.cdtipodoc=d.codtipodoc and c.cdtipomov=m.cdtipomov   and c.nromovi like '" & Me.tmov.Text.Trim & "%' and c.nrodoc like '" & Me.tdoc.Text.Trim & "%' and c.inout=1 and cdalmacen = '" & Trim(vie.calmacen.SelectedValue) & "' and c.fecdocum between '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yyyy") & "' and '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "MM/dd/yyyy") & "' order by c.nromovi"
            End If
        Else
            If Me.RadioButton1.Checked = True Then
                p = "select c.nromovi as iditem,c.nrodoc as marca,c.fecdocum as fecha,c.nroref as codart,m.dstipomov as bulto from movicab c,tipodoc d,tipomovi m where c.cdtipodoc=d.codtipodoc and c.cdtipomov=m.cdtipomov  and c.nromovi like '" & Me.tmov.Text.Trim & "%' and c.nrodoc like '" & Me.tdoc.Text.Trim & "%' and c.inout=0 and cdalmacen = '" & Trim(vie2.calmacen.SelectedValue) & "' order by c.nromovi"
            Else
                p = "select c.nromovi as iditem,c.nrodoc as marca,c.fecdocum as fecha,c.nroref as codart,m.dstipomov as bulto from movicab c,tipodoc d,tipomovi m where c.cdtipodoc=d.codtipodoc and c.cdtipomov=m.cdtipomov   and c.nromovi like '" & Me.tmov.Text.Trim & "%' and c.nrodoc like '" & Me.tdoc.Text.Trim & "%' and c.inout=0 and cdalmacen='" & Trim(vie2.calmacen.SelectedValue) & "' and c.fecdocum between '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yyyy") & "' and '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "MM/dd/yyyy") & "' order by c.nromovi"
            End If
        End If

        Conecta(p, "llena")
        oda.Fill(Me.Mercaderia1.Tables(0))
        Me.Grid1.Refresh()
    End Sub

    Private Sub tdoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdoc.KeyPress, tmov.KeyPress, DateTimePicker1.KeyPress, DateTimePicker2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Llena()
        End If
    End Sub
    Private Sub DataGrid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        Try
            Dim sql As String
            Dim PROCESO As Boolean

            Conecta("select estado from comprascred where nroingreso='" & Grid1.Item(Grid1.CurrentRowIndex, 0) & "' and nrodocum='" & Grid1.Item(Grid1.CurrentRowIndex, 1) & "' and codempresa='" & codempresa & "'", "VER")
            If ds.Tables("VER").Rows.Count > 0 Then
                If Trim(ds.Tables("VER").Rows(0)(0)).ToUpper <> "PENDIENTE" Then
                    MessageBox.Show("No puede modificar un Ingreso que tiene Nota de Crédtio ya Atendida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            TmpInsertDatos("DELETE FROM TMP_MOVIDET WHERE CDCOMPRA='" & Grid1.Item(Grid1.CurrentRowIndex, 1) & "'")

            If boingresoguiaing = True Then

                Conecta("select cdalmacen,cdtipomov,nromovi,cdprovee,cdtipodoc,nrodoc,fecdocum,tbruto,ttara,tneto,OBS,cdalmacensal,cond1,cond2,tipocred,nroimport,NROLOTE,PTOVTA,nroref,cdocref,cdmoneda,TABLA from movicab where codempresa='" & codempresa & "' and nromovi='" & Grid1.Item(Grid1.CurrentRowIndex, 0) & "' and nrodoc='" & Grid1.Item(Grid1.CurrentRowIndex, 1) & "' and inout=1", "llena")
                If ds.Tables("llena").Rows.Count > 0 Then
                    vie.ctipoprecio.SelectedValue = ds.Tables("llena").Rows(0)("cdmoneda")
                    vie.correl = Trim(ds.Tables("llena").Rows(0)(5))
                    vie.calmacen.SelectedValue = Trim(ds.Tables("llena").Rows(0)(0))
                    vie.ComboBox1.SelectedValue = Trim(ds.Tables("llena").Rows(0)(1))
                    vie.tmovimiento.Text = Trim(ds.Tables("llena").Rows(0)(2))
                    vie.tcodproveedor.Text = Trim(ds.Tables("llena").Rows(0)(3))
                    vie.ctipodoc.SelectedValue = Trim(ds.Tables("llena").Rows(0)(4))
                    vie.tdoc1.Text = Strings.Left(Trim(ds.Tables("llena").Rows(0)(5)), 3)
                    'vie.tdoc2.Text = Strings.Right("0000000000" + Strings.Right(Trim(ds.Tables("llena").Rows(0)(5)), Len(Trim(ds.Tables("llena").Rows(0)(5)) - 4)), 10)
                    vie.tdoc2.Text = Strings.Right(Trim(ds.Tables("llena").Rows(0)(5)), 7)
                    vie.dtpfecha.Value = Trim(ds.Tables("llena").Rows(0)(6))
                    vie.totbruto.Text = Trim(ds.Tables("llena").Rows(0)(7))
                    vie.tottara.Text = Trim(ds.Tables("llena").Rows(0)(8))
                    vie.totneto.Text = Trim(ds.Tables("llena").Rows(0)(9))
                    vie.TOBS.Text = Trim(ds.Tables("llena").Rows(0)(10))
                    Dim n As Integer = CInt(ds.Tables("llena").Rows(0)(21))
                    If n = 1 Then
                        vie.Destinos = True
                    Else
                        vie.Destinos = False
                    End If
                    vie.BTNGUARDAR.Enabled = False
                    vie.BTNELIMINAR.Enabled = True
                    vie.btnmodificar.Enabled = True
                    vie.llenaproveedor()
                    vie.grid1.ReadOnly = True
                    vie.Button2.Enabled = False
                    vie.CheckBox1.Enabled = False
                    vie.bomedidaing = Trim(ds.Tables("llena").Rows(0)(12))
                    vie.boumedidaing = Trim(ds.Tables("llena").Rows(0)(13))
                    vie.ctipocred.SelectedValue = Trim(ds.Tables("llena").Rows(0)(14))
                    vie.tlote.Text = Trim(ds.Tables("llena").Rows(0)(16))
                    vie.ComboBox2.SelectedValue = Trim(ds.Tables("llena").Rows(0)(17))
                    vie.TREF.Text = Strings.Right(Trim(ds.Tables("llena").Rows(0)(18)), 7)
                    vie.TxtDocRef1.Text = Strings.Left(Trim(ds.Tables("llena").Rows(0)(18)), 3)
                    'vie.TX.Text = STRINGS.Right(Trim(ds.Tables("llena").Rows(0)(18)),3)
                    vie.cboref.SelectedValue = Trim(ds.Tables("llena").Rows(0)(19))

                    If Trim(ds.Tables("llena").Rows(0)(15)) <> "" Then
                        vie.verifica()
                        vie.timportacion.Text = Trim(ds.Tables("llena").Rows(0)(15))
                        If vie.Destinos = True Then
                            Conecta("SELECT NROPEDIDO FROM PEDIDO WHERE RIGHT('000000'+CONVERT(VARCHAR(6),NROPEDIDO),6)+'/'+F1='" & vie.timportacion.Text.Trim & "'", "llena")
                            If ds.Tables("llena").Rows.Count > 0 Then
                                vie.ordenn = Trim(ds.Tables("llena").Rows(0)(0))
                            End If
                        Else
                            Conecta("select nrocompra from cabcomimp where nroimportacion='" & vie.timportacion.Text.Trim & "'", "llena")
                            If ds.Tables("llena").Rows.Count > 0 Then
                                vie.ordenn = Trim(ds.Tables("llena").Rows(0)(0))
                            End If
                        End If


                    End If
                    vie.modelo_grilla()
                End If
            Else

                Conecta("select cdalmacen,cdtipomov,nromovi,cdprovee,cdtipodoc,nrodoc,fecdocum,tbruto,ttara,tneto,OBS,cdalmacensal,tipocred,NROLOTE,PTOVTA,nroref,cdocref from movicab where codempresa='" & codempresa & "' and nromovi='" & Grid1.Item(Grid1.CurrentRowIndex, 0) & "' and nrodoc='" & Grid1.Item(Grid1.CurrentRowIndex, 1) & "' and inout=0", "llena")
                Dim dp As New DataSet
                oda.Fill(dp, "llena")
                If ds.Tables("llena").Rows.Count > 0 Then
                    vie2.calmacen.SelectedValue = Trim(dp.Tables("llena").Rows(0)(0))
                    vie2.ctipoing.SelectedValue = Trim(dp.Tables("llena").Rows(0)(1))
                    vie2.tmovimiento.Text = Trim(dp.Tables("llena").Rows(0)(2))
                    vie2.tcodproveedor.Text = Trim(dp.Tables("llena").Rows(0)(3))
                    vie2.ctipodoc.SelectedValue = Trim(dp.Tables("llena").Rows(0)(4))
                    vie2.TREF.Text = Strings.Right(Trim(dp.Tables("llena").Rows(0)(15)), 7)
                    vie2.TxtDocRef1.Text = Strings.Left(Trim(ds.Tables("llena").Rows(0)(15)), 3)
                    vie2.tdoc1.Text = Strings.Left(Trim(dp.Tables("llena").Rows(0)(5)), 3)
                    vie2.tdoc2.Text = Strings.Right(Trim(dp.Tables("llena").Rows(0)(5)), 7)
                    vie2.dtpfecha.Value = Trim(dp.Tables("llena").Rows(0)(6))
                    vie2.totbruto.Text = Trim(dp.Tables("llena").Rows(0)(7))
                    vie2.tottara.Text = Trim(dp.Tables("llena").Rows(0)(8))
                    vie2.totneto.Text = Trim(dp.Tables("llena").Rows(0)(9))
                    vie2.calmacen2.SelectedValue = Trim(dp.Tables("llena").Rows(0)(11))
                    vie2.ctipocred.SelectedValue = Trim(dp.Tables("llena").Rows(0)(12))
                    'vie2.timportacion.Text = Trim(dp.Tables("llena").Rows(0)(13))
                    vie2.ComboBox1.SelectedValue = Trim(dp.Tables("llena").Rows(0)(14))
                    'vie2.TREF.Text = Trim(dp.Tables("llena").Rows(0)(15))
                    vie2.cboref.SelectedValue = Trim(dp.Tables("llena").Rows(0)(16))

                    vie2.BTNGUARDAR.Enabled = False
                    vie2.BTNELIMINAR.Enabled = True
                    vie2.btnmodificar.Enabled = True
                    vie2.llenaproveedor()
                    vie2.grid1.ReadOnly = True
                End If
            End If


            If boingresoguiaing = True Then
                vie.correl = Trim(ds.Tables("llena").Rows(0)(5))

                If Trim(vie.ComboBox1.SelectedValue) = "ICRED" Then
                    Dim pa As String, po As Integer
                    pa = CType(Strings.Left(Trim(Grid1.Item(Grid1.CurrentRowIndex, 1)), 3), String) + CType(Strings.Right("0000000" + CType(Trim(Grid1.Item(Grid1.CurrentRowIndex, 1)), String), 7), String)
                    po = pa
                    Conecta("nsp_select_nta_credito '" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','','" & po & "',0", "llena")

                    If ds.Tables("LLENA").Rows.Count > 0 Then
                        vie.ctipodoc.SelectedValue = Trim(ds.Tables("LLENA").Rows(0)(0))
                        vie.ctipoprecio.SelectedValue = Trim(ds.Tables("LLENA").Rows(0)(4))
                        vie.txtcambio.Text = Trim(ds.Tables("LLENA").Rows(0)(5))

                        If vie.bomedidaing = True And vie.boumedidaing = False Then
                            'vie.Ds_diferencia_de_reportes1.Clear()
                            Conecta("NSP_SELECT_NTACRED '" & codempresa & "','" & Trim(ds.Tables("LLENA").Rows(0)(2)) & "',0", "LLENA")
                            'oda.Fill(vie.Ds_diferencia_de_reportes1)
                            vie.grid1.Refresh()
                        ElseIf vie.bomedidaing = False And vie.boumedidaing = True Then

                            'vie.DsInventInicial1.Clear()
                            Conecta("NSP_SELECT_NTACRED '" & codempresa & "','" & Trim(ds.Tables("LLENA").Rows(0)(2)) & "',1", "LLENA")
                            'oda.Fill(vie.DsInventInicial1.ds_inventini)
                            vie.grid1.Refresh()
                        ElseIf vie.bomedidaing = True And vie.boumedidaing = True Then

                            'vie.Ds_diferencia_de_reportes1.Clear()
                            Conecta("NSP_SELECT_NTACRED '" & codempresa & "','" & Trim(ds.Tables("LLENA").Rows(0)(2)) & "',0", "LLENA")
                            'oda.Fill(vie.Ds_diferencia_de_reportes1.Dsdifreporte)
                            vie.grid1.Refresh()
                        End If
                    End If

                Else
                    sql = "NSP_ins_movidet_ATEMP '" & Trim(ds.Tables("llena").Rows(0)(5)) & "','" & codempresa & "',1,'" & CodUsuario.Trim & "','" & NROPTOVTA & "'"
                    PROCESO = TmpInsertDatos(sql)
                    TmpInsertDatos("delete from tmp_SALD_IMPORTACION_2 WHERE CDALMACEN='" & vie.calmacen.SelectedValue.ToString & "' AND NROPTOVTA='" & vie.ComboBox2.SelectedValue.ToString & "' AND NROMOV='" & vie.tmovimiento.Text.Trim & "'")
                    TmpInsertDatos("nsp_insert_temp_modificar_saldo_imp 0,'" & vie.calmacen.SelectedValue.ToString & "','" & vie.ComboBox2.SelectedValue.ToString & "','" & Format(Microsoft.VisualBasic.DateValue(vie.dtpfecha.Value), "MM/dd/yyyy") & "','" & vie.tmovimiento.Text.Trim & "'")
                    vie.cargagrilla()

                End If

            Else
                vie2.correl = Trim(ds.Tables("llena").Rows(0)(5))
                sql = "NSP_ins_movidet_ATEMP_lote '" & Trim(ds.Tables("llena").Rows(0)(5)) & "','" & codempresa & "',0," & vie2.tmovimiento.Text.Trim & ",'" & Trim(vie2.ctipoing.SelectedValue.ToString()) & "','" & CodUsuario.Trim & "','" & NROPTOVTA & "'"
                PROCESO = TmpInsertDatos(sql)
                vie2.cargagrilla()
            End If

            Me.Close()

        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
        Else
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = True
        End If
    End Sub


End Class
