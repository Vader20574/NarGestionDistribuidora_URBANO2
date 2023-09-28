Public Class FrmVistaConfigSis
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        'Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        'Me.CrystalReportViewer1.ActiveViewIndex = -1
        'Me.CrystalReportViewer1.DisplayGroupTree = False
        'Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        'Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        'Me.CrystalReportViewer1.ReportSource = "C:\Documents and Settings\Administrador\Escritorio\W_Configsis\ReportConfigSys.rp" & _
        '"t"
        'Me.CrystalReportViewer1.Size = New System.Drawing.Size(408, 390)
        'Me.CrystalReportViewer1.TabIndex = 0
        '
        'FrmVistaConfigSis
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 390)
        'Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmVistaConfigSis"
        Me.Text = "FrmVistaConfigSis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
