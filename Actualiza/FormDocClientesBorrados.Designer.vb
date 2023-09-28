<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDocClientesBorrados
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
        Me.GridVend = New System.Windows.Forms.DataGrid
        CType(Me.GridVend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridVend
        '
        Me.GridVend.CaptionText = "[Enter para seleccionar]  o Doble clik"
        Me.GridVend.DataMember = ""
        Me.GridVend.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridVend.Location = New System.Drawing.Point(12, 12)
        Me.GridVend.Name = "GridVend"
        Me.GridVend.ReadOnly = True
        Me.GridVend.Size = New System.Drawing.Size(828, 244)
        Me.GridVend.TabIndex = 168
        '
        'FormDocClientesBorrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 304)
        Me.Controls.Add(Me.GridVend)
        Me.Name = "FormDocClientesBorrados"
        Me.Text = "FormDocClientesBorrados"
        CType(Me.GridVend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridVend As System.Windows.Forms.DataGrid
End Class
