Public Class FrmVistaRTarjeta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVistaRTarjeta))
        Me.CrystalReportViewer1 = New AxCrystal.AxCrystalReport
        CType(Me.CrystalReportViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.Enabled = True
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(272, 192)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.OcxState = CType(resources.GetObject("CrystalReportViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(28, 28)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'FrmVistaRTarjeta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 318)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmVistaRTarjeta"
        Me.Text = "FrmVistaRTarjeta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CrystalReportViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
