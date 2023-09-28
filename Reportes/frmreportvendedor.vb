Public Class frmreportvendedor
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
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboptovta As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstclie2 As System.Windows.Forms.ListBox
    Friend WithEvents lstclie1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstcod2 As System.Windows.Forms.ListBox
    Friend WithEvents lstcod1 As System.Windows.Forms.ListBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents crt As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreportvendedor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtfiltro = New System.Windows.Forms.TextBox
        Me.crt = New AxCrystal.AxCrystalReport
        Me.cbomoneda = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstclie2 = New System.Windows.Forms.ListBox
        Me.lstclie1 = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboptovta = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstcod2 = New System.Windows.Forms.ListBox
        Me.lstcod1 = New System.Windows.Forms.ListBox
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.crt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfiltro)
        Me.GroupBox1.Controls.Add(Me.crt)
        Me.GroupBox1.Controls.Add(Me.cbomoneda)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lstclie2)
        Me.GroupBox1.Controls.Add(Me.lstclie1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 382)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(15, 320)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(303, 21)
        Me.txtfiltro.TabIndex = 24
        '
        'crt
        '
        Me.crt.Enabled = True
        Me.crt.Location = New System.Drawing.Point(347, 24)
        Me.crt.Name = "crt"
        Me.crt.OcxState = CType(resources.GetObject("crt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crt.Size = New System.Drawing.Size(28, 28)
        Me.crt.TabIndex = 23
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.Location = New System.Drawing.Point(83, 348)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(235, 21)
        Me.cbomoneda.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Moneda : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Vendedores para Busqueda"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Vendedores en General"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(332, 138)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 25)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = ">"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 25)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "<<"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(332, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 25)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = ">>"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 25)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "<"
        '
        'lstclie2
        '
        Me.lstclie2.HorizontalScrollbar = True
        Me.lstclie2.Location = New System.Drawing.Point(402, 42)
        Me.lstclie2.Name = "lstclie2"
        Me.lstclie2.ScrollAlwaysVisible = True
        Me.lstclie2.Size = New System.Drawing.Size(303, 264)
        Me.lstclie2.TabIndex = 12
        '
        'lstclie1
        '
        Me.lstclie1.HorizontalScrollbar = True
        Me.lstclie1.Location = New System.Drawing.Point(15, 44)
        Me.lstclie1.Name = "lstclie1"
        Me.lstclie1.ScrollAlwaysVisible = True
        Me.lstclie1.Size = New System.Drawing.Size(303, 264)
        Me.lstclie1.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfecha2)
        Me.GroupBox2.Controls.Add(Me.dtpfecha1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 55)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas a Consultar"
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha2.Location = New System.Drawing.Point(224, 22)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(93, 21)
        Me.dtpfecha2.TabIndex = 3
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha1.Location = New System.Drawing.Point(67, 22)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(93, 21)
        Me.dtpfecha1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Al : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Del : "
        '
        'cboptovta
        '
        Me.cboptovta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboptovta.Location = New System.Drawing.Point(143, 425)
        Me.cboptovta.Name = "cboptovta"
        Me.cboptovta.Size = New System.Drawing.Size(206, 21)
        Me.cboptovta.TabIndex = 18
        Me.cboptovta.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 427)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Punto de Venta :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Visible = False
        '
        'lstcod2
        '
        Me.lstcod2.Location = New System.Drawing.Point(276, 234)
        Me.lstcod2.Name = "lstcod2"
        Me.lstcod2.Size = New System.Drawing.Size(157, 82)
        Me.lstcod2.TabIndex = 28
        '
        'lstcod1
        '
        Me.lstcod1.Location = New System.Drawing.Point(84, 226)
        Me.lstcod1.Name = "lstcod1"
        Me.lstcod1.Size = New System.Drawing.Size(157, 82)
        Me.lstcod1.TabIndex = 27
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(344, 400)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(176, 25)
        Me.btnaceptar.TabIndex = 25
        Me.btnaceptar.Text = "&Aceptar "
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(528, 400)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(176, 25)
        Me.btncancelar.TabIndex = 26
        Me.btncancelar.Text = "&Cancelar"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 19)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Procesando Reporte......"
        Me.Label7.Visible = False
        '
        'frmreportvendedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(733, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstcod2)
        Me.Controls.Add(Me.lstcod1)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.cboptovta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmreportvendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte por Vendedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.crt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub repv_frmcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call datacombo()
        Call cargadatos1()
        cboptovta.SelectedValue = Environment.MachineName
        cbomoneda.SelectedValue = CDMONBASE
        dtpfecha1.Value = Now.Date
        dtpfecha2.Value = Now.Date
    End Sub
    Sub datacombo()
        Try
            CAyuda.CargarDataCombo(cboptovta, "SP_SELE_TIENDAPTOVTA '" & codempresa & "'", "CODIGO", "NROPTOVTA")
            CAyuda.CargarDataCombo(cbomoneda, "nsp_sele_monefac '" & codempresa & "'", "Codigo", "Moneda")

        Catch ex As Exception
        End Try
    End Sub
    Sub cargadatos1()
        lstclie1.Items.Clear()
        lstcod1.Items.Clear()
        lstclie2.Items.Clear()
        lstcod2.Items.Clear()
        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("sp_select_vendedorreport '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstclie1.Items.Add(Trim(ds.Tables(0).Rows(i)(1)))
            Next

            ds.Dispose()
            ds = TmpListarDataset("sp_select_vendedorreport '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod1.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
            lstclie2.Items.Clear()
            lstcod2.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Sub cargadatos2()
        lstclie1.Items.Clear()
        lstcod1.Items.Clear()
        lstclie2.Items.Clear()
        lstcod2.Items.Clear()
        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("sp_select_vendedorreport '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstclie2.Items.Add(Trim(ds.Tables(0).Rows(i)(1)))
            Next
            ds.Dispose()
            ds = TmpListarDataset("sp_select_vendedorreport '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod2.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, lstclie1.DoubleClick
        Try
            If lstclie1.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Vendedor", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lstclie2.Items.Add(lstclie1.Items(lstclie1.SelectedIndex))
            lstcod2.Items.Add(lstcod1.Items(lstclie1.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstclie1.SelectedIndex
            lstclie1.Items.RemoveAt(removeitem)
            lstcod1.Items.RemoveAt(removeitem)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, lstclie2.DoubleClick
        Try

            If lstclie1.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Vendedor", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lstclie1.Items.Add(lstclie2.Items(lstclie2.SelectedIndex))
            lstcod1.Items.Add(lstcod2.Items(lstclie2.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstclie2.SelectedIndex
            lstclie2.Items.RemoveAt(removeitem)
            lstcod2.Items.RemoveAt(removeitem)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cargadatos2()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cargadatos1()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If lstclie2.Items.Count <= 0 Then
            MessageBox.Show("Selecione un Punto de Venta para realizar el reporte", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Label7.Visible = True
        Label7.Refresh()


        Label7.Text = "Procesando Reportes.."
        Label7.Refresh()
        Label7.Text = "Procesando Reportes....."
        Label7.Refresh()
        Label7.Text = "Procesando Reportes........"
        Label7.Refresh()
        Label7.Text = "Procesando Reportes..........."
        Label7.Refresh()

        Dim FECHA1, FECHA2 As String
        FECHA1 = dtpfecha1.Value.Date
        FECHA2 = dtpfecha2.Value.Date
        Call GENERAREPORTECLIENTES(FECHA1, FECHA2)

    End Sub
    Sub GENERAREPORTECLIENTES(ByVal FECHA1 As String, ByVal FECHA2 As String)
        If CDate(FECHA1) > CDate(FECHA2) Then
            MessageBox.Show("Rango de Fechas Incorrecta", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim fecini As String

        Dim mesact, anio, TABLAD, TABLAC As String
        Dim i As Integer
        Dim meses As Integer
        Dim ds As New DataSet
        Dim SQL, F1, F2, FM As String
        F1 = Format(CDate(FECHA1), "dd/MM/yyyy") & " 00:00:00"
        F2 = Format(CDate(FECHA2), "dd/MM/yyyy") & " 23:59:00"
        SQL = "SP_ELIMINAYCREA_TMP_REPORTCLIENTE"
        TmpInsertDatos(SQL)
        fecini = FECHA1
        meses = Val(DateDiff(DateInterval.Month, CDate(fecini), CDate(FECHA2)))
        Dim CDMONEDA, NROPTOVTA, DESPTOVTA As String
        NROPTOVTA = ""
        DESPTOVTA = ""

        CDMONEDA = cbomoneda.SelectedValue.ToString

        Dim FILTRO As String = ""
        If Me.lstclie1.Items.Count > 0 Then
            For i = 0 To lstcod2.Items.Count - 1
                If i = lstcod2.Items.Count - 1 Then
                    FILTRO = FILTRO + "'" & lstcod2.Items(i) & "'"
                Else
                    FILTRO = FILTRO + "'" & lstcod2.Items(i) & "',"
                End If

                Label7.Text = "Procesando Reportes.."
                Label7.Refresh()
                Label7.Text = "Procesando Reportes....."
                Label7.Refresh()
                Label7.Text = "Procesando Reportes........"
                Label7.Refresh()
                Label7.Text = "Procesando Reportes..........."
                Label7.Refresh()
            Next
        End If


        If Trim(CDMONEDA) = "S" Then

            If Me.lstclie1.Items.Count = 0 Then
                SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
    " SELECT '01/' + CAST(MONTH(v.fecproceso) AS VARCHAR(20))+ '/' + CAST(year(v.fecproceso) AS VARCHAR(20)) " & _
    "  , C.CODvend,c.dsvend  " & _
    "		,sum(TOTBAS),year(v.fecproceso),'MES'=case when " & _
    "			month(v.fecproceso)=1 then  'ENERO' WHEN " & _
    "			month(v.fecproceso)=2 then  'FEBRERO' WHEN " & _
    "			month(v.fecproceso)=3 then  'MARZO' WHEN " & _
    "			month(v.fecproceso)=4 then  'ABRIL' WHEN " & _
    "			month(v.fecproceso)=5 then  'MAYO' WHEN " & _
    "			month(v.fecproceso)=6 then  'JUNIO' WHEN " & _
    "			month(v.fecproceso)=7 then  'JULIO' WHEN " & _
    "			month(v.fecproceso)=8 then  'AGOSTO' WHEN " & _
    "			month(v.fecproceso)=9 then  'SETIEMBRE' WHEN " & _
    "			month(v.fecproceso)=10 then 'OCTUBRE' WHEN " & _
    "			month(v.fecproceso)=11 then 'NOVIEMBRE' WHEN " & _
    "			month(v.fecproceso)=12 then 'DICIEMBRE' END " & _
    "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from ventacab v,vendedor c where v.codvend=c.codvend and " & _
    "	 v.fecproceso between '" & F1 & "' and '" & F2 & "'" & _
    "	GROUP BY C.codvend,c.dsvend, " & _
    "	v.FECPROCESO "

            Else
                SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
                    " SELECT '01/' + CAST(MONTH(v.fecproceso) AS VARCHAR(20))+ '/' + CAST(year(v.fecproceso) AS VARCHAR(20)) " & _
                    "  , C.CODvend,c.dsvend " & _
                    "		,sum(TOTBAS),year(v.fecproceso),'MES'=case when " & _
                    "			month(v.fecproceso)=1 then  'ENERO' WHEN " & _
                    "			month(v.fecproceso)=2 then  'FEBRERO' WHEN " & _
                    "			month(v.fecproceso)=3 then  'MARZO' WHEN " & _
                    "			month(v.fecproceso)=4 then  'ABRIL' WHEN " & _
                    "			month(v.fecproceso)=5 then  'MAYO' WHEN " & _
                    "			month(v.fecproceso)=6 then  'JUNIO' WHEN " & _
                    "			month(v.fecproceso)=7 then  'JULIO' WHEN " & _
                    "			month(v.fecproceso)=8 then  'AGOSTO' WHEN " & _
                    "			month(v.fecproceso)=9 then  'SETIEMBRE' WHEN " & _
                    "			month(v.fecproceso)=10 then 'OCTUBRE' WHEN " & _
                    "			month(v.fecproceso)=11 then 'NOVIEMBRE' WHEN " & _
                    "			month(v.fecproceso)=12 then 'DICIEMBRE' END " & _
                    "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from ventacab v,vendedor c where v.codvend=c.codvend and " & _
                    "	 v.fecproceso between '" & F1 & "' and '" & F2 & "'" & _
                    "	GROUP BY C.codvend,c.dsvend, " & _
                    "	v.FECPROCESO "
            End If

            TmpInsertDatos(SQL)
        End If

        Label7.Text = "Procesando Reportes.."
        Label7.Refresh()
        Label7.Text = "Procesando Reportes....."
        Label7.Refresh()
        Label7.Text = "Procesando Reportes........"
        Label7.Refresh()
        Label7.Text = "Procesando Reportes..........."
        Label7.Refresh()



        If Trim(CDMONEDA) = "D" Then

            If Me.lstclie1.Items.Count = 0 Then
                SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
                    " SELECT '01/' + CAST(MONTH(v.fecproceso) AS VARCHAR(20))+ '/' + CAST(year(v.fecproceso) AS VARCHAR(20)) " & _
                    "  , C.codvend,c.dsvend  " & _
                    "		,sum(TOTEXT),year(v.fecproceso),'MES'=case when " & _
                    "			month(v.fecproceso)=1 then  'ENERO' WHEN " & _
                    "			month(v.fecproceso)=2 then  'FEBRERO' WHEN " & _
                    "			month(v.fecproceso)=3 then  'MARZO' WHEN " & _
                    "			month(v.fecproceso)=4 then  'ABRIL' WHEN " & _
                    "			month(v.fecproceso)=5 then  'MAYO' WHEN " & _
                    "			month(v.fecproceso)=6 then  'JUNIO' WHEN " & _
                    "			month(v.fecproceso)=7 then  'JULIO' WHEN " & _
                    "			month(v.fecproceso)=8 then  'AGOSTO' WHEN " & _
                    "			month(v.fecproceso)=9 then  'SETIEMBRE' WHEN " & _
                    "			month(v.fecproceso)=10 then 'OCTUBRE' WHEN " & _
                    "			month(v.fecproceso)=11 then 'NOVIEMBRE' WHEN " & _
                    "			month(v.fecproceso)=12 then 'DICIEMBRE' END " & _
                    "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from ventacab v,vendedor c where v.codvend=c.codvend and " & _
                    "	 v.fecproceso between '" & F1 & "' and '" & F2 & "'" & _
                    "	GROUP BY C.CODvend,c.dsvend, " & _
                    "	v.FECPROCESO"

            Else
                SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
                    " SELECT '01/' + CAST(MONTH(v.fecproceso) AS VARCHAR(20))+ '/' + CAST(year(v.fecproceso) AS VARCHAR(20)) " & _
                    "  , C.CODvend,c.dsvend  " & _
                    "		,sum(TOTEXT),year(v.fecproceso),'MES'=case when " & _
                    "			month(v.fecproceso)=1 then  'ENERO' WHEN " & _
                    "			month(v.fecproceso)=2 then  'FEBRERO' WHEN " & _
                    "			month(v.fecproceso)=3 then  'MARZO' WHEN " & _
                    "			month(v.fecproceso)=4 then  'ABRIL' WHEN " & _
                    "			month(v.fecproceso)=5 then  'MAYO' WHEN " & _
                    "			month(v.fecproceso)=6 then  'JUNIO' WHEN " & _
                    "			month(v.fecproceso)=7 then  'JULIO' WHEN " & _
                    "			month(v.fecproceso)=8 then  'AGOSTO' WHEN " & _
                    "			month(v.fecproceso)=9 then  'SETIEMBRE' WHEN " & _
                    "			month(v.fecproceso)=10 then 'OCTUBRE' WHEN " & _
                    "			month(v.fecproceso)=11 then 'NOVIEMBRE' WHEN " & _
                    "			month(v.fecproceso)=12 then 'DICIEMBRE' END " & _
                    "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from ventacab v,vendedor c where v.codvend=c.codvend and " & _
                    "	 v.fecproceso between '" & F1 & "' and '" & F2 & "'" & _
                    "	GROUP BY C.CODvend, " & _
                    "	v.FECPROCESO "
            End If

            TmpInsertDatos(SQL)
        End If







        For i = 0 To meses
            mesact = Format(DateAdd("m", i, fecini), "MM")
            anio = Format(DateAdd("m", i, fecini), "yyyy")
            'Nombre de las tablas a Consultar
            TABLAD = "VENTD" & anio & mesact
            TABLAC = "VENTC" & anio & mesact
            FM = "01/" & mesact & "/" & anio
            Try
                'PASO ACUMULADOS DE INFORMACION PASADA (IMPORTEMOS DATA)

                ds = TmpListarDataset("VERIFICA_HISTORICOVENT '" & TABLAC & "','" & codempresa & "'")
                If ds.Tables(0).Rows.Count > 0 Then


                    'PASO ACUMULADOS DE HISTORICOS

                    'SQL = "INSERT TMP_COMPARATIVOVENTAS(CODPRODUCTO,PRODUCTO,MES,AÑO,VENTAS,FECHAMES,PTOVENTA,DESPTOVTA) " & _
                    '        " SELECT  P.CODPRODUCTO,P.DESPRODUCTO,'" & MES(mesact) & "','" & anio & "',SUM(cantidad),'" & FM & "',NROPTOVTA,DESPTOVTA FROM " & TABLAD & " VD ,ARTICULO A, PRODUCTO P" & "  WHERE VD.CODARTI=A.CODARTI AND A.CODPRODUCTO=P.CODPRODUCTO AND " & _
                    '        " VD.NROPTOVTA in (" & FILTRO & ") and datepart(mm,FECPROCESO)=" & mesact & " and datepart(yyyy,FECPROCESO)=" & anio & " GROUP BY NROPTOVTA,DESPTOVTA,P.CODPRODUCTO,P.DESPRODUCTO "

                    If Trim(CDMONEDA) = "S" Then

                        If Me.lstclie1.Items.Count = 0 Then

                            SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
     " SELECT '01/' + CAST(MONTH(v.fecproceso) AS VARCHAR(20))+ '/' + CAST(year(v.fecproceso) AS VARCHAR(20)) " & _
     "  , C.CODvend,c.dsvend  " & _
     "		,sum(TOTBAS),year(v.fecproceso),'MES'=case when " & _
     "			month(v.fecproceso)=1 then  'ENERO' WHEN " & _
     "			month(v.fecproceso)=2 then  'FEBRERO' WHEN " & _
     "			month(v.fecproceso)=3 then  'MARZO' WHEN " & _
     "			month(v.fecproceso)=4 then  'ABRIL' WHEN " & _
     "			month(v.fecproceso)=5 then  'MAYO' WHEN " & _
     "			month(v.fecproceso)=6 then  'JUNIO' WHEN " & _
     "			month(v.fecproceso)=7 then  'JULIO' WHEN " & _
     "			month(v.fecproceso)=8 then  'AGOSTO' WHEN " & _
     "			month(v.fecproceso)=9 then  'SETIEMBRE' WHEN " & _
     "			month(v.fecproceso)=10 then 'OCTUBRE' WHEN " & _
     "			month(v.fecproceso)=11 then 'NOVIEMBRE' WHEN " & _
     "			month(v.fecproceso)=12 then 'DICIEMBRE' END " & _
     "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from " & TABLAC & " v,vendedor c where v.codvend=c.codvend and " & _
     "	 v.fecproceso between '" & F1 & "' and '" & F2 & "'" & _
     "	GROUP BY C.CODvend,c.dsvend, " & _
     "	v.FECPROCESO"
                        Else
                            SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
                                 " SELECT '01/' + CAST(MONTH(v.fecproceso) AS VARCHAR(20))+ '/' + CAST(year(v.fecproceso) AS VARCHAR(20)) " & _
                                 "  , C.CODvend,c.dsvend  " & _
                                 "		,sum(TOTBAS),year(v.fecproceso),'MES'=case when " & _
                                 "			month(v.fecproceso)=1 then  'ENERO' WHEN " & _
                                 "			month(v.fecproceso)=2 then  'FEBRERO' WHEN " & _
                                 "			month(v.fecproceso)=3 then  'MARZO' WHEN " & _
                                 "			month(v.fecproceso)=4 then  'ABRIL' WHEN " & _
                                 "			month(v.fecproceso)=5 then  'MAYO' WHEN " & _
                                 "			month(v.fecproceso)=6 then  'JUNIO' WHEN " & _
                                 "			month(v.fecproceso)=7 then  'JULIO' WHEN " & _
                                 "			month(v.fecproceso)=8 then  'AGOSTO' WHEN " & _
                                 "			month(v.fecproceso)=9 then  'SETIEMBRE' WHEN " & _
                                 "			month(v.fecproceso)=10 then 'OCTUBRE' WHEN " & _
                                 "			month(v.fecproceso)=11 then 'NOVIEMBRE' WHEN " & _
                                 "			month(v.fecproceso)=12 then 'DICIEMBRE' END " & _
                                 "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from " & TABLAC & " v,vendedor c where v.codvend=c.codvend and " & _
                                 "	 v.fecproceso between '" & F1 & "' and '" & F2 & "'" & _
                                 "	GROUP BY C.CODvend,c.dsvend, " & _
                                 "	v.FECPROCESO "
                        End If

                        Label7.Text = "Procesando Reportes.."
                        Label7.Refresh()
                        Label7.Text = "Procesando Reportes....."
                        Label7.Refresh()
                        Label7.Text = "Procesando Reportes........"
                        Label7.Refresh()
                        Label7.Text = "Comprobando Informacion..........."
                        Label7.Refresh()
                        TmpInsertDatos(SQL)
                    End If




                    If Trim(CDMONEDA) = "D" Then

                        If Me.lstclie1.Items.Count = 0 Then
                            SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
                                 " SELECT '01/' + CAST(MONTH(v.fecproceso) AS VARCHAR(20))+ '/' + CAST(year(v.fecproceso) AS VARCHAR(20)) " & _
                                 "  , C.CODvend,c.dsvend " & _
                                 "		,sum(TOTEXT),year(v.fecproceso),'MES'=case when " & _
                                 "			month(v.fecproceso)=1 then  'ENERO' WHEN " & _
                                 "			month(v.fecproceso)=2 then  'FEBRERO' WHEN " & _
                                 "			month(v.fecproceso)=3 then  'MARZO' WHEN " & _
                                 "			month(v.fecproceso)=4 then  'ABRIL' WHEN " & _
                                 "			month(v.fecproceso)=5 then  'MAYO' WHEN " & _
                                 "			month(v.fecproceso)=6 then  'JUNIO' WHEN " & _
                                 "			month(v.fecproceso)=7 then  'JULIO' WHEN " & _
                                 "			month(v.fecproceso)=8 then  'AGOSTO' WHEN " & _
                                 "			month(v.fecproceso)=9 then  'SETIEMBRE' WHEN " & _
                                 "			month(v.fecproceso)=10 then 'OCTUBRE' WHEN " & _
                                 "			month(v.fecproceso)=11 then 'NOVIEMBRE' WHEN " & _
                                 "			month(v.fecproceso)=12 then 'DICIEMBRE' END " & _
                                 "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from " & TABLAC & " v,vendedor c where v.codvend=c.codvend and " & _
                                 "	 v.fecproceso between '" & F1 & "' and '" & F2 & "'" & _
                                 "	GROUP BY C.CODvend,c.dsvend, " & _
                                 "	v.FECPROCESO"

                        Else
                            SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
                                 " SELECT '01/' + CAST(MONTH(v.fecproceso) AS VARCHAR(20))+ '/' + CAST(year(v.fecproceso) AS VARCHAR(20)) " & _
                                 "  , C.CODvend,c.dsvend " & _
                                 "		,sum(TOTEXT),year(v.fecproceso),'MES'=case when " & _
                                 "			month(v.fecproceso)=1 then  'ENERO' WHEN " & _
                                 "			month(v.fecproceso)=2 then  'FEBRERO' WHEN " & _
                                 "			month(v.fecproceso)=3 then  'MARZO' WHEN " & _
                                 "			month(v.fecproceso)=4 then  'ABRIL' WHEN " & _
                                 "			month(v.fecproceso)=5 then  'MAYO' WHEN " & _
                                 "			month(v.fecproceso)=6 then  'JUNIO' WHEN " & _
                                 "			month(v.fecproceso)=7 then  'JULIO' WHEN " & _
                                 "			month(v.fecproceso)=8 then  'AGOSTO' WHEN " & _
                                 "			month(v.fecproceso)=9 then  'SETIEMBRE' WHEN " & _
                                 "			month(v.fecproceso)=10 then 'OCTUBRE' WHEN " & _
                                 "			month(v.fecproceso)=11 then 'NOVIEMBRE' WHEN " & _
                                 "			month(v.fecproceso)=12 then 'DICIEMBRE' END " & _
                                 "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from " & TABLAC & " v,vendedor c where v.codvend=c.codvend and " & _
                                 "	 v.fecproceso between '" & F1 & "' and '" & F2 & "'" & _
                                 "	GROUP BY C.CODvend,c.dsvend, " & _
                                 "	v.FECPROCESO"
                        End If

                        Label7.Text = "Procesando Reportes.."
                        Label7.Refresh()
                        Label7.Text = "Procesando Reportes....."
                        Label7.Refresh()
                        Label7.Text = "Procesando Reportes........"
                        Label7.Refresh()
                        Label7.Text = "Comprobando Informacion..........."
                        Label7.Refresh()

                        TmpInsertDatos(SQL)
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '            Debug.WriteLine(TABLAC) : Debug.WriteLine(TABLAD)
        Next
        Call imprimereport()
        Label7.Visible = False
    End Sub
    Sub imprimereport()
        Try
            With CRT
                .WindowShowExportBtn = True
                .WindowShowPrintBtn = True
                .WindowShowPrintSetupBtn = True
                .set_Formulas(1, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(4, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "Fhasta='" & dtpfecha2.Value.ToShortDateString & "'")
                .set_Formulas(3, "Fini='" & dtpfecha1.Value.ToShortDateString & "'")
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .ReportFileName = RutaRptInv + CType("Rpt_ventasxvendedor.rpt", String)
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
        End Try
    End Sub
    Function MES(ByVal NUMMES As String) As String
        MES = ""
        Select Case NUMMES
            Case Is = "01"
                MES = "ENERO"
            Case Is = "02"
                MES = "FEBRERO"
            Case Is = "03"
                MES = "MARZO"
            Case Is = "04"
                MES = "ABRIL"
            Case Is = "05"
                MES = "MAYO"
            Case Is = "06"
                MES = "JUNIO"
            Case Is = "07"
                MES = "JULIO"
            Case Is = "08"
                MES = "AGOSTO"
            Case Is = "09"
                MES = "SEPTIEMBRE"
            Case Is = "10"
                MES = "OCTUBRE"
            Case Is = "11"
                MES = "NOVIEMBRE"
            Case Is = "12"
                MES = "DICIEMBRE"
        End Select
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label7.Width = Label7.Width + 1
        Label7.Refresh()
        If Label7.Width = 394 Then
            Label7.Width = 0
        End If
        Label7.Refresh()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfiltro.TextChanged
        Buscar()
    End Sub
    Private Sub Buscar()
        lstclie1.Items.Clear()
        lstcod1.Items.Clear()
        Dim dv As New DataView
        ds = TmpListarDataset("sp_select_vendedorreport '" & codempresa & "'")
        dv = ds.Tables(0).DefaultView

        dv.RowFilter = "dsvend like '" & txtfiltro.Text.Trim & "*'"
        For Each dr As DataRow In dv.ToTable.Rows
            lstclie1.Items.Add(Trim(dr.Item(1).ToString))
        Next
        For Each dr As DataRow In dv.ToTable.Rows
            lstcod1.Items.Add(Trim(dr.Item(0).ToString))
        Next

    End Sub
End Class
