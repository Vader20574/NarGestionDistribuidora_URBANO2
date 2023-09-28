Public Class FrmReportProvee
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RdbNac As System.Windows.Forms.RadioButton
    Friend WithEvents RdbExt As System.Windows.Forms.RadioButton
    Friend WithEvents cmbpais As System.Windows.Forms.ComboBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmReportProvee))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.cmbpais = New System.Windows.Forms.ComboBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btnreporte = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RdbNac = New System.Windows.Forms.RadioButton
        Me.RdbExt = New System.Windows.Forms.RadioButton
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.cmbpais)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 72)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(16, 32)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Todos los Pais"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(165, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.Text = "Selecciona Pais"
        '
        'cmbpais
        '
        Me.cmbpais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpais.Location = New System.Drawing.Point(272, 32)
        Me.cmbpais.Name = "cmbpais"
        Me.cmbpais.Size = New System.Drawing.Size(202, 21)
        Me.cmbpais.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnsalir
        '
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.ImageIndex = 5
        Me.btnsalir.ImageList = Me.ImageList1
        Me.btnsalir.Location = New System.Drawing.Point(272, 160)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(80, 23)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "&Salir"
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 6
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(144, 160)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(96, 23)
        Me.btnreporte.TabIndex = 5
        Me.btnreporte.Text = "&Reporte"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RdbNac)
        Me.GroupBox2.Controls.Add(Me.RdbExt)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 56)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo De Proveedor"
        '
        'RdbNac
        '
        Me.RdbNac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbNac.Location = New System.Drawing.Point(224, 24)
        Me.RdbNac.Name = "RdbNac"
        Me.RdbNac.Size = New System.Drawing.Size(80, 24)
        Me.RdbNac.TabIndex = 29
        Me.RdbNac.Text = "Nacional"
        '
        'RdbExt
        '
        Me.RdbExt.Checked = True
        Me.RdbExt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbExt.Location = New System.Drawing.Point(56, 24)
        Me.RdbExt.Name = "RdbExt"
        Me.RdbExt.Size = New System.Drawing.Size(80, 24)
        Me.RdbExt.TabIndex = 28
        Me.RdbExt.TabStop = True
        Me.RdbExt.Text = "Extranjero"
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(424, 24)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 4
        '
        'FrmReportProvee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(514, 190)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnreporte)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.crRpt)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportProvee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registros Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Public AObjBus As New ClsInterface
    Dim ADblOp As Integer

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        If RdbNac.Checked = True Then
            ADblOp = 1
        End If
        If RdbExt.Checked = True And RadioButton1.Checked = True Then
            ADblOp = 2
        End If
        If RdbExt.Checked = True And RadioButton2.Checked = True Then
            ADblOp = 3
        End If
        crRpt.ReportFileName = rutareporte & "RptProveedor.RPT"
        crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
        crRpt.set_StoredProcParam(0, codempresa)
        crRpt.set_StoredProcParam(1, CodUsuario)
        crRpt.set_StoredProcParam(2, ADblOp)
        If ADblOp = 2 Then
            crRpt.set_StoredProcParam(3, cmbpais.SelectedValue.ToString())
        Else
            crRpt.set_StoredProcParam(3, "0")

        End If
        crRpt.Destination = Crystal.DestinationConstants.crptToWindow
        crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
        crRpt.Action = 1
        crRpt.Reset()
    End Sub

    Private Sub RdbExt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbExt.CheckedChanged
        If RdbExt.Checked = True Then
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub RdbNac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbNac.CheckedChanged
        If RdbNac.Checked = True Then
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            cmbpais.Enabled = True
            CAyuda.CargarDataCombo(cmbpais, "NSP_Select_Pais", "Código", "Descripción")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            cmbpais.Enabled = False
        End If
    End Sub
End Class
