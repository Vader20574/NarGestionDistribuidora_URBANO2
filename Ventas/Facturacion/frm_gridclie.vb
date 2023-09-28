Imports System.Data.SqlClient

Public Class frm_gridclie
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
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents truc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents Ds_gridclie21 As mantenimiento.ds_gridclie2
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        'Me.Ds_gridclie21 = New mantenimiento.ds_gridclie2
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.truc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tcliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tcodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Ds_gridclie21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.CaptionText = "  Registro de Clientes"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(12, 61)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(808, 448)
        Me.grid1.TabIndex = 7
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Ds_gridclie21
        '
        'Me.Ds_gridclie21.DataSetName = "ds_gridclie2"
        'Me.Ds_gridclie21.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "codigo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "A Paterno"
        Me.DataGridTextBoxColumn2.MappingName = "apellidop"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "A Materno"
        Me.DataGridTextBoxColumn3.MappingName = "apellidom"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn4.MappingName = "nombre"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Razón Social"
        Me.DataGridTextBoxColumn5.MappingName = "razon"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "RUC"
        Me.DataGridTextBoxColumn6.MappingName = "ruc"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 110
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.truc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tcodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 46)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'truc
        '
        Me.truc.Location = New System.Drawing.Point(656, 17)
        Me.truc.Name = "truc"
        Me.truc.Size = New System.Drawing.Size(128, 21)
        Me.truc.TabIndex = 5
        Me.truc.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(616, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RUC :"
        '
        'tcliente
        '
        Me.tcliente.Location = New System.Drawing.Point(296, 17)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.Size = New System.Drawing.Size(264, 21)
        Me.tcliente.TabIndex = 3
        Me.tcliente.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente/Razon Social :"
        '
        'tcodigo
        '
        Me.tcodigo.Location = New System.Drawing.Point(72, 17)
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(80, 21)
        Me.tcodigo.TabIndex = 1
        Me.tcodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código :"
        '
        'frm_gridclie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(832, 517)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_gridclie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros de Cliente"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Ds_gridclie21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public AFrmGuiaDir As New FRMGUIADIRECTA
    Public AFrmGuiaTrans As New FrmGuiaTransp
    Dim i As Int32
    'Dim Inter As New ClsInterface
    Dim ds As New DataSet

    Private Sub frm_gridclie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call quita_maxi_min_form(Me)
            Dim dt As New DataTable
            dt = llena()
            Me.DataGridTableStyle1.MappingName = dt.TableName
            Me.DataGridTableStyle1.GridColumnStyles(0).MappingName = "codigo"
            Me.DataGridTableStyle1.GridColumnStyles(1).MappingName = "apellidop"
            Me.DataGridTableStyle1.GridColumnStyles(2).MappingName = "apellidom"
            Me.DataGridTableStyle1.GridColumnStyles(3).MappingName = "nombre"
            Me.DataGridTableStyle1.GridColumnStyles(4).MappingName = "razon"
            Me.DataGridTableStyle1.GridColumnStyles(5).MappingName = "ruc"
            Me.grid1.TableStyles.Add(Me.DataGridTableStyle1)


        Catch
        End Try
    End Sub
    'Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
    '                                     ByVal keyData As Keys) As Boolean
    '    Const WM_KEYDOWN As Integer = &H100
    '    Const WM_SYSKEYDOWN As Integer = &H104

    '    If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
    '        Select Case (keyData)
    '            Case Keys.Enter
    '                If grid1.Focus = True Then
    '                    pasadatos()
    '                End If
    '                Me.Close()

    '        End Select
    '    End If

    '    Return MyBase.ProcessCmdKey(msg, keyData)
    'End Function

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        pasadatos()
        Me.Close()

    End Sub

    Sub pasadatos()
        Try

            Dim ds As New DataSet

            Dim cn As New SqlConnection(STRCN)

            VAR1 = grid1.Item(grid1.CurrentRowIndex, 0)

            Dim da As New SqlDataAdapter("select codcliente,paterno,materno,nombres,razonsocial,ruc,direccion,dni from cliente where (codempresa='" & Codempresa & "' and estado=0 and codcliente='" & grid1.Item(grid1.CurrentRowIndex, 0) & "')", cn)
            da.Fill(ds)

            '  Conecta("select codcliente,paterno,materno,nombres,razonsocial,ruc,direccion,dni from cliente where (codempresa='" & Codempresa & "' and estado=0 and codcliente='" & grid1.Item(grid1.CurrentRowIndex, 0) & "') ", "pa2")

            Dim RucGuia As String
            RucGuia = ""

            RucGuia = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)(5))
            If ds.Tables(0).Rows.Count > 0 Then
                If AFrmGuiaTrans.AIntValor = 1 Then
                    AFrmGuiaTrans.txtcodcliente.Text = Trim(ds.Tables(0).Rows(0)(0))
                    If Trim(ds.Tables(0).Rows(0)(4)) = "" Then
                        AFrmGuiaTrans.txtdescliente.Text = Trim(ds.Tables(0).Rows(0)(1)) + " " + Trim(ds.Tables(0).Rows(0)(2)) + ", " + Trim(ds.Tables(0).Rows(0)(3))
                    Else
                        AFrmGuiaTrans.txtdescliente.Text = Trim(ds.Tables(0).Rows(0)(4))
                    End If
                    AFrmGuiaTrans.txtruc.Text = Trim(ds.Tables(0).Rows(0)(5))
                    AFrmGuiaTrans.txtdireccion.Text = Trim(ds.Tables(0).Rows(0)(6))

                Else
                    AFrmGuiaDir.txtcodcliente.Text = Trim(ds.Tables(0).Rows(0)(0))
                    If Trim(ds.Tables(0).Rows(0)(4)) = "" Then
                        AFrmGuiaDir.txtdescliente.Text = Trim(ds.Tables(0).Rows(0)(1)) + " " + Trim(ds.Tables(0).Rows(0)(2)) + ", " + Trim(ds.Tables(0).Rows(0)(3))
                    Else
                        AFrmGuiaDir.txtdescliente.Text = Trim(ds.Tables(0).Rows(0)(4))
                    End If

                    If Len(RucGuia.Trim) = 0 Then
                        AFrmGuiaDir.txtruc.Text = Trim(ds.Tables(0).Rows(0)(7))
                        AFrmGuiaDir.Label6.Text = "Dni :"
                    Else
                        AFrmGuiaDir.txtruc.Text = Trim(ds.Tables(0).Rows(0)(5))
                        AFrmGuiaDir.Label6.Text = "Ruc :"
                    End If

                    'AFrmGuiaDir.txtruc.Text = Trim(ds.Tables("pa").Rows(0)("dni"))
                    AFrmGuiaDir.txtdireccion.Text = Trim(ds.Tables(0).Rows(0)(6))
                End If
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function llena() As DataTable
        Try
            ds.Clear()
            'Conecta("select C.codcliente as codigo,paterno as apellidop,materno as apellidom,nombres as nombre,razonsocial as razon,ruc as ruc from cliente C  where (C.codempresa='" & Codempresa & "' and estado=0 and C.codcliente like '" & Me.tcodigo.Text.Trim & "%' and ruc like '" & Me.truc.Text.Trim & "%' and (paterno like '" & Me.tcliente.Text.Trim & "%' or materno like '" & Me.tcliente.Text.Trim & "%' or nombres like '" & Me.tcliente.Text.Trim & "%' or razonsocial like '" & Me.tcliente.Text.Trim & "%')) ", "pa")
            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_BUSC_CLIE", codempresa, Me.tcodigo.Text.Trim, Me.truc.Text.Trim, Me.tcliente.Text.Trim).Tables(0)
            'oda.Fill(ds)
            Me.grid1.DataSource = Nothing
            Me.grid1.DataSource = dt
            Return dt
        Catch
            Return Nothing
        End Try
    End Function

    Private Sub tcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodigo.KeyPress, tcliente.KeyPress, truc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub

    Private Sub tcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcodigo.TextChanged

    End Sub

    Private Sub grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            pasadatos()
            Me.Close()
        End If
    End Sub
End Class
