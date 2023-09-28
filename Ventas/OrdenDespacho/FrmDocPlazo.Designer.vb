<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocPlazo
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
        Me.dgdata = New System.Windows.Forms.DataGrid
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgdata
        '
        Me.dgdata.DataMember = ""
        Me.dgdata.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgdata.Location = New System.Drawing.Point(12, 42)
        Me.dgdata.Name = "dgdata"
        Me.dgdata.ReadOnly = True
        Me.dgdata.Size = New System.Drawing.Size(909, 229)
        Me.dgdata.TabIndex = 1
        '
        'FrmDocPlazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 321)
        Me.Controls.Add(Me.dgdata)
        Me.Name = "FrmDocPlazo"
        Me.Text = "FrmDocPlazo"
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgdata As System.Windows.Forms.DataGrid
End Class
