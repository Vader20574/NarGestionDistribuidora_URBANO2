Imports System.Data.SqlClient
Public Class frm_cajaactual
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cptovta As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ttotal As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tnrocierre As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ttotalext As System.Windows.Forms.TextBox
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Dsfinanza1 As NarGestionDistribuidora.dsfinanza
    Friend WithEvents Dscombo1 As NarGestionDistribuidora.dscombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_cajaactual))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataView1 = New System.Data.DataView
        Me.Dsfinanza1 = New NarGestionDistribuidora.dsfinanza
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.tnrocierre = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cptovta = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ttotal = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ttotalext = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.Dscombo1 = New NarGestionDistribuidora.dscombo
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfinanza1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dscombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Movimiento de Dinero"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DataView1
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 112)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(792, 320)
        Me.DataGrid1.TabIndex = 2
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataView1
        '
        Me.DataView1.Table = Me.Dsfinanza1.ctabanco
        '
        'Dsfinanza1
        '
        Me.Dsfinanza1.DataSetName = "dsfinanza"
        Me.Dsfinanza1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ctabanco"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Nro Comp"
        Me.DataGridTextBoxColumn3.MappingName = "ctacte"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn1.MappingName = "banco"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 490
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Monto S/   ."
        Me.DataGridTextBoxColumn2.MappingName = "saldo"
        Me.DataGridTextBoxColumn2.NullText = "0.0000"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Monto U$  ."
        Me.DataGridTextBoxColumn4.MappingName = "saldoext"
        Me.DataGridTextBoxColumn4.NullText = "0.0000"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 90
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.tnrocierre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cptovta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Filtro"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "TIENDAPTOVTA.D"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(104, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "TIENDAPTOVTA.C"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(688, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "P&rocesar"
        Me.Button6.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(568, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 21)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2007, 12, 4, 0, 0, 0, 0)
        '
        'tnrocierre
        '
        Me.tnrocierre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnrocierre.Location = New System.Drawing.Point(376, 22)
        Me.tnrocierre.Name = "tnrocierre"
        Me.tnrocierre.ReadOnly = True
        Me.tnrocierre.Size = New System.Drawing.Size(96, 21)
        Me.tnrocierre.TabIndex = 5
        Me.tnrocierre.Text = ""
        Me.tnrocierre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nro Cierre :"
        '
        'cptovta
        '
        Me.cptovta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cptovta.Location = New System.Drawing.Point(88, 20)
        Me.cptovta.Name = "cptovta"
        Me.cptovta.Size = New System.Drawing.Size(216, 21)
        Me.cptovta.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pto de Venta :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(480, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha Cierre:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Depositar/Retirar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(496, 464)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 24)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "&Salir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(648, 450)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total S/ :"
        '
        'ttotal
        '
        Me.ttotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttotal.Location = New System.Drawing.Point(717, 448)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.ReadOnly = True
        Me.ttotal.Size = New System.Drawing.Size(88, 21)
        Me.ttotal.TabIndex = 6
        Me.ttotal.Text = "0.00"
        Me.ttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(136, 464)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 24)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cerrar Caja"
        '
        'ttotalext
        '
        Me.ttotalext.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttotalext.Location = New System.Drawing.Point(717, 472)
        Me.ttotalext.Name = "ttotalext"
        Me.ttotalext.ReadOnly = True
        Me.ttotalext.Size = New System.Drawing.Size(88, 21)
        Me.ttotalext.TabIndex = 13
        Me.ttotalext.Text = "0.00"
        Me.ttotalext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(648, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Total U$ :"
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(136, 232)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(376, 464)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 24)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "&Imprimir"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(256, 464)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 24)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Eliminar Depósito"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DESARROLLO5;packet size=4096;user id=SA;data source=DESARROLLO1;pe" & _
        "rsist security info=False;initial catalog=HALEMA"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TIENDAPTOVTA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("C", "C"), New System.Data.Common.DataColumnMapping("D", "D")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT NROPTOVTA AS C, DESPTOVTA AS D FROM TIENDAPTOVTA WHERE (CODEMPRESA = @cd) " & _
        "AND (ESTADO = 0) ORDER BY DESPTOVTA"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cd", System.Data.SqlDbType.VarChar, 10, "CODEMPRESA"))
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(656, 272)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 4
        '
        'Dscombo1
        '
        Me.Dscombo1.DataSetName = "dscombo"
        Me.Dscombo1.Locale = New System.Globalization.CultureInfo("es-PE")
        '
        'frm_cajaactual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(818, 496)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ttotalext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ttotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(824, 528)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(824, 528)
        Me.Name = "frm_cajaactual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cierre en Caja Actual"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfinanza1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dscombo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frm_cajaactual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Value = Date.Now
        'Me.SqlDataAdapter1.SelectCommand.Parameters(0).Value = codempresa
        'Me.SqlDataAdapter1.Fill(Me.Dscombo1.TIENDAPTOVTA)

        Me.Dsfinanza1.Clear()
        conecta1("SELECT NROPTOVTA AS C, DESPTOVTA AS D FROM TIENDAPTOVTA  WHERE CODEMPRESA = '" & codempresa & "' AND ESTADO = 0 ORDER BY DESPTOVTA", "Table")
        oda.Fill(Me.Dscombo1.TIENDAPTOVTA)

        CAyuda.CargarDataCombo(Me.ComboBox1, "Nsp_Sele_tdaptoventa '" & codempresa & "','',''", "NROPTOVTA", "DESPTOVTA")
        'CAyuda.CargarDataCombo(Me.ComboBox1, "Nsp_Sele_tdaptoventa '" & codempresa & "','',''", "C", "D")

        Me.ComboBox1.SelectedValue = NROPTOVTA.ToString
        'cptovta.SelectedValue = Venta.ToString
        'cptovta_SelectedIndexChanged(sender, e)
        ComboBox1_SelectedIndexChanged(sender, e)
        llena()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Dim i As Integer
    Dim AObjBus As New ClsAyuda
    Public ADblCorr As Double

    Sub ObtieneCorr()
        ADblCorr = AObjBus.ListarDatos("ObtenerCorrelativoProcUtil", CodUsuario).Tables(0).Rows(0)(0)
    End Sub

    Sub llena()
        Try


            Dim AStrFecini, AStrFecFin As String
            AStrFecini = Format(Me.DateTimePicker1.Value, "MM/dd/yyyy")
            AStrFecFin = Format(Me.DateTimePicker1.Value, "MM/dd/yyyy")
            ObtieneCorr()
            TmpInsertDatos("delete from tmp_cierrecaja where CORREL='" & ADblCorr & "'")


            ''" & AStrFecini & "','" & AStrFecFin & "',

            Me.DataView1.Table.Clear()
            conecta1("nsp_totalcaja '" & codempresa & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & ADblCorr & "','" & AStrFecini & "'", "llena")
            oda.Fill(Me.DataView1.Table)
            'Me.DataView1.Table = ds.Tables("llena")

            Me.DataGrid1.Refresh()

            Dim tot, tot1 As Double
            For i = 0 To Me.DataView1.Table.Rows.Count - 1
                If IsDBNull(DataGrid1.Item(i, 2)) Then
                    tot += 0
                Else
                    tot += DataGrid1.Item(i, 2)
                End If

                If IsDBNull(DataGrid1.Item(i, 3)) Then
                    tot1 += 0
                Else
                    tot1 += DataGrid1.Item(i, 3)
                End If
            Next

            Me.ttotal.Text = tot.ToString("###0.00")
            Me.ttotalext.Text = tot1.ToString("###0.00")

        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub

    Private Sub cptovta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cptovta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim men As New frm_depositocobro
        'men.vie = Me
        'men.ShowDialog()
        'Me.DataView1.Table.Clear()
        'Me.DataGrid1.Refresh()
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
        Me.Button4.Enabled = True
        Me.Button5.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Conecta("SELECT * FROM CIERRECAJA WHERE FECHA>='" & Format(Now, "MM/dd/yy") & "' AND PTOVTA='" & Me.ComboBox1.SelectedValue.ToString() & "' AND CODEMPRESA='" & codempresa & "'", "verifica")
        If ds.Tables("verifica").Rows.Count > 0 Then
            MessageBox.Show("No puede efectuar un Cierre a esta fecha porque ya han realizado un Cierre de Caja anteriormente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Está seguro de querer cerrar la caja y finalizar el flujo de dinero?", "Confirme por favor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TmpInsertDatos("NSP_INS_CIERRECAJA '" & CodUsuario & "','" & Format(Now, "MM/dd/yy") & "','" & Me.ComboBox1.SelectedValue.ToString & "'," & ttotal.Text & "," & ttotalext.Text & ",'" & codempresa & "','" & ADblCorr & "','" & Strings.Right("000000000" + CType(Val(tnrocierre.Text + 1), String), 9) & "'")
            MessageBox.Show("Cierre de Caja procesado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & tnrocierre.Text & "','INSERT','CIERRECAJA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
        End If
    End Sub

    Private Sub frm_cajaactual_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        TmpInsertDatos("delete from tmp_cierrecaja where CORREL='" & ADblCorr & "'")
    End Sub

    Private Sub cptovta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cptovta.SelectedIndexChanged
        Conecta("select nroCIERRE from CONFIGFINANZAS where ptovta='" & Me.cptovta.SelectedValue & "' and codempresa='" & codempresa & "'", "correl")
        If ds.Tables("correl").Rows.Count > 0 Then
            tnrocierre.Text = Trim(ds.Tables("correl").Rows(0)(0))
        Else
            tnrocierre.Text = "000000000"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim AStrFecini, AStrFecFin As String
            AStrFecini = Format(Now, "MM/dd/yyyy") & " 00:00:00"
            AStrFecFin = Format(Now, "MM/dd/yyyy") & " 23:59:59"

            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, Me.ComboBox1.SelectedValue)
            crRpt.set_StoredProcParam(2, ADblCorr)
            crRpt.set_StoredProcParam(3, Format(Now, "MM/dd/yyyy"))

            crRpt.WindowShowExportBtn = True
            crRpt.WindowShowPrintBtn = True
            crRpt.WindowShowPrintSetupBtn = True
            crRpt.ReportFileName = rutareporte & "RPTCUADRECAJA.rpt"


            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized


            crRpt.Action = 1
            crRpt.Reset()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'If Me.DataGrid1.CurrentRowIndex > 0 Then
        '    If DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) = "S/NUMERO" Then
        '        MessageBox.Show("Solo puede eliminar Depósitos o Retiros Efectuados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If


        'End If
        If Me.Dsfinanza1.ctabanco.Rows.Count > 0 Then
            TmpInsertDatos("delete from depcuentas where nrocomp='" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & "' and codempresa='" & codempresa & "' and ptovta='" & Me.ComboBox1.SelectedValue.ToString & "'")
            llena()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.DataView1.Table.Clear()
        Me.Dsfinanza1.ctabanco.Clear()
        llena()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        'Me.DataView1.Table.Clear()
        'Me.Dsfinanza1.ctabanco.Clear()
        'llena()
    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Conecta("SELECT * FROM CIERRECAJA WHERE FECHA>='" & Format(Me.DateTimePicker1.Value, "MM/dd/yy") & "' AND PTOVTA='" & Me.ComboBox1.SelectedValue.ToString() & "' AND CODEMPRESA='" & codempresa & "'", "verifica")
            If ds.Tables("verifica").Rows.Count > 0 Then
                MessageBox.Show("Ya se Realizo el Cierre para esta fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Try
                    Me.DataView1.Table.Clear()
                    CAyuda.conecta_AUX("select nrodoc as ctacte , descripcion as banco, saldobas as saldo,saldoext from CIERRECAJADET where nrocierre='" & ds.Tables("verifica").Rows(0)(0) & "'", "llena")
                    oda.Fill(Me.DataView1.Table)
                    Me.DataGrid1.Refresh()

                    Dim tot, tot1 As Double
                    For i = 0 To Me.DataView1.Table.Rows.Count - 1
                        If IsDBNull(DataGrid1.Item(i, 2)) Then
                            tot += 0
                        Else
                            tot += DataGrid1.Item(i, 2)
                        End If

                        If IsDBNull(DataGrid1.Item(i, 3)) Then
                            tot1 += 0
                        Else
                            tot1 += DataGrid1.Item(i, 3)
                        End If
                    Next
                    tnrocierre.Text = CStr(ds.Tables("verifica").Rows(0)(0))
                    Me.ttotal.Text = tot.ToString("###0.00")
                    Me.ttotalext.Text = tot1.ToString("###0.00")
                    'Me.Button1.Enabled = False
                    Me.Button2.Enabled = False
                    Me.Button3.Enabled = False
                    Me.Button4.Enabled = False
                    Me.Button5.Enabled = False
                Catch ex As Exception

                End Try
                Exit Sub
            End If

            Me.DataView1.Table.Clear()
            Me.Dsfinanza1.ctabanco.Clear()
            llena()
        End If
    End Sub

    Private Sub DateTimePicker1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Click
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Conecta("select nroCIERRE from CONFIGFINANZAS where ptovta='" & Me.ComboBox1.SelectedValue & "' and codempresa='" & codempresa & "'", "correl")
        If ds.Tables("correl").Rows.Count > 0 Then
            tnrocierre.Text = Trim(ds.Tables("correl").Rows(0)(0))
        Else
            tnrocierre.Text = "000000000"
        End If
    End Sub
End Class
