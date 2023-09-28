Public Class FrmConsultarCotizacion
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDesCli As System.Windows.Forms.TextBox
    Friend WithEvents LblCont As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents VentaCabEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODTIPODOCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DSTIPODOCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRODOCUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECDOCUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODCLIENTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCLIENTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODMONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultarFacturac2))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtDesCli = New System.Windows.Forms.TextBox
        Me.LblCont = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtNroDoc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvlista = New System.Windows.Forms.DataGridView
        Me.VentaCabEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODTIPODOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DSTIPODOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRODOCUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECDOCUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CODCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CODMONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaCabEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvlista)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(610, 296)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDesCli)
        Me.GroupBox2.Location = New System.Drawing.Point(176, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 40)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'TxtDesCli
        '
        Me.TxtDesCli.Location = New System.Drawing.Point(8, 13)
        Me.TxtDesCli.Name = "TxtDesCli"
        Me.TxtDesCli.Size = New System.Drawing.Size(424, 20)
        Me.TxtDesCli.TabIndex = 0
        '
        'LblCont
        '
        Me.LblCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCont.ForeColor = System.Drawing.Color.Blue
        Me.LblCont.Location = New System.Drawing.Point(12, 396)
        Me.LblCont.Name = "LblCont"
        Me.LblCont.Size = New System.Drawing.Size(360, 16)
        Me.LblCont.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(542, 364)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 6
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
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNroDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
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
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Ingrese Nombre del Cliente :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Ingrese Nro de Documento :"
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoGenerateColumns = False
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODTIPODOCDataGridViewTextBoxColumn, Me.DSTIPODOCDataGridViewTextBoxColumn, Me.NRODOCUDataGridViewTextBoxColumn, Me.FECDOCUMDataGridViewTextBoxColumn, Me.CODCLIENTEDataGridViewTextBoxColumn, Me.DESCLIENTEDataGridViewTextBoxColumn, Me.CODMONDataGridViewTextBoxColumn})
        Me.dgvlista.DataSource = Me.VentaCabEBindingSource
        Me.dgvlista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlista.Location = New System.Drawing.Point(3, 16)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.Size = New System.Drawing.Size(604, 277)
        Me.dgvlista.TabIndex = 7
        '
        'VentaCabEBindingSource
        '
        Me.VentaCabEBindingSource.DataSource = GetType(NarGestionDistribuidora.VentaCabE)
        '
        'CODTIPODOCDataGridViewTextBoxColumn
        '
        Me.CODTIPODOCDataGridViewTextBoxColumn.DataPropertyName = "CODTIPODOC"
        Me.CODTIPODOCDataGridViewTextBoxColumn.HeaderText = "CODTIPODOC"
        Me.CODTIPODOCDataGridViewTextBoxColumn.Name = "CODTIPODOCDataGridViewTextBoxColumn"
        Me.CODTIPODOCDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODTIPODOCDataGridViewTextBoxColumn.Visible = False
        Me.CODTIPODOCDataGridViewTextBoxColumn.Width = 70
        '
        'DSTIPODOCDataGridViewTextBoxColumn
        '
        Me.DSTIPODOCDataGridViewTextBoxColumn.DataPropertyName = "DSTIPODOC"
        Me.DSTIPODOCDataGridViewTextBoxColumn.HeaderText = "TIPO DOCUMENTO"
        Me.DSTIPODOCDataGridViewTextBoxColumn.Name = "DSTIPODOCDataGridViewTextBoxColumn"
        Me.DSTIPODOCDataGridViewTextBoxColumn.ReadOnly = True
        Me.DSTIPODOCDataGridViewTextBoxColumn.Width = 150
        '
        'NRODOCUDataGridViewTextBoxColumn
        '
        Me.NRODOCUDataGridViewTextBoxColumn.DataPropertyName = "NRODOCU"
        Me.NRODOCUDataGridViewTextBoxColumn.HeaderText = "NRO DOCU"
        Me.NRODOCUDataGridViewTextBoxColumn.Name = "NRODOCUDataGridViewTextBoxColumn"
        Me.NRODOCUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECDOCUMDataGridViewTextBoxColumn
        '
        Me.FECDOCUMDataGridViewTextBoxColumn.DataPropertyName = "FECDOCUM"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FECDOCUMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FECDOCUMDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECDOCUMDataGridViewTextBoxColumn.Name = "FECDOCUMDataGridViewTextBoxColumn"
        Me.FECDOCUMDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECDOCUMDataGridViewTextBoxColumn.Width = 90
        '
        'CODCLIENTEDataGridViewTextBoxColumn
        '
        Me.CODCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CODCLIENTE"
        Me.CODCLIENTEDataGridViewTextBoxColumn.HeaderText = "CODCLIENTE"
        Me.CODCLIENTEDataGridViewTextBoxColumn.Name = "CODCLIENTEDataGridViewTextBoxColumn"
        Me.CODCLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODCLIENTEDataGridViewTextBoxColumn.Visible = False
        '
        'DESCLIENTEDataGridViewTextBoxColumn
        '
        Me.DESCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "DESCLIENTE"
        Me.DESCLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE"
        Me.DESCLIENTEDataGridViewTextBoxColumn.Name = "DESCLIENTEDataGridViewTextBoxColumn"
        Me.DESCLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCLIENTEDataGridViewTextBoxColumn.Width = 210
        '
        'CODMONDataGridViewTextBoxColumn
        '
        Me.CODMONDataGridViewTextBoxColumn.DataPropertyName = "CODMON"
        Me.CODMONDataGridViewTextBoxColumn.HeaderText = "CODMON"
        Me.CODMONDataGridViewTextBoxColumn.Name = "CODMONDataGridViewTextBoxColumn"
        Me.CODMONDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODMONDataGridViewTextBoxColumn.Visible = False
        '
        'FrmConsultarFacturac2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(625, 440)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblCont)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmConsultarFacturac2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Documento"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaCabEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Ayuda As New ClsAyuda
    Dim oTabla As New DataTable
    Public Factura As New FRMFACTURACION
    'Public Factura As New Factura
    Public DEVOLVER As Boolean
    Public EstadoServ As Integer
    Dim Lista As New List(Of VentaCabE)
    Dim dt_tabla As New DataTable
#Region "Funciones"
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Select Case KeyData
            Case Keys.Enter
                'If oTabla.Rows.Count > 0 Then
                '    If Me.dgvlista.Focus = True Then
                '        DEVOLVER = True
                '        Me.Close()
                '    End If
                'End If
            Case Keys.Escape
                Me.Close()
        End Select
    End Function

    Private Sub Cargar_Grilla(ByVal xNroDoc As String)
        Try
            'oTabla = Ayuda.TraerDataset("USP_CONSULTAR_FACTURACION", xNroDoc, Me.TxtDesCli.Text.Trim, Nroptovta, CodEmpresa).Tables(0)
            oTabla = CAyuda.ListarDatos("USP_CONSULTAR_FACTURACIONCOTIZACION", xNroDoc, Me.TxtDesCli.Text.Trim, codempresa, "").Tables(0)

            Lista.Clear()
            Cargar_Lista(oTabla, "")

            VentaCabEBindingSource.ResetBindings(False)
            VentaCabEBindingSource.DataSource = Lista
            Me.LblCont.Text = "Total de Registros Encontrados --->> " + Lista.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Me.Close()
        End Try
    End Sub

    Private Sub Cargar_Lista(ByVal tabla As DataTable, ByVal TABLAc As String)
        For Each dr As DataRow In tabla.Rows
            Dim o As New VentaCabE
            o.CODTIPODOC = dr.Item(0).ToString
            o.DSTIPODOC = dr.Item(1).ToString
            o.NRODOCU = dr.Item(2).ToString
            o.FECDOCUM = CDate(dr.Item(3))
            o.CODCLIENTE = dr.Item(4).ToString
            o.DESCLIENTE = dr.Item(5).ToString
            o.CODMON = dr.Item(6).ToString
            o.ESTADO = dr.Item(7).ToString
            o.VENTACAB = TABLAc
            Lista.Add(o)
        Next
    End Sub
    'Private Sub Devuelve()
    '    Dim xCodDoc As String, xMoneda As String

    '    Dim TblDoc As New DataTable

    '    With Me.dgvlista
    '        If EstadoServ = 1 Then
    '            VCdTipoDoc = Trim(.Item(.CurrentRowIndex, 0).ToString())
    '            VNroDoc = Trim(.Item(.CurrentRowIndex, 2).ToString())
    '            VNroDoc = VNroDoc

    '            Conecta("SELECT * FROM VENTACAB WHERE CODTIPODOC = '" & VCdTipoDoc & "' AND VNroDoc = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA & "'", "x")
    '            If ds.Tables("x").Rows.Count = 1 Then
    '                Tabla = "VENTACAB"
    '                TablaDet = "VENTADET"
    '            Else
    '                Conecta("SELECT * FROM HISTOVENTAS ORDER BY VENTCAB DESC", "x")
    '                Dim Tu As Long
    '                For Tu = 0 To ds.Tables("x").Rows.Count - 1
    '                    Tabla = Trim(ds.Tables("x").Rows(Tu).Item("VENTCAB").ToString())

    '                    Conecta("SELECT * FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc & "' AND VNroDoc = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA & "'", "x")
    '                    If ds.Tables("x").Rows.Count = 1 Then Exit For
    '                Next
    '                TablaDet = "VENTD" + Mid(Tabla, 6, 6)
    '            End If

    '            TblDoc = CAyuda.ListarDatos("USP_CONSULTAR_DOCUMENTO", Trim(.Item(.CurrentRowIndex, 0)), Trim(.Item(.CurrentRowIndex, 2)), NROPTOVTA, Trim(.Item(.CurrentRowIndex, 4)), codempresa).Tables(0)
    '            If TblDoc.Rows.Count = 1 Then
    '                With TblDoc
    '                    Factura.TXTSERIEDOC.Text = NROPTOVTA
    '                    Factura.TXTNUMERODOC.Text = Strings.Right(Trim(.Rows(0).Item("VNroDoc").ToString()), 7)
    '                    Factura.txtcodclie.Text = Trim(.Rows(0).Item("CODCLIENTE").ToString())
    '                    Dim Ruc As String
    '                    Ruc = Len(Trim(.Rows(0).Item("RUCCLIENTE").ToString()))
    '                    If Ruc = DigitosRuc Then
    '                        Factura.Label5.Text = "R.U.C :"
    '                        Factura.txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
    '                    Else
    '                        Factura.Label5.Text = "DNI :"
    '                        Factura.txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
    '                    End If
    '                    Factura.txtcliente.Text = Trim(.Rows(0).Item("DESCLIENTE").ToString())
    '                    Factura.txtdireccion.Text = Trim(.Rows(0).Item("DIRCLIENTE").ToString())
    '                    'Factura.cbomoneda.SelectedValue = Trim(.Rows(0).Item("CODMON").ToString())
    '                    Factura.dtpfechadoc.Value = .Rows(0).Item("FECDOCUM")
    '                    Factura.cbovendedor.SelectedValue = Trim(.Rows(0).Item("CODVEND").ToString())
    '                    'Factura.txtnotapesada.Text = Trim(.Rows(0).Item("NPESADA").ToString())
    '                    'Factura.txtnroguias.Text = Trim(.Rows(0).Item("NROGUIA").ToString())
    '                    Factura.lbloperador.Text = Trim(.Rows(0).Item("CDUSUARIO").ToString())
    '                    Factura.CTRLSUBTOTAL.CtlText = .Rows(0).Item("SUBTOTAL")
    '                    Factura.CTRLIGV.CtlText = .Rows(0).Item("IGV")
    '                    Factura.CTRLDESC.CtlText = .Rows(0).Item("DSCTO")
    '                    Factura.CTRLTOTAL.CtlText = .Rows(0).Item("TOTAL")
    '                    Factura.LblEstado.Text = Trim(.Rows(0).Item("ESTADO").ToString())

    '                    REM Si el Documento Esta Anulado

    '                    If Trim(.Rows(0).Item("ESTADO").ToString()) = "A" Then
    '                        Factura.btnanular.Enabled = False
    '                        Factura.btngeneranuevo.Enabled = False
    '                        Factura.btnreimprimir.Enabled = False
    '                    Else
    '                        Factura.btnanular.Enabled = True
    '                        Factura.btngeneranuevo.Enabled = True
    '                        Factura.btnreimprimir.Enabled = True
    '                    End If

    '                End With
    '            End If

    '            FACT_Cargagriddetalledirecto(Factura.Grid1, "USP_LISTAR_DETALLE_DOCUMENTO '" & .Item(.CurrentRowIndex, 0) & "','" & .Item(.CurrentRowIndex, 2) & "','" & NROPTOVTA & "','" & codempresa & "'")
    '            TblDoc = Nothing
    '            xCodDoc = Trim(.Item(.CurrentRowIndex, 0).ToString())
    '            xMoneda = Trim(.Item(.CurrentRowIndex, 6).ToString())

    '            If xCodDoc = CDBOLETA Then
    '                Factura.lbltipodoc.Text = "BOLETA"
    '            ElseIf xCodDoc = CDFACTURA Then
    '                Factura.lbltipodoc.Text = "FACTURA"
    '            End If

    '            If xMoneda = "S" Then
    '                Factura.lblsimbolo.Text = "S/."
    '                Factura.LBLSIMBOLO2.Text = "S/."
    '                Factura.LBLSIMBOLO4.Text = "S/."
    '            Else
    '                Factura.lblsimbolo.Text = "$"
    '                Factura.LBLSIMBOLO2.Text = "$"
    '                Factura.LBLSIMBOLO4.Text = "$"
    '            End If

    '            Factura.lblsimbolo.Visible = True
    '            Factura.LBLSIMBOLO2.Visible = True
    '            Factura.LBLSIMBOLO4.Visible = True
    '            Factura.lblsubtotal.Visible = True
    '            Factura.LBLIGV.Visible = True
    '            Factura.CTRLSUBTOTAL.Visible = True
    '            Factura.CTRLIGV.Visible = True

    '            'Factura.btnbus.Enabled = False
    '            Factura.txtcodclie.Enabled = False
    '            Factura.txtruc.Enabled = False
    '            Factura.txtcliente.Enabled = False
    '            Factura.txtdireccion.Enabled = False
    '            'Factura.cbomoneda.Enabled = False
    '            Factura.dtpfechadoc.Enabled = False
    '            Factura.cbovendedor.Enabled = False
    '            'Factura.txtnotapesada.Enabled = False
    '            Factura.GroupBox1.Enabled = False
    '            Factura.btnefectivo.Enabled = False
    '            Factura.btntarjeta.Enabled = False
    '            Factura.btncheque.Enabled = False
    '            Factura.btncredito.Enabled = False
    '            Factura.btnvale.Enabled = False
    '            Factura.Button3.Enabled = False
    '            Factura.btndsctoitem.Enabled = False
    '            Factura.btndsctototal.Enabled = False

    '        Else
    '            VCdTipoDoc = Trim(.Item(.CurrentRowIndex, 0).ToString())
    '            VNroDoc = Trim(.Item(.CurrentRowIndex, 2).ToString())
    '            VNroDoc = VNroDoc

    '            Conecta("SELECT * FROM VENTACAB WHERE CODTIPODOC = '" & VCdTipoDoc.Trim & "' AND VNroDoc = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA & "'", "x")
    '            If ds.Tables("x").Rows.Count = 1 Then
    '                Tabla = "VENTACAB"
    '                TablaDet = "VENTADET"
    '            Else
    '                Conecta("SELECT * FROM HISTOVENTAS ORDER BY VENTCAB DESC", "x")
    '                Dim Tu As Long
    '                For Tu = 0 To ds.Tables("x").Rows.Count - 1
    '                    Tabla = Trim(ds.Tables("x").Rows(Tu).Item("VENTCAB").ToString())

    '                    Conecta("SELECT * FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc.Trim & "' AND VNroDoc = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA & "'", "x")
    '                    If ds.Tables("x").Rows.Count = 1 Then Exit For
    '                Next
    '                TablaDet = "VENTD" + Mid(Tabla, 6, 6)
    '            End If

    '            TblDoc = CAyuda.ListarDatos("USP_CONSULTAR_DOCUMENTO", Trim(.Item(.CurrentRowIndex, 0)), Trim(.Item(.CurrentRowIndex, 2)), NROPTOVTA, Trim(.Item(.CurrentRowIndex, 4)), codempresa).Tables(0)
    '            If TblDoc.Rows.Count = 1 Then
    '                With TblDoc
    '                    Factura.TXTSERIEDOC.Text = NROPTOVTA
    '                    Factura.TXTNUMERODOC.Text = Strings.Right(Trim(.Rows(0).Item("VNroDoc").ToString()), 7)
    '                    Factura.txtcodclie.Text = Trim(.Rows(0).Item("CODCLIENTE").ToString())
    '                    Dim Ruc As String
    '                    Ruc = Len(Trim(.Rows(0).Item("RUCCLIENTE").ToString()))
    '                    If Ruc = DigitosRuc Then
    '                        Factura.Label5.Text = "R.U.C :"
    '                        Factura.txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
    '                    Else
    '                        Factura.Label5.Text = "DNI :"
    '                        Factura.txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
    '                    End If
    '                    Factura.txtcliente.Text = Trim(.Rows(0).Item("DESCLIENTE").ToString())
    '                    Factura.txtdireccion.Text = Trim(.Rows(0).Item("DIRCLIENTE").ToString())
    '                    'Factura.cbomoneda.SelectedValue = Trim(.Rows(0).Item("CODMON").ToString())
    '                    Factura.dtpfechadoc.Value = .Rows(0).Item("FECDOCUM")
    '                    'Factura.txtnroguias.Text = Trim(.Rows(0).Item("NROGUIA").ToString())
    '                    Factura.lbloperador.Text = Trim(.Rows(0).Item("CDUSUARIO").ToString())
    '                    Factura.CTRLSUBTOTAL.CtlText = .Rows(0).Item("SUBTOTAL")
    '                    'Factura.CTRLIGV.CtlText = .Rows(0).Item("IGV")
    '                    Factura.CTRLDESC.CtlText = .Rows(0).Item("DSCTO")
    '                    If Factura.lbltipodoc.Text = "FACTURA" Then
    '                        Factura.CTRLIGV.CtlText = .Rows(0).Item("IGV")
    '                        Factura.CTRLIGV.Visible = True
    '                    End If
    '                    Factura.CTRLTOTAL.CtlText = .Rows(0).Item("TOTAL")
    '                    'Factura.LblEstado.Text = Trim(.Rows(0).Item("ESTADO").ToString())

    '                    REM Si el Documento Esta Anulado

    '                    If Trim(.Rows(0).Item("ESTADO").ToString()) = "A" Then
    '                        Factura.btnanular.Enabled = False
    '                        Factura.btngeneranuevo.Enabled = False
    '                        Factura.btnreimprimir.Enabled = False
    '                    Else
    '                        Factura.btnanular.Enabled = True
    '                        Factura.btngeneranuevo.Enabled = True
    '                        Factura.btnreimprimir.Enabled = True
    '                    End If

    '                End With
    '            End If

    '            FACT_Cargagriddetalledirecto(Factura.Grid1, "USP_LISTAR_DETALLE_DOCUMENTO '" & .Item(.CurrentRowIndex, 0) & "','" & .Item(.CurrentRowIndex, 2) & "','" & NROPTOVTA & "','" & codempresa & "'")
    '            TblDoc = Nothing
    '            xCodDoc = Trim(.Item(.CurrentRowIndex, 0).ToString())
    '            xMoneda = Trim(.Item(.CurrentRowIndex, 6).ToString())

    '            If xCodDoc = CDBOLETA Then
    '                Factura.lbltipodoc.Text = "BOLETA"
    '            ElseIf xCodDoc = CDFACTURA Then
    '                Factura.lbltipodoc.Text = "FACTURA"
    '            End If

    '            If xMoneda = "S" Then
    '                Factura.lblsimbolo.Text = "S/."
    '                Factura.LBLSIMBOLO2.Text = "S/."
    '                Factura.LBLSIMBOLO4.Text = "S/."
    '            Else
    '                Factura.lblsimbolo.Text = "$"
    '                Factura.LBLSIMBOLO2.Text = "$"
    '                Factura.LBLSIMBOLO4.Text = "$"
    '            End If

    '            Factura.lblsimbolo.Visible = True
    '            Factura.LBLSIMBOLO2.Visible = True
    '            Factura.LBLSIMBOLO4.Visible = True
    '            Factura.lblsubtotal.Visible = True
    '            Factura.LBLIGV.Visible = True
    '            Factura.CTRLSUBTOTAL.Visible = True
    '            Factura.CTRLIGV.Visible = True

    '            'Factura.btnbus.Enabled = False
    '            Factura.txtcodclie.Enabled = False
    '            Factura.txtruc.Enabled = False
    '            Factura.txtcliente.Enabled = False
    '            Factura.txtdireccion.Enabled = False
    '            'Factura.cbomoneda.Enabled = False
    '            Factura.dtpfechadoc.Enabled = False
    '            Factura.cbovendedor.Enabled = False
    '            'Factura.txtnotapesada.Enabled = False
    '            Factura.GroupBox1.Enabled = False
    '            Factura.btnefectivo.Enabled = False
    '            Factura.btntarjeta.Enabled = False
    '            Factura.btncheque.Enabled = False
    '            Factura.btncredito.Enabled = False
    '            Factura.btnvale.Enabled = False
    '            Factura.Button3.Enabled = False
    '            Factura.btndsctoitem.Enabled = False
    '            Factura.btndsctototal.Enabled = False

    '        End If

    '    End With
    '    Me.Close()
    'End Sub

#End Region


    Private Sub FrmConsultarFacturac2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TblAyuda As New DataTable
        TblAyuda = CAyuda.ListarDatos("USP_BUSCAR_CONFIGVENTA", codempresa).Tables(0)
        If TblAyuda.Rows.Count = 1 Then
            With TblAyuda
                CDFACTURA = Trim(.Rows(0).Item("CDFACTURA").ToString())
                CDBOLETA = Trim(.Rows(0).Item("CDBOLETA").ToString())
            End With
        End If
        TblAyuda = Nothing
        Call Cargar_Grilla("")
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
                NroDoc = Format(Val(Me.TxtNroDoc.Text.Trim), "0000000")
            End If

            Cargar_Grilla_Filtro(Me.TxtNroDoc.Text.Trim)
        End If
    End Sub
    Private Sub Cargar_Grilla_Filtro(ByVal nrodoc As String)
        dt_tabla = CAyuda.ListarDatos("SP_LISTA_HISTO_VENTAS", codempresa).Tables(0)

        Lista.Clear()
        For Each dr As DataRow In dt_tabla.Rows
            oTabla = CAyuda.ListarDatos("USP_CONSULTAR_FACTURACION", nrodoc, Me.TxtDesCli.Text.Trim, codempresa, dr.Item(0).ToString).Tables(0)
            Cargar_Lista(oTabla, dr.Item(0).ToString)
        Next

        oTabla = CAyuda.ListarDatos("USP_CONSULTAR_FACTURACION", nrodoc, Me.TxtDesCli.Text.Trim, codempresa, "").Tables(0)
        Cargar_Lista(oTabla, "")

        VentaCabEBindingSource.ResetBindings(False)
        VentaCabEBindingSource.DataSource = Lista
        Me.LblCont.Text = "Total de Registros Encontrados --->> " + Lista.Count.ToString
    End Sub
    Private Sub TxtDesCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDesCli.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim NroDoc As String
            If Len(Me.TxtNroDoc.Text.Trim) = 0 Then
                NroDoc = ""
            Else
                NroDoc = Val(NROPTOVTA).ToString + Format(Val(Me.TxtNroDoc.Text.Trim), "0000000")
            End If
            Cargar_Grilla_Filtro(Me.TxtNroDoc.Text.Trim)
        End If
    End Sub
    Private Sub DtgDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Me.DtgDoc.CurrentRowIndex <> -1 Then
        '    Call Devuelve()
        'End If
        DEVOLVER = True
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvlista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvlista.DoubleClick
        If Lista.Count = 0 Then Exit Sub

        DEVOLVER = True
        Me.Close()
    End Sub
End Class

