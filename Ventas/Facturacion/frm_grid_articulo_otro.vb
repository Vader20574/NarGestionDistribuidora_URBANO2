Public Class frm_grid_articulo_otro
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
    Friend WithEvents tarticulo As System.Windows.Forms.TextBox
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    'Friend WithEvents Ds_detimportacion1 As mantenimiento.ds_detimportacion
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tmarca As System.Windows.Forms.TextBox
    Friend WithEvents tumedida As System.Windows.Forms.TextBox
    Friend WithEvents tmedida As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tarticulo = New System.Windows.Forms.TextBox
        Me.tcodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grid1 = New System.Windows.Forms.DataGrid
        'Me.Ds_detimportacion1 = New mantenimiento.ds_detimportacion
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tmarca = New System.Windows.Forms.TextBox
        Me.tumedida = New System.Windows.Forms.TextBox
        Me.tmedida = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Ds_detimportacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tarticulo)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(188, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 40)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'tarticulo
        '
        Me.tarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tarticulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarticulo.Location = New System.Drawing.Point(8, 13)
        Me.tarticulo.Name = "tarticulo"
        Me.tarticulo.Size = New System.Drawing.Size(684, 20)
        Me.tarticulo.TabIndex = 4
        Me.tarticulo.Text = ""
        '
        'tcodigo
        '
        Me.tcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcodigo.Location = New System.Drawing.Point(8, 13)
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(160, 20)
        Me.tcodigo.TabIndex = 3
        Me.tcodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese Articulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Codigo :"
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grid1.CaptionVisible = False
        Me.grid1.DataMember = ""
        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones
        Me.grid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(8, 64)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(880, 322)
        Me.grid1.TabIndex = 7
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Ds_detimportacion1
        '
        'Me.Ds_detimportacion1.DataSetName = "ds_detimportacion"
        'Me.Ds_detimportacion1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "importaciones"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "codigo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 85
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Artículo"
        Me.DataGridTextBoxColumn2.MappingName = "descripcion"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 245
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Medida"
        Me.DataGridTextBoxColumn3.MappingName = "medida"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Marca"
        Me.DataGridTextBoxColumn4.MappingName = "marca"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 115
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
        Me.DataGridTextBoxColumn5.MappingName = "umedida"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 30
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Costo ."
        Me.DataGridTextBoxColumn6.MappingName = "subtotal"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 70
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Mon"
        Me.DataGridTextBoxColumn7.MappingName = "mon"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 35
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Lote"
        Me.DataGridTextBoxColumn8.MappingName = "nrodoc"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 60
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Nro Import/Compra"
        Me.DataGridTextBoxColumn9.MappingName = "caract"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 110
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 40)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'tmarca
        '
        Me.tmarca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmarca.Location = New System.Drawing.Point(40, 416)
        Me.tmarca.Name = "tmarca"
        Me.tmarca.Size = New System.Drawing.Size(160, 20)
        Me.tmarca.TabIndex = 4
        Me.tmarca.Text = ""
        '
        'tumedida
        '
        Me.tumedida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tumedida.Location = New System.Drawing.Point(208, 416)
        Me.tumedida.Name = "tumedida"
        Me.tumedida.Size = New System.Drawing.Size(160, 20)
        Me.tumedida.TabIndex = 9
        Me.tumedida.Text = ""
        '
        'tmedida
        '
        Me.tmedida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmedida.Location = New System.Drawing.Point(376, 416)
        Me.tmedida.Name = "tmedida"
        Me.tmedida.Size = New System.Drawing.Size(160, 20)
        Me.tmedida.TabIndex = 10
        Me.tmedida.Text = ""
        '
        'frm_grid_articulo_otro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(898, 400)
        Me.Controls.Add(Me.tmedida)
        Me.Controls.Add(Me.tumedida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tmarca)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(904, 432)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(904, 432)
        Me.Name = "frm_grid_articulo_otro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Articulos de Ingreso de Mercaderia"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Ds_detimportacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public vie As New frm_guiaing_otros
    Public vie2 As New frm_guiasal_otros
    'Public vie3 As New frm_inventario_inicial_copia
    Public boingresoart As Boolean, incpeso, incbulto As Double
    'Public ObjIng As New FrmIngreso_Inventario
    Private Sub frm_gridclie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If boingresoart = True Then
            Conecta("select medida,umedida,porincpeso,incbulto from configinv where codempresa='" & codempresa & "'", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                vie.bomedidaing = ds.Tables("llena").Rows(0)(0)
                vie.boumedidaing = ds.Tables("llena").Rows(0)(1)
                incpeso = ds.Tables("llena").Rows(0)(2)
                incbulto = ds.Tables("llena").Rows(0)(3)
            Else
                MessageBox.Show("No tiene configurado las Ventas por Medida y UMedida en la Configuración de Inventarios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            Conecta("select medida,umedida,porincpeso,incbulto from configinv where codempresa='" & codempresa & "'", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                vie2.a1 = ds.Tables("llena").Rows(0)(0)
                vie2.a2 = ds.Tables("llena").Rows(0)(1)
                incpeso = ds.Tables("llena").Rows(0)(2)
                incbulto = ds.Tables("llena").Rows(0)(3)
            Else
                MessageBox.Show("No tiene configurado las Ventas por Medida y UMedida en la Configuración de Inventarios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        cargadatos()
        tarticulo.Focus()
    End Sub
    Sub cargadatos()
        Dim sql4 As String
        Try
            'Me.Ds_detimportacion1.Clear()

            If boingresoart = True Then

                If vie.Button2.Enabled = False Then
                    Me.DataGridTextBoxColumn9.Width = 115
                    Me.DataGridTextBoxColumn9.HeaderText = "Nro Import/Compra"
                Else
                    Me.DataGridTextBoxColumn9.Width = 0
                    Me.DataGridTextBoxColumn9.HeaderText = ""
                End If

                If vie.valorizado = True Then
                    Me.DataGridTextBoxColumn6.Width = 85
                    Me.DataGridTextBoxColumn6.HeaderText = "Costo"
                    Me.DataGridTextBoxColumn7.HeaderText = "Mon"
                    Me.DataGridTextBoxColumn7.Width = 45
                Else
                    Me.DataGridTextBoxColumn6.Width = 0
                    Me.DataGridTextBoxColumn6.HeaderText = ""
                    Me.DataGridTextBoxColumn7.HeaderText = ""
                    Me.DataGridTextBoxColumn7.Width = 0
                End If


                If vie.forma = 0 Then

                    If vie.bomedidaing = True And vie.boumedidaing = False Then
                        Dim sql2 As String = "Nsp_sel_articulo_medida_umedida_ING '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',0,'" & vie.tcodproveedor.Text.Trim & "','" & vie.calmacen.SelectedValue.ToString & "',0,''," & incpeso & "," & incbulto & ",'" & tumedida.Text.Trim.ToUpper & "'"
                        Conecta(sql2, "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones
                        'lumedida.Visible = False
                        'tumedida.Visible = False
                        'lmedida.Visible = True
                        'tmedida.Visible = True
                        Me.DataGridTextBoxColumn5.Width = 0
                        Me.DataGridTextBoxColumn5.HeaderText = ""
                        Me.DataGridTextBoxColumn3.HeaderText = "Medida"
                        Me.DataGridTextBoxColumn3.Width = 130


                    ElseIf vie.bomedidaing = False And vie.boumedidaing = True Then
                        Dim sql3 As String = "Nsp_sel_articulo_medida_umedida_ING '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',1,'" & vie.tcodproveedor.Text.Trim & "','" & vie.calmacen.SelectedValue.ToString & "',0,''," & incpeso & "," & incbulto & ",'" & tumedida.Text.Trim.ToUpper & "'"
                        Conecta(sql3, "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones
                        'lumedida.Visible = True
                        'tumedida.Visible = True
                        'lmedida.Visible = False
                        'tmedida.Visible = False
                        Me.DataGridTextBoxColumn3.Width = 0
                        Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                        Me.DataGridTextBoxColumn3.HeaderText = ""
                        Me.DataGridTextBoxColumn5.Width = 50

                    ElseIf vie.bomedidaing = True And vie.boumedidaing = True Then
                        If Trim(vie.ComboBox1.SelectedValue).Trim.ToString = "09" Then
                            sql4 = "Nsp_sel_articulo_medida_umedida_ING_Por_Lote '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',2,'" & vie.tcodproveedor.Text.Trim & "','" & vie.calmacen.SelectedValue.ToString & "',3,'" & IIf(Len(vie.timportacion.Text.Trim) = 0, 0, vie.timportacion.Text.Trim) & "'," & incpeso & "," & incbulto & ",'" & tumedida.Text.Trim.ToUpper & "','" & vie.tlote.Text.Trim & "'"
                        Else
                            sql4 = "Nsp_sel_articulo_medida_umedida_ING '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',2,'" & vie.tcodproveedor.Text.Trim & "','" & vie.calmacen.SelectedValue.ToString & "',3,'" & IIf(Len(vie.timportacion.Text.Trim) = 0, 0, vie.timportacion.Text.Trim) & "'," & incpeso & "," & incbulto & ",'" & tumedida.Text.Trim.ToUpper & "'"
                        End If
                        'Dim sql4 As String = "Nsp_sel_articulo_medida_umedida_ING '" & CodEmpresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',2,'" & vie.tcodproveedor.Text.Trim & "','" & vie.calmacen.SelectedValue.ToString & "',3,'" & IIf(Len(vie.timportacion.Text.Trim) = 0, 0, vie.timportacion.Text.Trim) & "'," & incpeso & "," & incbulto & ",'" & tumedida.Text.Trim.ToUpper & "'"
                        Conecta(sql4, "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        ''Me.Ds_detimportacion1.importaciones.DefaultView.RowFilter = vie.tlote.Text.Trim
                        '
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones

                        'lumedida.Visible = True
                        'tumedida.Visible = True
                        'lmedida.Visible = True
                        'tmedida.Visible = True
                        Me.DataGridTextBoxColumn3.Width = 50
                        Me.DataGridTextBoxColumn5.Width = 50
                        Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                        Me.DataGridTextBoxColumn3.HeaderText = "Medida"
                    End If

                ElseIf vie.forma = 1 Then

                    Conecta("Nsp_sel_articulo_medida_umedida_ING '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',2,'" & vie.tcodproveedor.Text.Trim & "','" & vie.calmacen.SelectedValue.ToString & "',2," & Val(Strings.Left(vie.timportacion.Text.Trim, 6) + Strings.Right(vie.timportacion.Text.Trim, 4)) & "," & incpeso & "," & incbulto & ",'" & tumedida.Text.Trim.ToUpper & "'", "pa")
                    'conecta("nsp_select_ingreso_art_importacion '" & CodEmpresa & "'," & Val(Strings.Left(vie.timportacion.Text.Trim, 6) + Strings.Right(vie.timportacion.Text.Trim, 4)) & "", "pa")
                    'oda.Fill(Me.Ds_detimportacion1.importaciones)
                    'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones
                    'lumedida.Visible = True
                    'tumedida.Visible = True
                    'lmedida.Visible = True
                    'tmedida.Visible = True
                    Me.DataGridTextBoxColumn3.Width = 50
                    Me.DataGridTextBoxColumn5.Width = 50
                    Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                    Me.DataGridTextBoxColumn3.HeaderText = "Medida"

                ElseIf vie.forma = 2 Then

                    If vie.bomedidaing = True And vie.boumedidaing = False Then

                        Conecta("Nsp_sel_articulo_medida_umedida_ING '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',0,'" & vie.tcodproveedor.Text.Trim & "','" & vie.calmacen.SelectedValue.ToString & "',1,''," & incpeso & "," & incbulto & ",'" & tumedida.Text.Trim.ToUpper & "'", "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones
                        'lumedida.Visible = False
                        'tumedida.Visible = False
                        'lmedida.Visible = True
                        'tmedida.Visible = True
                        Me.DataGridTextBoxColumn5.Width = 0
                        Me.DataGridTextBoxColumn5.HeaderText = ""
                        Me.DataGridTextBoxColumn3.HeaderText = "Medida"
                        Me.DataGridTextBoxColumn3.Width = 50

                    ElseIf vie.bomedidaing = False And vie.boumedidaing = True Then

                        Conecta("Nsp_sel_articulo_medida_umedida_ING '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',1,'" & vie.tcodproveedor.Text.Trim & "','" & vie.calmacen.SelectedValue.ToString & "',1,''," & incpeso & "," & incbulto & ",'" & tumedida.Text.Trim.ToUpper & "'", "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones
                        'lumedida.Visible = True
                        'tumedida.Visible = True
                        'lmedida.Visible = False
                        'tmedida.Visible = False
                        Me.DataGridTextBoxColumn3.Width = 0
                        Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                        Me.DataGridTextBoxColumn3.HeaderText = ""
                        Me.DataGridTextBoxColumn5.Width = 50

                    ElseIf vie.bomedidaing = True And vie.boumedidaing = True Then
                        Conecta("Nsp_sel_articulo_medida_umedida_ING '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',2,'" & vie.tcodproveedor.Text.Trim & "','" & vie.calmacen.SelectedValue.ToString & "',1,''," & incpeso & "," & incbulto & ",'" & tumedida.Text.Trim.ToUpper & "'", "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones
                        'lumedida.Visible = True
                        'tumedida.Visible = True
                        'lmedida.Visible = True
                        'tmedida.Visible = True
                        Me.DataGridTextBoxColumn3.Width = 50
                        Me.DataGridTextBoxColumn5.Width = 50
                        Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                        Me.DataGridTextBoxColumn3.HeaderText = "Medida"
                    End If
                End If

            Else
                If vie2.valorizado = True Then
                    Me.DataGridTextBoxColumn6.Width = 85
                    Me.DataGridTextBoxColumn6.HeaderText = "Costo"
                    Me.DataGridTextBoxColumn7.HeaderText = "Mon"
                    Me.DataGridTextBoxColumn7.Width = 45
                Else
                    Me.DataGridTextBoxColumn6.Width = 0
                    Me.DataGridTextBoxColumn6.HeaderText = ""
                    Me.DataGridTextBoxColumn7.HeaderText = ""
                    Me.DataGridTextBoxColumn7.Width = 0
                End If

                If vie2.forma = 0 Then

                    If vie2.a1 = True And vie2.a2 = False Then

                        Conecta("Nsp_sel_articulo_medida_umedida_lote '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',0,'" & vie2.tcodproveedor.Text.Trim & "','" & vie2.calmacen.SelectedValue.ToString & "',0,'" & vie2.tlote.Text.Trim.ToUpper & "','" & tumedida.Text.Trim.ToUpper & "'", "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones

                        'lumedida.Visible = False
                        'tumedida.Visible = False
                        'lmedida.Visible = True
                        'tmedida.Visible = True
                        Me.DataGridTextBoxColumn5.Width = 0
                        Me.DataGridTextBoxColumn5.HeaderText = ""
                        Me.DataGridTextBoxColumn3.HeaderText = "Medida"
                        Me.DataGridTextBoxColumn3.Width = 50

                    ElseIf vie2.a1 = False And vie2.a2 = True Then

                        Conecta("Nsp_sel_articulo_medida_umedida_lote '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',1,'" & vie2.tcodproveedor.Text.Trim & "','" & vie2.calmacen.SelectedValue.ToString & "',0,'" & vie2.tlote.Text.Trim.ToUpper & "','" & tumedida.Text.Trim.ToUpper & "'", "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones

                        'lumedida.Visible = True
                        'tumedida.Visible = True
                        'lmedida.Visible = False
                        'tmedida.Visible = False
                        Me.DataGridTextBoxColumn3.Width = 0
                        Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                        Me.DataGridTextBoxColumn3.HeaderText = ""
                        Me.DataGridTextBoxColumn5.Width = 50

                    ElseIf vie2.a1 = True And vie2.a2 = True Then

                        Conecta("Nsp_sel_articulo_medida_umedida_lote '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',2,'" & vie2.tcodproveedor.Text.Trim & "','" & vie2.calmacen.SelectedValue.ToString & "',0,'" & vie2.tlote.Text.Trim.ToUpper & "','" & tumedida.Text.Trim.ToUpper & "'", "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones
                        Me.DataGridTextBoxColumn3.Width = 50
                        Me.DataGridTextBoxColumn5.Width = 50
                        Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                        Me.DataGridTextBoxColumn3.HeaderText = "Medida"
                    End If

                ElseIf vie2.forma = 1 Then

                    Conecta("Nsp_sel_articulo_medida_umedida_lote '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',2,'" & vie2.tcodproveedor.Text.Trim & "','" & vie2.calmacen.SelectedValue.ToString & "',2,'" & vie2.tlote.Text.Trim.ToUpper & "','" & tumedida.Text.Trim.ToUpper & "'", "pa")
                    'oda.Fill(Me.Ds_detimportacion1.importaciones)
                    'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones

                    'lumedida.Visible = True
                    'tumedida.Visible = True
                    'lmedida.Visible = True
                    'tmedida.Visible = True
                    Me.DataGridTextBoxColumn3.Width = 50
                    Me.DataGridTextBoxColumn5.Width = 50
                    Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                    Me.DataGridTextBoxColumn3.HeaderText = "Medida"

                ElseIf vie2.forma = 2 Then

                    If vie2.a1 = True And vie2.a2 = False Then

                        Conecta("Nsp_sel_articulo_medida_umedida_lote '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',0,'" & vie2.tcodproveedor.Text.Trim & "','" & vie2.calmacen.SelectedValue.ToString & "',1,'" & vie2.tmovimiento.Text.Trim.ToUpper & "','" & tumedida.Text.Trim.ToUpper & "'", "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones

                        'lumedida.Visible = False
                        'tumedida.Visible = False
                        'lmedida.Visible = True
                        'tmedida.Visible = True
                        Me.DataGridTextBoxColumn5.Width = 0
                        Me.DataGridTextBoxColumn5.HeaderText = ""
                        Me.DataGridTextBoxColumn3.HeaderText = "Medida"
                        Me.DataGridTextBoxColumn3.Width = 130


                    ElseIf vie2.a1 = False And vie2.a2 = True Then

                        Conecta("Nsp_sel_articulo_medida_umedida_lote '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',1,'" & vie2.tcodproveedor.Text.Trim & "','" & vie2.calmacen.SelectedValue.ToString & "',1,'" & vie2.tmovimiento.Text.Trim.ToUpper & "','" & tumedida.Text.Trim.ToUpper & "'", "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones

                        'lumedida.Visible = True
                        'tumedida.Visible = True
                        'lmedida.Visible = False
                        'tmedida.Visible = False
                        Me.DataGridTextBoxColumn3.Width = 0
                        Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                        Me.DataGridTextBoxColumn3.HeaderText = ""
                        Me.DataGridTextBoxColumn5.Width = 50

                    ElseIf vie2.a1 = True And vie2.a2 = True Then

                        Conecta("Nsp_sel_articulo_medida_umedida_lote '" & codempresa & "','" & Me.tcodigo.Text.Trim & "','" & Me.tarticulo.Text.Trim & "','" & Me.tmarca.Text.Trim & "','" & Me.tmedida.Text.Trim & "','" & Me.tumedida.Text & "',2,'" & vie2.tcodproveedor.Text.Trim & "','" & vie2.calmacen.SelectedValue.ToString & "',1,'" & vie2.tlote.Text.Trim.ToUpper & "','" & tumedida.Text.Trim.ToUpper & "'", "pa")
                        'oda.Fill(Me.Ds_detimportacion1.importaciones)
                        'Me.grid1.DataSource = Me.Ds_detimportacion1.importaciones

                        'lumedida.Visible = True
                        'tumedida.Visible = True
                        'lmedida.Visible = True
                        'tmedida.Visible = True
                        Me.DataGridTextBoxColumn3.Width = 50
                        Me.DataGridTextBoxColumn5.Width = 50
                        Me.DataGridTextBoxColumn5.HeaderText = "UMedida"
                        Me.DataGridTextBoxColumn3.HeaderText = "Medida"
                    End If
                End If
            End If

        Catch x As Exception
            MsgBox(x.Message)
        End Try
    End Sub
    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        pasadatos()
    End Sub
    Public IGV As Double
    Sub pasadatos()
        Try
            If boingresoart = True Then

                vie.tumedida.Items.Clear()
                vie.arrmedidaing.Clear()
                vie.timports.Text = grid1.Item(grid1.CurrentRowIndex, 7)
                vie.timport2.Text = grid1.Item(grid1.CurrentRowIndex, 8)
                vie.Nro_Importacion = Mid(grid1.Item(grid1.CurrentRowIndex, 8), 3, 3)
                'vie.Nro_Importacion = vie.Nro_Importacion + CStr(Date.Now.Year.ToString)
                'MsgBox(vie.Nro_Importacion.ToString)
                If vie.bomedidaing = True And vie.boumedidaing = False Then

                    Conecta("Nsp_sel_click_articulo_medida_umedida '" & codempresa & "','" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "pa")

                    vie.tarticulo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                    vie.txtdesarticulo.Text = Trim(ds.Tables("pa").Rows(0)(1))
                    vie.arrmedidaing.Add(Trim(ds.Tables("pa").Rows(0)(2)))

                    vie.tmarca.Text = Trim(ds.Tables("pa").Rows(0)(3))
                    vie.strmarcaing = Trim(ds.Tables("pa").Rows(0)(4))
                    vie.ttara.Text = Trim(ds.Tables("pa").Rows(0)(5))
                    vie.strtaraimp = Trim(ds.Tables("pa").Rows(0)(5))
                    vie.tumedida.Items.Add(ds.Tables("pa").Rows(0)(6))
                    'vie2.codmed = Trim(ds.Tables("pa").Rows(0)(8).ToString())
                    vie.txtcantidad.Text = 0
                    vie.tbruto.Text = 0
                    vie.ttara.Text = 0
                    vie.tneto.Text = 0

                    If vie.ctipoprecio.SelectedValue.ToString = grid1.Item(grid1.CurrentRowIndex, 6) Then
                        vie.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5)).ToString("###0.00000")
                    Else
                        If vie.ctipoprecio.SelectedValue.ToString = "S" Then
                            vie.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) * vie.txtcambio.Text).ToString("###0.00000")
                        Else
                            vie.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) / vie.txtcambio.Text).ToString("###0.00000")
                        End If
                    End If

                    vie.txtcantidad.Focus()
                    vie.txtcantidad.SelectAll()



                ElseIf vie.bomedidaing = False And vie.boumedidaing = True Then

                    Conecta("Nsp_sel_click_articulo_medida_umedida '" & codempresa & "','" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "pa")

                    vie.tarticulo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                    vie.txtdesarticulo.Text = Trim(ds.Tables("pa").Rows(0)(1))
                    vie.tumedida.Items.Add(ds.Tables("pa").Rows(0)(7))
                    vie.arrmedidaing.Add(Trim(ds.Tables("pa").Rows(0)(8)))
                    'vie2.codmed = Trim(ds.Tables("pa").Rows(0)(8).ToString())
                    vie.tmarca.Text = Trim(ds.Tables("pa").Rows(0)(3))
                    vie.strmarcaing = Trim(ds.Tables("pa").Rows(0)(4))
                    vie.ttara.Text = Trim(ds.Tables("pa").Rows(0)(5))
                    vie.strtaraimp = Trim(ds.Tables("pa").Rows(0)(5))
                    vie.txtcantidad.Text = 0
                    vie.tbruto.Text = 0
                    vie.ttara.Text = 0
                    vie.tneto.Text = 0


                    If vie.ctipoprecio.SelectedValue.ToString = grid1.Item(grid1.CurrentRowIndex, 6) Then
                        vie.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5)).ToString("###0.00000")
                    Else
                        If vie.ctipoprecio.SelectedValue.ToString = "S" Then
                            vie.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) * vie.txtcambio.Text).ToString("###0.00000")
                        Else
                            vie.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) / vie.txtcambio.Text).ToString("###0.00000")
                        End If
                    End If

                    vie.txtcantidad.Focus()
                    vie.txtcantidad.SelectAll()

                ElseIf vie.bomedidaing = True And vie.boumedidaing = True Then

                    Conecta("Nsp_sel_click_articulo_medida_umedida '" & codempresa & "','" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "pa")

                    vie.tarticulo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                    vie.txtdesarticulo.Text = Trim(ds.Tables("pa").Rows(0)(1))
                    vie.tumedida.Items.Add(ds.Tables("pa").Rows(0)(6))
                    vie.arrmedidaing.Add(Trim(ds.Tables("pa").Rows(0)(2)))
                    vie.tumedida.Items.Add(ds.Tables("pa").Rows(0)(7))
                    vie.arrmedidaing.Add(Trim(ds.Tables("pa").Rows(0)(8)))
                    'vie2.codmed = Trim(ds.Tables("pa").Rows(0)(8).ToString())
                    vie.tmarca.Text = Trim(ds.Tables("pa").Rows(0)(3))
                    vie.strmarcaing = Trim(ds.Tables("pa").Rows(0)(4))
                    vie.ttara.Text = Trim(ds.Tables("pa").Rows(0)(5))
                    vie.strtaraimp = Trim(ds.Tables("pa").Rows(0)(5))
                    vie.txtcantidad.Text = 0
                    vie.tbruto.Text = 0
                    vie.ttara.Text = 0
                    vie.tneto.Text = 0

                    If vie.ctipoprecio.SelectedValue.ToString = grid1.Item(grid1.CurrentRowIndex, 6) Then
                        vie.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5)).ToString("###0.00000")
                    Else
                        If vie.ctipoprecio.SelectedValue.ToString = "S" Then
                            vie.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) * vie.txtcambio.Text).ToString("###0.00000")
                        Else
                            vie.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) / vie.txtcambio.Text).ToString("###0.00000")
                        End If
                    End If

                    vie.txtcantidad.Focus()
                    vie.txtcantidad.SelectAll()

                End If

                vie.tumedida.Enabled = True
                If vie.tumedida.Items.Count > 0 Then
                    vie.tumedida.SelectedIndex = 0
                End If
            Else
                vie2.tumedida.Items.Clear()
                vie2.medida.Clear()
                vie2.tlote.Text = grid1.Item(grid1.CurrentRowIndex, 7)
                vie2.timport2.Text = grid1.Item(grid1.CurrentRowIndex, 8)

                If vie2.a1 = True And vie2.a2 = False Then

                    Conecta("Nsp_sel_click_articulo_medida_umedida '" & codempresa & "','" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "pa")

                    vie2.tarticulo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                    vie2.txtdesarticulo.Text = Trim(ds.Tables("pa").Rows(0)(1))
                    vie2.medida.Add(Trim(ds.Tables("pa").Rows(0)(2)))

                    vie2.tmarca.Text = Trim(ds.Tables("pa").Rows(0)(3))
                    vie2.marca = Trim(ds.Tables("pa").Rows(0)(4))
                    vie2.ttara.Text = Trim(ds.Tables("pa").Rows(0)(5))
                    vie2.tara = Trim(ds.Tables("pa").Rows(0)(5))
                    vie2.tumedida.Items.Add(ds.Tables("pa").Rows(0)(6))
                    'vie2.codmed = Trim(ds.Tables("pa").Rows(0)(8).ToString())
                    vie2.txtcantidad.Text = 0
                    vie2.tbruto.Text = 0
                    vie2.ttara.Text = 0
                    vie2.tneto.Text = 0

                    If vie2.ctipoprecio.SelectedValue.ToString = grid1.Item(grid1.CurrentRowIndex, 6) Then
                        vie2.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5)).ToString("###0.00000")
                    Else
                        If vie2.ctipoprecio.SelectedValue.ToString = "S" Then
                            vie2.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) * vie2.txtcambio.Text).ToString("###0.00000")
                        Else
                            vie2.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) / vie2.txtcambio.Text).ToString("###0.00000")
                        End If
                    End If

                    vie2.txtcantidad.Focus()
                    vie2.txtcantidad.SelectAll()

                ElseIf vie2.a1 = False And vie2.a2 = True Then

                    Conecta("Nsp_sel_click_articulo_medida_umedida '" & codempresa & "','" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "pa")

                    vie2.tarticulo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                    vie2.txtdesarticulo.Text = Trim(ds.Tables("pa").Rows(0)(1))
                    vie2.tumedida.Items.Add(ds.Tables("pa").Rows(0)(7))
                    vie2.medida.Add(Trim(ds.Tables("pa").Rows(0)(8)))
                    'vie2.codmed = Trim(ds.Tables("pa").Rows(0)(8).ToString())
                    vie2.tmarca.Text = Trim(ds.Tables("pa").Rows(0)(3))
                    vie2.marca = Trim(ds.Tables("pa").Rows(0)(4))
                    vie2.ttara.Text = Trim(ds.Tables("pa").Rows(0)(5))
                    vie2.tara = Trim(ds.Tables("pa").Rows(0)(5))
                    vie2.txtcantidad.Text = 0
                    vie2.tbruto.Text = 0
                    vie2.ttara.Text = 0
                    vie2.tneto.Text = 0

                    If vie2.ctipoprecio.SelectedValue.ToString = grid1.Item(grid1.CurrentRowIndex, 6) Then
                        vie2.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5)).ToString("###0.00000")
                    Else
                        If vie2.ctipoprecio.SelectedValue.ToString = "S" Then
                            vie2.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) * vie2.txtcambio.Text).ToString("###0.00000")
                        Else
                            vie2.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) / vie2.txtcambio.Text).ToString("###0.00000")
                        End If
                    End If

                    vie2.txtcantidad.Focus()
                    vie2.txtcantidad.SelectAll()


                ElseIf vie2.a1 = True And vie2.a2 = True Then

                    Conecta("Nsp_sel_click_articulo_medida_umedida '" & codempresa & "','" & grid1.Item(grid1.CurrentRowIndex, 0) & "'", "pa")

                    vie2.tarticulo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                    vie2.txtdesarticulo.Text = Trim(ds.Tables("pa").Rows(0)(1))
                    vie2.tumedida.Items.Add(ds.Tables("pa").Rows(0)(6))
                    vie2.medida.Add(Trim(ds.Tables("pa").Rows(0)(2)))
                    vie2.tumedida.Items.Add(ds.Tables("pa").Rows(0)(7))
                    vie2.medida.Add(Trim(ds.Tables("pa").Rows(0)(8)))
                    'vie2.codmed = Trim(ds.Tables("pa").Rows(0)(8).ToString())
                    vie2.tmarca.Text = Trim(ds.Tables("pa").Rows(0)(3))
                    vie2.marca = Trim(ds.Tables("pa").Rows(0)(4))
                    vie2.ttara.Text = Trim(ds.Tables("pa").Rows(0)(5))
                    vie2.tara = Trim(ds.Tables("pa").Rows(0)(5))
                    vie2.txtcantidad.Text = 0
                    vie2.tbruto.Text = 0
                    vie2.ttara.Text = 0
                    vie2.tneto.Text = 0

                    If vie2.ctipoprecio.SelectedValue.ToString = grid1.Item(grid1.CurrentRowIndex, 6) Then
                        vie2.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5)).ToString("###0.00000")
                    Else
                        If vie2.ctipoprecio.SelectedValue.ToString = "S" Then
                            vie2.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) * vie2.txtcambio.Text).ToString("###0.00000")
                        Else
                            vie2.tcosto.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5) / vie2.txtcambio.Text).ToString("###0.00000")
                        End If
                    End If

                    vie2.txtcantidad.Focus()
                    vie2.txtcantidad.SelectAll()

                End If

                'vie2.tumedida.Enabled = True
                If vie2.tumedida.Items.Count > 0 Then
                    vie2.tumedida.SelectedIndex = 0
                End If
            End If
            Me.Close()
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Private Sub frm_grid_articulo_otro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.tarticulo.Focus()
    End Sub
    Private Sub tcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tcodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cargadatos()
            Me.tarticulo.Focus()

        ElseIf e.KeyCode = Keys.Down Then
            Me.grid1.Focus()
        End If
    End Sub
    Private Sub tarticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tarticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cargadatos()
            Me.tarticulo.Focus()

        ElseIf e.KeyCode = Keys.Down Then
            Me.grid1.Focus()
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If Me.grid1.Focus = True Then
                        Try
                            If Me.grid1.CurrentRowIndex <> -1 Then
                                Call pasadatos()
                            End If
                        Catch ex As Exception
                        End Try
                    End If

                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function
    Private Sub grid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.CurrentCellChanged
        Me.grid1.Select(Me.grid1.CurrentRowIndex)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
