<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReciboxHonorario
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
        Me.txtGirador = New System.Windows.Forms.TextBox
        Me.txtRuc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTotalHonorario = New System.Windows.Forms.TextBox
        Me.txtRetenImpNeto = New System.Windows.Forms.TextBox
        Me.txtTotalNeto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtEjercicio = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCodGirador = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.txtconcepto = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtGirador
        '
        Me.txtGirador.Location = New System.Drawing.Point(107, 66)
        Me.txtGirador.Name = "txtGirador"
        Me.txtGirador.Size = New System.Drawing.Size(281, 20)
        Me.txtGirador.TabIndex = 0
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(107, 92)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(277, 20)
        Me.txtRuc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Girador Recibo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ruc:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Concepto :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Honorarios :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-3, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Retencion imp Neto :"
        '
        'txtTotalHonorario
        '
        Me.txtTotalHonorario.Location = New System.Drawing.Point(107, 268)
        Me.txtTotalHonorario.Name = "txtTotalHonorario"
        Me.txtTotalHonorario.Size = New System.Drawing.Size(277, 20)
        Me.txtTotalHonorario.TabIndex = 8
        '
        'txtRetenImpNeto
        '
        Me.txtRetenImpNeto.Location = New System.Drawing.Point(107, 294)
        Me.txtRetenImpNeto.Name = "txtRetenImpNeto"
        Me.txtRetenImpNeto.Size = New System.Drawing.Size(277, 20)
        Me.txtRetenImpNeto.TabIndex = 9
        '
        'txtTotalNeto
        '
        Me.txtTotalNeto.Location = New System.Drawing.Point(107, 320)
        Me.txtTotalNeto.Name = "txtTotalNeto"
        Me.txtTotalNeto.Size = New System.Drawing.Size(277, 20)
        Me.txtTotalNeto.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Neto  :"
        '
        'dtFecha
        '
        Me.dtFecha.Location = New System.Drawing.Point(108, 133)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(253, 20)
        Me.dtFecha.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Fecha :"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(209, 159)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(136, 21)
        Me.cboPeriodo.TabIndex = 22
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(155, 161)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Periodo: "
        '
        'txtEjercicio
        '
        Me.txtEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEjercicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjercicio.Location = New System.Drawing.Point(107, 159)
        Me.txtEjercicio.MaxLength = 7
        Me.txtEjercicio.Name = "txtEjercicio"
        Me.txtEjercicio.Size = New System.Drawing.Size(40, 20)
        Me.txtEjercicio.TabIndex = 20
        Me.txtEjercicio.Text = "2010"
        Me.txtEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Ejercicio: "
        '
        'txtCodGirador
        '
        Me.txtCodGirador.Location = New System.Drawing.Point(108, 40)
        Me.txtCodGirador.Name = "txtCodGirador"
        Me.txtCodGirador.Size = New System.Drawing.Size(281, 20)
        Me.txtCodGirador.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Cod Recibo :"
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.Location = New System.Drawing.Point(391, 12)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(66, 28)
        Me.btnbuscar.TabIndex = 69
        Me.btnbuscar.Text = "Busqueda"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(444, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(109, 192)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.Location = New System.Drawing.Point(17, 130)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNCANCELAR.TabIndex = 9
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.Location = New System.Drawing.Point(17, 158)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNCERRAR.TabIndex = 11
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(17, 74)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNMODIFICAR.TabIndex = 7
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.Location = New System.Drawing.Point(17, 102)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNELIMINAR.TabIndex = 8
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.Location = New System.Drawing.Point(17, 18)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(75, 22)
        Me.BTNNUEVO.TabIndex = 5
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(17, 46)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNGUARDAR.TabIndex = 6
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtconcepto
        '
        Me.txtconcepto.Location = New System.Drawing.Point(107, 186)
        Me.txtconcepto.MaxLength = 200
        Me.txtconcepto.Multiline = True
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(320, 72)
        Me.txtconcepto.TabIndex = 71
        '
        'FrmReciboxHonorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 510)
        Me.Controls.Add(Me.txtconcepto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCodGirador)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtEjercicio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalNeto)
        Me.Controls.Add(Me.txtRetenImpNeto)
        Me.Controls.Add(Me.txtTotalHonorario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRuc)
        Me.Controls.Add(Me.txtGirador)
        Me.Name = "FrmReciboxHonorario"
        Me.Text = "Recibo x Honorario"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGirador As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHonorario As System.Windows.Forms.TextBox
    Friend WithEvents txtRetenImpNeto As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEjercicio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodGirador As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents txtconcepto As System.Windows.Forms.TextBox
End Class
