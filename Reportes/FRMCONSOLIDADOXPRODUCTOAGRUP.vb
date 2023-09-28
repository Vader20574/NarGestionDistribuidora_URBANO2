Public Class FRMCONSOLIDADOXPRODUCTOAGRUP
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
    Friend WithEvents lblestado As System.Windows.Forms.Label
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
    Friend WithEvents lstproduc2 As System.Windows.Forms.ListBox
    Friend WithEvents lstproduc1 As System.Windows.Forms.ListBox
    Friend WithEvents lstcod2 As System.Windows.Forms.ListBox
    Friend WithEvents lstcod1 As System.Windows.Forms.ListBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMCONSOLIDADOXPRODUCTOAGRUP))
        Me.lblestado = New System.Windows.Forms.Label
        Me.CRT = New AxCrystal.AxCrystalReport
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstproduc2 = New System.Windows.Forms.ListBox
        Me.lstproduc1 = New System.Windows.Forms.ListBox
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
        Me.lblestado.Location = New System.Drawing.Point(359, 315)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(312, 16)
        Me.lblestado.TabIndex = 39
        '
        'CRT
        '
        Me.CRT.Enabled = True
        Me.CRT.Location = New System.Drawing.Point(40, 456)
        Me.CRT.Name = "CRT"
        Me.CRT.OcxState = CType(resources.GetObject("CRT.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CRT.Size = New System.Drawing.Size(28, 28)
        Me.CRT.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfecha2)
        Me.GroupBox2.Controls.Add(Me.dtpfecha1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 51)
        Me.GroupBox2.TabIndex = 28
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
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lstproduc2)
        Me.GroupBox1.Controls.Add(Me.lstproduc1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 296)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(309, 114)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(51, 24)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = ">"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(309, 186)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 24)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "<<"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(309, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 24)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = ">>"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(309, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 24)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "<"
        '
        'lstproduc2
        '
        Me.lstproduc2.HorizontalScrollbar = True
        Me.lstproduc2.Location = New System.Drawing.Point(370, 23)
        Me.lstproduc2.Name = "lstproduc2"
        Me.lstproduc2.ScrollAlwaysVisible = True
        Me.lstproduc2.Size = New System.Drawing.Size(272, 238)
        Me.lstproduc2.TabIndex = 12
        '
        'lstproduc1
        '
        Me.lstproduc1.HorizontalScrollbar = True
        Me.lstproduc1.Location = New System.Drawing.Point(23, 23)
        Me.lstproduc1.Name = "lstproduc1"
        Me.lstproduc1.ScrollAlwaysVisible = True
        Me.lstproduc1.Size = New System.Drawing.Size(272, 238)
        Me.lstproduc1.TabIndex = 11
        '
        'lstcod2
        '
        Me.lstcod2.Location = New System.Drawing.Point(272, 432)
        Me.lstcod2.Name = "lstcod2"
        Me.lstcod2.Size = New System.Drawing.Size(144, 30)
        Me.lstcod2.TabIndex = 33
        '
        'lstcod1
        '
        Me.lstcod1.Location = New System.Drawing.Point(104, 432)
        Me.lstcod1.Name = "lstcod1"
        Me.lstcod1.Size = New System.Drawing.Size(144, 30)
        Me.lstcod1.TabIndex = 32
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(519, 339)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(143, 25)
        Me.btncancelar.TabIndex = 31
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(367, 339)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(143, 25)
        Me.btnaceptar.TabIndex = 30
        Me.btnaceptar.Text = "&Aceptar "
        '
        'FRMCONSOLIDADOXPRODUCTOAGRUP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(674, 389)
        Me.Controls.Add(Me.lblestado)
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
        Me.MaximumSize = New System.Drawing.Size(680, 417)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(680, 417)
        Me.Name = "FRMCONSOLIDADOXPRODUCTOAGRUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSOLIDADO AGRUPADO POR PRODUCTO PESO NETO"
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCONSOLIDADOXPRODUCTOAGRUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargadatos1()
        dtpfecha1.Value = Now.Date
        dtpfecha2.Value = Now.Date
        
    End Sub
    Sub cargadatos1()
        lstproduc1.Items.Clear()
        lstcod1.Items.Clear()
        lstproduc2.Items.Clear()
        lstcod2.Items.Clear()
        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("sp_todos_productos_nombres '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstproduc1.Items.Add(Trim(ds.Tables(0).Rows(i)(1)))
            Next
            ds.Dispose()
            ds = TmpListarDataset("sp_todos_productos_nombres '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod1.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
            lstproduc2.Items.Clear()
            lstcod2.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Sub cargadatos2()
        lstproduc1.Items.Clear()
        lstcod1.Items.Clear()
        lstproduc2.Items.Clear()
        lstcod2.Items.Clear()
        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("sp_todos_productos_nombres '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstproduc2.Items.Add(Trim(ds.Tables(0).Rows(i)(1)))
            Next
            ds.Dispose()
            ds = TmpListarDataset("sp_todos_productos_nombres '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod2.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If lstproduc1.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Producto", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lstproduc2.Items.Add(lstproduc1.Items(lstproduc1.SelectedIndex))
            lstcod2.Items.Add(lstcod1.Items(lstproduc1.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstproduc1.SelectedIndex
            lstproduc1.Items.RemoveAt(removeitem)
            lstcod1.Items.RemoveAt(removeitem)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cargadatos2()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cargadatos1()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If lstproduc2.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Producto", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            lstproduc1.Items.Add(lstproduc2.Items(lstproduc2.SelectedIndex))
            lstcod1.Items.Add(lstcod2.Items(lstproduc2.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstproduc2.SelectedIndex
            lstproduc2.Items.RemoveAt(removeitem)
            lstcod2.Items.RemoveAt(removeitem)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub acepta(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If lstproduc2.Items.Count <= 0 Then
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
        SQL = "DELETE FROM tmp_report_consolidadoproducto_PESONETO WHERE MAQUINA='" & maquina.Trim & "'"
        TmpInsertDatos(SQL)

        If lstcod1.Items.Count <> 0 Then
            For i = 0 To lstcod2.Items.Count - 1
                SQL = "SP_CONSOLIDADO_X_PRODUCTO_PESONETO '" & maquina & "','" & Fechaini & "','" & Fechafin & "','" & codempresa & "','',' And  P.CODPRODUCTO=''" & lstcod2.Items(i) & "'''"
                TmpInsertDatos(SQL)
                lblestado.Text = "Procesando " & i & " Registros de " & lstcod2.Items.Count - 1
                lblestado.Refresh()
            Next
        Else
            SQL = "SP_CONSOLIDADO_X_PRODUCTO_PESONETO '" & maquina & "','" & Fechaini & "','" & Fechafin & "','" & codempresa & "','',''"
            TmpInsertDatos(SQL)
            lblestado.Text = "Procesando " & i & " Registros de " & lstcod2.Items.Count - 1
            lblestado.Refresh()
        End If
        lblestado.Text = "Proceso Terminado "
        lblestado.Refresh()


        Call imprimereport(maquina)
    End Sub
    Sub imprimereport(ByVal MAQUINA As String)
        Try
            With CRT
                .WindowShowExportBtn = True
                .WindowShowPrintBtn = True
                .WindowShowPrintSetupBtn = True
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .ReportFileName = rutareporte + CType("CONSOLIDADOXPRODUCTOPESONETO.rpt", String)
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, MAQUINA)
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
End Class
