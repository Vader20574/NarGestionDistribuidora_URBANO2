Public Class FrmModificarVentas
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
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarVentas))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.TxtPrecio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txt_Cantidad = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(175, 94)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(132, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(79, 22)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(174, 20)
        Me.TxtPrecio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Precio :"
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageList = Me.ImageList1
        Me.btnGuardar.Location = New System.Drawing.Point(37, 94)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 54)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Modificar"
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Location = New System.Drawing.Point(79, 55)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(174, 20)
        Me.txt_Cantidad.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad :"
        '
        'FrmModificarVentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Cantidad)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmModificarVentas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MODIFICAR"
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


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click



        DEVOLVER = False
        Me.Close()


    End Sub
    Private Sub FrmOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtPrecio.Text = PRECIO
        txt_Cantidad.Text = CANTIDAD


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

        Dim RptaTrans As Boolean
        RptaTrans = CAyuda.Ejecutar("SP_UPD_TMP_VENTAS", codempresa, NRODOCU, CODTIPODOC, ITEM, ARTICULO, CInt(txt_Cantidad.Text.Trim), CDbl(TxtPrecio.Text.Trim), DESCUENTO)
        If RptaTrans Then
            '     MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If
        DEVOLVER = True
        Opcion = 1
        Me.Close()

    End Sub
End Class
