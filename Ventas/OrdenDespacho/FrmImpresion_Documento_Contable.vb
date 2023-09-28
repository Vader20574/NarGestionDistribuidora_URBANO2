Public Class FrmImpresion_Documento_Contable
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtIni2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIni1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtfin2 As System.Windows.Forms.TextBox
    Friend WithEvents txtfin1 As System.Windows.Forms.TextBox
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnBusOrden As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBusqDoc As System.Windows.Forms.Button
    Friend WithEvents btnBusqDoc2 As System.Windows.Forms.Button
    Friend WithEvents ChkImpresora As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTicketera As CheckBox
    Friend WithEvents LblOrdenDesp As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpresion_Documento_Contable))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkImpresora = New System.Windows.Forms.CheckBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBusqDoc = New System.Windows.Forms.Button()
        Me.txtIni2 = New System.Windows.Forms.TextBox()
        Me.txtIni1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBusqDoc2 = New System.Windows.Forms.Button()
        Me.txtfin2 = New System.Windows.Forms.TextBox()
        Me.txtfin1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Rpt1 = New AxCrystal.AxCrystalReport()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblOrdenDesp = New System.Windows.Forms.TextBox()
        Me.btnBusOrden = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkTicketera = New System.Windows.Forms.CheckBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ChkTicketera)
        Me.Panel3.Controls.Add(Me.ChkImpresora)
        Me.Panel3.Controls.Add(Me.btnImprimir)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.CboTipoDoc)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(116, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(538, 126)
        Me.Panel3.TabIndex = 0
        '
        'ChkImpresora
        '
        Me.ChkImpresora.Checked = True
        Me.ChkImpresora.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkImpresora.Location = New System.Drawing.Point(446, 2)
        Me.ChkImpresora.Name = "ChkImpresora"
        Me.ChkImpresora.Size = New System.Drawing.Size(88, 24)
        Me.ChkImpresora.TabIndex = 34
        Me.ChkImpresora.Text = "Por pantalla"
        '
        'btnImprimir
        '
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.ImageIndex = 11
        Me.btnImprimir.ImageList = Me.ImageList1
        Me.btnImprimir.Location = New System.Drawing.Point(432, 84)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 30)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "&Imprimir"
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
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(234, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "NroDoc. Final"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "NroDoc. Inicio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Tipo de Documento:  "
        '
        'CboTipoDoc
        '
        Me.CboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoDoc.ItemHeight = 16
        Me.CboTipoDoc.Location = New System.Drawing.Point(6, 34)
        Me.CboTipoDoc.Name = "CboTipoDoc"
        Me.CboTipoDoc.Size = New System.Drawing.Size(216, 24)
        Me.CboTipoDoc.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBusqDoc)
        Me.Panel1.Controls.Add(Me.txtIni2)
        Me.Panel1.Controls.Add(Me.txtIni1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 30)
        Me.Panel1.TabIndex = 1
        '
        'btnBusqDoc
        '
        Me.btnBusqDoc.ImageIndex = 5
        Me.btnBusqDoc.ImageList = Me.ImageList1
        Me.btnBusqDoc.Location = New System.Drawing.Point(154, 2)
        Me.btnBusqDoc.Name = "btnBusqDoc"
        Me.btnBusqDoc.Size = New System.Drawing.Size(34, 26)
        Me.btnBusqDoc.TabIndex = 3
        '
        'txtIni2
        '
        Me.txtIni2.Location = New System.Drawing.Point(60, 4)
        Me.txtIni2.Name = "txtIni2"
        Me.txtIni2.Size = New System.Drawing.Size(87, 20)
        Me.txtIni2.TabIndex = 0
        Me.txtIni2.Text = "0000000"
        '
        'txtIni1
        '
        Me.txtIni1.Location = New System.Drawing.Point(4, 4)
        Me.txtIni1.Name = "txtIni1"
        Me.txtIni1.Size = New System.Drawing.Size(46, 20)
        Me.txtIni1.TabIndex = 1
        Me.txtIni1.Text = "000"
        Me.txtIni1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBusqDoc2)
        Me.Panel2.Controls.Add(Me.txtfin2)
        Me.Panel2.Controls.Add(Me.txtfin1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(216, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 30)
        Me.Panel2.TabIndex = 2
        '
        'btnBusqDoc2
        '
        Me.btnBusqDoc2.ImageIndex = 5
        Me.btnBusqDoc2.ImageList = Me.ImageList1
        Me.btnBusqDoc2.Location = New System.Drawing.Point(154, 1)
        Me.btnBusqDoc2.Name = "btnBusqDoc2"
        Me.btnBusqDoc2.Size = New System.Drawing.Size(34, 26)
        Me.btnBusqDoc2.TabIndex = 4
        '
        'txtfin2
        '
        Me.txtfin2.Location = New System.Drawing.Point(60, 4)
        Me.txtfin2.Name = "txtfin2"
        Me.txtfin2.Size = New System.Drawing.Size(87, 20)
        Me.txtfin2.TabIndex = 1
        Me.txtfin2.Text = "0000000"
        '
        'txtfin1
        '
        Me.txtfin1.Location = New System.Drawing.Point(4, 4)
        Me.txtfin1.Name = "txtfin1"
        Me.txtfin1.Size = New System.Drawing.Size(46, 20)
        Me.txtfin1.TabIndex = 0
        Me.txtfin1.Text = "000"
        Me.txtfin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "-"
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(122, 62)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.ImageIndex = 12
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(6, 156)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(96, 30)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "&Salir"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LblOrdenDesp)
        Me.Panel4.Controls.Add(Me.btnBusOrden)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(118, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(536, 46)
        Me.Panel4.TabIndex = 49
        '
        'LblOrdenDesp
        '
        Me.LblOrdenDesp.Enabled = False
        Me.LblOrdenDesp.Location = New System.Drawing.Point(197, 16)
        Me.LblOrdenDesp.Name = "LblOrdenDesp"
        Me.LblOrdenDesp.Size = New System.Drawing.Size(107, 20)
        Me.LblOrdenDesp.TabIndex = 46
        '
        'btnBusOrden
        '
        Me.btnBusOrden.ImageIndex = 5
        Me.btnBusOrden.ImageList = Me.ImageList1
        Me.btnBusOrden.Location = New System.Drawing.Point(310, 12)
        Me.btnBusOrden.Name = "btnBusOrden"
        Me.btnBusOrden.Size = New System.Drawing.Size(34, 26)
        Me.btnBusOrden.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "NRO ORDEN DESPACHO:"
        '
        'ChkTicketera
        '
        Me.ChkTicketera.Location = New System.Drawing.Point(445, 21)
        Me.ChkTicketera.Name = "ChkTicketera"
        Me.ChkTicketera.Size = New System.Drawing.Size(88, 24)
        Me.ChkTicketera.TabIndex = 36
        Me.ChkTicketera.Text = "Ticketera"
        '
        'FrmImpresion_Documento_Contable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(873, 266)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Rpt1)
        Me.Controls.Add(Me.BtnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmImpresion_Documento_Contable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Documento  Contable"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "FIELDS"
    Private CODZONA As String
    Private NRODOCUMENTO As String
    Private TABLE_DETALLE_PEDI As New DataTable
    Private NROINI, NROFIN As String
    Private FECHADOCUM As String
    Dim GUIAD As String



#End Region

#Region "FUNCIONES"
    Sub LlenarCombo()
        CboTipoDoc.DataSource = TmpListarDatos("NSP_TRAER_DOC_VTA   '" & codempresa & "' ")
        CboTipoDoc.DisplayMember = "DSTIPODOC"
        CboTipoDoc.ValueMember = "CODTIPODOC"
    End Sub

    Sub BUSQUEDA_DOC()
        Dim DOCUMENTO As String
        Dim FrmDoc As New FrmDocumentosNoImprimidos
        FrmDoc.CODTIPODOC = CboTipoDoc.SelectedValue.ToString.Trim
        FrmDoc.LblDocumento.Text = CboTipoDoc.Text.Trim
        FrmDoc.NRODESPACHO = LblOrdenDesp.Text.Trim
        FrmDoc.GUIAD = GUIAD


        FrmDoc.ShowDialog()
        If FrmDoc.DEVOLVER = False Then
            Exit Sub
        End If
        DOCUMENTO = FrmDoc.GridDocumento.Item(FrmDoc.GridDocumento.CurrentRowIndex, 4).ToString.Trim
        NROINI = Mid(DOCUMENTO, 1, DOCUMENTO.Length - 7)
        NROINI = "0000000" & NROINI
        NROINI = Mid(NROINI, NROINI.Trim.Length - 2)
        NROFIN = Mid((DOCUMENTO), DOCUMENTO.Trim.Length - 6)
        FECHADOCUM = FrmDoc.GridDocumento.Item(FrmDoc.GridDocumento.CurrentRowIndex, 2).ToString.Trim
        FECHADOCUM = Format(CDate(FECHADOCUM), "dd/MM/yyyy")

    End Sub


#End Region

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim DocumentoInicial As Double
        Dim DocumentoFinal As Double
        Dim valor As Boolean = False
        If CDbl(txtIni2.Text) = 0 Then
            MsgBox("El numero Inicial esta mal Ingresado...", MsgBoxStyle.Information, "NARSISTEMAS S.A.C.")
            Exit Sub
        End If
        If CDbl(txtfin2.Text) = 0 Then
            MsgBox("El numero Final esta mal Ingresado...", MsgBoxStyle.Information, "NARSISTEMAS S.A.C.")
            Exit Sub
        End If

        Try
            DocumentoInicial = CDbl(txtIni1.Text) & txtIni2.Text
            DocumentoFinal = CDbl(txtfin1.Text) & txtfin2.Text
        Catch ex As Exception
            MsgBox("Ingrese bien los numeros")
        End Try
        Dim CODTIPODOC, StrMonLet As String
        Dim Table_Busq As New DataTable
        CODTIPODOC = CboTipoDoc.SelectedValue.ToString.Trim
        For imp As Double = DocumentoInicial To DocumentoFinal

            Table_Busq = TmpListarDatos("NSP_BUSCAR_FACTURACION   '" & codempresa & "','" & imp & "','" & CODTIPODOC & "','" & rand & "'")
            NRODOCUMENTO = imp
            If Table_Busq.Rows.Count > 0 Then
                FECHADOCUM = Format(CDate(Table_Busq.Rows(0)("FECDOCUM")), "dd/MM/yyy")


                If EMIELECTRONIC = True Then

                    If ChkTicketera.Checked = True Then
                        Dim RUTAIMP As String
                        RUTAIMP = Application.StartupPath & "\TICKET.TXT"
                        VCdTipoDoc = CODTIPODOC
                        ReEscribirTicketFact2(RUTAIMP, NRODOCUMENTO, 0, 4, CStr(FECHADOCUM))

                        If imp = False Then
                            For X As Integer = 0 To CANT_F - 1
                                Shell("notepad.exe " & Application.StartupPath & "\Ticket.txt", AppWinStyle.NormalFocus)
                            Next
                        Else
                            For X As Integer = 0 To CANT_F - 1
                                Shell("print /d:" & RUTAPRN & " " & RUTAIMP)
                                ObtenerNroLineasTicket("TICKET.TXT")
                                Dim FrmCorta As New FrmCortaTicket
                                FrmCorta.ShowDialog()
                            Next
                        End If

                    Else

                        Dim TIPODOCUMENTO As String
                        Dim LETRADOC As String

                        If CODTIPODOC = "01" Then
                            TIPODOCUMENTO = "FACTURA DE VENTA ELECTRONICA"
                            LETRADOC = "F"
                        End If

                        If CODTIPODOC = "03" Then
                            TIPODOCUMENTO = "BOLETA DE VENTA ELECTRONICA"
                            LETRADOC = "B"
                        End If

                        If CODTIPODOC = "06" Then
                            TIPODOCUMENTO = "NOTA PEDIDO"
                            LETRADOC = "P"
                        End If

                        Dim INAFECTO As String
                        Dim TABLA_INAFECTO As New DataTable
                        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO_HISTO  '" & codempresa.Trim & "','" & CODTIPODOC.Trim & "','" & NRODOCUMENTO.Trim & "','" & CStr(FECHADOCUM.Trim) & "'")

                        If TABLA_INAFECTO.Rows.Count > 0 Then
                            INAFECTO = FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString
                        End If

                        Dim AFECTO As String
                        Dim TABLA_AFECTO As New DataTable
                        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_AFECTO_HISTO  '" & codempresa.Trim & "','" & CODTIPODOC.Trim & "','" & NRODOCUMENTO.Trim & "','" & CStr(FECHADOCUM.Trim) & "'")
                        If TABLA_INAFECTO.Rows.Count > 0 Then
                            AFECTO = FACT_GMascara(TABLA_INAFECTO.Rows(0)("AFECTO").ToString.Trim, 2).ToString
                        End If

                        If CODTIPODOC = CDFACTURA.Trim Then
                            StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString) - CDbl(Table_Busq.Rows(0)("IPERCEP").ToString), "SOLES")
                            Rpt1.WindowShowExportBtn = True
                            Rpt1.WindowShowPrintBtn = True
                            Rpt1.WindowShowPrintSetupBtn = True
                            Rpt1.set_StoredProcParam(0, codempresa)
                            Rpt1.set_StoredProcParam(1, CODTIPODOC)
                            Rpt1.set_StoredProcParam(2, imp)
                            Rpt1.set_StoredProcParam(3, CStr(FECHADOCUM))

                            Rpt1.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")
                            Rpt1.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & TIPODOCUMENTO & "'")
                            Rpt1.set_Formulas(2, "FNombre='" & GHEAD1 & "'")
                            Rpt1.set_Formulas(3, "FRuc='" & GHEAD3 & "'")
                            Rpt1.set_Formulas(4, "FDireccion='" & GHEAD4 & "'")
                            Rpt1.set_Formulas(5, "FUbicacion='" & GHEAD5 & "'")
                            Rpt1.set_Formulas(6, "FInafecto='" & INAFECTO & "'")
                            Rpt1.set_Formulas(7, "FGravadas='" & AFECTO & "'")
                            Rpt1.set_Formulas(8, "FExoneradas='" & 0.0 & "'")


                            Rpt1.ReportFileName = rutareporte + CType("Rpt_FacturaFE.rpt", String)
                            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                            If ChkImpresora.CheckState = CheckState.Checked Then
                                Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
                            Else
                                Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
                            End If

                            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
                            Rpt1.Action = 1
                            Rpt1.Reset()
                        ElseIf CODTIPODOC = CDBOLETA.Trim Then
                            StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString) - CDbl(Table_Busq.Rows(0)("IPERCEP").ToString), "SOLES")
                            Rpt1.WindowShowExportBtn = True
                            Rpt1.WindowShowPrintBtn = True
                            Rpt1.WindowShowPrintSetupBtn = True
                            Rpt1.set_StoredProcParam(0, codempresa)
                            Rpt1.set_StoredProcParam(1, CODTIPODOC)
                            Rpt1.set_StoredProcParam(2, imp)
                            Rpt1.set_StoredProcParam(3, CStr(FECHADOCUM))
                            Rpt1.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")
                            Rpt1.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & TIPODOCUMENTO & "'")
                            Rpt1.set_Formulas(2, "FNombre='" & GHEAD1 & "'")
                            Rpt1.set_Formulas(3, "FRuc='" & GHEAD3 & "'")
                            Rpt1.set_Formulas(4, "FDireccion='" & GHEAD4 & "'")
                            Rpt1.set_Formulas(5, "FUbicacion='" & GHEAD5 & "'")
                            Rpt1.set_Formulas(6, "FInafecto='" & INAFECTO & "'")
                            Rpt1.set_Formulas(7, "FGravadas='" & AFECTO & "'")
                            Rpt1.set_Formulas(8, "FExoneradas='" & 0.0 & "'")

                            Rpt1.ReportFileName = rutareporte + CType("Rpt_BoletaFE.rpt", String)
                            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                            If ChkImpresora.CheckState = CheckState.Checked Then
                                Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
                            Else
                                Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
                            End If
                            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
                            Rpt1.Action = 1
                            Rpt1.Reset()
                        ElseIf CODTIPODOC = CDNTAPEDIDO.Trim Then
                            StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString) - CDbl(Table_Busq.Rows(0)("IPERCEP").ToString), "SOLES")
                            Rpt1.WindowShowExportBtn = True
                            Rpt1.WindowShowPrintBtn = True
                            Rpt1.WindowShowPrintSetupBtn = True
                            Rpt1.set_StoredProcParam(0, codempresa)
                            Rpt1.set_StoredProcParam(1, CODTIPODOC)
                            Rpt1.set_StoredProcParam(2, imp)
                            Rpt1.set_StoredProcParam(3, CStr(FECHADOCUM))
                            Rpt1.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")
                            Rpt1.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & "NP " & Format(CDbl(NRODOCUMENTO), "0##-#######") & "'")
                            Rpt1.ReportFileName = rutareporte + CType("Rpt_NotaPedido.rpt", String)

                            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"


                            If ChkImpresora.CheckState = CheckState.Checked Then
                                Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
                            Else
                                Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
                            End If
                            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
                            Rpt1.Action = 1
                            Rpt1.Reset()
                        End If

                    End If

                Else


                    If CODTIPODOC = CDFACTURA.Trim Then
                        StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString) - CDbl(Table_Busq.Rows(0)("IPERCEP").ToString), "SOLES")
                        Rpt1.WindowShowExportBtn = True
                        Rpt1.WindowShowPrintBtn = True
                        Rpt1.WindowShowPrintSetupBtn = True
                        Rpt1.set_StoredProcParam(0, codempresa)
                        Rpt1.set_StoredProcParam(1, CODTIPODOC)
                        Rpt1.set_StoredProcParam(2, imp)
                        Rpt1.set_StoredProcParam(3, CStr(FECHADOCUM))

                        Rpt1.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")
                        Rpt1.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & "FV " & Format(CDbl(NRODOCUMENTO), "0##-#######") & "'")
                        Rpt1.ReportFileName = rutareporte + CType("Rpt_Factura.rpt", String)
                        Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                        If ChkImpresora.CheckState = CheckState.Checked Then
                            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
                        Else
                            Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
                        End If

                        Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
                        Rpt1.Action = 1
                        Rpt1.Reset()
                    ElseIf CODTIPODOC = CDBOLETA.Trim Then
                        StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString) - CDbl(Table_Busq.Rows(0)("IPERCEP").ToString), "SOLES")
                        Rpt1.WindowShowExportBtn = True
                        Rpt1.WindowShowPrintBtn = True
                        Rpt1.WindowShowPrintSetupBtn = True
                        Rpt1.set_StoredProcParam(0, codempresa)
                        Rpt1.set_StoredProcParam(1, CODTIPODOC)
                        Rpt1.set_StoredProcParam(2, imp)
                        Rpt1.set_StoredProcParam(3, CStr(FECHADOCUM))
                        Rpt1.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")
                        Rpt1.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & "BV " & Format(CDbl(NRODOCUMENTO), "0##-#######") & "'")
                        Rpt1.ReportFileName = rutareporte + CType("Rpt_Boleta.rpt", String)
                        Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                        If ChkImpresora.CheckState = CheckState.Checked Then
                            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
                        Else
                            Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
                        End If
                        Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
                        Rpt1.Action = 1
                        Rpt1.Reset()
                    ElseIf CODTIPODOC = CDNTAPEDIDO.Trim Then
                        StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString) - CDbl(Table_Busq.Rows(0)("IPERCEP").ToString), "SOLES")
                        Rpt1.WindowShowExportBtn = True
                        Rpt1.WindowShowPrintBtn = True
                        Rpt1.WindowShowPrintSetupBtn = True
                        Rpt1.set_StoredProcParam(0, codempresa)
                        Rpt1.set_StoredProcParam(1, CODTIPODOC)
                        Rpt1.set_StoredProcParam(2, imp)
                        Rpt1.set_StoredProcParam(3, CStr(FECHADOCUM))
                        Rpt1.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")
                        Rpt1.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & "NP " & Format(CDbl(NRODOCUMENTO), "0##-#######") & "'")
                        Rpt1.ReportFileName = rutareporte + CType("Rpt_NotaPedido.rpt", String)

                        Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"


                        If ChkImpresora.CheckState = CheckState.Checked Then
                            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
                        Else
                            Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
                        End If
                        Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
                        Rpt1.Action = 1
                        Rpt1.Reset()
                    End If
                End If

                TmpInsertDatos("NSP_IMP_FACTURACION_OD   '" & codempresa & "','" & CODTIPODOC.Trim & "','" & NRODOCUMENTO & "' ")
                valor = True


            Else
                MsgBox("No se encontro el Documento.." & " " & imp, MsgBoxStyle.Information, "NARSISTEMAS S.A.C.")
                If MsgBox("Desea  cancelar la operacion...", MsgBoxStyle.YesNo, "NARSISTEMAS S.A.C.") = MsgBoxResult.Yes Then
                    Exit Sub
                End If
            End If




        Next




        If valor = True Then
            txtIni1.Text = "000"
            txtIni2.Text = "0000000"
        End If


    End Sub


    Private Sub FrmImpresion_Documento_Contable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LlenarCombo()
        ValorRan()

    End Sub


    Dim rand As Integer

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function
    Private Sub txtIni1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIni1.TextChanged

    End Sub

    Private Sub txtIni1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIni1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtIni1.Text = "0000000" & txtIni1.Text
            txtIni1.Text = Mid(txtIni1.Text, txtIni1.Text.Trim.Length - 2)
            txtIni2.Focus()
        End If
    End Sub

    Private Sub txtIni2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIni2.TextChanged



    End Sub

    Private Sub txtIni2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIni2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtIni2.Text = "0000000" & txtIni2.Text
            txtIni2.Text = Mid((txtIni2.Text), txtIni2.Text.Trim.Length - 6)
            txtfin1.Focus()
        End If
    End Sub

    Private Sub txtfin1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfin1.TextChanged

    End Sub

    Private Sub txtfin1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfin1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfin1.Text = "0000000" & txtfin1.Text
            txtfin1.Text = Mid(txtfin1.Text, txtfin1.Text.Trim.Length - 2)
            txtfin2.Focus()
        End If
    End Sub

    Private Sub txtfin2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfin2.TextChanged

    End Sub

    Private Sub txtfin2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtfin2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtfin2.Text = "0000000" & txtfin2.Text
            txtfin2.Text = Mid((txtfin2.Text), txtfin2.Text.Trim.Length - 6)
            btnImprimir.Focus()
        End If
    End Sub

    Private Sub CboTipoDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoDoc.SelectedIndexChanged

    End Sub

    Private Sub CboTipoDoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboTipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtIni1.Focus()
        End If
    End Sub


    Private Sub txtIni2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIni2.KeyPress, txtIni1.KeyPress, txtfin1.KeyPress, txtfin2.KeyPress
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnBusOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusOrden.Click
        Dim o As New FrmBusquedaDeOrdenDespacho2
        o.TIPO = "F"
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        LblOrdenDesp.Text = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        GUIAD = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 5)



    End Sub

    Private Sub btnBusqVehicu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqDoc.Click
        If LblOrdenDesp.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        BUSQUEDA_DOC()
        txtIni1.Text = NROINI
        txtIni2.Text = NROFIN
    End Sub

    Private Sub ChkTicketera_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTicketera.CheckedChanged

    End Sub

    Private Sub btnBusqDoc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqDoc2.Click
        If LblOrdenDesp.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        BUSQUEDA_DOC()
        txtfin1.Text = NROINI
        txtfin2.Text = NROFIN

    End Sub
End Class
