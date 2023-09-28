<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteCuentasContables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteCuentasContables))
        Me.BtnQuitaTodo = New System.Windows.Forms.Button
        Me.BtnQuitaUno = New System.Windows.Forms.Button
        Me.BtnPasaTodo = New System.Windows.Forms.Button
        Me.BtnPasaUno = New System.Windows.Forms.Button
        Me.LblTitSelec = New System.Windows.Forms.Label
        Me.LblTitDisp = New System.Windows.Forms.Label
        Me.LstSelecDistrito = New System.Windows.Forms.ListBox
        Me.LstDispDistrito = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnQuitaTodo
        '
        Me.BtnQuitaTodo.ImageIndex = 10
        Me.BtnQuitaTodo.Location = New System.Drawing.Point(320, 147)
        Me.BtnQuitaTodo.Name = "BtnQuitaTodo"
        Me.BtnQuitaTodo.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo.TabIndex = 23
        Me.BtnQuitaTodo.Text = "<<"
        '
        'BtnQuitaUno
        '
        Me.BtnQuitaUno.ImageIndex = 8
        Me.BtnQuitaUno.Location = New System.Drawing.Point(320, 107)
        Me.BtnQuitaUno.Name = "BtnQuitaUno"
        Me.BtnQuitaUno.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno.TabIndex = 22
        Me.BtnQuitaUno.Text = "<"
        '
        'BtnPasaTodo
        '
        Me.BtnPasaTodo.ImageIndex = 9
        Me.BtnPasaTodo.Location = New System.Drawing.Point(320, 67)
        Me.BtnPasaTodo.Name = "BtnPasaTodo"
        Me.BtnPasaTodo.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo.TabIndex = 21
        Me.BtnPasaTodo.Text = ">>"
        '
        'BtnPasaUno
        '
        Me.BtnPasaUno.ImageIndex = 7
        Me.BtnPasaUno.Location = New System.Drawing.Point(320, 27)
        Me.BtnPasaUno.Name = "BtnPasaUno"
        Me.BtnPasaUno.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno.TabIndex = 20
        Me.BtnPasaUno.Text = ">"
        '
        'LblTitSelec
        '
        Me.LblTitSelec.AutoSize = True
        Me.LblTitSelec.Location = New System.Drawing.Point(386, 9)
        Me.LblTitSelec.Name = "LblTitSelec"
        Me.LblTitSelec.Size = New System.Drawing.Size(117, 13)
        Me.LblTitSelec.TabIndex = 19
        Me.LblTitSelec.Text = "Clientes Seleccionados"
        '
        'LblTitDisp
        '
        Me.LblTitDisp.AutoSize = True
        Me.LblTitDisp.Location = New System.Drawing.Point(10, 8)
        Me.LblTitDisp.Name = "LblTitDisp"
        Me.LblTitDisp.Size = New System.Drawing.Size(144, 13)
        Me.LblTitDisp.TabIndex = 18
        Me.LblTitDisp.Text = "Clientes Principal Disponibles"
        '
        'LstSelecDistrito
        '
        Me.LstSelecDistrito.Location = New System.Drawing.Point(384, 25)
        Me.LstSelecDistrito.Name = "LstSelecDistrito"
        Me.LstSelecDistrito.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecDistrito.TabIndex = 17
        '
        'LstDispDistrito
        '
        Me.LstDispDistrito.Location = New System.Drawing.Point(8, 25)
        Me.LstDispDistrito.Name = "LstDispDistrito"
        Me.LstDispDistrito.Size = New System.Drawing.Size(302, 160)
        Me.LstDispDistrito.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(295, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 68)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(384, 179)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 25
        '
        'FrmReporteCuentasContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 386)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnQuitaTodo)
        Me.Controls.Add(Me.BtnQuitaUno)
        Me.Controls.Add(Me.BtnPasaTodo)
        Me.Controls.Add(Me.BtnPasaUno)
        Me.Controls.Add(Me.LblTitSelec)
        Me.Controls.Add(Me.LblTitDisp)
        Me.Controls.Add(Me.LstSelecDistrito)
        Me.Controls.Add(Me.LstDispDistrito)
        Me.Name = "FrmReporteCuentasContables"
        Me.Text = "FrmReporteCuentasContables"
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnQuitaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno As System.Windows.Forms.Button
    Friend WithEvents LblTitSelec As System.Windows.Forms.Label
    Friend WithEvents LblTitDisp As System.Windows.Forms.Label
    Friend WithEvents LstSelecDistrito As System.Windows.Forms.ListBox
    Friend WithEvents LstDispDistrito As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
End Class
