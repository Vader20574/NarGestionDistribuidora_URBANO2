Public Class FrmConsFacturacion
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesCli As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtgDoc As System.Windows.Forms.DataGrid
    Friend WithEvents LblCont As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConsFacturacion))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtNroDoc = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtDesCli = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DtgDoc = New System.Windows.Forms.DataGrid
        Me.LblCont = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DtgDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Ingrese Nro de Documento :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(175, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Ingrese Nombre del Cliente :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNroDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 40)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'TxtNroDoc
        '
        Me.TxtNroDoc.Location = New System.Drawing.Point(8, 13)
        Me.TxtNroDoc.Name = "TxtNroDoc"
        Me.TxtNroDoc.Size = New System.Drawing.Size(144, 20)
        Me.TxtNroDoc.TabIndex = 0
        Me.TxtNroDoc.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDesCli)
        Me.GroupBox2.Location = New System.Drawing.Point(172, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 40)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'TxtDesCli
        '
        Me.TxtDesCli.Location = New System.Drawing.Point(8, 13)
        Me.TxtDesCli.Name = "TxtDesCli"
        Me.TxtDesCli.Size = New System.Drawing.Size(396, 20)
        Me.TxtDesCli.TabIndex = 1
        Me.TxtDesCli.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtgDoc)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(576, 216)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'DtgDoc
        '
        Me.DtgDoc.BackgroundColor = System.Drawing.Color.White
        Me.DtgDoc.CaptionBackColor = System.Drawing.Color.Silver
        Me.DtgDoc.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgDoc.CaptionForeColor = System.Drawing.Color.DarkBlue
        Me.DtgDoc.CaptionText = "Doble Click Sobre el Registro Seleccioando"
        Me.DtgDoc.DataMember = ""
        Me.DtgDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgDoc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgDoc.Location = New System.Drawing.Point(8, 10)
        Me.DtgDoc.Name = "DtgDoc"
        Me.DtgDoc.ReadOnly = True
        Me.DtgDoc.Size = New System.Drawing.Size(560, 200)
        Me.DtgDoc.TabIndex = 49
        '
        'LblCont
        '
        Me.LblCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCont.ForeColor = System.Drawing.Color.Blue
        Me.LblCont.Location = New System.Drawing.Point(16, 296)
        Me.LblCont.Name = "LblCont"
        Me.LblCont.Size = New System.Drawing.Size(360, 16)
        Me.LblCont.TabIndex = 141
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(512, 280)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 142
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(6, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FrmConsFacturacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 358)
        Me.Controls.Add(Me.LblCont)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsFacturacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Documento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DtgDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Ayuda As New ClsAyuda
    Dim oTabla As New DataTable
    Public Factura As New FRMFACTURACION
    Public FacturaServ As New frmfactservicio
    Public EstadoServ As Integer
    Private Sub Formato_Grilla()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = oTabla.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "CODTIPODOC"
            .MappingName = "CODTIPODOC"
            .Width = 0
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "TIPO DOCUMENTO"
            .MappingName = "DSTIPODOC"
            .Width = 120
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "NUMERO"
            .MappingName = "NroDocu"
            .Width = 100
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "FECHA"
            .MappingName = "FECDOCUM"
            .Width = 70
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "CODCLIENTE"
            .MappingName = "CODCLIENTE"
            .Width = 0
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "CLIENTE"
            .MappingName = "DESCLIENTE"
            .Width = 210
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "MONEDA"
            .MappingName = "CODMON"
            .Width = 0
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5, grdColStyle6, grdColStyle7})
        Me.DtgDoc.TableStyles.Add(grdTableStyle1)
    End Sub
    Private Sub Cargar_Grilla(ByVal xNroDoc As String)





        Try
            oTabla = CAyuda.ListarDatos("USP_CONSULTAR_FACTURACION", xNroDoc, Me.TxtDesCli.Text.Trim, "01", "ventacab").Tables(0)
            Me.DtgDoc.DataSource = oTabla
            Me.LblCont.Text = "Total de Registros Encontrados --->> " + oTabla.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Me.Close()
        End Try
    End Sub
    Private Sub Devuelve()
        Dim xCodDoc As String, xMoneda As String

        Dim TblDoc As New DataTable

        With Me.DtgDoc
            If EstadoServ = 1 Then
                VCdTipoDoc = Trim(.Item(.CurrentRowIndex, 0).ToString())
                VNroDoc = Trim(.Item(.CurrentRowIndex, 2).ToString())
                VNroDoc = VNroDoc

                Conecta("SELECT * FROM VENTACAB WHERE CODTIPODOC = '" & VCdTipoDoc.Trim & "' AND NroDocu = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA.Trim & "'", "x")
                If ds.Tables("x").Rows.Count = 1 Then
                    Tabla = "VENTACAB"
                    TablaDet = "VENTADET"
                Else
                    Conecta("SELECT * FROM HISTOVENTAS ORDER BY VENTCAB DESC", "x")
                    Dim Tu As Long
                    For Tu = 0 To ds.Tables("x").Rows.Count - 1
                        Tabla = Trim(ds.Tables("x").Rows(Tu).Item("VENTCAB").ToString())

                        Conecta("SELECT * FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc.Trim & "' AND NroDocu = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA.Trim & "'", "x")
                        If ds.Tables("x").Rows.Count = 1 Then Exit For
                    Next
                    TablaDet = "VENTD" + Mid(Tabla, 6, 6)
                End If

                TblDoc = CAyuda.ListarDatos("USP_CONSULTAR_DOCUMENTO", Trim(Me.DtgDoc.Item(Me.DtgDoc.CurrentRowIndex, 0)), Trim(Me.DtgDoc.Item(Me.DtgDoc.CurrentRowIndex, 2)), NROPTOVTA.Trim, Trim(Me.DtgDoc.Item(Me.DtgDoc.CurrentRowIndex, 4)), codempresa.Trim).Tables(0)

                If TblDoc.Rows.Count = 1 Then
                    With TblDoc
                        Factura.TXTSERIEDOC.Text = NROPTOVTA.Trim
                        Factura.TXTNUMERODOC.Text = Strings.Right(Trim(.Rows(0).Item("VNroDoc").ToString()), 7)
                        Factura.txtcodclie.Text = Trim(.Rows(0).Item("CODCLIENTE").ToString())
                        VCodCliente = Trim(.Rows(0).Item("CODCLIENTE").ToString())
                        Dim Ruc As String
                        Ruc = Len(Trim(.Rows(0).Item("RUCCLIENTE").ToString()))
                        If Ruc = DigitosRuc Then
                            Factura.Label5.Text = "R.U.C :"
                            Factura.txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
                        Else
                            Factura.Label5.Text = "DNI :"
                            Factura.txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
                        End If
                        Factura.txtcliente.Text = Trim(.Rows(0).Item("DESCLIENTE").ToString())
                        Factura.txtdireccion.Text = Trim(.Rows(0).Item("DIRCLIENTE").ToString())
                        'Factura.cbomoneda.SelectedValue = Trim(.Rows(0).Item("CODMON").ToString())
                        Factura.dtpfechadoc.Value = .Rows(0).Item("FECDOCUM")
                        Factura.cbovendedor.SelectedValue = Trim(.Rows(0).Item("CODVEND").ToString())
                        'Factura.txtnotapesada.Text = Trim(.Rows(0).Item("NPESADA").ToString())
                        'Factura.txtnroguias.Text = Trim(.Rows(0).Item("NROGUIA").ToString())
                        Factura.lbloperador.Text = Trim(.Rows(0).Item("CDUSUARIO").ToString())
                        Factura.CTRLSUBTOTAL.CtlText = .Rows(0).Item("SUBTOTAL")
                        Factura.CTRLIGV.CtlText = .Rows(0).Item("IGV")
                        Factura.CTRLDESC.CtlText = .Rows(0).Item("DSCTO")
                        Factura.CTRLTOTAL.CtlText = .Rows(0).Item("TOTAL")
                        Factura.LblEstado.Text = Trim(.Rows(0).Item("ESTADO").ToString())

                        REM Si el Documento Esta Anulado

                        If Trim(.Rows(0).Item("ESTADO").ToString()) = "A" Then
                            Factura.btnanular.Enabled = False
                            Factura.btngeneranuevo.Enabled = False
                            Factura.btnreimprimir.Enabled = False
                        Else
                            Factura.btnanular.Enabled = True
                            Factura.btngeneranuevo.Enabled = True
                            Factura.btnreimprimir.Enabled = True
                        End If

                    End With
                End If

                FACT_Cargagriddetalledirecto(Factura.Grid1, "USP_LISTAR_DETALLE_DOCUMENTO '" & Me.DtgDoc.Item(.CurrentRowIndex, 0) & "','" & .Item(Me.DtgDoc.CurrentRowIndex, 2) & "','" & NROPTOVTA.Trim & "','" & codempresa.Trim & "'")
                TblDoc = Nothing
                xCodDoc = Trim(.Item(Me.DtgDoc.CurrentRowIndex, 0).ToString())
                xMoneda = Trim(.Item(Me.DtgDoc.CurrentRowIndex, 6).ToString())

                If xCodDoc = CDBOLETA Then
                    Factura.lbltipodoc.Text = "BOLETA"
                ElseIf xCodDoc = CDFACTURA Then
                    Factura.lbltipodoc.Text = "FACTURA"
                End If

                If xMoneda = "S" Then
                    Factura.lblsimbolo.Text = "S/."
                    Factura.LBLSIMBOLO2.Text = "S/."
                    Factura.LBLSIMBOLO4.Text = "S/."
                Else
                    Factura.lblsimbolo.Text = "$"
                    Factura.LBLSIMBOLO2.Text = "$"
                    Factura.LBLSIMBOLO4.Text = "$"
                End If

                Factura.lblsimbolo.Visible = True
                Factura.LBLSIMBOLO2.Visible = True
                Factura.LBLSIMBOLO4.Visible = True
                Factura.lblsubtotal.Visible = True
                Factura.LBLIGV.Visible = True
                Factura.CTRLSUBTOTAL.Visible = True
                Factura.CTRLIGV.Visible = True

                'Factura.btnbus.Enabled = False
                Factura.txtcodclie.Enabled = False
                Factura.txtruc.Enabled = False
                Factura.txtcliente.Enabled = False
                Factura.txtdireccion.Enabled = False
                'Factura.cbomoneda.Enabled = False
                Factura.dtpfechadoc.Enabled = False
                Factura.cbovendedor.Enabled = False
                'Factura.txtnotapesada.Enabled = False
                Factura.GroupBox1.Enabled = False
                Factura.btnefectivo.Enabled = False
                Factura.btntarjeta.Enabled = False
                Factura.btncheque.Enabled = False
                Factura.btncredito.Enabled = False
                Factura.btnvale.Enabled = False
                Factura.Button3.Enabled = False
                Factura.btndsctoitem.Enabled = False
                Factura.btndsctototal.Enabled = False

            Else
                VCdTipoDoc = Trim(Me.DtgDoc.Item(.CurrentRowIndex, 0).ToString())
                VNroDoc = Trim(Me.DtgDoc.Item(.CurrentRowIndex, 2).ToString())
                VNroDoc = VNroDoc

                Conecta("SELECT * FROM VENTACAB WHERE CODTIPODOC = '" & VCdTipoDoc.Trim & "' AND NroDocU = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA.Trim & "'", "x")
                If ds.Tables("x").Rows.Count = 1 Then
                    Tabla = "VENTACAB"
                    TablaDet = "VENTADET"
                Else
                    Conecta("SELECT * FROM HISTOVENTAS ORDER BY VENTCAB DESC", "x")
                    Dim Tu As Long
                    For Tu = 0 To ds.Tables("x").Rows.Count - 1
                        Tabla = Trim(ds.Tables("x").Rows(Tu).Item("VENTCAB").ToString())

                        Conecta("SELECT * FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc.Trim & "' AND VNroDoc = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA.Trim & "'", "x")
                        If ds.Tables("x").Rows.Count = 1 Then Exit For
                    Next
                    TablaDet = "VENTD" + Mid(Tabla, 6, 6)
                End If

                TblDoc = CAyuda.ListarDatos("USP_CONSULTAR_DOCUMENTO", Trim(.Item(.CurrentRowIndex, 0)), Trim(.Item(.CurrentRowIndex, 2)), NROPTOVTA.Trim, Trim(.Item(.CurrentRowIndex, 4)), codempresa.Trim).Tables(0)
                If TblDoc.Rows.Count = 1 Then
                    With TblDoc
                        FacturaServ.TXTSERIEDOC.Text = Strings.Left(Trim(.Rows(0).Item("NroDocu").ToString()), 1)
                        FacturaServ.TXTNUMERODOC.Text = Strings.Right(Trim(.Rows(0).Item("NroDocu").ToString()), 8)
                        FacturaServ.txtcodclie.Text = Trim(.Rows(0).Item("CODCLIENTE").ToString())
                        VCodCliente = Trim(.Rows(0).Item("CODCLIENTE").ToString())
                        Dim Ruc As String
                        Ruc = Len(Trim(.Rows(0).Item("RUCCLIENTE").ToString()))
                        If Ruc = DigitosRuc Then
                            FacturaServ.Label5.Text = "R.U.C :"
                            FacturaServ.txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
                        Else
                            FacturaServ.Label5.Text = "DNI :"
                            FacturaServ.txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
                        End If
                        FacturaServ.txtcliente.Text = Trim(.Rows(0).Item("DESCLIENTE").ToString())
                        FacturaServ.txtdireccion.Text = Trim(.Rows(0).Item("DIRCLIENTE").ToString())
                        FacturaServ.cbomoneda.SelectedValue = Trim(.Rows(0).Item("CODMON").ToString())
                        FacturaServ.dtpfechadoc.Value = .Rows(0).Item("FECDOCUM")
                        FacturaServ.lblprincipal.Visible = True
                        'FacturaServ.CboPagador.Visible = False
                        FacturaServ.lblprincipal.Text = Trim(.Rows(0).Item("CODDEP").ToString())
                        FacturaServ.cbovendedor.SelectedValue = Trim(.Rows(0).Item("CODVEND").ToString())
                        FacturaServ.txtnotapesada.Text = ""
                        FacturaServ.txtnroguias.Text = Trim(.Rows(0).Item("NROGUIA").ToString())
                        FacturaServ.lbloperador.Text = Trim(.Rows(0).Item("CDUSUARIO").ToString())
                        FacturaServ.CTRLSUBTOTAL.CtlText = .Rows(0).Item("SUBTOTAL")
                        FacturaServ.CTRLIGV2.CtlText = .Rows(0).Item("IGV")
                        FacturaServ.CTRLDESC.CtlText = .Rows(0).Item("DSCTO")
                        FacturaServ.CTRLTOTAL.CtlText = .Rows(0).Item("TOTAL")
                        'FacturaServ.LblEstado.Text = Trim(.Rows(0).Item("ESTADO").ToString())

                        REM Si el Documento Esta Anulado

                        If Trim(.Rows(0).Item("ESTADO").ToString()) = "A" Then
                            FacturaServ.btnanular.Enabled = False
                            FacturaServ.btngeneranuevo.Enabled = False
                            FacturaServ.btnreimprimir.Enabled = False
                        Else
                            FacturaServ.btnanular.Enabled = True
                            FacturaServ.btngeneranuevo.Enabled = True
                            FacturaServ.btnreimprimir.Enabled = True
                        End If

                    End With
                End If

                'FACT_Cargagriddetalledirecto(FacturaServ.Grid1, "USP_LISTAR_DETALLE_DOCUMENTO '" & .Item(.CurrentRowIndex, 0) & "','" & .Item(.CurrentRowIndex, 2) & "','" & NROPTOVTA.Trim & "','" & codempresa.Trim & "'")

                Dim TMP_VENTADET As DataTable
                TMP_VENTADET = TmpListarDatos("USP_LISTAR_DETALLE_DOCUMENTO '" & .Item(.CurrentRowIndex, 0) & "','" & .Item(.CurrentRowIndex, 2) & "','" & NROPTOVTA.Trim & "','" & codempresa.Trim & "'")
                FacturaServ.Grid1.DataSource = TMP_VENTADET




                TblDoc = Nothing
                xCodDoc = Trim(.Item(.CurrentRowIndex, 0).ToString())
                xMoneda = Trim(.Item(.CurrentRowIndex, 6).ToString())

                If xCodDoc = CDBOLETA Then
                    FacturaServ.lbltipodoc.Text = "BOLETA"
                ElseIf xCodDoc = CDFACTURA Then
                    FacturaServ.lbltipodoc.Text = "FACTURA"
                End If

                If xMoneda = "S" Then
                    FacturaServ.lblsimbolo.Text = "S/."
                    FacturaServ.LBLSIMBOLO2.Text = "S/."
                    FacturaServ.LBLSIMBOLO4.Text = "S/."
                Else
                    FacturaServ.lblsimbolo.Text = "$"
                    FacturaServ.LBLSIMBOLO2.Text = "$"
                    FacturaServ.LBLSIMBOLO4.Text = "$"
                End If

                FacturaServ.lblsimbolo.Visible = True
                FacturaServ.LBLSIMBOLO2.Visible = True
                FacturaServ.LBLSIMBOLO4.Visible = True
                FacturaServ.lblsubtotal.Visible = True
                FacturaServ.LBLIGV.Visible = True
                FacturaServ.CTRLIGV2.Visible = True
                FacturaServ.CTRLSUBTOTAL.Visible = True
                'FacturaServ.CTRLIGV.Visible = True

                FacturaServ.btnbus.Enabled = False
                FacturaServ.txtcodclie.Enabled = False
                FacturaServ.txtruc.Enabled = False
                FacturaServ.txtcliente.Enabled = False
                FacturaServ.txtdireccion.Enabled = False
                FacturaServ.cbomoneda.Enabled = False
                FacturaServ.dtpfechadoc.Enabled = False
                FacturaServ.cbovendedor.Enabled = False
                FacturaServ.txtnotapesada.Enabled = False
                FacturaServ.GroupBox1.Enabled = False
                FacturaServ.btnefectivo.Enabled = False
                FacturaServ.btntarjeta.Enabled = False
                FacturaServ.btncheque.Enabled = False
                FacturaServ.btncredito.Enabled = False
                FacturaServ.btnvale.Enabled = False
                FacturaServ.Button3.Enabled = False
                FacturaServ.btndsctoitem.Enabled = False
                FacturaServ.btndsctototal.Enabled = False

            End If

        End With
        Me.Close()
    End Sub
    Private Sub FrmConsFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TblAyuda As New DataTable
        TblAyuda = CAyuda.ListarDatos("USP_BUSCAR_CONFIGVENTA", codempresa.Trim).Tables(0)
        If TblAyuda.Rows.Count = 1 Then
            With TblAyuda
                CDFACTURA = Trim(.Rows(0).Item("CDFACTURA").ToString())
                CDBOLETA = Trim(.Rows(0).Item("CDBOLETA").ToString())
            End With
        End If
        TblAyuda = Nothing
        Call Cargar_Grilla("")
        Call Formato_Grilla()
    End Sub
    Private Sub FrmConsFacturacion_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Ayuda = Nothing
        oTabla = Nothing
    End Sub
    Private Sub TxtNroDoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNroDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim NroDoc As String
            If Len(Me.TxtNroDoc.Text.Trim) = 0 Then
                NroDoc = ""
            Else
                NroDoc = Val(NROPTOVTA.Trim).ToString + Format(Val(Me.TxtNroDoc.Text.Trim), "0000000")
            End If

            Call Cargar_Grilla(NroDoc)
        End If
    End Sub
    Private Sub TxtDesCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDesCli.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim NroDoc As String
            If Len(Me.TxtNroDoc.Text.Trim) = 0 Then
                NroDoc = ""
            Else
                NroDoc = Val(NROPTOVTA.Trim).ToString + Format(Val(Me.TxtNroDoc.Text.Trim), "0000000")
            End If
            Call Cargar_Grilla(NroDoc)
        End If
    End Sub
    Private Sub DtgDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgDoc.DoubleClick
        If Me.DtgDoc.CurrentRowIndex <> -1 Then
            Call Devuelve()
        End If
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub DtgDoc_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DtgDoc.Navigate

    End Sub
End Class
