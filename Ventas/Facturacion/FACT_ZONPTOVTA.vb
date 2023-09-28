Public Class FACT_ZONPTOVTA

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
    Friend WithEvents FRAMEPUNTO As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents CBOZONAVENTA As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FACT_ZONPTOVTA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.FRAMEPUNTO = New System.Windows.Forms.GroupBox
        Me.CBOZONAVENTA = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BTNACEPTAR = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.FRAMEPUNTO.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.FRAMEPUNTO)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 72)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de Proceso"
        Me.Label3.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(188, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 21)
        Me.DateTimePicker1.TabIndex = 4
        Me.DateTimePicker1.Value = New Date(2008, 1, 29, 0, 0, 0, 0)
        Me.DateTimePicker1.Visible = False
        '
        'FRAMEPUNTO
        '
        Me.FRAMEPUNTO.Controls.Add(Me.CBOZONAVENTA)
        Me.FRAMEPUNTO.Controls.Add(Me.Label4)
        Me.FRAMEPUNTO.Location = New System.Drawing.Point(8, 16)
        Me.FRAMEPUNTO.Name = "FRAMEPUNTO"
        Me.FRAMEPUNTO.Size = New System.Drawing.Size(313, 41)
        Me.FRAMEPUNTO.TabIndex = 3
        Me.FRAMEPUNTO.TabStop = False
        '
        'CBOZONAVENTA
        '
        Me.CBOZONAVENTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOZONAVENTA.Location = New System.Drawing.Point(88, 13)
        Me.CBOZONAVENTA.Name = "CBOZONAVENTA"
        Me.CBOZONAVENTA.Size = New System.Drawing.Size(211, 21)
        Me.CBOZONAVENTA.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Zona de Venta :"
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.ImageList = Me.ImageList1
        Me.BTNACEPTAR.Location = New System.Drawing.Point(68, 81)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(193, 24)
        Me.BTNACEPTAR.TabIndex = 50
        Me.BTNACEPTAR.Text = "Aceptar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FACT_ZONPTOVTA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(363, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FACT_ZONPTOVTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  ZONAS DE VENTA"
        Me.GroupBox1.ResumeLayout(False)
        Me.FRAMEPUNTO.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim U As String
    Private Sub FACT_ZONPTOVTA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(CBOZONAVENTA, "sp_ptosxusuario '" & codempresa & "','" & CodUsuario & "'", "codigo", "punto")
        'MsgBox(U.ToString)
    End Sub

    Private Sub BTNACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACEPTAR.Click
        Dim ptovta As String
        ptovta = CBOZONAVENTA.SelectedValue.ToString
        ZonaVenta = CBOZONAVENTA.Text

        Venta = ptovta
        If Trim(ptovta) = "" Then
            MessageBox.Show("Selecione un Punto de Venta", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Call inicia_variables_ptovta(ptovta)
        'CargaVariablesGlobales()
        Dim FECHA As String = ""
        'FECHA = Format(Me.DateTimePicker1.Value, "MM/dd/yyyy")
        'Guarda("FECHA_UPDATE '" & Venta.ToString & "','" & FECHA.ToString & "'")

        Close()
        fact_title = "Facturacion Directa " & CBOZONAVENTA.Text & "  Punto de Venta " & NROPTOVTA

        If FOCOVENTANA = "INICIAFACTURACION" Then
            Dim FRMX As New FRMFACTURACION
            FRMX.Text = fact_title
            FRMX.Show()
            FOCOVENTANA = ""
        End If
        FOCOVENTANA = ""
    End Sub
    Private Sub CBOZONAVENTA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBOZONAVENTA.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BTNACEPTAR.Focus()
        End If
    End Sub

    Private Sub CBOZONAVENTA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOZONAVENTA.SelectedIndexChanged

    End Sub

    Private Sub CBOZONAVENTA_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOZONAVENTA.SelectedValueChanged

    End Sub

    Private Sub CBOZONAVENTA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOZONAVENTA.Click

    End Sub

    Private Sub CBOZONAVENTA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOZONAVENTA.TextChanged

    End Sub
End Class
