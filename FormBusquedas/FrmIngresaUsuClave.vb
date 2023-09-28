Public Class FrmIngresaUsuClave
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblProceso As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmIngresaUsuClave))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtClave = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblProceso = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 155
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtClave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(116, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(74, 40)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(124, 20)
        Me.TxtClave.TabIndex = 2
        Me.TxtClave.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña : "
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(74, 14)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(124, 20)
        Me.TxtUsuario.TabIndex = 1
        Me.TxtUsuario.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario : "
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 15
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(124, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "  &Aceptar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 14
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(252, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "     &Cancelar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Proceso : "
        '
        'LblProceso
        '
        Me.LblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProceso.Location = New System.Drawing.Point(70, 6)
        Me.LblProceso.Name = "LblProceso"
        Me.LblProceso.Size = New System.Drawing.Size(282, 23)
        Me.LblProceso.TabIndex = 160
        Me.LblProceso.Text = "ANULACION DE INGRESO"
        Me.LblProceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmIngresaUsuClave
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(364, 154)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblProceso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmIngresaUsuClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingrese Usuario y Contraseña"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Public DEVOLVER As Boolean
    Public Proceso As String


#End Region


    Private Sub FrmIngresaUsuClave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DS As New DataSet

        If TxtUsuario.Text.Trim = "" Or TxtClave.Text.Trim = "" Then
            MessageBox.Show("INGRESE USUARIO Y PASSWORD PARA EL INGRESO ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If TmpListarDatos("ProBusUsuCod  '" & codempresa & "','" & TxtUsuario.Text.Trim & "'").Rows.Count = 0 Then
            MessageBox.Show("EL USUARIO ES INCORRECTO... ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtUsuario.Text = ""
            TxtUsuario.Focus()
            Exit Sub
        End If
        If TmpListarDatos("NSP_LOGEAR_USUARIO  '" & codempresa & "','" & TxtUsuario.Text.Trim & "','" & TxtClave.Text.Trim & "'").Rows.Count = 0 Then
            MessageBox.Show("EL PASSWORD ES INCORRECTO... ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtClave.Text = ""
            TxtClave.Focus()
            Exit Sub
        End If
        If SELECT_PERMISO_PROC(Proceso, TxtUsuario.Text) = False Then
            MsgBox("EL USUARIO NO TIENE ACCESO A ESTE PROCESO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub TxtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUsuario.TextChanged

    End Sub

    Private Sub TxtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtClave.Focus()
        End If
    End Sub

    Private Sub TxtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClave.TextChanged

    End Sub

    Private Sub TxtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class
