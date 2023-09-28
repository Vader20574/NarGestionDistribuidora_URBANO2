Public Class FrmCuotasVendedorX_Linea
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgCuotaLinea As System.Windows.Forms.DataGrid
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarVend As System.Windows.Forms.Button
    Friend WithEvents txtVendedor As System.Windows.Forms.Label
    Friend WithEvents txtCuota As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSubCategoria As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCuotasVendedorX_Linea))
        Me.dgCuotaLinea = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboCategoria = New System.Windows.Forms.ComboBox
        Me.cboSubCategoria = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.txtCuota = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAñadir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.btnBuscarVend = New System.Windows.Forms.Button
        Me.txtVendedor = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnQuitar = New System.Windows.Forms.Button
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCuotaLinea
        '
        Me.dgCuotaLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCuotaLinea.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgCuotaLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCuotaLinea.DataMember = ""
        Me.dgCuotaLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCuotaLinea.Location = New System.Drawing.Point(8, 142)
        Me.dgCuotaLinea.Name = "dgCuotaLinea"
        Me.dgCuotaLinea.ReadOnly = True
        Me.dgCuotaLinea.Size = New System.Drawing.Size(526, 276)
        Me.dgCuotaLinea.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboCategoria)
        Me.GroupBox1.Controls.Add(Me.cboSubCategoria)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFecha2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha1)
        Me.GroupBox1.Controls.Add(Me.txtCuota)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Categoría : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.Location = New System.Drawing.Point(10, 32)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(230, 21)
        Me.cboCategoria.TabIndex = 18
        '
        'cboSubCategoria
        '
        Me.cboSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubCategoria.Location = New System.Drawing.Point(284, 32)
        Me.cboSubCategoria.Name = "cboSubCategoria"
        Me.cboSubCategoria.Size = New System.Drawing.Size(234, 21)
        Me.cboSubCategoria.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(334, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Fec. Fin :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(166, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fec. Inicio :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha2.Location = New System.Drawing.Point(396, 64)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(90, 20)
        Me.dtpFecha2.TabIndex = 4
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha1.Location = New System.Drawing.Point(230, 64)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(86, 20)
        Me.dtpFecha1.TabIndex = 3
        '
        'txtCuota
        '
        Me.txtCuota.Location = New System.Drawing.Point(52, 64)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(56, 20)
        Me.txtCuota.TabIndex = 2
        Me.txtCuota.Text = "0.0"
        Me.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cuota :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Sub Categoría : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(542, 162)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(80, 26)
        Me.btnAñadir.TabIndex = 2
        Me.btnAñadir.Text = "Añadir"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(58, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendedor :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(118, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Text = ""
        '
        'btnBuscarVend
        '
        Me.btnBuscarVend.ImageIndex = 5
        Me.btnBuscarVend.ImageList = Me.ImageList1
        Me.btnBuscarVend.Location = New System.Drawing.Point(434, 12)
        Me.btnBuscarVend.Name = "btnBuscarVend"
        Me.btnBuscarVend.Size = New System.Drawing.Size(44, 23)
        Me.btnBuscarVend.TabIndex = 1
        '
        'txtVendedor
        '
        Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendedor.Location = New System.Drawing.Point(176, 12)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(254, 20)
        Me.txtVendedor.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.txtVendedor)
        Me.GroupBox2.Controls.Add(Me.btnBuscarVend)
        Me.GroupBox2.Location = New System.Drawing.Point(6, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 40)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(542, 194)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(80, 26)
        Me.btnQuitar.TabIndex = 3
        Me.btnQuitar.Text = "Quitar"
        '
        'FrmCuotasVendedorX_Linea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(626, 428)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgCuotaLinea)
        Me.Controls.Add(Me.btnAñadir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCuotasVendedorX_Linea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuota de Vendedor por SubCategoria"
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Public TablaCuotasLinea As New DataTable
    Public CodVendedor As String = String.Empty
    Public CodLinea As String = String.Empty
    'Private Obj As New ClsInterface
    Private ActEventCombo As Boolean

#End Region

#Region "FUNCIONES DE FORM"

    Private Sub CargarDatos()
        CAyuda.CargarDataCombo(cboCategoria, "NSP_Select_Listado_Linea   '" & codempresa & "'", "Código", "Descripción")
        ActEventCombo = True
        CAyuda.CargarDataCombo(cboSubCategoria, "NSP_Sele_SubLineaxlinea '" & cboCategoria.SelectedValue & "','" & codempresa & "'", "Codigo", "Descripcion")
        '  CAyuda.CargarDataCombo(cboSubCategoria, "NSP_Select_Listado_Moneda   '" & codempresa & "'", "Código", "Descripción")

    End Sub


#End Region

    Public Sub FORMATO_GRID()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TablaCuotasLinea.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODVENDED"
            .HeaderText = "CODVEND"
            .Width = 50
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODLINEA"
            .HeaderText = "SUBCATEGORIA"
            .Width = 50
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "DESSUBLINEA"
            .HeaderText = "DESCRIPCION"
            .Width = 150
        End With
        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "MONTOCUOTA"
            .HeaderText = "CUOTA"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "FEC_INI"
            .HeaderText = "FEC_INI"
            .Width = 100
        End With
        Dim column6 As New DataGridTextBoxColumn
        With column6
            .MappingName = "FEC_FIN"
            .HeaderText = "FEC_FIN"
            .Width = 100
        End With
        dgCuotaLinea.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5, column6})
        dgCuotaLinea.TableStyles.Add(TableStyle1)

    End Sub


    Private Sub btnBuscarVend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarVend.Click
        Dim FRMX As New FRM_GRIDVEND
        FRMX.vie2 = Me
        FRMX.ShowDialog()
        FORMATO_GRID()
        cboCategoria.Focus()
    End Sub
    Private Sub btnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñadir.Click
        If Me.TablaCuotasLinea.Rows.Count = 0 Then
            If Me.txtCuota.Text.Trim.Length > 0 Then
                CAyuda.Ejecutar("NSP_INSERT_CUOTAXLINEA_VEND", codempresa, CodVendedor, CodLinea, txtCuota.Text.Trim, dtpFecha1.Value.ToShortDateString, dtpFecha2.Value.ToShortDateString)
                TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, CodVendedor.Trim).Tables(0)
                Me.dgCuotaLinea.DataSource = TablaCuotasLinea
                FORMATO_GRID()
            End If
        Else
            If Me.txtCuota.Text.Trim.Length > 0 Then

                If CStr(cboSubCategoria.SelectedValue) = Nothing Then
                    MsgBox("FALTA LA SUB CATEGORIA ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                    cboSubCategoria.Focus()
                    Exit Sub
                End If

                For cont1 As Integer = 0 To TablaCuotasLinea.Rows.Count - 1
                    If CStr(TablaCuotasLinea.Rows(cont1)("CODLINEA")).Trim = CStr(cboSubCategoria.SelectedValue) Then
                        CAyuda.Ejecutar("NSP_UPDATE_CUOTAXLINEA_VEND", codempresa, CodVendedor, CodLinea, txtCuota.Text.Trim, dtpFecha1.Value.ToShortDateString, dtpFecha2.Value.ToShortDateString)
                        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, CodVendedor.Trim).Tables(0)
                        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
                        FORMATO_GRID()
                        MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

                        Exit For
                    End If
                    If cont1 = TablaCuotasLinea.Rows.Count - 1 Then
                        CAyuda.Ejecutar("NSP_INSERT_CUOTAXLINEA_VEND", codempresa, CodVendedor, CodLinea, txtCuota.Text.Trim, dtpFecha1.Value.ToShortDateString, dtpFecha2.Value.ToShortDateString)
                        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, CodVendedor.Trim).Tables(0)
                        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
                        FORMATO_GRID()
                        MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

                    End If
                Next
            Else

                MsgBox("FALTA LA COUTA ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                txtCuota.Focus()

            End If
        End If
        Me.txtCuota.Text = String.Empty
        Me.dtpFecha1.Value = Now : dtpFecha2.Value = Now
    End Sub
    Private Sub FrmCuotasVendedorX_Linea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
        Me.txtCodigo.Focus()

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

        If TablaCuotasLinea.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar la cuota de la SubCategoria [ " & Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_CUOTAXLINEA_VEND", codempresa, CodVendedor.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 1).ToString.Trim)
            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, CodVendedor.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID()

        End If
    End Sub


    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim FRMX As New FRM_GRIDVEND
            FRMX.vie2 = Me
            FRMX.ShowDialog()
            cboCategoria.Focus()
        End If
    End Sub




#Region "RESTRICCIONES-KEYPRESS"

    Private Sub CajaTexto_SoloLetras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsControl(CType(e.KeyChar, Char)) Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub



#End Region

    Private Sub txtLinea_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            Dim MEN As New FRM_GRIDLINEA
            MEN.Vie2 = Me
            MEN.ShowDialog()
            Me.txtCuota.Focus()
        End If
    End Sub

    Private Sub dgCuotaLinea_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgCuotaLinea.Navigate

    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategoria.SelectedIndexChanged
        If ActEventCombo = True Then
            CAyuda.CargarDataCombo(cboSubCategoria, "NSP_Sele_SubLineaxlinea '" & cboCategoria.SelectedValue & "','" & codempresa & "'", "Codigo", "Descripcion")
        End If

    End Sub

    Private Sub cboSubCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubCategoria.SelectedIndexChanged
        CodLinea = CStr(cboSubCategoria.SelectedValue).Trim
    End Sub

    Private Sub cboSubCategoria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSubCategoria.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtCuota.Focus()
        End If
    End Sub

    Private Sub cboCategoria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCategoria.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboSubCategoria.Focus()
        End If
    End Sub

    Private Sub txtCuota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuota.TextChanged

    End Sub

    Private Sub txtCuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuota.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            dtpFecha1.Focus()
        End If

    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged

    End Sub

    Private Sub dtpFecha1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha1.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            dtpFecha2.Focus()
        End If
    End Sub

    Private Sub dtpFecha2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha2.ValueChanged

    End Sub

    Private Sub dtpFecha2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha2.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            btnAñadir_Click(sender, e)
        End If

    End Sub


    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            btnBuscarVend_Click(sender, e)
        End If

    End Sub
End Class
