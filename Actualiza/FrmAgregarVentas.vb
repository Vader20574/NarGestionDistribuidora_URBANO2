Public Class FrmAgregarVentas
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
    Friend WithEvents TxtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodclie As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodArti As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMontoDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodVend As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents btnBusCli As System.Windows.Forms.Button
    Friend WithEvents btnBusqPromo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarVentas))
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.TxtNroDoc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcodclie = New System.Windows.Forms.TextBox
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodArti = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCant = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPrecio = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtMontoDesc = New System.Windows.Forms.TextBox
        Me.txtCodVend = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox
        Me.btnBusCli = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBusqPromo = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(180, 324)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(132, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        '
        'TxtNroDoc
        '
        Me.TxtNroDoc.Location = New System.Drawing.Point(90, 22)
        Me.TxtNroDoc.Name = "TxtNroDoc"
        Me.TxtNroDoc.Size = New System.Drawing.Size(174, 20)
        Me.TxtNroDoc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NroDoc :"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(42, 324)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 54)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Agregar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tipo Doc :"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(90, 95)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.dtpFecha.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcodclie
        '
        Me.txtcodclie.Location = New System.Drawing.Point(90, 121)
        Me.txtcodclie.Name = "txtcodclie"
        Me.txtcodclie.Size = New System.Drawing.Size(174, 20)
        Me.txtcodclie.TabIndex = 10
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(90, 147)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(174, 20)
        Me.txtItem.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cod Cliente :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Item :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodArti
        '
        Me.txtCodArti.Location = New System.Drawing.Point(90, 173)
        Me.txtCodArti.Name = "txtCodArti"
        Me.txtCodArti.Size = New System.Drawing.Size(174, 20)
        Me.txtCodArti.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CodArti :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(90, 199)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(174, 20)
        Me.txtCant.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cantidad :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Precio :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(88, 226)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(174, 20)
        Me.txtPrecio.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "cod vend :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoDesc
        '
        Me.txtMontoDesc.Location = New System.Drawing.Point(88, 252)
        Me.txtMontoDesc.Name = "txtMontoDesc"
        Me.txtMontoDesc.Size = New System.Drawing.Size(174, 20)
        Me.txtMontoDesc.TabIndex = 21
        '
        'txtCodVend
        '
        Me.txtCodVend.Location = New System.Drawing.Point(88, 278)
        Me.txtCodVend.Name = "txtCodVend"
        Me.txtCodVend.Size = New System.Drawing.Size(174, 20)
        Me.txtCodVend.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Monto Desc :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.Location = New System.Drawing.Point(88, 55)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(144, 21)
        Me.cbTipoDoc.TabIndex = 24
        '
        'btnBusCli
        '
        Me.btnBusCli.ImageIndex = 5
        Me.btnBusCli.ImageList = Me.ImageList1
        Me.btnBusCli.Location = New System.Drawing.Point(279, 121)
        Me.btnBusCli.Name = "btnBusCli"
        Me.btnBusCli.Size = New System.Drawing.Size(33, 23)
        Me.btnBusCli.TabIndex = 37
        Me.btnBusCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        '
        'btnBusqPromo
        '
        Me.btnBusqPromo.ImageIndex = 5
        Me.btnBusqPromo.ImageList = Me.ImageList1
        Me.btnBusqPromo.Location = New System.Drawing.Point(282, 176)
        Me.btnBusqPromo.Name = "btnBusqPromo"
        Me.btnBusqPromo.Size = New System.Drawing.Size(30, 22)
        Me.btnBusqPromo.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(279, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 22)
        Me.Button1.TabIndex = 39
        '
        'FrmAgregarVentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBusqPromo)
        Me.Controls.Add(Me.btnBusCli)
        Me.Controls.Add(Me.cbTipoDoc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCodVend)
        Me.Controls.Add(Me.txtMontoDesc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodArti)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.txtcodclie)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNroDoc)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmAgregarVentas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public DEVOLVER As Boolean
    Public Opcion As Integer



    Public NRODOCU As String
    Public CODTIPODOC As String
    Public ITEM As String

    Public ARTICULO As String

    Public PRECIO As Double

    Public CANTIDAD As Integer

    Public DESCUENTO As Double

    Public fecha As Date

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click


        DEVOLVER = False
        Me.Close()

    End Sub
    Private Sub FrmOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargaCombo()

        txtcodclie.Enabled = False
        txtCodArti.Enabled = False
        txtCodVend.Enabled = False

        dtpFecha.Value = fecha
    End Sub
    Private Sub LinkSi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        DEVOLVER = True
        Opcion = 2
        Me.Close()
    End Sub
    Private Sub LinkNo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        DEVOLVER = True
        Opcion = 1
        Me.Close()
    End Sub
    Private Sub LinkEnProceso_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        DEVOLVER = True
        Opcion = 3
        Me.Close()
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click



        If TxtNroDoc.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese el NroDoc", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNroDoc.Focus()
            Exit Sub
        End If


        If txtcodclie.Text.Trim.Length = 0 Then
            MessageBox.Show("Seleccione un Cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcodclie.Focus()
            Exit Sub
        End If



        If txtItem.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese el Item", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtItem.Focus()
            Exit Sub
        End If



        If txtCodArti.Text.Trim.Length = 0 Then
            MessageBox.Show("Seleccione el Articulo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodArti.Focus()
            Exit Sub
        End If



        If txtCant.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese la Cantidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCant.Focus()
            Exit Sub
        End If


        If txtPrecio.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese el Precio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrecio.Focus()
            Exit Sub
        End If

        If txtMontoDesc.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese el Monto Desc", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMontoDesc.Focus()
            Exit Sub
        End If



        If txtCodVend.Text.Trim.Length = 0 Then
            MessageBox.Show("Seleccione el Vendedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodVend.Focus()
            Exit Sub
        End If






        Dim RptaTrans As Boolean
        RptaTrans = CAyuda.Ejecutar("SP_INS_TMP_VENTAS", codempresa, TxtNroDoc.Text, cbTipoDoc.SelectedValue, Format(CDate(dtpFecha.Value), "dd/MM/yyyy"), txtcodclie.Text, CInt(txtItem.Text.Trim), txtCodArti.Text, CInt(txtCant.Text), CDbl(txtPrecio.Text), CDbl(txtMontoDesc.Text), txtCodVend.Text)
        If RptaTrans Then
            '     MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If
        DEVOLVER = True
        Opcion = 1
        Me.Close()

    End Sub

    Private Sub CargaCombo()
        CAyuda.CargarDataCombo(cbTipoDoc, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")
    End Sub




    Private Sub btnBusCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusCli.Click
        Dim FrmCli As New FrmBuscarClieDepen
        FrmCli.ShowDialog()
        If FrmCli.DEVOLVER = False Then
            Exit Sub
        End If
        txtcodclie.Text = FrmCli.GridCli.Item(FrmCli.GridCli.CurrentRowIndex, 0)
    End Sub

    Private Sub btnBusqPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqPromo.Click
        Dim FRMX As New frmgridarticulo
        FRMX.ShowDialog()
        If FRMX.DEVOLVER = False Then
            Exit Sub
        End If

        txtCodArti.Text = FRMX.Grid1.Item(FRMX.Grid1.CurrentRowIndex, 0)
        '  txtDescripción.Text = FRMX.Grid1.Item(FRMX.Grid1.CurrentRowIndex, 1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FrmVend As New FrmBuscVendedor
        FrmVend.ShowDialog()
        txtCodVend.Text = FrmVend.GridVend.Item(FrmVend.GridVend.CurrentRowIndex, 0)

    End Sub

    Private Sub TxtNroDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroDoc.KeyPress

        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If



    End Sub

    Private Sub TxtNroDoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNroDoc.TextChanged

    End Sub

    Private Sub txtcodclie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodclie.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodclie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodclie.TextChanged

    End Sub

    Private Sub txtItem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItem.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.TextChanged

    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant.KeyPress

        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCant.TextChanged

    End Sub

    Private Sub txtCodArti_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodArti.KeyPress

        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodArti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodArti.TextChanged

    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress

        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub txtMontoDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoDesc.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMontoDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoDesc.TextChanged

    End Sub

    Private Sub txtCodVend_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodVend.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodVend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodVend.TextChanged

    End Sub
End Class
