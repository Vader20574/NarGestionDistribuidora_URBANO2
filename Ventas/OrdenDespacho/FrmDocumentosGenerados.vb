Public Class FrmDocumentosGenerados
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
    Friend WithEvents TxtDoc As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtDoc = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtDoc
        '
        Me.TxtDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc.Location = New System.Drawing.Point(8, 18)
        Me.TxtDoc.Multiline = True
        Me.TxtDoc.Name = "TxtDoc"
        Me.TxtDoc.Size = New System.Drawing.Size(376, 184)
        Me.TxtDoc.TabIndex = 0
        Me.TxtDoc.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aceptar"
        '
        'FrmDocumentosGenerados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(398, 270)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtDoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentosGenerados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos Generados"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
