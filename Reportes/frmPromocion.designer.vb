<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromocion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPromocion))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbmes = New System.Windows.Forms.ComboBox
        Me.cmbanio = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnpromosub = New System.Windows.Forms.Button
        Me.btnpromoprod = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha :"
        '
        'cmbmes
        '
        Me.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Location = New System.Drawing.Point(89, 26)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(144, 21)
        Me.cmbmes.TabIndex = 1
        '
        'cmbanio
        '
        Me.cmbanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbanio.FormattingEnabled = True
        Me.cmbanio.Location = New System.Drawing.Point(239, 26)
        Me.cmbanio.Name = "cmbanio"
        Me.cmbanio.Size = New System.Drawing.Size(77, 21)
        Me.cmbanio.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AxCrystalReport1)
        Me.GroupBox1.Controls.Add(Me.btnpromosub)
        Me.GroupBox1.Controls.Add(Me.btnpromoprod)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbanio)
        Me.GroupBox1.Controls.Add(Me.cmbmes)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 165)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnpromosub
        '
        Me.btnpromosub.Location = New System.Drawing.Point(102, 109)
        Me.btnpromosub.Name = "btnpromosub"
        Me.btnpromosub.Size = New System.Drawing.Size(172, 23)
        Me.btnpromosub.TabIndex = 3
        Me.btnpromosub.Text = "Promoción por SubCategoria"
        Me.btnpromosub.UseVisualStyleBackColor = True
        '
        'btnpromoprod
        '
        Me.btnpromoprod.Location = New System.Drawing.Point(102, 77)
        Me.btnpromoprod.Name = "btnpromoprod"
        Me.btnpromoprod.Size = New System.Drawing.Size(172, 23)
        Me.btnpromoprod.TabIndex = 3
        Me.btnpromoprod.Text = "Promoción por Productos"
        Me.btnpromoprod.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(329, 76)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 4
        '
        'frmPromocion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 165)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPromocion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Promociones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbanio As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnpromosub As System.Windows.Forms.Button
    Friend WithEvents btnpromoprod As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
End Class
