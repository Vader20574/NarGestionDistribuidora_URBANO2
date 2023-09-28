Public Class FRMDESCTOTAL
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents txttotalact As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttotalant As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbmonto As System.Windows.Forms.RadioButton
    Friend WithEvents rbporcentaje As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMDESCTOTAL))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.txttotalact = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttotalant = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdescuento = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbmonto = New System.Windows.Forms.RadioButton
        Me.rbporcentaje = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btncancelar
        '
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btncancelar.ImageIndex = 6
        Me.btncancelar.ImageList = Me.ImageList1
        Me.btncancelar.Location = New System.Drawing.Point(424, 48)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(103, 26)
        Me.btncancelar.TabIndex = 17
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnaceptar
        '
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnaceptar.ImageIndex = 12
        Me.btnaceptar.ImageList = Me.ImageList1
        Me.btnaceptar.Location = New System.Drawing.Point(424, 16)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(103, 26)
        Me.btnaceptar.TabIndex = 16
        Me.btnaceptar.Text = "&Aceptar"
        '
        'txttotalact
        '
        Me.txttotalact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalact.Location = New System.Drawing.Point(304, 64)
        Me.txttotalact.Name = "txttotalact"
        Me.txttotalact.ReadOnly = True
        Me.txttotalact.Size = New System.Drawing.Size(101, 20)
        Me.txttotalact.TabIndex = 15
        Me.txttotalact.Text = ""
        Me.txttotalact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(232, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Total Actual : "
        '
        'txttotalant
        '
        Me.txttotalant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalant.Location = New System.Drawing.Point(304, 32)
        Me.txttotalant.Name = "txttotalant"
        Me.txttotalant.ReadOnly = True
        Me.txttotalant.TabIndex = 13
        Me.txttotalant.Text = ""
        Me.txttotalant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(216, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Aplicado al Total : "
        '
        'txtdescuento
        '
        Me.txtdescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescuento.Location = New System.Drawing.Point(304, 8)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.TabIndex = 11
        Me.txtdescuento.Text = ""
        Me.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(224, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Descuento :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbmonto)
        Me.GroupBox1.Controls.Add(Me.rbporcentaje)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 76)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descuento en "
        '
        'rbmonto
        '
        Me.rbmonto.Location = New System.Drawing.Point(16, 48)
        Me.rbmonto.Name = "rbmonto"
        Me.rbmonto.Size = New System.Drawing.Size(64, 16)
        Me.rbmonto.TabIndex = 1
        Me.rbmonto.Text = "Monto "
        '
        'rbporcentaje
        '
        Me.rbporcentaje.Location = New System.Drawing.Point(16, 19)
        Me.rbporcentaje.Name = "rbporcentaje"
        Me.rbporcentaje.Size = New System.Drawing.Size(88, 16)
        Me.rbporcentaje.TabIndex = 0
        Me.rbporcentaje.Text = "Porcentaje "
        '
        'FRMDESCTOTAL
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 85)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.txttotalact)
        Me.Controls.Add(Me.txttotalant)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRMDESCTOTAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Descuento  Total Documento"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub rbporcentaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbporcentaje.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtdescuento.Focus()
        End If

    End Sub
    Private Sub rbmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbmonto.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtdescuento.Focus()
        End If

    End Sub

    Private Sub frmdescitem_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        rbporcentaje.Focus()
    End Sub
    Sub calculo()

        If rbmonto.Checked = True Then
            If Val(txtdescuento.Text) >= Val(txttotalant.Text) Then
                MessageBox.Show("Descuento no Puede ser mayor o igual  al MONTO del ITEM verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtdescuento.Focus()
                Exit Sub
            End If
            txttotalact.Text = FACT_GFormatodeNumero(Val(txttotalant.Text) - Val(txtdescuento.Text))

        End If

        If rbporcentaje.Checked = True Then
            If Val(txtdescuento.Text) >= 100 Then
                MessageBox.Show("Descuento no Puede ser del 100% sobre el ITEM verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtdescuento.Focus()
                Exit Sub
            End If

            Dim porc As Double
            porc = (Val(txttotalant.Text) / 100) * Val(txtdescuento.Text)
            txttotalact.Text = FACT_GFormatodeNumero(Val(txttotalant.Text) - porc)
        End If
    End Sub

    Private Sub txtdescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescuento.TextChanged

    End Sub

    Private Sub txtdescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescuento.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            calculo()
            btnaceptar.Focus()
        End If


    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim MONTODESCBAS, PORCENDESC As Double

        If rbmonto.Checked = True Then
            MONTODESCBAS = CDbl(txtdescuento.Text)
            PORCENDESC = (CDbl(txtdescuento.Text) / CDbl(txttotalant.Text)) * 100
        End If
        If rbporcentaje.Checked = True Then
            MONTODESCBAS = (CDbl(txtdescuento.Text) * CDbl(txttotalant.Text)) / 100
            PORCENDESC = CDbl(txtdescuento.Text)
        End If

        VDescTotbas = CDbl(PORCENDESC)
        Me.Close()



    End Sub
    Private Sub FRMDESCTOTAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If VTotBas = 0 Then
            Exit Sub
        End If
        txttotalant.Text = FACT_GFormatodeNumero(VTotBas)
    End Sub
End Class
