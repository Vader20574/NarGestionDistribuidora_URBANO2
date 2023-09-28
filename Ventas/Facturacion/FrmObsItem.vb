Public Class FrmObsItem
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
    Friend WithEvents txtobsitem As System.Windows.Forms.TextBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmObsItem))
        Me.txtobsitem = New System.Windows.Forms.TextBox
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'txtobsitem
        '
        Me.txtobsitem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobsitem.Location = New System.Drawing.Point(16, 15)
        Me.txtobsitem.Multiline = True
        Me.txtobsitem.Name = "txtobsitem"
        Me.txtobsitem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobsitem.Size = New System.Drawing.Size(344, 120)
        Me.txtobsitem.TabIndex = 0
        Me.txtobsitem.Text = ""
        '
        'btncancelar
        '
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.ImageIndex = 4
        Me.btncancelar.Location = New System.Drawing.Point(224, 143)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(128, 24)
        Me.btncancelar.TabIndex = 1
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnaceptar
        '
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.ImageIndex = 1
        Me.btnaceptar.ImageList = Me.ImageList1
        Me.btnaceptar.Location = New System.Drawing.Point(80, 143)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(128, 24)
        Me.btnaceptar.TabIndex = 2
        Me.btnaceptar.Text = "&Aceptar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FrmObsItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(376, 175)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.txtobsitem)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(382, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(382, 200)
        Me.Name = "FrmObsItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observacion item"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public AFrmGuiaDir As New FRMGUIADIRECTA
    Public AFrmGuiaTran As New FrmGuiaTransp

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If AFrmGuiaTran.AIntValor = 1 Then
            AFrmGuiaTran.AStrObsGuiaTran = txtobsitem.Text
        Else
            AFrmGuiaDir.obsGuiaDir = txtobsitem.Text
        End If

        Me.Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmObsItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If AFrmGuiaDir.INICIA = 0 Then
            bloquea()
        Else
            desbloquea()
        End If

        If AFrmGuiaTran.ABoolObs = False Then
            bloquea()
        Else
            desbloquea()
        End If

    End Sub
    Public Sub bloquea()
        bloqueatextbox(Me)
    End Sub

    Public Sub desbloquea()
        desbloqueatextbox(Me)
    End Sub
End Class
