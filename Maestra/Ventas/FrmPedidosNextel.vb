Public Class FrmPedidosNextel
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Dsfinanza1 As NarGestionDistribuidora.dsfinanza
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Grid1 = New System.Windows.Forms.DataGrid()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Dsfinanza1 = New NarGestionDistribuidora.dsfinanza()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfinanza1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(616, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Procesar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(808, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(40, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(248, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registro de Pedidos Nextel"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(32, 60)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(944, 260)
        Me.Grid1.TabIndex = 24
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(296, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(144, 32)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.Text = "Buscar"
        '
        'Dsfinanza1
        '
        Me.Dsfinanza1.DataSetName = "dsfinanza"
        Me.Dsfinanza1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'FrmPedidosNextel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 346)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPedidosNextel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Pedidos Nextel"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfinanza1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private tblImp As New DataTable
    Private Sub FrmPedidosNextel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '   tblImp = CAyuda.ListarPedidosNextel("SP_LISTA_TBL_PEDIDO").Tables(0)
        ' Grid1.DataSource = tblImp



        'CargagridPedidosNextel(Grid1, "SP_LISTA_TBL_PEDIDO '" & codempresa & "','09/11/2006'")

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        'CargagridPedidosNextel(Grid1, "SP_LISTA_TBL_PEDIDO '" & VCODNEXTEL & "','" & Me.DateTimePicker1.Value().ToString("dd/MM/yyyy") & "'")
        'Dim TAB_PEDIDO As New DataTable
        'TAB_PEDIDO = ListarGridPedidosNextel("SP_LISTA_TBL_PEDIDO_2  '" & VCODNEXTEL & "','" & Me.DateTimePicker1.Value().ToString("dd/MM/yyyy") & "'")

        'If TAB_PEDIDO.Rows.Count = 0 Then
        '    MessageBox.Show("No Tiene Pedidos", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If




        Dim TAB_PEDIDO_CAB As New DataTable

        TAB_PEDIDO_CAB = CAyuda.ListarDatos("SP_SELECT_PEDIDO_CAB_FATL  ", codempresa).Tables(0)

        Grid1.DataSource = TAB_PEDIDO_CAB

    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub

    Private Sub Grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim TAB_PEDIDO_CAB As New DataTable

        TAB_PEDIDO_CAB = CAyuda.ListarDatos("SP_SELECT_PEDIDO_CAB_FATL  ", codempresa).Tables(0)

        Dim NUMEROPEDIDO As String
        Dim FECHA As Date

        If TAB_PEDIDO_CAB.Rows.Count > 0 Then
            For x As Integer = 0 To TAB_PEDIDO_CAB.Rows.Count - 1

                NUMEROPEDIDO = TAB_PEDIDO_CAB.Rows(x)("NUM_PEDIDO")
                FECHA = Format(CDate(TAB_PEDIDO_CAB.Rows(x)("FECPEDIDO")), "dd/MM/yyyy")

                CAyuda.Ejecutar("NSP_DELETE_TMP_PEDIDO_VTA_DET", VCorrelVta)

                Dim TAB_PEDIDO_DET As New DataTable

                TAB_PEDIDO_DET = CAyuda.ListarDatos("SP_SELECT_PEDIDOS_DET_FALT  ", codempresa, NUMEROPEDIDO).Tables(0)

                If TAB_PEDIDO_DET.Rows.Count > 0 Then
                    For x2 As Integer = 0 To TAB_PEDIDO_DET.Rows.Count - 1
                        Try

                            CAyuda.Ejecutar("InsTMP_PEDIDO_VTA_DETxProc", codempresa, TAB_PEDIDO_DET.Rows(x2)("CODARTI"), TAB_PEDIDO_DET.Rows(x2)("DESARTI"), TAB_PEDIDO_DET.Rows(x2)("CANTIDAD"), TAB_PEDIDO_DET.Rows(x2)("PRECIO"), TAB_PEDIDO_DET.Rows(x2)("PRECIOVTA"), TAB_PEDIDO_DET.Rows(x2)("CODPRES"), TAB_PEDIDO_DET.Rows(x2)("DESPRES"), TAB_PEDIDO_DET.Rows(x2)("MONEDA"), VCorrelVta, CDZONA, CodUsuario, TAB_PEDIDO_DET.Rows(x2)("CODTIPOPRE"), TAB_PEDIDO_DET.Rows(x2)("CODTIPOPAGO"), Format(CDate(TAB_PEDIDO_DET.Rows(x2)("FECPEDIDO")), "dd/MM/yyyy"), TAB_PEDIDO_DET.Rows(x2)("CODCLIENTE"))

                        Catch ex As Exception

                            MsgBox(ex.ToString)
                        End Try
                    Next

                End If

                CAyuda.Ejecutar("NSP_INSERT_PEDIDOVTA_DET_ACTU", codempresa, NUMEROPEDIDO, VCorrelVta, FECHA, CodUsuario, NROPTOVTA)
            Next

        End If

        MsgBox("SE TRANSFERIO")




    End Sub

  
    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        Dim FRMX As New FrmDetallePedidoNextel
        FRMX.CODPEDIDO = Grid1.Item(Grid1.CurrentRowIndex, 0)
        'FRMX.bol = True
        FRMX.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
       


    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged





    End Sub




    Private Sub DateTimePicker1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Click

        CargagridPedidosNextel(Grid1, "SP_LISTA_TBL_PEDIDO '" & codempresa & "','" & "12/12/2020" & "'")
        Dim TAB_PEDIDO As New DataTable
        TAB_PEDIDO = ListarGridPedidosNextel("SP_LISTA_TBL_PEDIDO_2  '" & codempresa & "','" & Me.DateTimePicker1.Value().ToString("dd/MM/yyyy") & "'")


    End Sub


End Class
