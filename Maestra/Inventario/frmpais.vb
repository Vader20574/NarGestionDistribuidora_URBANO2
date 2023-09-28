Imports System.Data.SqlClient

Public Class FRMPAIS
    Inherits System.Windows.Forms.Form
    Dim FLAG As Integer
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents TXTDESPAIS As System.Windows.Forms.TextBox
    Friend WithEvents TXTCODPAIS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMPAIS))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.TXTDESPAIS = New System.Windows.Forms.TextBox
        Me.TXTCODPAIS = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 196)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(11, 131)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(11, 159)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(11, 75)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNMODIFICAR.TabIndex = 3
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(11, 103)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(11, 19)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(83, 23)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(11, 47)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.TXTDESPAIS)
        Me.GroupBox2.Controls.Add(Me.TXTCODPAIS)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 81)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(134, 21)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 10
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTDESPAIS
        '
        Me.TXTDESPAIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDESPAIS.Location = New System.Drawing.Point(56, 47)
        Me.TXTDESPAIS.MaxLength = 50
        Me.TXTDESPAIS.Name = "TXTDESPAIS"
        Me.TXTDESPAIS.Size = New System.Drawing.Size(275, 21)
        Me.TXTDESPAIS.TabIndex = 9
        '
        'TXTCODPAIS
        '
        Me.TXTCODPAIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCODPAIS.Location = New System.Drawing.Point(56, 22)
        Me.TXTCODPAIS.MaxLength = 4
        Me.TXTCODPAIS.Name = "TXTCODPAIS"
        Me.TXTCODPAIS.Size = New System.Drawing.Size(72, 21)
        Me.TXTCODPAIS.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pais : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 23)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "MANTENIMIENTO DE PAIS"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 41)
        Me.Button1.TabIndex = 161
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRMPAIS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(473, 208)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(486, 240)
        Me.Name = "FRMPAIS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Pais"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Private Sub FRMPAIS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim sql As String
        Dim PROCESO As Boolean
        Call formatotextbox(Me)
        If TXTCODPAIS.Text = "" Or TXTDESPAIS.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If FLAG = 0 Then
            If TmpListarDatos("SELECT DESPAIS FROM PAIS WHERE CODPAIS='" & TXTCODPAIS.Text.Trim & "' AND COD_EMPRESA='" & codempresa & "' ").Rows.Count > 0 Then
                MsgBox("EL CODIGO YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            If TmpListarDatos("SELECT DESPAIS FROM PAIS WHERE DESPAIS='" & TXTDESPAIS.Text.Trim & "' AND COD_EMPRESA='" & codempresa & "' ").Rows.Count > 0 Then
                MsgBox("EL PAIS YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            sql = "Nsp_inst_pais '" & TXTCODPAIS.Text & "','" & TXTDESPAIS.Text & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TXTCODPAIS.Text & "','INSERT','PAIS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
        End If


        If FLAG = 1 Then

            If TmpListarDatos("SELECT DESPAIS FROM PAIS WHERE DESPAIS='" & TXTDESPAIS.Text.Trim & "' AND COD_EMPRESA='" & codempresa & "' AND CODPAIS<>'" & TXTCODPAIS.Text & "' ").Rows.Count > 0 Then
                MsgBox("EL PAIS YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            sql = "nsp_upda_pais '" & TXTCODPAIS.Text & "','" & TXTDESPAIS.Text & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TXTCODPAIS.Text & "','UPDATE','PAIS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")

        End If

        If PROCESO = False Then
            Exit Sub
        Else
            MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If

        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)

        Call BOTONES(True, False, False, False, True)


        BTNNUEVO.Focus()



    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, False)
        FLAG = 0
        TXTCODPAIS.Focus()

        btnbuscar.Enabled = False

    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
    End Sub
    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Try
            Dim FRMX As New frmgridpais1
            FRMX.ShowDialog()
            mostrar()
            Call BOTONES(True, False, True, True, True)
            TXTCODPAIS.ReadOnly = True
        Catch ex As Exception
            MsgBox("no se encontro ninguna fila seleccionada...", MsgBoxStyle.Information, "Nar Gestion")
        End Try
    End Sub
    Public Sub mostrar()
        TXTCODPAIS.Text = VAR1
        TXTDESPAIS.Text = VAR2
    End Sub
    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click


        If TXTCODPAIS.Text.ToString.Trim.Length = 0 Then
            MsgBox("Debe seleccionar un registro...", MsgBoxStyle.Information, "Nar Gestion")
            Exit Sub
        End If

        Call desbloqueatextbox(Me)
        TXTCODPAIS.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        FLAG = 1
        TXTDESPAIS.Focus()
        TXTDESPAIS.SelectAll()
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)

        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR

    End Sub


    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click


        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            Dim PROCESO As Boolean
            Dim sql As String

            sql = "nsp_dele_pais '" & TXTCODPAIS.Text & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = False Then
                Exit Sub
            Else
                MsgBox("SE ELIMINO CORRECTAMENTE EL  REGISTRO...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            End If

            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TXTCODPAIS.Text & "','DELETE','PAIS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            BOTONES(True, False, False, False, True)
            Call Bloqueatextbox(Me)
            Call Limpiatextbox(Me)
        End If


    End Sub


    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub FRMPAIS_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        BTNNUEVO.Focus()
    End Sub

    Private Sub TXTCODPAIS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCODPAIS.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            TXTDESPAIS.Focus()
        End If
    End Sub

    Private Sub TXTDESPAIS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTDESPAIS.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub TXTCODPAIS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTCODPAIS.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub


    Private Sub TXTCODPAIS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCODPAIS.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click






        'Dim obj As New ConsultaSunatWeb.ConsultaSunatWeb
        'Dim dato() As String

        'Dim nombre As String
        'dato = obj.ConsultaRucSunat("20509333778")
        'nombre = dato(0)




        'STRCN2 = "DATA SOURCE=190.117.84.150;INITIAL CATALOG=FE_CMQ;USER ID=narsistemas;PASSWORD=123456"
        'Dim StrSql As String
        'StrSql = "INSERT INTO PRUEBA (CODIGO, NOMBRE)  VALUES ('" & "01" & " ','" & "RRR" & "')"

        'Dim con2 As New SqlConnection
        'Dim cmd2 As New SqlCommand
        'Try
        '    con2.ConnectionString = STRCN2
        '    con2.Open()
        '    cmd2.Connection = con2
        '    cmd2.CommandText = StrSql
        '    cmd2.ExecuteNonQuery()

        'Catch ex As Exception
        '    MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        'Finally
        '    con2.Close()
        'End Try










        'STRCN2 = "DATA SOURCE=190.117.84.150;INITIAL CATALOG=FE_CMQ;USER ID=narsistemas;PASSWORD=123456"

        'Cn2.ConnectionString = STRCN2

        'Dim cmd As New SqlCommand
        ''Decimos que tipo de prcedimiento es y cual es su nombre
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.CommandText = "INS_PRUEBA" 'AQUI VA EL NOMBRE DEL PROCEDIMIENTO'
        ''Establecemos la conexion con la base de datos
        'cmd.Connection = Cn2
        ''Agregamos parametros con sus valores
        'cmd.Parameters.Add("@CODIGO", "01")
        'cmd.Parameters.Add("@NOMBRE", "AAA")
        ''Creamos una variable, Abrimos y cerramos conexion
        'Dim I As Integer
        'Cn2.Open()
        ''Ejecutamos el procedimiento de acuerdo a sus filas establecidas
        'I = cmd.ExecuteNonQuery
        'Cn2.Close()





    End Sub
End Class
