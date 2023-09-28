Public Class VistaReporteTDoc
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
    'Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer1 As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(VistaReporteTDoc))
        Me.CrystalReportViewer1 = New AxCrystal.AxCrystalReport
        CType(Me.CrystalReportViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.Enabled = True
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(216, 200)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.OcxState = CType(resources.GetObject("CrystalReportViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(28, 28)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'VistaReporteTDoc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 510)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "VistaReporteTDoc"
        Me.Text = "VistaReporteTDoc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CrystalReportViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub VistaReporteTDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
