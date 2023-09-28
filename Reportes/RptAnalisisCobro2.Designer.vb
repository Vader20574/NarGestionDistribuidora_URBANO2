<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptAnalisisCobro2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptAnalisisCobro2))
        Me.gPlanillaReparto = New System.Windows.Forms.GroupBox
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.FechaCan = New System.Windows.Forms.Label
        Me.FechaVenc = New System.Windows.Forms.Label
        Me.FechaEmi = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDsClienteDep = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtDsCliente = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAcuenta = New System.Windows.Forms.TextBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDeuda = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgDetalleCobranza = New System.Windows.Forms.DataGrid
        Me.gPlanillaReparto.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalleCobranza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gPlanillaReparto
        '
        Me.gPlanillaReparto.Controls.Add(Me.AxCrystalReport1)
        Me.gPlanillaReparto.Controls.Add(Me.FechaCan)
        Me.gPlanillaReparto.Controls.Add(Me.FechaVenc)
        Me.gPlanillaReparto.Controls.Add(Me.FechaEmi)
        Me.gPlanillaReparto.Controls.Add(Me.Label9)
        Me.gPlanillaReparto.Controls.Add(Me.Label8)
        Me.gPlanillaReparto.Controls.Add(Me.Label2)
        Me.gPlanillaReparto.Controls.Add(Me.txtDsClienteDep)
        Me.gPlanillaReparto.Controls.Add(Me.Label1)
        Me.gPlanillaReparto.Controls.Add(Me.TextBox1)
        Me.gPlanillaReparto.Controls.Add(Me.txtDsCliente)
        Me.gPlanillaReparto.Controls.Add(Me.Label11)
        Me.gPlanillaReparto.Controls.Add(Me.txtAcuenta)
        Me.gPlanillaReparto.Controls.Add(Me.txtNroDoc)
        Me.gPlanillaReparto.Controls.Add(Me.cbTipoDoc)
        Me.gPlanillaReparto.Controls.Add(Me.Label6)
        Me.gPlanillaReparto.Controls.Add(Me.Label4)
        Me.gPlanillaReparto.Controls.Add(Me.Label3)
        Me.gPlanillaReparto.Controls.Add(Me.txtSaldo)
        Me.gPlanillaReparto.Controls.Add(Me.Label7)
        Me.gPlanillaReparto.Controls.Add(Me.txtDeuda)
        Me.gPlanillaReparto.Controls.Add(Me.Label5)
        Me.gPlanillaReparto.Location = New System.Drawing.Point(24, 29)
        Me.gPlanillaReparto.Name = "gPlanillaReparto"
        Me.gPlanillaReparto.Size = New System.Drawing.Size(728, 251)
        Me.gPlanillaReparto.TabIndex = 3
        Me.gPlanillaReparto.TabStop = False
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(572, 72)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 33
        '
        'FechaCan
        '
        Me.FechaCan.AutoSize = True
        Me.FechaCan.Location = New System.Drawing.Point(146, 213)
        Me.FechaCan.Name = "FechaCan"
        Me.FechaCan.Size = New System.Drawing.Size(105, 13)
        Me.FechaCan.TabIndex = 32
        Me.FechaCan.Text = "Fecha Cancelacion :"
        Me.FechaCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FechaVenc
        '
        Me.FechaVenc.AutoSize = True
        Me.FechaVenc.Location = New System.Drawing.Point(146, 189)
        Me.FechaVenc.Name = "FechaVenc"
        Me.FechaVenc.Size = New System.Drawing.Size(104, 13)
        Me.FechaVenc.TabIndex = 31
        Me.FechaVenc.Text = "Fecha Vencimiento :"
        Me.FechaVenc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FechaEmi
        '
        Me.FechaEmi.AutoSize = True
        Me.FechaEmi.Location = New System.Drawing.Point(146, 165)
        Me.FechaEmi.Name = "FechaEmi"
        Me.FechaEmi.Size = New System.Drawing.Size(82, 13)
        Me.FechaEmi.TabIndex = 30
        Me.FechaEmi.Text = "Fecha Emision :"
        Me.FechaEmi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Fecha Cancelacion :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Fecha Vencimiento :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Fecha Emision :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDsClienteDep
        '
        Me.txtDsClienteDep.BackColor = System.Drawing.Color.White
        Me.txtDsClienteDep.Location = New System.Drawing.Point(84, 70)
        Me.txtDsClienteDep.Name = "txtDsClienteDep"
        Me.txtDsClienteDep.ReadOnly = True
        Me.txtDsClienteDep.Size = New System.Drawing.Size(298, 20)
        Me.txtDsClienteDep.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Cliente Dep :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(624, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(82, 20)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Text = "0.00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox1.Visible = False
        '
        'txtDsCliente
        '
        Me.txtDsCliente.BackColor = System.Drawing.Color.White
        Me.txtDsCliente.Location = New System.Drawing.Point(84, 44)
        Me.txtDsCliente.Name = "txtDsCliente"
        Me.txtDsCliente.ReadOnly = True
        Me.txtDsCliente.Size = New System.Drawing.Size(298, 20)
        Me.txtDsCliente.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Cliente Prin :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAcuenta
        '
        Me.txtAcuenta.Location = New System.Drawing.Point(626, 165)
        Me.txtAcuenta.Name = "txtAcuenta"
        Me.txtAcuenta.Size = New System.Drawing.Size(80, 20)
        Me.txtAcuenta.TabIndex = 3
        Me.txtAcuenta.Text = "0.00"
        Me.txtAcuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAcuenta.Visible = False
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(296, 18)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(96, 20)
        Me.txtNroDoc.TabIndex = 1
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.Location = New System.Drawing.Point(84, 18)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(144, 21)
        Me.cbTipoDoc.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(580, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pagar :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(242, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nro. Doc.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Doc. :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtSaldo.Location = New System.Drawing.Point(82, 119)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(92, 24)
        Me.txtSaldo.TabIndex = 23
        Me.txtSaldo.Text = "0.00"
        Me.txtSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(36, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Saldo :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDeuda
        '
        Me.txtDeuda.BackColor = System.Drawing.Color.White
        Me.txtDeuda.Location = New System.Drawing.Point(84, 96)
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.ReadOnly = True
        Me.txtDeuda.Size = New System.Drawing.Size(82, 20)
        Me.txtDeuda.TabIndex = 1
        Me.txtDeuda.Text = "0.00"
        Me.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Import :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgDetalleCobranza
        '
        Me.dgDetalleCobranza.DataMember = ""
        Me.dgDetalleCobranza.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetalleCobranza.Location = New System.Drawing.Point(37, 286)
        Me.dgDetalleCobranza.Name = "dgDetalleCobranza"
        Me.dgDetalleCobranza.ReadOnly = True
        Me.dgDetalleCobranza.RowHeadersVisible = False
        Me.dgDetalleCobranza.Size = New System.Drawing.Size(728, 188)
        Me.dgDetalleCobranza.TabIndex = 22
        '
        'RptAnalisisCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 497)
        Me.Controls.Add(Me.dgDetalleCobranza)
        Me.Controls.Add(Me.gPlanillaReparto)
        Me.Name = "RptAnalisisCobro"
        Me.Text = "RptAnalisisCobro"
        Me.gPlanillaReparto.ResumeLayout(False)
        Me.gPlanillaReparto.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalleCobranza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gPlanillaReparto As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDsCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAcuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDsClienteDep As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FechaCan As System.Windows.Forms.Label
    Friend WithEvents FechaVenc As System.Windows.Forms.Label
    Friend WithEvents FechaEmi As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgDetalleCobranza As System.Windows.Forms.DataGrid
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
