Public Class FrmOpcionesA
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents LinkSi As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkNo As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkEnProceso As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpcionesA))
        Me.LinkSi = New System.Windows.Forms.LinkLabel
        Me.LinkNo = New System.Windows.Forms.LinkLabel
        Me.LinkEnProceso = New System.Windows.Forms.LinkLabel
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkSi
        '
        Me.LinkSi.AutoSize = True
        Me.LinkSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkSi.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkSi.Location = New System.Drawing.Point(10, 6)
        Me.LinkSi.Name = "LinkSi"
        Me.LinkSi.Size = New System.Drawing.Size(44, 33)
        Me.LinkSi.TabIndex = 1
        Me.LinkSi.TabStop = True
        Me.LinkSi.Text = "SI"
        '
        'LinkNo
        '
        Me.LinkNo.AutoSize = True
        Me.LinkNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkNo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkNo.Location = New System.Drawing.Point(8, 54)
        Me.LinkNo.Name = "LinkNo"
        Me.LinkNo.Size = New System.Drawing.Size(61, 33)
        Me.LinkNo.TabIndex = 2
        Me.LinkNo.TabStop = True
        Me.LinkNo.Text = "NO"
        '
        'LinkEnProceso
        '
        Me.LinkEnProceso.AutoSize = True
        Me.LinkEnProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkEnProceso.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkEnProceso.Location = New System.Drawing.Point(325, 106)
        Me.LinkEnProceso.Name = "LinkEnProceso"
        Me.LinkEnProceso.Size = New System.Drawing.Size(218, 33)
        Me.LinkEnProceso.TabIndex = 3
        Me.LinkEnProceso.TabStop = True
        Me.LinkEnProceso.Text = "EN PROCESO"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(200, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 157
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(8, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FrmOpcionesA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(116, 102)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkEnProceso)
        Me.Controls.Add(Me.LinkNo)
        Me.Controls.Add(Me.LinkSi)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "FrmOpcionesA"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                    ANULAR"
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public DEVOLVER As Boolean
    Public Opcion As Integer
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        DEVOLVER = False
        Me.Close()
    End Sub
    Private Sub FrmOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub LinkSi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkSi.LinkClicked
        DEVOLVER = True
        Opcion = 2
        Me.Close()
    End Sub
    Private Sub LinkNo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkNo.LinkClicked
        DEVOLVER = False
        Opcion = 1
        Me.Close()
    End Sub
    Private Sub LinkEnProceso_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkEnProceso.LinkClicked
        DEVOLVER = True
        Opcion = 3
        Me.Close()
    End Sub
End Class
