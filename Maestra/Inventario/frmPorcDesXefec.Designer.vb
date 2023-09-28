<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPorcDesXefec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPorcDesXefec))
        Me.cbolinea = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label15 = New System.Windows.Forms.Label
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbolinea
        '
        Me.cbolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolinea.ItemHeight = 13
        Me.cbolinea.Location = New System.Drawing.Point(129, 50)
        Me.cbolinea.Name = "cbolinea"
        Me.cbolinea.Size = New System.Drawing.Size(282, 21)
        Me.cbolinea.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 44)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "X Categoria"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "                    Relacion Descuento x Efectivo,[F3] Eliminar"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(12, 109)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(1163, 246)
        Me.DataGrid1.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(51, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Categoria :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(659, 22)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(559, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 44)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Todo Categoria"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmPorcDesXefec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 367)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbolinea)
        Me.Name = "frmPorcDesXefec"
        Me.Text = "frmPorcDesXefec"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbolinea As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
