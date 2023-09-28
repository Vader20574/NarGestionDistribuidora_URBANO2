<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistribucion
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
        Me.GridNotaCred = New System.Windows.Forms.DataGrid
        CType(Me.GridNotaCred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridNotaCred
        '
        Me.GridNotaCred.BackgroundColor = System.Drawing.Color.Gray
        Me.GridNotaCred.DataMember = ""
        Me.GridNotaCred.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridNotaCred.Location = New System.Drawing.Point(12, 12)
        Me.GridNotaCred.Name = "GridNotaCred"
        Me.GridNotaCred.ReadOnly = True
        Me.GridNotaCred.Size = New System.Drawing.Size(452, 278)
        Me.GridNotaCred.TabIndex = 8
        '
        'frmDistribucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 311)
        Me.Controls.Add(Me.GridNotaCred)
        Me.Name = "frmDistribucion"
        Me.Text = "Distribuciones"
        CType(Me.GridNotaCred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridNotaCred As System.Windows.Forms.DataGrid
End Class
