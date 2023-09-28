Public Class FrmCambioTipoPago
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
    Friend WithEvents PnlTipoPago As System.Windows.Forms.Panel
    Friend WithEvents BtnCargar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PnlTipoPago = New System.Windows.Forms.Panel
        Me.BtnCargar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'PnlTipoPago
        '
        Me.PnlTipoPago.AutoScroll = True
        Me.PnlTipoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTipoPago.Location = New System.Drawing.Point(10, 16)
        Me.PnlTipoPago.Name = "PnlTipoPago"
        Me.PnlTipoPago.Size = New System.Drawing.Size(272, 182)
        Me.PnlTipoPago.TabIndex = 0
        '
        'BtnCargar
        '
        Me.BtnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargar.Location = New System.Drawing.Point(50, 222)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(182, 44)
        Me.BtnCargar.TabIndex = 1
        Me.BtnCargar.Text = "<< CARGAR TIPO DE PAGO"
        Me.BtnCargar.Visible = False
        '
        'FrmCambioTipoPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 210)
        Me.Controls.Add(Me.BtnCargar)
        Me.Controls.Add(Me.PnlTipoPago)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambioTipoPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Tipo de Pago"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Form"
    Private TMP_TIPOPAGO As New DataTable
    Public DEVOLVER As Boolean
    Public CODIGOPAG As String

#End Region

#Region "Funciones Form"
    Private Sub CargarControles()
        Dim X, Y As Integer
        X = 15
        Y = 5
        TMP_TIPOPAGO = TmpListarDatos("Nsp_Sele_TipoPago '" & codempresa & "'")
        If TMP_TIPOPAGO.Rows.Count > 0 Then
            For i As Integer = 0 To TMP_TIPOPAGO.Rows.Count - 1
                If VCdPagCredito = TMP_TIPOPAGO.Rows(i)(0).ToString.Trim Or VCdPagEfectivo = TMP_TIPOPAGO.Rows(i)(0).ToString.Trim Then
                    Dim RdbTipoPago As New RadioButton
                    RdbTipoPago.Name = "RdbPag" & TMP_TIPOPAGO.Rows(i)(0)
                    RdbTipoPago.Text = TMP_TIPOPAGO.Rows(i)(1)
                    RdbTipoPago.Font = New System.Drawing.Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                    RdbTipoPago.Width = 200
                    RdbTipoPago.Height = 50
                    RdbTipoPago.Tag = TMP_TIPOPAGO.Rows(i)(0)
                    RdbTipoPago.Location = New Point(X, Y)
                    If CODIGOPAG.Trim = TMP_TIPOPAGO.Rows(i)(0).ToString.Trim Then
                        RdbTipoPago.Checked = True
                    End If
                    PnlTipoPago.Controls.Add(RdbTipoPago)
                    Y = Y + 45
                End If
            Next
        End If
    End Sub
    Private Sub ActivarEventos(ByVal Control As Control)
        Dim ctrl As Control
        For Each ctrl In Control.Controls
            If TypeOf ctrl Is RadioButton Then
                AddHandler ctrl.Click, AddressOf Me.Rdbpago_CheckedChanged
            End If
        Next

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal Keydata As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case Keydata
                Case Keys.Enter
                    DEVOLVER = True
                    Me.Close()
                Case Keys.Escape
                    Me.Close()
            End Select

        End If


    End Function


#End Region



    Private Sub FrmCambioTipoPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarControles()
        ActivarEventos(PnlTipoPago)

    End Sub

    Private Sub BtnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCargar.Click
        DEVOLVER = True
        Me.Close()

    End Sub
    Private Sub Rdbpago_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CODIGOPAG = CType(sender, Control).Tag
    End Sub


End Class
