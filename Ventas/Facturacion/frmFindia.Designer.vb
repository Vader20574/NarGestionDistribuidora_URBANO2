<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindia))
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.lblfechaact = New System.Windows.Forms.Label
        Me.lblfechaproc = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbnotas = New System.Windows.Forms.ListBox
        Me.txtmesproceso = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(415, 29)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "FIN DE DIA - MES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.ImageIndex = 12
        Me.BtnSalir.Location = New System.Drawing.Point(257, 206)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(110, 23)
        Me.BtnSalir.TabIndex = 65
        Me.BtnSalir.Text = "Salir"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.ImageIndex = 1
        Me.BtnGuardar.Location = New System.Drawing.Point(140, 206)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(110, 23)
        Me.BtnGuardar.TabIndex = 64
        Me.BtnGuardar.Text = "Aplicar"
        '
        'lblfechaact
        '
        Me.lblfechaact.BackColor = System.Drawing.SystemColors.Window
        Me.lblfechaact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfechaact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaact.Location = New System.Drawing.Point(263, 40)
        Me.lblfechaact.Name = "lblfechaact"
        Me.lblfechaact.Size = New System.Drawing.Size(136, 20)
        Me.lblfechaact.TabIndex = 71
        Me.lblfechaact.Text = "12/11/2012"
        Me.lblfechaact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblfechaproc
        '
        Me.lblfechaproc.BackColor = System.Drawing.SystemColors.Window
        Me.lblfechaproc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfechaproc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaproc.Location = New System.Drawing.Point(12, 206)
        Me.lblfechaproc.Name = "lblfechaproc"
        Me.lblfechaproc.Size = New System.Drawing.Size(100, 20)
        Me.lblfechaproc.TabIndex = 72
        Me.lblfechaproc.Text = "12/11/2012"
        Me.lblfechaproc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblfechaproc.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Fecha Documento :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Fecha Proceso :"
        '
        'lbnotas
        '
        Me.lbnotas.FormattingEnabled = True
        Me.lbnotas.Location = New System.Drawing.Point(116, 100)
        Me.lbnotas.Name = "lbnotas"
        Me.lbnotas.Size = New System.Drawing.Size(283, 95)
        Me.lbnotas.TabIndex = 73
        '
        'txtmesproceso
        '
        Me.txtmesproceso.BackColor = System.Drawing.SystemColors.Window
        Me.txtmesproceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtmesproceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmesproceso.Location = New System.Drawing.Point(263, 65)
        Me.txtmesproceso.Name = "txtmesproceso"
        Me.txtmesproceso.Size = New System.Drawing.Size(136, 20)
        Me.txtmesproceso.TabIndex = 72
        Me.txtmesproceso.Text = "12/11/2012"
        Me.txtmesproceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmFindia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 239)
        Me.Controls.Add(Me.lbnotas)
        Me.Controls.Add(Me.lblfechaact)
        Me.Controls.Add(Me.txtmesproceso)
        Me.Controls.Add(Me.lblfechaproc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFindia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fin de Dia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblfechaact As System.Windows.Forms.Label
    Friend WithEvents lblfechaproc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbnotas As System.Windows.Forms.ListBox
    Friend WithEvents txtmesproceso As System.Windows.Forms.Label
End Class
