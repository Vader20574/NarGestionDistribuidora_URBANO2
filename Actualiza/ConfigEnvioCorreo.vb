Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class ConfigEnvioCorreo
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ChecPuntosBonus As System.Windows.Forms.CheckBox
    Friend WithEvents txtidimpisc As System.Windows.Forms.TextBox
    Friend WithEvents txtidimpigv As System.Windows.Forms.TextBox
    Friend WithEvents txtcdbal As System.Windows.Forms.TextBox
    Friend WithEvents txtrecibo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigEnvioCorreo))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ChecPuntosBonus = New System.Windows.Forms.CheckBox
        Me.txtidimpisc = New System.Windows.Forms.TextBox
        Me.txtidimpigv = New System.Windows.Forms.TextBox
        Me.txtcdbal = New System.Windows.Forms.TextBox
        Me.txtrecibo = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código IGV :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código ISC :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Dígito Balanza :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Nro Recibo Pendiente :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChecPuntosBonus
        '
        Me.ChecPuntosBonus.Location = New System.Drawing.Point(152, 132)
        Me.ChecPuntosBonus.Name = "ChecPuntosBonus"
        Me.ChecPuntosBonus.Size = New System.Drawing.Size(136, 16)
        Me.ChecPuntosBonus.TabIndex = 68
        Me.ChecPuntosBonus.Text = "Activar Puntos Bonus"
        Me.ChecPuntosBonus.Visible = False
        '
        'txtidimpisc
        '
        Me.txtidimpisc.Location = New System.Drawing.Point(152, 48)
        Me.txtidimpisc.Name = "txtidimpisc"
        Me.txtidimpisc.Size = New System.Drawing.Size(169, 21)
        Me.txtidimpisc.TabIndex = 3
        '
        'txtidimpigv
        '
        Me.txtidimpigv.Location = New System.Drawing.Point(152, 24)
        Me.txtidimpigv.Name = "txtidimpigv"
        Me.txtidimpigv.Size = New System.Drawing.Size(169, 21)
        Me.txtidimpigv.TabIndex = 1
        '
        'txtcdbal
        '
        Me.txtcdbal.Location = New System.Drawing.Point(152, 72)
        Me.txtcdbal.Name = "txtcdbal"
        Me.txtcdbal.Size = New System.Drawing.Size(169, 21)
        Me.txtcdbal.TabIndex = 23
        '
        'txtrecibo
        '
        Me.txtrecibo.Location = New System.Drawing.Point(152, 96)
        Me.txtrecibo.Name = "txtrecibo"
        Me.txtrecibo.Size = New System.Drawing.Size(169, 21)
        Me.txtrecibo.TabIndex = 26
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
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(448, 192)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(88, 26)
        Me.btnreporte.TabIndex = 21
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.Visible = False
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(352, 336)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNELIMINAR.TabIndex = 1
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNELIMINAR.Visible = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(448, 102)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(88, 28)
        Me.BTNCANCELAR.TabIndex = 10
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(448, 132)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(88, 28)
        Me.BTNCERRAR.TabIndex = 13
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(448, 42)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(88, 28)
        Me.BTNMODIFICAR.TabIndex = 4
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(448, 162)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(88, 28)
        Me.BTNNUEVO.TabIndex = 18
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNNUEVO.Visible = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(448, 72)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(88, 28)
        Me.BTNGUARDAR.TabIndex = 7
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidimpisc)
        Me.GroupBox1.Controls.Add(Me.txtidimpigv)
        Me.GroupBox1.Controls.Add(Me.txtcdbal)
        Me.GroupBox1.Controls.Add(Me.txtrecibo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ChecPuntosBonus)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 295)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ConfigEnvioCorreo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(564, 307)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigEnvioCorreo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ABoolPb_editar As Boolean = True
    Dim GrsConfigVta As DataTable
    Dim AIntResp As Integer

    Private Sub FrmConfigVta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarFormularios(Me)

        If CAyuda.ListarDatos("NSP_SELECT_CONFIGENVIOCORREO", codempresa.ToString()).Tables.Count > 0 Then
            GrsConfigVta = CAyuda.ListarDatos("NSP_SELECT_CONFIGENVIOCORREO", codempresa.ToString()).Tables(0)
            asigna_campos()
            botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
                    BTNCERRAR, True, False, True, True, True, True, True)
            bloqueatextos(Me)
            'gHabilitarReg(Me, False)

            ChecPuntosBonus.Enabled = False

        Else

            botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
             BTNCERRAR, True, False, True, True, True, True, True)
            Me.txtidimpigv.Focus()
            ABoolPb_editar = True
        End If
    End Sub

    Private Sub txtrecibo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrecibo.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtrecibo.Focus()
        End If

       
    End Sub

    Private Sub txtcobranza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        
    End Sub

    Private Sub txtpago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

       
    End Sub

    Private Sub TxtMonTickProm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        If Keyascii = 13 Then

        End If

    End Sub

    Private Sub TxtNumCumProm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        If Keyascii = 13 Then

        End If
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If ValidaDatos() Then
            If ABoolPb_editar Then
                AIntResp = CAyuda.Ejecutar("NSP_ins_CONFIGVTA", txtidimpigv.Text, txtidimpisc.Text, txtcdbal.Text, txtrecibo.Text, ChecPuntosBonus.CheckState)
                If AIntResp = 1 Then
                    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA 'INSERT','INSERT','CONFIGVTA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MessageBox.Show("Error Durante el Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                AIntResp = CAyuda.Ejecutar("sp_Upd_ConfigEnvioCorreo", txtidimpigv.Text, txtidimpisc.Text, txtcdbal.Text, txtrecibo.Text, ChecPuntosBonus.CheckState)
                If AIntResp = 1 Then
                    MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA 'UPDATE','UPDATE','CONFIGVTA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MessageBox.Show("Error Durante el Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If


        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
                           BTNCERRAR, True, False, True, True, True, True, True)


    End Sub
    Private Function ValidaDatos() As Boolean
        ValidaDatos = False
        If GVDATO(txtidimpigv.Text) = "" Then
            MessageBox.Show("Falta Ingresar un Valor", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MsgBox "Ingrese impuesto", vbExclamation, "Configuración"
            txtidimpigv.Focus()
            Exit Function
        End If
        If GVDATO(txtidimpisc.Text) = "" Then
            MessageBox.Show("Falta Ingresar un Valor", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MsgBox "Ingrese nombre de impuesto", vbExclamation, "Configuración"
            txtidimpisc.Focus()
            Exit Function
        End If




        ValidaDatos = True
    End Function

    Private Sub BTNMODIFICAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
      
        'gHabilitarReg(Me, True)
        ABoolPb_editar = False
        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
        BTNCERRAR, True, True, False, True, True, True, True)
        desbloqueatextos(Me)

        Me.ChecPuntosBonus.Enabled = True




       
        Me.txtidimpigv.Focus()
    End Sub


    Private Sub txtidimpigv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtidimpigv.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtidimpisc.Focus()
        End If
    End Sub


    Private Sub Txtcdntacred_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtcdbal.Focus()
        End If
    End Sub

    Private Sub txtcdbal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcdbal.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtrecibo.Focus()
        End If
    End Sub

    Private Sub asigna_campos()
        Try
            If GrsConfigVta.Rows.Count <> 0 Then
                txtidimpigv.Text = GrsConfigVta.Rows(0)("ServidorSMTP")
                txtidimpisc.Text = GrsConfigVta.Rows(0)("Puerto")
                txtcdbal.Text = GrsConfigVta.Rows(0)("Usuario")
                txtrecibo.Text = GrsConfigVta.Rows(0)("clave")
                ChecPuntosBonus.Checked = GrsConfigVta.Rows(0)("SSLE")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub



    Private Sub BTNCANCELAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        GrsConfigVta = CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGVTA", codempresa.ToString()).Tables(0)
        asigna_campos()
        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
           BTNCERRAR, True, False, True, True, True, True, True)
        bloqueatextos(Me)
     
    End Sub


    Private Sub txtidimpisc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtidimpisc.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
      
    End Sub

    Private Sub CMBTICKET_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
      
    End Sub

    Private Sub CMBFACTURA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
       
    End Sub

    Private Sub CMBBOLETA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
       
    End Sub

    Private Sub CMBNOTCRED_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
     
    End Sub


    Private Sub cbonotadeb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
      
    End Sub

    Private Sub cmboperador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtcdbal.Focus()
        End If
    End Sub

    Private Sub TxtMonTickProm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmboperador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtNroitemFact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
      
    End Sub

    Private Sub txtNroitemGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
       
    End Sub

    Private Sub txtNroitemNotCred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        
    End Sub

    Private Sub txtNroitemBol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
       
    End Sub

    Private Sub txtMontoBoleta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
       
    End Sub

    Private Sub txtCodclienteVarios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
       
    End Sub

    Private Sub TXTDIGIRUC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        
    End Sub

    Private Sub TXTDIGIDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        
    End Sub

    Private Sub TxtUit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub txtpago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TXTDIGIRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click

    End Sub

    Private Sub txtNroitemFact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtNumCumProm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtMontoBoleta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
       
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
      
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
