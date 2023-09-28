Public Class ArticuloPresentacion
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GrpPresent As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents BtnPresent As System.Windows.Forms.Button
    Friend WithEvents BtnBusArt As System.Windows.Forms.Button
    Friend WithEvents LblArticulo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ArticuloPresentacion))
        Me.Label14 = New System.Windows.Forms.Label
        Me.BtnPresent = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GrpPresent = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnBusArt = New System.Windows.Forms.Button
        Me.LblArticulo = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.GrpPresent.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(100, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(218, 22)
        Me.Label14.TabIndex = 812
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnPresent
        '
        Me.BtnPresent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPresent.ImageIndex = 5
        Me.BtnPresent.ImageList = Me.ImageList1
        Me.BtnPresent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPresent.Location = New System.Drawing.Point(322, 48)
        Me.BtnPresent.Name = "BtnPresent"
        Me.BtnPresent.Size = New System.Drawing.Size(40, 24)
        Me.BtnPresent.TabIndex = 813
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(16, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 810
        Me.Label6.Text = "Presentación :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(142, 328)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(72, 23)
        Me.BtnAceptar.TabIndex = 816
        Me.BtnAceptar.Text = "&Grabar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(246, 328)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(72, 23)
        Me.BtnCancelar.TabIndex = 817
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(100, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(68, 20)
        Me.TextBox3.TabIndex = 815
        Me.TextBox3.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(16, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 814
        Me.Label1.Text = "Equivalencia :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GrpPresent
        '
        Me.GrpPresent.Controls.Add(Me.BtnBusArt)
        Me.GrpPresent.Controls.Add(Me.LblArticulo)
        Me.GrpPresent.Controls.Add(Me.Label2)
        Me.GrpPresent.Controls.Add(Me.BtnPresent)
        Me.GrpPresent.Controls.Add(Me.Label6)
        Me.GrpPresent.Controls.Add(Me.Label14)
        Me.GrpPresent.Controls.Add(Me.TextBox3)
        Me.GrpPresent.Controls.Add(Me.Label1)
        Me.GrpPresent.Location = New System.Drawing.Point(18, 16)
        Me.GrpPresent.Name = "GrpPresent"
        Me.GrpPresent.Size = New System.Drawing.Size(436, 112)
        Me.GrpPresent.TabIndex = 818
        Me.GrpPresent.TabStop = False
        Me.GrpPresent.Text = "Seleccione el Articulo y  Presentacion a relacionar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(42, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 816
        Me.Label2.Text = "Articulo :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnBusArt
        '
        Me.BtnBusArt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBusArt.ImageIndex = 5
        Me.BtnBusArt.ImageList = Me.ImageList1
        Me.BtnBusArt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnBusArt.Location = New System.Drawing.Point(382, 20)
        Me.BtnBusArt.Name = "BtnBusArt"
        Me.BtnBusArt.Size = New System.Drawing.Size(40, 24)
        Me.BtnBusArt.TabIndex = 818
        '
        'LblArticulo
        '
        Me.LblArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblArticulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblArticulo.Location = New System.Drawing.Point(100, 22)
        Me.LblArticulo.Name = "LblArticulo"
        Me.LblArticulo.Size = New System.Drawing.Size(276, 22)
        Me.LblArticulo.TabIndex = 817
        Me.LblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(348, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 23)
        Me.Button3.TabIndex = 819
        Me.Button3.Text = "&Salir"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(42, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 23)
        Me.Button4.TabIndex = 820
        Me.Button4.Text = "&Nuevo"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "                    Relacion Articulo Presentacion,[F3] Eliminar"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(18, 138)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(436, 180)
        Me.DataGrid1.TabIndex = 821
        '
        'ArticuloPresentacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(476, 366)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GrpPresent)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ArticuloPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relacion Articulo Presentacion"
        Me.GrpPresent.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Fields Form"
    Private Codarticulo As String = ""
    Private CodPresent As String = ""


#End Region

#Region "Function Form"




#End Region



    Private Sub ArticuloPresentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub

    Private Sub BtnBusArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusArt.Click
        Dim FrmArt As New frmgridarticulo
        FrmArt.ShowDialog()
        If FrmArt.DEVOLVER = False Then
            Exit Sub
        End If
        Codarticulo = FrmArt.Grid1.Item(FrmArt.Grid1.CurrentRowIndex, 0)
        LblArticulo.Text = FrmArt.Grid1.Item(FrmArt.Grid1.CurrentRowIndex, 1)


    End Sub
End Class
