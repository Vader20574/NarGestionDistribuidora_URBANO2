<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptUtilidadArticulo5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptUtilidadArticulo5))
        Me.ItemsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LstSelecDistrito = New System.Windows.Forms.ListBox
        Me.LstDispDistrito = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Rpt1 = New AxCrystal.AxCrystalReport
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnQuitaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnQuitaUno_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaUno_Ruta = New System.Windows.Forms.Button
        Me.LstSelecRuta = New System.Windows.Forms.ListBox
        Me.LstDispRuta = New System.Windows.Forms.ListBox
        CType(Me.ItemsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemsBindingSource3
        '
        Me.ItemsBindingSource3.DataSource = GetType(NarGestionDistribuidora.frmEstadoInv.Items)
        '
        'ItemsBindingSource2
        '
        Me.ItemsBindingSource2.DataSource = GetType(NarGestionDistribuidora.frmEstadoInv.Items)
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataSource = GetType(NarGestionDistribuidora.frmEstadoInv.Items)
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataSource = GetType(NarGestionDistribuidora.frmEstadoInv.Items)
        '
        'Button6
        '
        Me.Button6.ImageIndex = 10
        Me.Button6.Location = New System.Drawing.Point(329, 241)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 32)
        Me.Button6.TabIndex = 60
        Me.Button6.Text = "<<"
        '
        'Button7
        '
        Me.Button7.ImageIndex = 8
        Me.Button7.Location = New System.Drawing.Point(329, 201)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 32)
        Me.Button7.TabIndex = 59
        Me.Button7.Text = "<"
        '
        'Button8
        '
        Me.Button8.ImageIndex = 9
        Me.Button8.Location = New System.Drawing.Point(329, 161)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 32)
        Me.Button8.TabIndex = 58
        Me.Button8.Text = ">>"
        '
        'Button9
        '
        Me.Button9.ImageIndex = 7
        Me.Button9.Location = New System.Drawing.Point(329, 121)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 32)
        Me.Button9.TabIndex = 57
        Me.Button9.Text = ">"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(395, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Categoria Seleccionados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Categoria Disponibles"
        '
        'LstSelecDistrito
        '
        Me.LstSelecDistrito.Location = New System.Drawing.Point(393, 119)
        Me.LstSelecDistrito.Name = "LstSelecDistrito"
        Me.LstSelecDistrito.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecDistrito.TabIndex = 54
        '
        'LstDispDistrito
        '
        Me.LstDispDistrito.Location = New System.Drawing.Point(17, 119)
        Me.LstDispDistrito.Name = "LstDispDistrito"
        Me.LstDispDistrito.Size = New System.Drawing.Size(302, 160)
        Me.LstDispDistrito.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(289, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 37)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Reporte 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(724, 448)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 62
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(166, 73)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(270, 21)
        Me.cboAlmacen.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfin)
        Me.GroupBox1.Controls.Add(Me.dtpinicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 40)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha "
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(300, 13)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(110, 20)
        Me.dtpfin.TabIndex = 1
        '
        'dtpinicio
        '
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio.Location = New System.Drawing.Point(86, 13)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(118, 20)
        Me.dtpinicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Almacen :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(390, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Vendedor Seleccionados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Vendedor Disponibles"
        '
        'BtnQuitaTodo_Ruta
        '
        Me.BtnQuitaTodo_Ruta.ImageIndex = 10
        Me.BtnQuitaTodo_Ruta.Location = New System.Drawing.Point(329, 428)
        Me.BtnQuitaTodo_Ruta.Name = "BtnQuitaTodo_Ruta"
        Me.BtnQuitaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo_Ruta.TabIndex = 72
        Me.BtnQuitaTodo_Ruta.Text = "<<"
        '
        'BtnQuitaUno_Ruta
        '
        Me.BtnQuitaUno_Ruta.ImageIndex = 8
        Me.BtnQuitaUno_Ruta.Location = New System.Drawing.Point(329, 388)
        Me.BtnQuitaUno_Ruta.Name = "BtnQuitaUno_Ruta"
        Me.BtnQuitaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno_Ruta.TabIndex = 71
        Me.BtnQuitaUno_Ruta.Text = "<"
        '
        'BtnPasaTodo_Ruta
        '
        Me.BtnPasaTodo_Ruta.ImageIndex = 9
        Me.BtnPasaTodo_Ruta.Location = New System.Drawing.Point(329, 348)
        Me.BtnPasaTodo_Ruta.Name = "BtnPasaTodo_Ruta"
        Me.BtnPasaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo_Ruta.TabIndex = 70
        Me.BtnPasaTodo_Ruta.Text = ">>"
        '
        'BtnPasaUno_Ruta
        '
        Me.BtnPasaUno_Ruta.ImageIndex = 7
        Me.BtnPasaUno_Ruta.Location = New System.Drawing.Point(329, 308)
        Me.BtnPasaUno_Ruta.Name = "BtnPasaUno_Ruta"
        Me.BtnPasaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno_Ruta.TabIndex = 69
        Me.BtnPasaUno_Ruta.Text = ">"
        '
        'LstSelecRuta
        '
        Me.LstSelecRuta.Location = New System.Drawing.Point(393, 304)
        Me.LstSelecRuta.Name = "LstSelecRuta"
        Me.LstSelecRuta.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecRuta.TabIndex = 68
        '
        'LstDispRuta
        '
        Me.LstDispRuta.Location = New System.Drawing.Point(17, 304)
        Me.LstDispRuta.Name = "LstDispRuta"
        Me.LstDispRuta.Size = New System.Drawing.Size(302, 160)
        Me.LstDispRuta.TabIndex = 67
        '
        'frmRptUtilidadArticulo5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 514)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnQuitaTodo_Ruta)
        Me.Controls.Add(Me.BtnQuitaUno_Ruta)
        Me.Controls.Add(Me.BtnPasaTodo_Ruta)
        Me.Controls.Add(Me.BtnPasaUno_Ruta)
        Me.Controls.Add(Me.LstSelecRuta)
        Me.Controls.Add(Me.LstDispRuta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboAlmacen)
        Me.Controls.Add(Me.Rpt1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LstSelecDistrito)
        Me.Controls.Add(Me.LstDispDistrito)
        Me.Name = "frmRptUtilidadArticulo5"
        Me.Text = "Reporte Utilidades x Articulo"
        CType(Me.ItemsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemsBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LstSelecDistrito As System.Windows.Forms.ListBox
    Friend WithEvents LstDispDistrito As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnQuitaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents LstSelecRuta As System.Windows.Forms.ListBox
    Friend WithEvents LstDispRuta As System.Windows.Forms.ListBox
End Class
