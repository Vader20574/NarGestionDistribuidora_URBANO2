Public Class FRMPRODUCTOS_VENDIDOSXCLIENPAG
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboptovta As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CRT As AxCrystal.AxCrystalReport
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstCLIE2 As System.Windows.Forms.ListBox
    Friend WithEvents lstCLIE1 As System.Windows.Forms.ListBox
    Friend WithEvents lstcod2 As System.Windows.Forms.ListBox
    Friend WithEvents lstcod1 As System.Windows.Forms.ListBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMPRODUCTOS_VENDIDOSXCLIENPAG))
        Me.lblestado = New System.Windows.Forms.Label
        Me.cbomoneda = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboptovta = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CRT = New AxCrystal.AxCrystalReport
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstCLIE2 = New System.Windows.Forms.ListBox
        Me.lstCLIE1 = New System.Windows.Forms.ListBox
        Me.lstcod2 = New System.Windows.Forms.ListBox
        Me.lstcod1 = New System.Windows.Forms.ListBox
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblestado
        '
        Me.lblestado.BackColor = System.Drawing.Color.White
        Me.lblestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.Black
        Me.lblestado.Location = New System.Drawing.Point(357, 347)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(296, 16)
        Me.lblestado.TabIndex = 52
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.Location = New System.Drawing.Point(477, 315)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(152, 21)
        Me.cbomoneda.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Moneda : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboptovta
        '
        Me.cboptovta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboptovta.Location = New System.Drawing.Point(109, 315)
        Me.cboptovta.Name = "cboptovta"
        Me.cboptovta.Size = New System.Drawing.Size(206, 21)
        Me.cboptovta.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Punto de Venta :"
        '
        'CRT
        '
        Me.CRT.Enabled = True
        Me.CRT.Location = New System.Drawing.Point(56, 456)
        Me.CRT.Name = "CRT"
        Me.CRT.OcxState = CType(resources.GetObject("CRT.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CRT.Size = New System.Drawing.Size(28, 28)
        Me.CRT.TabIndex = 47
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfecha2)
        Me.GroupBox2.Controls.Add(Me.dtpfecha1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 339)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 51)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas a Consultar"
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha2.Location = New System.Drawing.Point(197, 22)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(95, 21)
        Me.dtpfecha2.TabIndex = 3
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha1.Location = New System.Drawing.Point(49, 22)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(101, 21)
        Me.dtpfecha1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Al : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Del : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lstCLIE2)
        Me.GroupBox1.Controls.Add(Me.lstCLIE1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 296)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 268)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 21)
        Me.TextBox1.TabIndex = 17
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(301, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 24)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = ">"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(301, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 24)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "<<"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 24)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = ">>"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 22)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "<"
        '
        'lstCLIE2
        '
        Me.lstCLIE2.HorizontalScrollbar = True
        Me.lstCLIE2.Location = New System.Drawing.Point(357, 23)
        Me.lstCLIE2.Name = "lstCLIE2"
        Me.lstCLIE2.ScrollAlwaysVisible = True
        Me.lstCLIE2.Size = New System.Drawing.Size(275, 251)
        Me.lstCLIE2.TabIndex = 12
        '
        'lstCLIE1
        '
        Me.lstCLIE1.HorizontalScrollbar = True
        Me.lstCLIE1.Location = New System.Drawing.Point(16, 23)
        Me.lstCLIE1.Name = "lstCLIE1"
        Me.lstCLIE1.ScrollAlwaysVisible = True
        Me.lstCLIE1.Size = New System.Drawing.Size(275, 238)
        Me.lstCLIE1.TabIndex = 11
        '
        'lstcod2
        '
        Me.lstcod2.Location = New System.Drawing.Point(288, 432)
        Me.lstcod2.Name = "lstcod2"
        Me.lstcod2.Size = New System.Drawing.Size(144, 56)
        Me.lstcod2.TabIndex = 46
        '
        'lstcod1
        '
        Me.lstcod1.Location = New System.Drawing.Point(120, 432)
        Me.lstcod1.Name = "lstcod1"
        Me.lstcod1.Size = New System.Drawing.Size(144, 56)
        Me.lstcod1.TabIndex = 45
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(509, 371)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(143, 25)
        Me.btncancelar.TabIndex = 44
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(357, 371)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(143, 25)
        Me.btnaceptar.TabIndex = 43
        Me.btnaceptar.Text = "&Aceptar "
        '
        'FRMPRODUCTOS_VENDIDOSXCLIENPAG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(674, 400)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.cbomoneda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboptovta)
        Me.Controls.Add(Me.CRT)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstcod2)
        Me.Controls.Add(Me.lstcod1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(680, 432)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(680, 432)
        Me.Name = "FRMPRODUCTOS_VENDIDOSXCLIENPAG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos Vendidos x Cliente y Pagador "
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim PASA_DATO As String
    Private Sub FRMPRODUCTOS_VENDIDOSXCLIENPAG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargadatos1()
        dtpfecha1.Value = Now.Date
        dtpfecha2.Value = Now.Date
        CAyuda.CargarDataCombo(cbomoneda, "sp_selemoneda", "Codigo", "Moneda")
        CAyuda.CargarDataCombo(cboptovta, "sp_select_ptovtas", "codigo", "descripcion")
        cboptovta.SelectedValue = NROPTOVTA
        cbomoneda.SelectedValue = CDMONBASE
    End Sub
    Sub cargadatos1()
        lstCLIE1.Items.Clear()
        lstcod1.Items.Clear()
        lstCLIE2.Items.Clear()
        lstcod2.Items.Clear()
        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("SP_SELECT_CLIENTE '" & codempresa & "',''")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstCLIE1.Items.Add(Trim(ds.Tables(0).Rows(i)(1)))
            Next
            ds.Dispose()
            ds = TmpListarDataset("SP_SELECT_CLIENTE '" & codempresa & "',''")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod1.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
            lstCLIE2.Items.Clear()
            lstcod2.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Sub bUSCAR(ByVal CLI As String)
        lstCLIE1.Items.Clear()
        lstcod1.Items.Clear()

        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("SP_SELECT_CLIENTE_BUS  '" & codempresa & "','" & CLI.ToString & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstCLIE1.Items.Add(Trim(ds.Tables(0).Rows(i)(1)))
            Next
            ds.Dispose()
            ds = TmpListarDataset("SP_SELECT_CLIENTE_BUS  '" & codempresa & "','" & CLI.ToString & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod1.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next

        Catch ex As Exception
        End Try
    End Sub
    Sub cargadatos2()
        lstCLIE1.Items.Clear()
        lstcod1.Items.Clear()
        lstCLIE2.Items.Clear()
        lstcod2.Items.Clear()
        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("SP_SELECT_CLIENTE '" & codempresa & "',''")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstCLIE2.Items.Add(Trim(ds.Tables(0).Rows(i)(1)))
            Next
            ds.Dispose()
            ds = TmpListarDataset("SP_SELECT_CLIENTE '" & codempresa & "',''")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod2.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If lstCLIE1.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Cliente", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lstCLIE2.Items.Add(lstCLIE1.Items(lstCLIE1.SelectedIndex))
            lstcod2.Items.Add(lstcod1.Items(lstCLIE1.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstCLIE1.SelectedIndex
            lstCLIE1.Items.RemoveAt(removeitem)
            lstcod1.Items.RemoveAt(removeitem)
            PASA_DATO = "POR UNO"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cargadatos2()
        PASA_DATO = "TODOS"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cargadatos1()
        PASA_DATO = "NIMGUNO"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If lstCLIE2.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Cliente", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            lstCLIE1.Items.Add(lstCLIE2.Items(lstCLIE2.SelectedIndex))
            lstcod1.Items.Add(lstcod2.Items(lstCLIE2.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstCLIE2.SelectedIndex
            lstCLIE2.Items.RemoveAt(removeitem)
            lstcod2.Items.RemoveAt(removeitem)
            PASA_DATO = "MENOS UNO"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub acepta(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If lstCLIE2.Items.Count <= 0 Then
            MessageBox.Show("Selecione un Producto para realizar el reporte", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim FECHA1, FECHA2 As String
        FECHA1 = dtpfecha1.Value.Date
        FECHA2 = dtpfecha2.Value.Date
        Call ventas_por_producto_y_marca(FECHA1, FECHA2)
    End Sub
    Sub ventas_por_producto_y_marca(ByVal FECHA1 As String, ByVal FECHA2 As String)
        If CDate(FECHA1) > CDate(FECHA2) Then
            MessageBox.Show("Rango de Fechas Incorrecta", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim maquina As String
        Dim i As Integer
        Dim ds As New DataSet
        Dim SQL, Fechaini, Fechafin As String

        maquina = Environment.MachineName()
        Fechaini = Format(CDate(FECHA1), "dd/MM/yyyy")
        Fechafin = Format(CDate(FECHA2), "dd/MM/yyyy")
        SQL = "DELETE FROM TMP_ARTICULO_VENDIDOS_X_CLIENTE WHERE MAQUINA='" & maquina.Trim & "'"
        TmpInsertDatos(SQL)


        'If lstcod1.Items.Count <> 0 Then
        '    For i = 0 To lstcod2.Items.Count - 1
        '        SQL = "SP_TMP_ARTICULO_VENDIDOS_X_CLIENTE '" & maquina & "','" & Fechaini & "','" & Fechafin & "','" & FACT_codempresa & "','" & cbomoneda.SelectedValue.ToString & "','',' and vc.coddep=''" & lstcod2.Items(i) & "''','" & cboptovta.SelectedValue.ToString & "'"
        '        Guarda(SQL)
        '        lblestado.Text = "Procesando " & i & " Registros de " & lstcod2.Items.Count - 1
        '        lblestado.Refresh()
        '    Next
        'Else
        '    SQL = "SP_TMP_ARTICULO_VENDIDOS_X_CLIENTE '" & maquina & "','" & Fechaini & "','" & Fechafin & "','" & FACT_codempresa & "','" & cbomoneda.SelectedValue.ToString & "','','','" & cboptovta.SelectedValue.ToString & "'"
        '    Guarda(SQL)
        '    lblestado.Text = "Procesando " & i & " Registros de " & lstcod2.Items.Count - 1
        '    lblestado.Refresh()
        '    lblestado.Text = "Proceso Terminado "
        '    lblestado.Refresh()
        'End If
        If PASA_DATO = "TODOS" Then
            SQL = "SP_TMP_ARTICULO_VENDIDOS_X_CLIENTE '" & maquina & "','" & Fechaini & "','" & Fechafin & "','" & codempresa & "','" & cbomoneda.SelectedValue.ToString & "','','','" & cboptovta.SelectedValue.ToString & "'"
            TmpInsertDatos(SQL)
            lblestado.Text = "Procesando " & i & " Registros de " & lstcod2.Items.Count - 1
            lblestado.Refresh()
            lblestado.Text = "Proceso Terminado "
            lblestado.Refresh()
        ElseIf PASA_DATO = "POR UNO" Then
            For i = 0 To lstcod2.Items.Count - 1
                SQL = "SP_TMP_ARTICULO_VENDIDOS_X_CLIENTE '" & maquina & "','" & Fechaini & "','" & Fechafin & "','" & codempresa & "','" & cbomoneda.SelectedValue.ToString & "','',' and vc.coddep=''" & lstcod2.Items(i) & "''','" & cboptovta.SelectedValue.ToString & "'"
                TmpInsertDatos(SQL)
                lblestado.Text = "Procesando " & i & " Registros de " & lstcod2.Items.Count - 1
                lblestado.Refresh()
            Next
        End If
        Call imprimereport(maquina)
    End Sub
    Sub imprimereport(ByVal MAQUINA As String)
        Try
            With CRT
                .WindowShowExportBtn = True
                .WindowShowPrintBtn = True
                .WindowShowPrintSetupBtn = True
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .ReportFileName = rutareporte + CType("PRODUCTOS_VENDIDOS_X_CLIENTE_PAGADOR.rpt", String)
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_StoredProcParam(0, MAQUINA)
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub lstCLIE1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCLIE1.DoubleClick
        Call Button4_Click(sender, e)
    End Sub

    Private Sub lstCLIE2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCLIE2.DoubleClick
        Call Button1_Click(sender, e)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        bUSCAR(Me.TextBox1.Text.Trim.ToString)
    End Sub
End Class
