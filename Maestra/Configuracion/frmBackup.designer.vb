<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnbackup = New System.Windows.Forms.Button
        Me.btnruta = New System.Windows.Forms.Button
        Me.txtruta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnbackup)
        Me.GroupBox1.Controls.Add(Me.btnruta)
        Me.GroupBox1.Controls.Add(Me.txtruta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 201)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnbackup
        '
        Me.btnbackup.Image = Global.NarGestionDistribuidora.My.Resources.Resources.Download_Database
        Me.btnbackup.Location = New System.Drawing.Point(191, 78)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(126, 80)
        Me.btnbackup.TabIndex = 3
        Me.btnbackup.UseVisualStyleBackColor = True
        '
        'btnruta
        '
        Me.btnruta.Location = New System.Drawing.Point(446, 35)
        Me.btnruta.Name = "btnruta"
        Me.btnruta.Size = New System.Drawing.Size(43, 23)
        Me.btnruta.TabIndex = 2
        Me.btnruta.Text = ". . ."
        Me.btnruta.UseVisualStyleBackColor = True
        '
        'txtruta
        '
        Me.txtruta.Location = New System.Drawing.Point(70, 37)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(370, 20)
        Me.txtruta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruta :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nota : Es recomendable no realizar ningun proceso durante la copia de seguridad."
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 201)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copia de Seguridad del Sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnruta As System.Windows.Forms.Button
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnbackup As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
