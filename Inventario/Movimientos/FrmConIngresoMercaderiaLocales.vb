Public Class FrmConIngresoMercaderiaLocales
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
    Friend WithEvents TxtArt As System.Windows.Forms.TextBox
    Friend WithEvents TxtDes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtgProducto As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtArt = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtDes = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DtgProducto = New System.Windows.Forms.DataGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DtgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtArt)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtArt
        '
        Me.TxtArt.Location = New System.Drawing.Point(8, 13)
        Me.TxtArt.Name = "TxtArt"
        Me.TxtArt.Size = New System.Drawing.Size(120, 20)
        Me.TxtArt.TabIndex = 0
        Me.TxtArt.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDes)
        Me.GroupBox2.Location = New System.Drawing.Point(144, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(540, 40)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TxtDes
        '
        Me.TxtDes.Location = New System.Drawing.Point(8, 13)
        Me.TxtDes.Name = "TxtDes"
        Me.TxtDes.Size = New System.Drawing.Size(512, 20)
        Me.TxtDes.TabIndex = 1
        Me.TxtDes.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtgProducto)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(681, 312)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'DtgProducto
        '
        Me.DtgProducto.CaptionVisible = False
        Me.DtgProducto.DataMember = ""
        Me.DtgProducto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgProducto.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgProducto.Location = New System.Drawing.Point(8, 12)
        Me.DtgProducto.Name = "DtgProducto"
        Me.DtgProducto.ReadOnly = True
        Me.DtgProducto.Size = New System.Drawing.Size(660, 292)
        Me.DtgProducto.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Ingrese Descripcion del Articulo :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Ingrese Codigo :"
        '
        'FrmConIngresoMercaderiaLocales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(690, 382)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConIngresoMercaderiaLocales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Articulos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DtgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
  

#Region "FUNCIONES"
    Private Ayuda As New ClsAyuda
    Private Tabla As New DataTable
    Public Ingreso As New FrmIngresoDeMercaderia
    'Private Inter As New ClsInterface
    Public DEVOLVER As Boolean
    Public CDALMACEN As String
    Private TipoOperacion As String


#End Region

    Private Sub Formato_Grilla()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = Tabla.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "CODIGO"
            .MappingName = "CODARTI"
            .Width = 80
        End With
        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "DESCRIPCION"
            .MappingName = "DESARTI"
            .Width = 380
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "PRECIO"
            .MappingName = "COSTOBAS"
            .Width = 80
            .NullText = "0"
        End With


        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "MEDIDA"
            .MappingName = "CODMED"
            .Width = 80
        End With


        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "PRESENTACIÓN"
            .MappingName = "DESPRES"
            .Width = 200
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .NullText = ""
            .HeaderText = "FICHA TECNICA"
            .MappingName = "NROFICHATEC"
            .Width = 100
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "NRO COMPRA"
            .MappingName = "CODGEN"
            .Width = 100
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
           {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4})
        Me.DtgProducto.TableStyles.Add(grdTableStyle1)

    End Sub
    Private Sub Cargar_Grilla()
        Try
            Tabla = CAyuda.ListarDatos("NSP_LISTAR_ARTI_PRESENT", codempresa, CDALMACEN).Tables(0)
            Me.DtgProducto.DataSource = Tabla
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub
    Private Sub Devuelve()
        Try
            With Me.DtgProducto
                Ingreso.tarticulo.Text = Trim(.Item(.CurrentRowIndex, 0))
                Ingreso.txtdesarticulo.Text = Trim(.Item(.CurrentRowIndex, 1))
                'Ingreso.TxtPrecio.Text = Inter.ValidaNullsInteger(.Item(.CurrentRowIndex, 2))
                'Ingreso.txtunidad.Text = Trim(Inter.ValidaNulls(.Item(.CurrentRowIndex, 3)))
                'Ingreso.txtnorden.Text = Trim(Inter.ValidaNulls(.Item(.CurrentRowIndex, 6)))
                'Ingreso.cbPresentacion.SelectedValue = Trim(Inter.ValidaNulls(.Item(.CurrentRowIndex, 4)))
            End With
            'Ingreso.Label16.Visible = False
            'Ingreso.txtcantidadD.Visible = False
            Ingreso.txtcantidad.ReadOnly = False
            TipoOperacion = "Ingresar"
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message + Chr(13) + "Consulte a su Proveedor", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
        End Try
    End Sub
    Private Sub FrmConIngresoMercaderiaLocales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Grilla()
        Call Formato_Grilla()
    End Sub
    Private Sub FrmConIngresoMercaderiaLocales_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Ayuda = Nothing
        Tabla = Nothing
        'Inter = Nothing
    End Sub
    Private Sub TxtArt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtArt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Grilla()
            Me.TxtArt.Focus()

        ElseIf e.KeyCode = Keys.Down Then
            Me.DtgProducto.Focus()
        End If
    End Sub
    Private Sub TxtDes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Grilla()
            Me.TxtDes.Focus()

        ElseIf e.KeyCode = Keys.Down Then
            Me.DtgProducto.Focus()
        End If
    End Sub
    Private Sub DtgProducto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgProducto.DoubleClick
        If Me.DtgProducto.CurrentRowIndex <> -1 Then
            DEVOLVER = True
            Call Devuelve()
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If DtgProducto.Focus = True Then
                        Try
                            If Me.DtgProducto.CurrentRowIndex <> -1 Then

                                DEVOLVER = True
                                Devuelve()

                            End If
                        Catch ex As Exception
                        End Try
                    End If

                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function
    Private Sub DtgProducto_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgProducto.CurrentCellChanged
        Me.DtgProducto.Select(Me.DtgProducto.CurrentRowIndex)
    End Sub

    Private Sub DtgProducto_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DtgProducto.Navigate

    End Sub

    Private Sub TxtArt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtArt.TextChanged
        For i As Integer = 0 To Tabla.Rows.Count - 1
            DtgProducto.UnSelect(i)
        Next
        For i As Integer = 0 To Tabla.Rows.Count - 1
            If Mid(DtgProducto.Item(i, 0).tostring.Trim, 1, TxtArt.Text.Trim.Length) = TxtArt.Text.Trim Then
                DtgProducto.CurrentRowIndex = i
                Exit For
            End If
        Next

    End Sub

    Private Sub TxtDes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDes.TextChanged
        For i As Integer = 0 To Tabla.Rows.Count - 1
            DtgProducto.UnSelect(i)
        Next
        For i As Integer = 0 To Tabla.Rows.Count - 1
            If Mid(DtgProducto.Item(i, 1).tostring.Trim, 1, TxtDes.Text.Trim.Length) = TxtDes.Text.Trim Then
                DtgProducto.CurrentRowIndex = i
                Exit For
            End If
        Next
    End Sub
End Class
