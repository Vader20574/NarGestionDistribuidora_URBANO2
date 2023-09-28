Public Class FrmConsultaEmisionRet
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public objRetenEmiProvCab As New FrmRetenEmiProvCab

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbpais As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbpais = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registro de Emision de Comprobante De Retencion"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(16, 58)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(664, 218)
        Me.Grid1.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbpais)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 50)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'rbpais
        '
        Me.rbpais.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbpais.Location = New System.Drawing.Point(436, 22)
        Me.rbpais.Name = "rbpais"
        Me.rbpais.Size = New System.Drawing.Size(135, 16)
        Me.rbpais.TabIndex = 3
        Me.rbpais.Text = "Proveedor"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(313, 21)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(125, 19)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Nro de Documento"
        '
        'txtdato
        '
        Me.txtdato.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(56, 20)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(230, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'FrmConsultaEmisionRet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 332)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultaEmisionRet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Emision de Comprobante De Retencion"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public NumEmision As String

    Private Sub FrmDetallePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargagridRETENEMIPROVCAB(Grid1, "NSP_SELECT_RETENEMIPROVCAB '" & codempresa & "'")

    End Sub

    Private Sub Grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Click
        Dim Tmp_Present As DataTable

        Tmp_Present = TmpListarDatos("NSP_SELECT_RETENEMIPROVCAB_XNUM '" & codempresa & "','" & Me.Grid1.Item(Me.Grid1.CurrentRowIndex, 0) & "'")

        objRetenEmiProvCab.txtserienum.Text = Tmp_Present.Rows(0)("NRONTARETEN")
        objRetenEmiProvCab.lblcodproveedor.Text = Tmp_Present.Rows(0)("CDPROVEE")
        objRetenEmiProvCab.txtproveedor.Text = Tmp_Present.Rows(0)("DESPROVEE")
        objRetenEmiProvCab.lblruc.Text = Tmp_Present.Rows(0)("RUCPROVEE")
        objRetenEmiProvCab.lbldireccion.Text = Tmp_Present.Rows(0)("DIRPROVEE")
        objRetenEmiProvCab.dtpfecha.Value = Tmp_Present.Rows(0)("FECDOCUM")
        'objRetenEmiProvCab.TxtDoc1.Text = Tmp_Present.Rows(0)("lblruc")
        'objRetenEmiProvCab.TxtDoc2.Text = Tmp_Present.Rows(0)("lblruc")
        objRetenEmiProvCab.txtserienum.Text = Tmp_Present.Rows(0)("NRONTARETEN")

        objRetenEmiProvCab.lbltotal.Text = Tmp_Present.Rows(0)("MONTORETBAS")

        Me.Close()

    End Sub

    Private Sub Grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid1.KeyDown

    End Sub


    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub

    Sub llena()
        If Me.txtdato.Text.Trim = "" Then

            CargagridRETENEMIPROVCAB(Grid1, "NSP_SELECT_RETENEMIPROVCAB '" & codempresa & "'")

        Else
            If Me.rbcodigo.Checked = True Then
                CargagridRETENEMIPROVCAB(Grid1, "NSP_SELECT_RETENEMIPROVCAB_FILTRO '" & Me.txtdato.Text.Trim & "','','" & codempresa & "'")
            Else
                CargagridRETENEMIPROVCAB(Grid1, "NSP_SELECT_RETENEMIPROVCAB_FILTRO '','" & Me.txtdato.Text.Trim & "','" & codempresa & "'")
            End If
        End If
    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        llena()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
