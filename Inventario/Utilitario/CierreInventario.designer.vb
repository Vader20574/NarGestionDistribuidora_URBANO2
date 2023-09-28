<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCierreInventario
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdalmacen = New System.Windows.Forms.ComboBox
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pbrLoad = New System.Windows.Forms.ProgressBar
        Me.lblmensaje = New System.Windows.Forms.Label
        Me.txtanio = New System.Windows.Forms.TextBox
        Me.cmbmes = New System.Windows.Forms.ComboBox
        Me.lblfechacierre = New System.Windows.Forms.Label
        Me.lblfechaactual = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Almacen :"
        '
        'cmdalmacen
        '
        Me.cmdalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdalmacen.FormattingEnabled = True
        Me.cmdalmacen.Location = New System.Drawing.Point(128, 74)
        Me.cmdalmacen.Name = "cmdalmacen"
        Me.cmdalmacen.Size = New System.Drawing.Size(239, 21)
        Me.cmdalmacen.TabIndex = 1
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(96, 182)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 2
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(206, 182)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 2
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbrLoad)
        Me.GroupBox1.Controls.Add(Me.lblmensaje)
        Me.GroupBox1.Controls.Add(Me.txtanio)
        Me.GroupBox1.Controls.Add(Me.cmbmes)
        Me.GroupBox1.Controls.Add(Me.lblfechacierre)
        Me.GroupBox1.Controls.Add(Me.lblfechaactual)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.cmdalmacen)
        Me.GroupBox1.Controls.Add(Me.btnaceptar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 264)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'pbrLoad
        '
        Me.pbrLoad.Location = New System.Drawing.Point(12, 227)
        Me.pbrLoad.Name = "pbrLoad"
        Me.pbrLoad.Size = New System.Drawing.Size(376, 23)
        Me.pbrLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbrLoad.TabIndex = 8
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.Location = New System.Drawing.Point(34, 211)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(11, 13)
        Me.lblmensaje.TabIndex = 7
        Me.lblmensaje.Text = "."
        '
        'txtanio
        '
        Me.txtanio.Location = New System.Drawing.Point(128, 136)
        Me.txtanio.Name = "txtanio"
        Me.txtanio.ReadOnly = True
        Me.txtanio.Size = New System.Drawing.Size(100, 20)
        Me.txtanio.TabIndex = 6
        '
        'cmbmes
        '
        Me.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Location = New System.Drawing.Point(128, 105)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(174, 21)
        Me.cmbmes.TabIndex = 5
        '
        'lblfechacierre
        '
        Me.lblfechacierre.AutoSize = True
        Me.lblfechacierre.Location = New System.Drawing.Point(128, 47)
        Me.lblfechacierre.Name = "lblfechacierre"
        Me.lblfechacierre.Size = New System.Drawing.Size(16, 13)
        Me.lblfechacierre.TabIndex = 4
        Me.lblfechacierre.Text = "..."
        '
        'lblfechaactual
        '
        Me.lblfechaactual.AutoSize = True
        Me.lblfechaactual.Location = New System.Drawing.Point(128, 16)
        Me.lblfechaactual.Name = "lblfechaactual"
        Me.lblfechaactual.Size = New System.Drawing.Size(39, 13)
        Me.lblfechaactual.TabIndex = 4
        Me.lblfechaactual.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ultimo Cierre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Año :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mes :"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmCierreInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCierreInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre de Inventario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblfechaactual As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblfechacierre As System.Windows.Forms.Label
    Friend WithEvents txtanio As System.Windows.Forms.TextBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
    Friend WithEvents pbrLoad As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
