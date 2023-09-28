<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTranferirProtisa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTranferirProtisa))
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grid1 = New System.Windows.Forms.DataGrid()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(385, 54)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(118, 20)
        Me.DtFechaIni.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grid1
        '
        Me.grid1.AllowSorting = False
        Me.grid1.CaptionText = "Registro Promociones        DobleClik o Enter para Seleccionar"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(12, 143)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(1087, 254)
        Me.grid1.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(267, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(295, 40)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Transferir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1156, 327)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 31)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1159, 294)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 27)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(822, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 31)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(822, 109)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(120, 31)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Agregar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DtFechaInicial
        '
        Me.DtFechaInicial.Enabled = False
        Me.DtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaInicial.Location = New System.Drawing.Point(12, 12)
        Me.DtFechaInicial.Name = "DtFechaInicial"
        Me.DtFechaInicial.Size = New System.Drawing.Size(118, 20)
        Me.DtFechaInicial.TabIndex = 21
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(527, 51)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(54, 26)
        Me.btnBuscar.TabIndex = 40
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(822, 29)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 37)
        Me.Button7.TabIndex = 41
        Me.Button7.Text = "Nuevo"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(593, 406)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(295, 40)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Transferir"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(964, 29)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(114, 37)
        Me.btnAnular.TabIndex = 43
        Me.btnAnular.Text = "Anulado"
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'FrmTranferirProtisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 458)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DtFechaIni)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtFechaInicial)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmTranferirProtisa"
        Me.Text = "FrmTranferirProtisa"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btnAnular As Button
End Class
