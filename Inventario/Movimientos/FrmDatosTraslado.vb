Public Class FrmDatosTraslado
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDatos As System.Windows.Forms.TextBox
    Friend WithEvents TxtAutorizado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboTipoProv As System.Windows.Forms.ComboBox
    Friend WithEvents CboProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtMontoFlete As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDatos = New System.Windows.Forms.TextBox
        Me.TxtAutorizado = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboTipoProv = New System.Windows.Forms.ComboBox
        Me.CboProveedor = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtMontoFlete = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(132, 258)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(258, 258)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Proveedor :  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Autorizado por:"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(16, 258)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.TabIndex = 6
        Me.BtnNuevo.Text = "Limpiar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 136)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Transportista"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Datos: "
        '
        'TxtDatos
        '
        Me.TxtDatos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDatos.Location = New System.Drawing.Point(58, 22)
        Me.TxtDatos.MaxLength = 50
        Me.TxtDatos.Multiline = True
        Me.TxtDatos.Name = "TxtDatos"
        Me.TxtDatos.Size = New System.Drawing.Size(250, 106)
        Me.TxtDatos.TabIndex = 0
        Me.TxtDatos.Text = ""
        '
        'TxtAutorizado
        '
        Me.TxtAutorizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAutorizado.Location = New System.Drawing.Point(98, 10)
        Me.TxtAutorizado.MaxLength = 25
        Me.TxtAutorizado.Name = "TxtAutorizado"
        Me.TxtAutorizado.Size = New System.Drawing.Size(234, 20)
        Me.TxtAutorizado.TabIndex = 8
        Me.TxtAutorizado.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tipo Proveedor :"
        '
        'CboTipoProv
        '
        Me.CboTipoProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoProv.Location = New System.Drawing.Point(98, 34)
        Me.CboTipoProv.Name = "CboTipoProv"
        Me.CboTipoProv.Size = New System.Drawing.Size(236, 21)
        Me.CboTipoProv.TabIndex = 11
        '
        'CboProveedor
        '
        Me.CboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProveedor.Location = New System.Drawing.Point(98, 62)
        Me.CboProveedor.Name = "CboProveedor"
        Me.CboProveedor.Size = New System.Drawing.Size(236, 21)
        Me.CboProveedor.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Monto Flete :  "
        '
        'TxtMontoFlete
        '
        Me.TxtMontoFlete.Location = New System.Drawing.Point(100, 88)
        Me.TxtMontoFlete.Name = "TxtMontoFlete"
        Me.TxtMontoFlete.Size = New System.Drawing.Size(76, 20)
        Me.TxtMontoFlete.TabIndex = 14
        Me.TxtMontoFlete.Text = "0.00"
        Me.TxtMontoFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmDatosTraslado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 294)
        Me.Controls.Add(Me.TxtMontoFlete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CboProveedor)
        Me.Controls.Add(Me.CboTipoProv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtAutorizado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDatosTraslado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de Traslado"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "VARIABLES"
    Public DEVOLVER As Boolean
    Private ActEvent As Boolean


#End Region

#Region "FUNCIONES"
    Private Sub Cargacombos()
        'Call CargadataCombos(Me.CboAutorizado, "NSP_Select_Listado_Usuario  '" & codempresa & "'", "CDUSUARIO", "USUARIO")
        'Call CargadataCombos(Me.CboResponsable, "USP_LLENAR_ALMACEN", "Codigo", "Descripcion")

    End Sub
    Private Sub LIMPIAR()
        TxtAutorizado.Text = ""
        CboProveedor.Text = ""
        TxtDatos.Text = ""
    End Sub

#End Region
    Private Sub FrmDatosTraslado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(CboTipoProv, "SELECT  CODEMPRESA,CDTIPOPROV,DSTIPOPROV  FROM TIPOPROVEE  WHERE  CODEMPRESA='" & codempresa & "'", "CDTIPOPROV", "DSTIPOPROV")
        CAyuda.CargarDataCombo(CboProveedor, "SELECT  CODPROVEEDOR,DESPROVEEDOR FROM PROVEEDOR  WHERE  CODEMPRESA='" & codempresa & "' AND  TIPOPROVEEDOR='" & IIf(IsNothing(CboTipoProv.SelectedValue), "", CboTipoProv.SelectedValue) & "' ", "CODPROVEEDOR", "DESPROVEEDOR")
        ActEvent = True

    End Sub


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        DEVOLVER = True
        Me.Close()


    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        LIMPIAR()

    End Sub

    Private Sub CboTipoProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoProv.SelectedIndexChanged
        If ActEvent = True Then
            CAyuda.CargarDataCombo(CboProveedor, "SELECT  CODPROVEEDOR,DESPROVEEDOR FROM PROVEEDOR  WHERE  CODEMPRESA='" & codempresa & "' AND  TIPOPROVEEDOR='" & IIf(IsNothing(CboTipoProv.SelectedValue), "", CboTipoProv.SelectedValue) & "' ", "CODPROVEEDOR", "DESPROVEEDOR")
        End If
    End Sub
End Class
