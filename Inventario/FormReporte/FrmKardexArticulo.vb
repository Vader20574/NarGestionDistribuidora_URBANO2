Public Class FrmKardexArticulo
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblArticulo As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnpassizt As System.Windows.Forms.Button
    Friend WithEvents btnpassiz As System.Windows.Forms.Button
    Friend WithEvents btnpasde As System.Windows.Forms.Button
    Friend WithEvents btnpasdet As System.Windows.Forms.Button
    Friend WithEvents lbvende2 As System.Windows.Forms.ListBox
    Friend WithEvents lbvende1 As System.Windows.Forms.ListBox
    Friend WithEvents BtnBusc As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKardexArticulo))
        Me.BtnGenerar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CboAlmacen = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblArticulo = New System.Windows.Forms.Label
        Me.BtnBusc = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Rpt1 = New AxCrystal.AxCrystalReport
        Me.btnpassizt = New System.Windows.Forms.Button
        Me.btnpassiz = New System.Windows.Forms.Button
        Me.btnpasde = New System.Windows.Forms.Button
        Me.btnpasdet = New System.Windows.Forms.Button
        Me.lbvende2 = New System.Windows.Forms.ListBox
        Me.lbvende1 = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGenerar
        '
        Me.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGenerar.ImageIndex = 11
        Me.BtnGenerar.ImageList = Me.ImageList1
        Me.BtnGenerar.Location = New System.Drawing.Point(102, 206)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerar.TabIndex = 0
        Me.BtnGenerar.Text = "&Generar"
        Me.BtnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.ImageList1.Images.SetKeyName(14, "")
        Me.ImageList1.Images.SetKeyName(15, "")
        Me.ImageList1.Images.SetKeyName(16, "")
        Me.ImageList1.Images.SetKeyName(17, "")
        Me.ImageList1.Images.SetKeyName(18, "")
        Me.ImageList1.Images.SetKeyName(19, "")
        Me.ImageList1.Images.SetKeyName(20, "")
        Me.ImageList1.Images.SetKeyName(21, "")
        Me.ImageList1.Images.SetKeyName(22, "")
        Me.ImageList1.Images.SetKeyName(23, "")
        Me.ImageList1.Images.SetKeyName(24, "")
        Me.ImageList1.Images.SetKeyName(25, "")
        Me.ImageList1.Images.SetKeyName(26, "")
        Me.ImageList1.Images.SetKeyName(27, "")
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(270, 206)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "     &Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboAlmacen)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LblArticulo)
        Me.GroupBox1.Controls.Add(Me.BtnBusc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 116)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Articulo"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(76, 21)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(190, 20)
        Me.TxtCodigo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Codigo : "
        '
        'CboAlmacen
        '
        Me.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAlmacen.Location = New System.Drawing.Point(74, 82)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(210, 21)
        Me.CboAlmacen.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Almacen : "
        '
        'LblArticulo
        '
        Me.LblArticulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblArticulo.Location = New System.Drawing.Point(74, 50)
        Me.LblArticulo.Name = "LblArticulo"
        Me.LblArticulo.Size = New System.Drawing.Size(362, 23)
        Me.LblArticulo.TabIndex = 2
        Me.LblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBusc
        '
        Me.BtnBusc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBusc.ImageIndex = 5
        Me.BtnBusc.ImageList = Me.ImageList1
        Me.BtnBusc.Location = New System.Drawing.Point(270, 20)
        Me.BtnBusc.Name = "BtnBusc"
        Me.BtnBusc.Size = New System.Drawing.Size(34, 28)
        Me.BtnBusc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripcion : "
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(76, 26)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(90, 20)
        Me.DtFechaIni.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desde :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta : "
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(266, 24)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.DtFechaFin.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtFechaIni)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DtFechaFin)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 58)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fecha"
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(412, 204)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 8
        '
        'btnpassizt
        '
        Me.btnpassizt.Location = New System.Drawing.Point(202, 382)
        Me.btnpassizt.Name = "btnpassizt"
        Me.btnpassizt.Size = New System.Drawing.Size(65, 23)
        Me.btnpassizt.TabIndex = 46
        Me.btnpassizt.Text = "<<"
        Me.btnpassizt.UseVisualStyleBackColor = True
        '
        'btnpassiz
        '
        Me.btnpassiz.Location = New System.Drawing.Point(202, 347)
        Me.btnpassiz.Name = "btnpassiz"
        Me.btnpassiz.Size = New System.Drawing.Size(65, 23)
        Me.btnpassiz.TabIndex = 48
        Me.btnpassiz.Text = "<"
        Me.btnpassiz.UseVisualStyleBackColor = True
        '
        'btnpasde
        '
        Me.btnpasde.Location = New System.Drawing.Point(202, 312)
        Me.btnpasde.Name = "btnpasde"
        Me.btnpasde.Size = New System.Drawing.Size(65, 23)
        Me.btnpasde.TabIndex = 49
        Me.btnpasde.Text = ">"
        Me.btnpasde.UseVisualStyleBackColor = True
        '
        'btnpasdet
        '
        Me.btnpasdet.Location = New System.Drawing.Point(202, 277)
        Me.btnpasdet.Name = "btnpasdet"
        Me.btnpasdet.Size = New System.Drawing.Size(65, 23)
        Me.btnpasdet.TabIndex = 47
        Me.btnpasdet.Text = ">>"
        Me.btnpasdet.UseVisualStyleBackColor = True
        '
        'lbvende2
        '
        Me.lbvende2.FormattingEnabled = True
        Me.lbvende2.Location = New System.Drawing.Point(313, 266)
        Me.lbvende2.Name = "lbvende2"
        Me.lbvende2.Size = New System.Drawing.Size(155, 147)
        Me.lbvende2.TabIndex = 44
        '
        'lbvende1
        '
        Me.lbvende1.FormattingEnabled = True
        Me.lbvende1.Location = New System.Drawing.Point(12, 266)
        Me.lbvende1.Name = "lbvende1"
        Me.lbvende1.Size = New System.Drawing.Size(155, 160)
        Me.lbvende1.TabIndex = 45
        '
        'FrmKardexArticulo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(567, 540)
        Me.Controls.Add(Me.btnpassizt)
        Me.Controls.Add(Me.btnpassiz)
        Me.Controls.Add(Me.btnpasde)
        Me.Controls.Add(Me.btnpasdet)
        Me.Controls.Add(Me.lbvende2)
        Me.Controls.Add(Me.lbvende1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.Rpt1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmKardexArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Kardex de Articulo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields Form"

    Dim Cierrealdia As Boolean
    Dim Fechari, Fecharf As Date
    Dim MstrFechaIni, MstrFechaFin As String
    Dim Meses As Integer
    Dim PresInicial As String
#End Region

#Region "Function Form"
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
    Private Function BuscaUltCierre(ByVal StrAlmacen As String, ByVal FecSaldo As Date) As String
        Dim StrCad, UltFecha As String
        Dim rs As New DataTable
        StrCad = "select * from resukdx  where fecha='" & FecSaldo & "' AND CODEMPRESA='" & codempresa & "' "
        rs = TmpListarDatos(StrCad)
        If rs.Rows.Count > 0 Then
            UltFecha = Format(rs.Rows(0)("FECHA"), "dd/MM/yyyy")
            Cierrealdia = True
        Else
            StrCad = "SELECT MAX(FECHA) AS MAX_FECHA FROM RESUKDX WHERE ALMACEN='" & StrAlmacen & "' AND  fechA >='" & FecSaldo & "' AND  CODEMPRESA='" & codempresa & "'  GROUP BY CODARTI "
            rs = TmpListarDatos(StrCad)
            If rs.Rows.Count > 0 Then
                UltFecha = Format(rs.Rows(0)("MAX_FECHA"), "dd/MM/yyyy")
            Else
                StrCad = "SELECT MAX(FECHA) AS MAX_FECHA FROM RESUKDX WHERE ALMACEN='" & StrAlmacen & "' AND  fechA <='" & FecSaldo & "' AND  CODEMPRESA='" & codempresa & "'  GROUP BY CODARTI "
                rs = TmpListarDatos(StrCad)
                If rs.Rows.Count > 0 Then
                    UltFecha = Format(rs.Rows(0)("MAX_FECHA"), "dd/MM/yyyy")

                Else

                    UltFecha = DtFechaIni.Value
                    Cierrealdia = True
                End If
            End If
        End If
        BuscaUltCierre = UltFecha

    End Function
    Private Function SelectFechCiere(ByVal fecha As Date, ByVal HizoCierre As Boolean, ByVal StrAlmacen As String) As DataTable

        Dim dt As New DataTable
        If HizoCierre = True Then
            'dt = TmpListarDatos("select * from resukdx where fecha='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select *  from CIERRE_MES_INVENTARIO where fecha=('" & Format(fecha, "dd/MM/yyyy") & "') AND ALMACEN ='" & StrAlmacen & "'")
        Else
            'dt = TmpListarDatos("SELECT max (fechA) AS FECHA from resukdx where fechA <= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select max (fechA) AS Fecha from CIERRE_MES_INVENTARIO where fecha <='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
        End If

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("Fecha") Is DBNull.Value Then
                'dt = TmpListarDatos("SELECT mIN (fechA) AS FECHa from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
                dt = TmpListarDatos("select mIN (fechA)  AS Fecha from CIERRE_MES_INVENTARIO where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")

            End If
        Else
            '  dt = TmpListarDatos("SELECT distinct FECHA=max(fecha) from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'   AND ALMACEN ='" & StrAlmacen & "'  group by CODARTI")

            dt = TmpListarDatos("select distinct FECHA=max(fecha)  from CIERRE_MES_INVENTARIO where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "' group by articulo ")
         
        End If

        Return dt

    End Function
    Private Sub Generar_Reporte_New()
        Dim FECHCIERRE As Date
        Dim f, Fech As Date
        Dim dt As New DataTable
        Dim fecini As Date

        Cierrealdia = False
        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)
        f = DateAdd("d", 1, Fech)

        dt = SelectFechCiere(Fech, True, Trim(Me.CboAlmacen.SelectedValue.ToString))

        If dt.Rows.Count <> 0 And Date.Parse(DtFechaIni.Value.ToShortDateString) = Date.Parse(f.ToShortDateString) Then
            Cierrealdia = True
            FECHCIERRE = CDate(dt.Rows(0)("FECHA"))
            fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")
            ProcesarSaldo(FECHCIERRE, True)

        Else 'OBTENIENDO LA FECHA DE CIERRE MAS CERCANO
            dt = SelectFechCiere(Fech, False, Trim(Me.CboAlmacen.SelectedValue.ToString))
            FECHCIERRE = IIf(dt.Rows(0)("FECHA") Is DBNull.Value, "01/01/2013", dt.Rows(0)("FECHA"))

            Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
            Fecharf = DateAdd("d", -1, DtFechaIni.Value)


            TmpInsertDatos("DELETE FROM TEMPORAL  WHERE  CODEMPRESA='" & codempresa & "'")

            ProcesarSaldo(FECHCIERRE, False)


            Dim resukdx As New DataTable
            Dim saldoini As String
            resukdx = TmpListarDatos(" SELECT ALMACEN,CIERRE_MES_INVENTARIO.ARTICULO,STOCK AS STKINICIO " & _
                                  " FROM CIERRE_MES_INVENTARIO WHERE ARTICULO='" & TxtCodigo.Text & "' AND ALMACEN='" & Trim(CboAlmacen.SelectedValue) & "' AND FECHa='" & Format(FECHCIERRE, "dd/MM/yyyy") & "'")
            If resukdx.Rows.Count = 0 Then
                saldoini = 0
            Else
                saldoini = resukdx.Rows(0)("STKINICIO")
                TmpInsertDatos("insert into TEMPORAL(CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS, VENTAS, SALAJUSTE, SALTRANSF, SALOTROS, CODEMPRESA) values('" + CboAlmacen.SelectedValue.ToString + "',DBO.FN_LINEA('" + codempresa + "','" + TxtCodigo.Text + "'),'" + TxtCodigo.Text + "', " + saldoini + ", 0, 0, 0, 0, 0, 0, 0, 0, 0,'" + codempresa + "')")
            End If

            TmpInsertDatos("DELETE FROM TMP_SUMKARDEX  WHERE  CODEMPRESA='" & codempresa & "'")
            TmpInsertDatos("INSERT INTO TMP_SUMKARDEX(CODEMPRESA,CDALMA,CDG01,CDARTI,STOCKINI,STOCKREC,COMPRAS,INGAJUSTE,INGTRANSF,INGOTROS,VENTAS,SALAJUSTE,SALTRANsF,salotros,SALDOFIN) SELECT  CODEMPRESA,CDALMA,CDG01,CDARTI,SUM(STOCKINI) AS STOKINI,SUM(STOCKREC) AS STOCKREC,SUM(COMPRAS) AS COMPRAS,SUM(INGAJUSTE) AS INGAJUSTE,SUM(INGTRANSF) AS INGTRANSF,SUM(INGOTROS) AS INGOTROS,SUM(VENTAS) AS VENTAS, SUM(SALAJUSTE) AS SALAJUSTE ,SUM(SALTRANSF) AS SALTRANF,SUM(SALOTROS),0 AS SALDOFIN FROM TEMPORAL  WHERE CODEMPRESA='" & codempresa & "' GROUP BY  CODEMPRESA,CDALMA,CDG01,CDARTI")
            TmpInsertDatos("update tmp_sumkardex set saldofin=(STOCKINI+COMPRAS+INGAJUSTE+INGTRANSF+INGOTROS-VENTAS-SALAJUSTE-SALTRANsF-salotros) WHERE CODEMPRESA='" & codempresa & "'")
            'TmpInsertDatos("update tmp_sumkardex set saldofin=(select TOP 1 STKACTU from artidat where codarti='" & TxtCodigo.Text.ToString & "' and CODEMPRESA='" & codempresa & "' and codalmacen='" & CboAlmacen.SelectedValue.ToString & "')")
            TmpInsertDatos("Delete from resu_kdxtmp WHERE CODEMPRESA='" & codempresa & "' ")
            TmpInsertDatos("INSERT INTO RESU_KDXTMP(CODEMPRESA,CDARTI,CDALMA,FECH_CIERRE,CANT_SALIDA,CANT_INGR,CANT_SALDO) SELECT CODEMPRESA,CDARTI,CDALMA,'" & Format(Fecharf, "dd/MM/yyyy") & "',0,0,saldofin from tmp_sumkardex  WHERE CODEMPRESA='" & codempresa & "'")

            ProcesarSaldo(Fecharf, True)

        End If

    End Sub
    Sub ProcesarSaldo(ByVal fcierre As Date, ByVal Cierreigual As Boolean)
        Dim MesAct, ANIO, TablaD, TablaC, MoviDet, MoviCab As String
        If Cierreigual = True Then
            Fechari = DateAdd("d", 1, fcierre)
            Fecharf = DateAdd("d", -1, DtFechaFin.Value)
            MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy 00:00:00")
            MstrFechaFin = Format(DtFechaFin.Value, "dd/MM/yyyy 23:59:00")
            'fecini = Format(DtFechaIni.Value, "DD/MM/YYYY")
            Meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            TmpInsertDatos("Delete from TMp_kardexart  WHERE CODEMPRESA='" & codempresa & "'")

            TmpInsertDatos("KARDEX_articulo_REPORT_saldo  '" & codempresa & "','" & VCodArti & "','" & MstrFechaIni & "','" & MstrFechaFin & "','" & CDMONBASE & "','" & Trim(CboAlmacen.SelectedValue) & "','0','VENTAD','VENTAC','" & fcierre & "','0','MOVID','MOVIC'," & rand)

            'Registros del Histórico
            For i As Integer = 0 To Meses
                MesAct = Format(DateAdd("m", i, MstrFechaIni), "MM")
                ANIO = Format(DateAdd("m", i, MstrFechaIni), "yyyy")

                'Nombre de las tablas a Consultar
                TablaD = "VENTD" & ANIO & MesAct
                TablaC = "VENTC" & ANIO & MesAct
                MoviDet = "MOVID" & ANIO & MesAct
                MoviCab = "MOVIC" & ANIO & MesAct

                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviCab & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_ARTICULO_REPORT_SALDO_MOVI_N  '" & codempresa & "','" & VCodArti & "','" & MstrFechaIni & "','" & MstrFechaFin & "','" & CDMONBASE & "','" & Trim(CboAlmacen.SelectedValue) & "','1','" & fcierre & "','0','" & MoviDet & "','" & MoviCab & "'," & rand)
                End If

                If VERIFICA_HISTORICOVENT(TablaC) = True Then
                    TmpInsertDatos("KARDEX_ARTICULO_REPORT_SALDO_VENTAS_N  '" & codempresa & "','" & VCodArti & "','" & MstrFechaIni & "','" & MstrFechaFin & "','" & CDMONBASE & "','" & Trim(CboAlmacen.SelectedValue) & "','1','" & TablaD & "','" & TablaC & "','" & fcierre & "','0'," & rand)
                End If

            Next
            SelectKardexart(Cierrealdia, Trim(fcierre))

        Else
            Fechari = DateAdd("d", 1, fcierre)
            Fecharf = DateAdd("d", -1, DtFechaIni.Value)

            'fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")
            Meses = Val(DateDiff("m", Format(Fechari, "dd/MM/yyyy"), Fecharf))
            MstrFechaIni = Format(Fechari, "dd/MM/yyyy 00:00:00")
            MstrFechaFin = Format(Fecharf, "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_ARTICULO_RECALCULO  '" & codempresa & "','" & VCodArti & "','" & MstrFechaIni & "','" & MstrFechaFin & "','" & CDMONBASE & "','" & Trim(CboAlmacen.SelectedValue) & "','0','VENTADET','" & fcierre & "',1,'MOVIDET'")
            ''Registros del Histórico

            For i As Integer = 0 To Meses
                MesAct = Format(DateAdd("m", i, MstrFechaIni), "MM")
                ANIO = Format(DateAdd("m", i, MstrFechaIni), "yyyy")
                TablaC = "VENTC" & ANIO & MesAct
                TablaD = "VENTD" & ANIO & MesAct
                MoviCab = "MOVIC" & ANIO & MesAct
                MoviDet = "MOVID" & ANIO & MesAct
                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviCab & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_ARTICULO_RECALCULO_INGSAL  '" & codempresa & "','" & VCodArti & "','" & MstrFechaIni & "','" & MstrFechaFin & "','" & CDMONBASE & "','" & Trim(CboAlmacen.SelectedValue) & "','1','" & fcierre & "','0','" & MoviCab & "','" & MoviDet & "'")
                End If

                If VERIFICA_HISTORICOVENT(TablaC) = True Then
                    TmpInsertDatos("KARDEX_ARTICULO_RECALCULO_VENTAS_N  '" & codempresa & "','" & VCodArti & "','" & MstrFechaIni & "','" & MstrFechaFin & "','" & CDMONBASE & "','" & Trim(CboAlmacen.SelectedValue) & "','1','" & fcierre & "','0','" & TablaC & "','" & TablaD & "'")
                End If
            Next
        End If
    End Sub

    Sub SelectKardexart(ByVal cierrealdia As Boolean, ByVal fecha As Date)
        TmpInsertDatos("Delete from kardexdet_tmp  WHERE  CODEMPRESA='" & codempresa & "'")
        Dim tmp_kardexArt As New DataTable
        Dim resukdx As New DataTable
        Dim saldoini As Decimal
        Dim Present As String
        tmp_kardexArt = TmpListarDatos("Select CDALMACEN,dSALMACEN,CDARTI,DSARTI,CDG01,DSG01,UNIMED,FECHA,NROMOVI,CDTIPDOC,ABRVTIPDOC,NRODOC,(COMPRAS+INGAJUSTE+INGTRANSF+INGOTROS) as CI,  (VENTAS+ SALAJUSTE + SALTRANSF + SALOTROS)as CS,SALDOFIN from tmp_kardexArt WHERE  CODEMPRESA='" & codempresa & "'  order by fecha,ABRVTIPDOC,nrodoc")

        If tmp_kardexArt.Rows.Count <> 0 Then
            'If cierrealdia = True Then
            '    resukdx = TmpListarDatos(" SELECT ALMACEN,CIERRE_MES_INVENTARIO.ARTICULO,STOCK AS STKINICIO " & _
            '                          " FROM CIERRE_MES_INVENTARIO WHERE ARTICULO='" & tmp_kardexArt.Rows(0)("CDARTI") & "' AND ALMACEN='" & Trim(CboAlmacen.SelectedValue) & "' AND FECHa='" & Format(fecha, "dd/MM/yyyy") & "'")
            'Else
            '    resukdx = TmpListarDatos(" SELECT ALMACEN,CIERRE_MES_INVENTARIO.ARTICULO,STOCK AS STKINICIO " & _
            '                          " FROM CIERRE_MES_INVENTARIO WHERE ARTICULO='" & tmp_kardexArt.Rows(0)("CDARTI") & "' AND ALMACEN='" & Trim(CboAlmacen.SelectedValue) & "' AND FECHa='" & Format(fecha, "dd/MM/yyyy") & "'")
            'End If

            If cierrealdia = True Then
                resukdx = TmpListarDatos(" SELECT ALMACEN,CIERRE_MES_INVENTARIO.ARTICULO,STOCK AS STKINICIO " & _
                      " FROM CIERRE_MES_INVENTARIO WHERE ARTICULO='" & VCodArti & "' AND ALMACEN='" & Trim(CboAlmacen.SelectedValue) & "' AND FECHa='" & Format(fecha, "dd/MM/yyyy") & "'")
            Else
                resukdx = TmpListarDatos(" SELECT CDALMA,RESU_KDXTMP.CDARTI,CANT_SALDO AS STKINICIO " & _
                                     " FROM RESU_KDXTMP WHERE CDARTI='" & tmp_kardexArt.Rows(0)("CDARTI") & " ' AND  CDALMA='" & Trim(CboAlmacen.SelectedValue) & "' AND FECH_CIERRE='" & Format(fecha, "dd/MM/yyyy") & "'")
            End If



            If resukdx.Rows.Count = 0 Then
                saldoini = 0
            Else
                saldoini = resukdx.Rows(0)("STKINICIO")
            End If
            'aqui VA CUANDO HAY MOVIMIENTOS
            Dim saldofin As Decimal
            For k As Integer = 0 To tmp_kardexArt.Rows.Count - 1
                If k = 0 Then
                    PresInicial = DevolverPresent(VCodArti, saldoini)
                End If
                'Else
                '    Present = ""
                'End If
                saldofin = saldoini + CDec(tmp_kardexArt.Rows(k)("CI")) - CDec(tmp_kardexArt.Rows(k)("CS"))
                Present = DevolverPresent(VCodArti, saldofin)
                TmpInsertDatos("insert into kardexdet_tmp(CODEMPRESA,item,CDARTI,DSARTI, CDALMACEN,DSALMACEN,CDG01,DSG01,UNIDAD,  FECHA,NROMOVI,TIPODOC,NRODOCUM,SALDOINI,INGRESOS,SALIDAS,SALDOFIN,CTOPROM,PRESENTACION) values('" & codempresa & "', " & k & " ,'" & Trim(tmp_kardexArt.Rows(k)("CDARTI")) & "','" & Trim(tmp_kardexArt.Rows(k)("DSARTI")) & "','" & Trim(tmp_kardexArt.Rows(k)("CDALMACEN")) & "','" & Trim(tmp_kardexArt.Rows(k)("DSALMACEN")) & "','" & Trim(tmp_kardexArt.Rows(k)("CDG01")) & "','" & Trim(tmp_kardexArt.Rows(k)("DSG01")) & "','" & Trim(tmp_kardexArt.Rows(k)("UNIMED")) & "','" & Format(CDate(tmp_kardexArt.Rows(k)("FECHA")), "dd/MM/yyyy") & "','" & Trim(tmp_kardexArt.Rows(k)("NROMOVI")) & "','" & Trim(tmp_kardexArt.Rows(k)("ABRVTIPDOC")) & "','" & Trim(tmp_kardexArt.Rows(k)("NRODOC")) & "'," & saldoini & "," & CDec(tmp_kardexArt.Rows(k)("CI")) & " ," & CDec(tmp_kardexArt.Rows(k)("CS")) & " , " & saldofin & ",0,'" & Present & "')")
                saldoini = saldoini + CDec(tmp_kardexArt.Rows(k)("CI")) - CDec(tmp_kardexArt.Rows(k)("CS"))
            Next

        Else
            'AQUI ES CUANDO NO HAY MOVIMIENTO SOLO SALDO INICIAL
     

            If cierrealdia = True Then
                resukdx = TmpListarDatos(" SELECT ALMACEN,CIERRE_MES_INVENTARIO.ARTICULO,STOCK AS STKINICIO " & _
                      " FROM CIERRE_MES_INVENTARIO WHERE ARTICULO='" & VCodArti & "' AND ALMACEN='" & Trim(CboAlmacen.SelectedValue) & "' AND FECHa='" & Format(fecha, "dd/MM/yyyy") & "'")
            Else
                resukdx = TmpListarDatos(" SELECT CDALMA,RESU_KDXTMP.CDARTI,CANT_SALDO AS STKINICIO " & _
                      " FROM RESU_KDXTMP WHERE CDARTI='" & VCodArti & " ' AND  CDALMA='" & Trim(CboAlmacen.SelectedValue) & "' AND FECH_CIERRE='" & Format(fecha, "dd/MM/yyyy") & "'")
            End If


            If resukdx.Rows.Count = 0 Then
                saldoini = 0
            Else
                saldoini = resukdx.Rows(0)("STKINICIO")
            End If

            If saldoini <> 0 Then
                Dim rsk As New DataTable
                rsk = TmpListarDatos("SELECT ARTICULO.CODUMED, ARTICULO.CODLINEA, LINEA.DESLINEA FROM ARTICULO INNER JOIN LINEA ON ARTICULO.CODLINEA = LINEA.CODLINEA AND ARTICULO.CODEMPRESA=LINEA.CODEMPRESA WHERE CODARTI ='" & VCodArti & "' AND LINEA.CODEMPRESA='" & codempresa & "'")
                Present = DevolverPresent(VCodArti, saldoini)
                TmpInsertDatos("insert into kardexdet_tmp(CODEMPRESA,item,CDARTI,DSARTI, CDALMACEN,DSALMACEN,CDG01,DSG01,UNIDAD,  FECHA,NROMOVI,TIPODOC,NRODOCUM,SALDOINI,INGRESOS,SALIDAS,SALDOFIN,CTOPROM,PRESENTACION) values('" & codempresa & "', " & 1 & " ,'" & VCodArti & "','" & LblArticulo.Text.Trim & "','" & Trim(CboAlmacen.SelectedValue.ToString) & "','" & CboAlmacen.Text.Trim & "','" & Trim(rsk.Rows(0)("CODLINEA")) & "','" & Trim(rsk.Rows(0)("DESLINEA")) & "','" & Trim(rsk.Rows(0)("CODUMED")) & "','" & Format(CDate(fecha), "dd/MM/yyyy") & "',0,'-','-'," & saldoini & ",0 ,0, " & saldoini + 0 - 0 & ",0,'" & Present & "') ")
            End If
        End If

    End Sub
   

    Private Function DevolverPresent(ByVal DcdArti As String, ByVal DMonto As Double) As String
        Dim Monto, Equiv As Double
        Dim Present As String = ""
        Dim CodPres As String = ""

        Dim TbArtiPresent As New DataTable
        TbArtiPresent = TmpListarDatos("SELECT  CODEMPRESA,CODARTI,CODPRES,EQUIVALENCIA  FROM  ARTIPRESENT  WHERE  CODEMPRESA='" & codempresa & "'  AND CODARTI='" & DcdArti & "'  ORDER BY EQUIVALENCIA DESC")
        For i As Integer = 0 To TbArtiPresent.Rows.Count - 1
            CodPres = Trim(TbArtiPresent.Rows(i)("CODPRES"))
            Equiv = CDbl(TbArtiPresent.Rows(i)("EQUIVALENCIA"))
            Monto = TmpListarDatos("SELECT  (" & DMonto & "/" & Equiv & ")").Rows(0)(0)
            If Monto > 0 Then
                If Trim(Present) = "" Then
                    Present = Trim(Monto) + "  " + Trim(TmpListarDatos("SELECT  DESPRES FROM PRESENTACION   WHERE  CODEMPRESA='" & codempresa & "' AND  CODPRES='" & CodPres & "'").Rows(0)(0))
                Else
                    Present = Present + " + " + Trim(Monto) + "  " + Trim(TmpListarDatos("SELECT  DESPRES FROM PRESENTACION   WHERE  CODEMPRESA='" & codempresa & "' AND  CODPRES='" & CodPres & "'").Rows(0)(0))
                End If
            End If
            DMonto = DMonto - (Monto * Equiv)
            If DMonto = 0 Then
                Exit For
            End If

        Next

        Return Present

    End Function

#End Region

    Private Function Validar() As Boolean
        If TxtCodigo.Text.Trim.Length = 0 Then
            MsgBox("Seleccione un articulo.", MsgBoxStyle.Information, "NARSISTEMAS")
            Return False
        End If

        If LblArticulo.Text.Trim.Length = 0 Then
            MsgBox("Seleccione un articulo falta la despcripcion.", MsgBoxStyle.Information, "NARSISTEMAS")
            Return False
        End If

        If CDate(DtFechaIni.Value.ToShortDateString) > CDate(DtFechaFin.Value.ToShortDateString) Then
            MsgBox("Fecha fuera de rango.", MsgBoxStyle.Information, "NARSISTEMAS")
            Return False
        End If
        Return True
    End Function

    Dim rand As Integer

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click

        Dim SQL As String
        SQL = "DELETE_TMP_TIPO_DOC " & rand
        If TmpInsertDatos(SQL) = True Then
        End If

        For k As Integer = 0 To ListaV2.Count - 1
            ListaV.Add(ListaV2.Item(k))
            SQL = "INSERT_TMP_TIPO_DOC '" & ListaV2.Item(k).CODIGO.ToString & "','" & rand & "'"
            If TmpInsertDatos(SQL) = True Then
            End If
        Next

        If Validar() = False Then Exit Sub
        PresInicial = ""
        Generar_Reporte_New()
        'GenerarReporte()

        Try
            With Rpt1
                .ReportFileName = RutaRptInv & CType("RptKardexArticulo.rpt", String)
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "FormFecFin='" & Format(CDate(DtFechaFin.Value), "dd/MM/yyyy") & "'")
                .set_Formulas(2, "FormFecIni='" & Format(CDate(DtFechaIni.Value), "dd/MM/yyyy") & "'")
                .set_Formulas(3, "PresInicial='" & PresInicial & "'")
                .set_Formulas(4, "Usuario='" & DesUsuario & "'")



                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)
    Dim i As Integer


    Private Sub FrmKardexArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(CboAlmacen, "SELECT  CODALMACEN,DESALMACEN FROM ALMACEN  WHERE  CODEMPRESA='" & codempresa & "'", "CODALMACEN", "DESALMACEN")


        Dim dt As New DataTable

        dt = CAyuda.ListarDatos("SP_LISTAR_DOCUMENTOS", codempresa).Tables(0)
        ListaV = LLenar(dt)
        lbvende1.DataSource = ListaV


        ValorRan()

    End Sub
    Private Function LLenar(ByVal dt As DataTable) As List(Of ReporteVentaE)
        Dim lista As New List(Of ReporteVentaE)
        For Each dr As DataRow In dt.Rows
            Dim o As New ReporteVentaE
            o.CODIGO = dr.Item(0).ToString
            o.DESCRIPCION = dr.Item(1).ToString
            lista.Add(o)
        Next
        Return lista
    End Function
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub

    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            VCodArti = Trim(TxtCodigo.Text)
            Dim dt_arti As New DataTable
            dt_arti = TmpListarDatos("SELECT  DESARTI FROM  ARTICULO  WHERE CODEMPRESA='" & codempresa & "' AND CODARTI='" & VCodArti & "'")
            If dt_arti.Rows.Count <> 0 Then
                LblArticulo.Text = Trim(dt_arti.Rows(0)(0))
            Else
                MsgBox("El articulo no existe.", MsgBoxStyle.Information, "NARSISTEMAS")
            End If


        End If
    End Sub


    Private Sub BtnBusc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusc.Click
        Dim FrmArt As New frmgridarticulo
        FrmArt.ShowDialog()
        If FrmArt.DEVOLVER = False Then
            Exit Sub
        End If
        TxtCodigo.Text = FrmArt.Grid1.Item(FrmArt.Grid1.CurrentRowIndex, 0)
        VCodArti = Trim(TxtCodigo.Text)
        LblArticulo.Text = Trim(TmpListarDatos("SELECT  DESARTI FROM  ARTICULO  WHERE CODEMPRESA='" & codempresa & "' AND CODARTI='" & VCodArti & "'").Rows(0)(0))

    End Sub

    Private Sub btnpasdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasdet.Click

        For k As Integer = 0 To ListaV.Count - 1
            ListaV2.Add(ListaV.Item(k))
        Next
        ListaV.Clear()
        Actualizar(1)


    End Sub


    Private Sub Actualizar(ByVal a As Int16)
        Select Case a
            Case 0
                'Me.lbfuerza1.DataSource = Nothing
                'Me.lbfuerza2.DataSource = Nothing
                'Me.lbfuerza1.DataSource = ListaF
                'Me.lbfuerza2.DataSource = ListaF2
            Case 1
                Me.lbvende1.DataSource = Nothing
                Me.lbvende2.DataSource = Nothing
                Me.lbvende1.DataSource = ListaV
                Me.lbvende2.DataSource = ListaV2
            Case 2

        End Select
    End Sub


    Private Sub btnpasde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasde.Click

        i = Me.lbvende1.SelectedIndex
        If i < 0 Then Exit Sub
        ListaV2.Add(ListaV.Item(i))
        ListaV.RemoveAt(i)
        Actualizar(1)

    End Sub

    Private Sub btnpassiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpassiz.Click
        i = Me.lbvende2.SelectedIndex
        If i < 0 Then Exit Sub
        ListaV.Add(ListaV2.Item(i))
        ListaV2.RemoveAt(i)
        Actualizar(1)
    End Sub

    Private Sub btnpassizt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpassizt.Click
        For k As Integer = 0 To ListaV2.Count - 1
            ListaV.Add(ListaV2.Item(k))
        Next
        ListaV2.Clear()
        Actualizar(1)
    End Sub
End Class
