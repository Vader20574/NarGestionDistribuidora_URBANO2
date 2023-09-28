Public Class FrmTipoDeDocumento
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
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboTipoDoc As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboTipoDoc = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(26, 78)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 46)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(238, 80)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 46)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo de Documento:  "
        '
        'CboTipoDoc
        '
        Me.CboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoDoc.ItemHeight = 16
        Me.CboTipoDoc.Location = New System.Drawing.Point(142, 14)
        Me.CboTipoDoc.Name = "CboTipoDoc"
        Me.CboTipoDoc.Size = New System.Drawing.Size(216, 24)
        Me.CboTipoDoc.TabIndex = 2
        '
        'FrmTipoDeDocumento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(390, 146)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboTipoDoc)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmTipoDeDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo De Documento"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public DEVOLVER As Boolean
    Public CODTIPODOC As String

    Sub LlenarCombo()
        CboTipoDoc.DataSource = TmpListarDatos("NSP_TRAER_DOC_VTA   '" & codempresa & "' ")
        CboTipoDoc.DisplayMember = "DSTIPODOC"
        CboTipoDoc.ValueMember = "CODTIPODOC"
    End Sub

    Private Sub FrmTipoDeDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarCombo()
        CboTipoDoc.SelectedValue = CODTIPODOC.ToString.Trim
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        DEVOLVER = True
        Me.Close()
    End Sub
End Class
