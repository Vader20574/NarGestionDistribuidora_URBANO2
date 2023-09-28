Imports System.Text

Public Class frmfact_login
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TXTUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfact_login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.TXTPASSWORD = New System.Windows.Forms.TextBox()
        Me.TXTUSUARIO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNACEPTAR)
        Me.GroupBox1.Controls.Add(Me.TXTPASSWORD)
        Me.GroupBox1.Controls.Add(Me.TXTUSUARIO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ForeColor = System.Drawing.Color.Black
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(344, 79)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(89, 24)
        Me.BTNCANCELAR.TabIndex = 15
        Me.BTNCANCELAR.Text = "Cancelar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.ImageList = Me.ImageList1
        Me.BTNACEPTAR.Location = New System.Drawing.Point(344, 54)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(88, 21)
        Me.BTNACEPTAR.TabIndex = 14
        Me.BTNACEPTAR.Text = "Aceptar"
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPASSWORD.Location = New System.Drawing.Point(190, 84)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASSWORD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTPASSWORD.Size = New System.Drawing.Size(137, 21)
        Me.TXTPASSWORD.TabIndex = 12
        Me.TXTPASSWORD.Text = "301102"
        '
        'TXTUSUARIO
        '
        Me.TXTUSUARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTUSUARIO.Location = New System.Drawing.Point(190, 58)
        Me.TXTUSUARIO.Name = "TXTUSUARIO"
        Me.TXTUSUARIO.Size = New System.Drawing.Size(137, 21)
        Me.TXTUSUARIO.TabIndex = 11
        Me.TXTUSUARIO.Text = "2411"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(128, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(139, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CodUsuario : "
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sistema de Gestion NarGesto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmfact_login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(470, 126)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(486, 165)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(486, 165)
        Me.Name = "frmfact_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN NAR GEST"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmfact_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dsa As New DataSet
        Try
            If Environment.MachineName <> "PC-GEORGE" Then
                TXTUSUARIO.Text = ""
                TXTPASSWORD.Text = ""
            End If

            'IniciarconfigVta()
            Me.TXTUSUARIO.Focus()
        Catch X As Exception
            MessageBox.Show("Ruta de Servidor Erronea. Consulte con el administrador del Sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End Try

    End Sub


    Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Integer, ByVal ByValfRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer
    Private Const vbAPINull As Integer = 0
    Private Const ODBC_ADD_DSN As Short = 1

    Private Sub crearDSN()
        Const driver As String = "SQL Server"
        Const nombredsn As String = "REPORTES"
        Const descripcion As String = "Acceso a datos mediante DSN"
        Dim host As String = "190.117.178.122"
        Dim base As String = "NARGEST"
        Dim user As String = "SA"
        Dim pass As String = "0p3r@d0r"

        Dim attributes As New StringBuilder($"DSN={nombredsn}{Convert.ToChar(0)}")
        attributes.Append($"Server={host}{Convert.ToChar(0)}")
        attributes.Append($"Description={descripcion}{Convert.ToChar(0)}")
        attributes.Append($"Database={base}{Convert.ToChar(0)}")
        attributes.Append("Trusted_Connection=NO{Convert.ToChar(0)}")
        attributes.Append($"UID={user}{Convert.ToString(0)}")
        attributes.Append($"PWD={pass}{Convert.ToString(0)}")

        If (Not SQLConfigDataSource(0, ODBC_ADD_DSN, driver, attributes.ToString)) Then
            MessageBox.Show("Se ha creado el DSN de sistema.")
        Else
            MessageBox.Show("No se ha podido crear el DSN de sistema.")
        End If
    End Sub


    Sub BorrarDNS()

        Dim dl As Long                 ' Valor devuelto por la función API
        Dim sDriver As String          ' Nombre del controlador
        Dim sDsnName As String         ' Nombre del DSN

        Const ODBC_REMOVE_SYS_DSN As Long = 6    ' Se eliminará un DSN de sistema

        ' Establecemos los atributos necesarios

        ' CUIDADO: no dejar espacios en blanco entre el parámetro
        ' «DSN», el signo igual y el nombre del DSN (DSN=Nombre DSN)
        sDsnName = "DSN=REPORTES"
        sDriver = "SQL Server"

        ' Modificamos el origen de datos de usuario especificado
        dl = SQLConfigDataSource(0&, ODBC_REMOVE_SYS_DSN, sDriver, sDsnName)

        If (dl = 1) Then
            MessageBox.Show("El DSN de sistema se ha eliminado correctamente.")
        Else
            MessageBox.Show("No se ha podido eliminar el DSN de sistema especificado.")
        End If


    End Sub


    Public Sub BTNACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACEPTAR.Click
        'BorrarDNS()
        'crearDSN()





        Dim DtUsu As New DataTable

        Dim SQL As String
        If TXTUSUARIO.Text.Trim = "" Or TXTPASSWORD.Text.Trim = "" Then
            MessageBox.Show("INGRESE CodUsuario Y PASSWORD PARA EL INGRESO ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If TmpListarDatos("ProBusUsuCod  '" & codempresa & "','" & TXTUSUARIO.Text.Trim & "'").Rows.Count = 0 Then
            MessageBox.Show("EL CodUsuario ES INCORRECTO... ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXTUSUARIO.Text = ""
            TXTUSUARIO.Focus()
            Exit Sub
        End If

        If TmpListarDatos("NSP_LOGEAR_USUARIO  '" & codempresa & "','" & TXTUSUARIO.Text.Trim & "','" & TXTPASSWORD.Text.Trim & "'").Rows.Count = 0 Then
            MessageBox.Show("EL PASSWORD ES INCORRECTO... ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXTPASSWORD.Text = ""
            TXTPASSWORD.Focus()
            Exit Sub
        End If

        SQL = "SP_SELECTUSUARIO    '" & codempresa & "','" & TXTUSUARIO.Text.Trim & "'"
        DtUsu = TmpListarDatos(SQL)
        If DtUsu.Rows.Count = 0 Then
            MsgBox("EL CodUsuario NO TIENE PERMISO PARA USAR ESTE MODULO DEL SISTEMA NARGESTION..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            TXTUSUARIO.Text = ""
            TXTPASSWORD.Text = ""
            TXTUSUARIO.Focus()
            Exit Sub

        Else
            CodUsuario = DtUsu.Rows(0)("CdUsuario").ToString.Trim
            DesUsuario = DtUsu.Rows(0)("Usuario").ToString.Trim
            UsuNivel = DtUsu.Rows(0)("nivel").ToString.Trim

        End If

        SQL = "SP_SELECTPTOVTA    '" & codempresa & "','" & Environment.MachineName & "'"
        DtUsu = TmpListarDatos(SQL)
        If DtUsu.Rows.Count = 0 Then
            MsgBox("LA nroptovta NO ESTA REGISTRADA EN EL SISTEMA.VERIFICAR PTOVTA ", MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC")
            Exit Sub
        End If

        'NROPTOVTA = DS.Tables(0).Rows(0)("NROPTOVTA").ToString.Trim
        'Venta = DS.Tables(0).Rows(0)("NROPTOVTA").ToString.Trim
        'VEditPrecio = DS.Tables(0).Rows(0)("EDITPRECIO")
        'VEEIDTFECHA = DS.Tables(0).Rows(0)("EDITFECHA")
        'zonventa = NROPTOVTA
        'nroptovta = zonventa
        'nroptovta = nroptovta
        'IniciarCnfgPtoVta()
        'fact_title = "Facturacion Directa " & zonventa & "  Punto de Venta " & nroptovta
        'VIE.mnucambiopunto.Visible = False

        ProcesarFormatoTicket()
        PTOVTASelProc()

        Me.Close()

    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        End
    End Sub

    Private Sub TXTUSUARIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTUSUARIO.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TXTPASSWORD.Focus()
            Me.TXTPASSWORD.SelectAll()
        End If
    End Sub

    Private Sub TXTPASSWORD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTPASSWORD.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BTNACEPTAR_Click(sender, e)
        End If
    End Sub

    Private Sub TXTPASSWORD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTPASSWORD.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class