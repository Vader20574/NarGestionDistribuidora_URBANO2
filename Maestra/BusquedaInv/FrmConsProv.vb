Imports Vb = Microsoft.VisualBasic
Public Class FrmConsProv
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtgProv As System.Windows.Forms.DataGrid
    Friend WithEvents rbDescrip As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbDescrip = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DtgProv = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DtgProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDato)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtDato
        '
        Me.TxtDato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDato.Location = New System.Drawing.Point(8, 16)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(296, 20)
        Me.TxtDato.TabIndex = 0
        Me.TxtDato.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbDescrip)
        Me.GroupBox2.Controls.Add(Me.rbcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 48)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'rbDescrip
        '
        Me.rbDescrip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescrip.Location = New System.Drawing.Point(80, 16)
        Me.rbDescrip.Name = "rbDescrip"
        Me.rbDescrip.Size = New System.Drawing.Size(80, 16)
        Me.rbDescrip.TabIndex = 5
        Me.rbDescrip.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(8, 15)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtgProv)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 248)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'DtgProv
        '
        Me.DtgProv.CaptionVisible = False
        Me.DtgProv.DataMember = ""
        Me.DtgProv.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgProv.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgProv.Location = New System.Drawing.Point(8, 16)
        Me.DtgProv.Name = "DtgProv"
        Me.DtgProv.ReadOnly = True
        Me.DtgProv.Size = New System.Drawing.Size(472, 224)
        Me.DtgProv.TabIndex = 0
        '
        'FrmConsProv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 302)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsProv"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DtgProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim Ayuda As New ClsAyuda
    'Dim CAyuda As New ClsInterface
    Dim TblProv As New DataTable
    Public ObjProv As New FrmProveedor
    Public objIngOPer As New frmRetencProv
    Public objIngOPer2 As New FrmRetenEmiProvCab
    Public objPercepProv As New frmPercepProv
    Dim DatoCod, DatoDes As String
    Private xAyuda As Integer

    Public Function Valida_Pais_Nulls(ByVal Obj As Object, ByVal CodCiudad As String) As Object
        If Vb.IsDBNull(Obj) Then
            Dim CodPais As String
            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("USP_BUSCAR_CODIGO_PAIS_NULLS", CodCiudad, codempresa).Tables(0)
            If dt.Rows.Count <> 0 Then
                CodPais = dt.Rows(0).Item("CODPAIS")
            Else
                CodPais = ""
            End If

            Return CodPais.Trim
        Else
            Return Obj
        End If
    End Function
    Private Sub Formato_Grilla()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = TblProv.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "CODIGO"
            .MappingName = "CODPROVEEDOR"
            .Width = 100
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "DESCRIPCION"
            .MappingName = "DESPROVEEDOR"
            .Width = 312
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2})
        DtgProv.TableStyles.Add(grdTableStyle1)
    End Sub
    Private Sub Cargar_Grilla(ByVal pCod As String, ByVal pDes As String)
        Try
            TblProv = CAyuda.ListarDatos("USP_CONSULTAR_PROVEEDOR", pCod, pDes, codempresa).Tables(0)
            Me.DtgProv.DataSource = TblProv
        Catch ex As Exception
            MsgBox(ex.Message + Chr(13) + "Consulte a su Proveedor", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Me.Close()
        End Try
    End Sub
    Private Sub Devuelve()
        Try
            With Me.DtgProv
                Dim TblBusProv As New DataTable
                TblBusProv = CAyuda.ListarDatos("USP_BUSCAR_PROVEEDOR", Trim(.Item(.CurrentRowIndex, 0).ToString()), codempresa.Trim).Tables(0)
                If TblBusProv.Rows.Count = 1 Then
                    With TblBusProv
                        If xAyuda = 1 Then
                            'ObjFact.TxtCodPro.Text = Trim(.Rows(0).Item("CODPROVEEDOR").ToString())
                            'ObjFact.TxtDesPro.Text = Trim(.Rows(0).Item("DESPROVEEDOR").ToString())
                        Else
                            'If .Rows(0).Item("TIPOPROVEEDOR") = 1 Then ObjProv.RdbExt.Checked = True
                            'If .Rows(0).Item("TIPOPROVEEDOR") = 2 Then ObjProv.RdbNac.Checked = True


                            ObjProv.CboTipoProv.SelectedValue = .Rows(0).Item("TIPOPROVEEDOR")



                            ObjProv.TxtCodProv.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("CODPROVEEDOR").ToString()))
                            ObjProv.TxtNombre.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("DESPROVEEDOR").ToString()))
                            ObjProv.TxtRuc.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("RUC").ToString()))
                            ObjProv.TxtDireccion.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("DIRECCION").ToString()))
                            ObjProv.CmbPais.SelectedValue = Valida_Pais_Nulls((.Rows(0).Item("PAIS")), .Rows(0).Item("CODCIUDAD"))
                            ObjProv.CmbCuidad.SelectedValue = CAyuda.ValidaNulls(Trim(.Rows(0).Item("CODCIUDAD").ToString()))
                            ObjProv.TxtTelefono.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("TELEFONO").ToString()))
                            ObjProv.txtcelu.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("FAXPROVEE").ToString()))
                            ObjProv.TxtWeb.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("WEB").ToString()))
                            ObjProv.txtcontacto.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("CONTACTO").ToString()))
                            ObjProv.txtdirconta.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("DIRECCONTC").ToString()))
                            ObjProv.txttelconta.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("TLFCONT").ToString()))
                            ObjProv.txtcelconta.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("CLUCONTC").ToString()))
                            ObjProv.TXTCORREOCONTA.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("CORREOCONTA").ToString()))
                            ObjProv.txtobs.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("OBSERVACION").ToString()))
                            ObjProv.TxtNomCom.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("NOMBRE_COMERCIAL").ToString()))
                            ObjProv.cbFormaPago.SelectedValue = CAyuda.ValidaNulls(Trim(.Rows(0).Item("TIPO_PAGO").ToString()))
                            If CAyuda.ValidaNulls(.Rows(0).Item("DOMICILIADO")) = "" Then
                                ObjProv.CboDomiCiliado.SelectedIndex = 0
                            Else
                                ObjProv.CboDomiCiliado.SelectedIndex = .Rows(0).Item("DOMICILIADO")
                            End If

                            objIngOPer2.lblcodproveedor.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("CODPROVEEDOR").ToString()))
                            objIngOPer2.txtproveedor.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("DESPROVEEDOR").ToString()))
                            objIngOPer2.lblruc.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("RUC").ToString()))
                            objIngOPer2.lbldireccion.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("DIRECCION").ToString()))

                            objIngOPer.lblcodproveedor.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("CODPROVEEDOR").ToString()))
                            objIngOPer.TxtProveedor.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("DESPROVEEDOR").ToString()))
                            objIngOPer.lblruc.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("RUC").ToString()))
                            objIngOPer.lbldireccion.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("DIRECCION").ToString()))


                            objPercepProv.lblcodproveedor.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("CODPROVEEDOR").ToString()))
                            objPercepProv.txtproveedor.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("DESPROVEEDOR").ToString()))
                            objPercepProv.lblruc.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("RUC").ToString()))
                            objPercepProv.lbldireccion.Text = CAyuda.ValidaNulls(Trim(.Rows(0).Item("DIRECCION").ToString()))



                        End If
                    End With
                End If
                TblBusProv = Nothing
                Me.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message + Chr(13) + "Consulte a su Proveedor", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
        End Try
    End Sub
    Private Sub FrmConsProv_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub
    Private Sub FrmConsProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Grilla("", "")
        Call Formato_Grilla()
    End Sub
    Private Sub FrmConsProv_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        TblProv = Nothing
        'Ayuda = Nothing
    End Sub
    Private Sub CboCriterio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TxtDato.Text = ""
        If rbcodigo.Checked = True Then
            Call Cargar_Grilla(Me.TxtDato.Text.Trim, "")
        Else
            Call Cargar_Grilla("", Me.TxtDato.Text.Trim)
        End If
        Me.TxtDato.Focus()
    End Sub
    Private Sub TxtDato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDato.KeyDown
    
    End Sub
    Private Sub DtgProv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgProv.DoubleClick
        If Me.DtgProv.CurrentRowIndex <> -1 Then
            Call Devuelve()
        End If
    End Sub
    Private Sub DtgProv_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgProv.CurrentCellChanged
        Me.DtgProv.Select(Me.DtgProv.CurrentRowIndex)
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If Me.DtgProv.Focus = True Then
                        Try
                            If Me.DtgProv.CurrentRowIndex <> -1 Then
                                Call Devuelve()
                            End If
                        Catch ex As Exception
                        End Try
                    End If

                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function

    Private Sub DtgProv_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DtgProv.Navigate

    End Sub

    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged

        If rbcodigo.Checked = True Then
            Call Cargar_Grilla(Me.TxtDato.Text.Trim, "")
        Else
            Call Cargar_Grilla("", Me.TxtDato.Text.Trim)
        End If

    End Sub
End Class
