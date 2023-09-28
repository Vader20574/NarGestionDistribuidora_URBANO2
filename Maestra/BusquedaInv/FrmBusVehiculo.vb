Public Class FrmBusVehiculo
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, -25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Criterio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, -25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Dato"
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid1.DataMember = ""
        Me.grid1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(16, 63)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(520, 224)
        Me.grid1.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 48)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescripcion.Location = New System.Drawing.Point(408, 16)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(96, 24)
        Me.rbdescripcion.TabIndex = 5
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(328, 16)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 24)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdato.Location = New System.Drawing.Point(56, 18)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(205, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dato : "
        '
        'FrmBusVehiculo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(554, 293)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 321)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 321)
        Me.Name = "FrmBusVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Vehiculo"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Dim ATblBus As New DataTable
    Public AFrmVehi As New FrmVehiculo

    Private Sub FrmBusVehiculo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ATblBus = CAyuda.ListarDatos("NSP_SELECT_LISTA_VEHICULO", "", codempresa).Tables(0)
        grid1.DataSource = ATblBus
        FormatGrid()


    End Sub
    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = ATblBus.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Cod.Vehiculo"
            .MappingName = "CODVEHI"
            .Width = 80
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Placa_"
            .MappingName = "PLACA"
            .Width = 400
        End With
        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2})
        grid1.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub FrmBusVehiculo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtdato.Focus()
    End Sub


    Private Sub CMBCONDICION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtdato.Focus()
    End Sub


    Private Sub txtdato_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        ATblBus.Clear()
        If rbdescripcion.Checked = True Then
            ATblBus = CAyuda.ListarDatos("NSP_SELECT_BUSQUEDA_VEHICULO", txtdato.Text, codempresa, 1).Tables(0)
        Else
            ATblBus = CAyuda.ListarDatos("NSP_SELECT_BUSQUEDA_VEHICULO", txtdato.Text, codempresa, 2).Tables(0)
        End If
        grid1.DataSource = ATblBus

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                               ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If grid1.Focus = True Then
                        Dim ATblVe As New DataTable
                        ATblVe = CAyuda.ListarDatos("NSP_SELECT_LISTA_VEHICULO", grid1.Item(grid1.CurrentRowIndex, 0), codempresa).Tables(0)
                        AFrmVehi.txtcod.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("CODVEHI"))
                        AFrmVehi.txtdescripcion.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("DESVEHI"))
                        AFrmVehi.txtplaca.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("PLACA"))
                        AFrmVehi.txtcerti.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("CERTIFICADO"))
                        AFrmVehi.TXTMARCA.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("MARCA"))
                        AFrmVehi.TXTCOLOR.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("COLOR"))
                        AFrmVehi.TXTAÑOFA.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("AÑOFABRI"))
                        Me.Close()
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        Dim ATblVe As New DataTable
        ATblVe = CAyuda.ListarDatos("NSP_SELECT_LISTA_VEHICULO", grid1.Item(grid1.CurrentRowIndex, 0), codempresa).Tables(0)
        AFrmVehi.txtcod.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("CODVEHI"))
        AFrmVehi.txtdescripcion.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("DESVEHI"))
        AFrmVehi.txtplaca.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("PLACA"))
        AFrmVehi.txtcerti.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("CERTIFICADO"))
        AFrmVehi.TXTMARCA.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("MARCA"))
        AFrmVehi.TXTCOLOR.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("COLOR"))
        AFrmVehi.TXTAÑOFA.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("AÑOFABRI"))

        AFrmVehi.txtCargaUtil.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("CARGAUTIL"))
        AFrmVehi.txtcubicaje.Text = CAyuda.ValidaNulls(ATblVe.Rows(0)("CBKILPET"))

        If CAyuda.ValidaNulls(ATblVe.Rows(0)("Imagen")) = Nothing Then
        Else
            AFrmVehi.PictureBox1.Image = Image.FromFile(CAyuda.ValidaNulls(ATblVe.Rows(0)("Imagen")))
        End If

        Me.Close()

    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
