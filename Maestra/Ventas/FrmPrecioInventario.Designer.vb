<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrecioInventario
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
        Me.txtCodArt = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtMinPrec = New System.Windows.Forms.TextBox
        Me.txtFactor = New System.Windows.Forms.TextBox
        Me.txtcodpres = New System.Windows.Forms.TextBox
        Me.txtprecio = New System.Windows.Forms.TextBox
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnsele = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtruta = New System.Windows.Forms.TextBox
        Me.dgvlista = New System.Windows.Forms.DataGridView
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodArt
        '
        Me.txtCodArt.Location = New System.Drawing.Point(648, 232)
        Me.txtCodArt.Name = "txtCodArt"
        Me.txtCodArt.Size = New System.Drawing.Size(136, 20)
        Me.txtCodArt.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(186, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMinPrec
        '
        Me.txtMinPrec.Enabled = False
        Me.txtMinPrec.Location = New System.Drawing.Point(648, 283)
        Me.txtMinPrec.Name = "txtMinPrec"
        Me.txtMinPrec.Size = New System.Drawing.Size(136, 20)
        Me.txtMinPrec.TabIndex = 2
        '
        'txtFactor
        '
        Me.txtFactor.Enabled = False
        Me.txtFactor.Location = New System.Drawing.Point(648, 309)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(136, 20)
        Me.txtFactor.TabIndex = 3
        '
        'txtcodpres
        '
        Me.txtcodpres.Enabled = False
        Me.txtcodpres.Location = New System.Drawing.Point(648, 258)
        Me.txtcodpres.Name = "txtcodpres"
        Me.txtcodpres.Size = New System.Drawing.Size(136, 20)
        Me.txtcodpres.TabIndex = 5
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(648, 338)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(139, 20)
        Me.txtprecio.TabIndex = 6
        '
        'dtpfecha
        '
        Me.dtpfecha.Enabled = False
        Me.dtpfecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(648, 364)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(596, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 43)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(578, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cod Articulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(551, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cod Presentacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(551, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Des Presentacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(577, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Equivalente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(593, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(593, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Fecha"
        '
        'btnsele
        '
        Me.btnsele.Location = New System.Drawing.Point(477, 4)
        Me.btnsele.Name = "btnsele"
        Me.btnsele.Size = New System.Drawing.Size(43, 23)
        Me.btnsele.TabIndex = 21
        Me.btnsele.Text = "..."
        Me.btnsele.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Ruta Excel :"
        '
        'txtruta
        '
        Me.txtruta.Enabled = False
        Me.txtruta.Location = New System.Drawing.Point(114, 5)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(357, 20)
        Me.txtruta.TabIndex = 19
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlista.Location = New System.Drawing.Point(51, 33)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.Size = New System.Drawing.Size(428, 182)
        Me.dgvlista.TabIndex = 22
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivo de Texto (*.csv)|*.csv"
        Me.OpenFileDialog1.Title = "Seleccionar el Archivo Cvs"
        '
        'FrmPrecioInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 295)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.btnsele)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtruta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtcodpres)
        Me.Controls.Add(Me.txtFactor)
        Me.Controls.Add(Me.txtMinPrec)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCodArt)
        Me.Name = "FrmPrecioInventario"
        Me.Text = "Actualizar Precio Inventario"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodArt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtMinPrec As System.Windows.Forms.TextBox
    Friend WithEvents txtFactor As System.Windows.Forms.TextBox
    Friend WithEvents txtcodpres As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnsele As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
