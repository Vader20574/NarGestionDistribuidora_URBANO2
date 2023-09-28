Public Class FrmNivelModulo
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Lst1 As System.Windows.Forms.ListBox
    Friend WithEvents Lst2 As System.Windows.Forms.ListBox
    Friend WithEvents LblModulo As System.Windows.Forms.Label
    Friend WithEvents BtnPasaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno As System.Windows.Forms.Button
    Friend WithEvents BtnRegresaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnRegresaUno As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Lst1 = New System.Windows.Forms.ListBox
        Me.Lst2 = New System.Windows.Forms.ListBox
        Me.BtnPasaTodo = New System.Windows.Forms.Button
        Me.BtnPasaUno = New System.Windows.Forms.Button
        Me.BtnRegresaTodo = New System.Windows.Forms.Button
        Me.BtnRegresaUno = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblModulo = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Lst1
        '
        Me.Lst1.Location = New System.Drawing.Point(18, 92)
        Me.Lst1.Name = "Lst1"
        Me.Lst1.Size = New System.Drawing.Size(208, 251)
        Me.Lst1.TabIndex = 0
        '
        'Lst2
        '
        Me.Lst2.Location = New System.Drawing.Point(314, 90)
        Me.Lst2.Name = "Lst2"
        Me.Lst2.Size = New System.Drawing.Size(208, 251)
        Me.Lst2.TabIndex = 1
        '
        'BtnPasaTodo
        '
        Me.BtnPasaTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPasaTodo.Location = New System.Drawing.Point(236, 126)
        Me.BtnPasaTodo.Name = "BtnPasaTodo"
        Me.BtnPasaTodo.Size = New System.Drawing.Size(68, 24)
        Me.BtnPasaTodo.TabIndex = 2
        Me.BtnPasaTodo.Text = ">>"
        '
        'BtnPasaUno
        '
        Me.BtnPasaUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPasaUno.Location = New System.Drawing.Point(236, 172)
        Me.BtnPasaUno.Name = "BtnPasaUno"
        Me.BtnPasaUno.Size = New System.Drawing.Size(68, 24)
        Me.BtnPasaUno.TabIndex = 3
        Me.BtnPasaUno.Text = ">"
        '
        'BtnRegresaTodo
        '
        Me.BtnRegresaTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresaTodo.Location = New System.Drawing.Point(236, 212)
        Me.BtnRegresaTodo.Name = "BtnRegresaTodo"
        Me.BtnRegresaTodo.Size = New System.Drawing.Size(68, 24)
        Me.BtnRegresaTodo.TabIndex = 4
        Me.BtnRegresaTodo.Text = "<<"
        '
        'BtnRegresaUno
        '
        Me.BtnRegresaUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresaUno.Location = New System.Drawing.Point(238, 256)
        Me.BtnRegresaUno.Name = "BtnRegresaUno"
        Me.BtnRegresaUno.Size = New System.Drawing.Size(68, 24)
        Me.BtnRegresaUno.TabIndex = 5
        Me.BtnRegresaUno.Text = "<"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Modulo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nivel Disponible"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nivel No Disponible"
        '
        'LblModulo
        '
        Me.LblModulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblModulo.Location = New System.Drawing.Point(76, 10)
        Me.LblModulo.Name = "LblModulo"
        Me.LblModulo.Size = New System.Drawing.Size(340, 23)
        Me.LblModulo.TabIndex = 9
        Me.LblModulo.Text = "Maestra de Inventario"
        Me.LblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(142, 366)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "&Guardar"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(326, 366)
        Me.Button6.Name = "Button6"
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "&Cancelar"
        '
        'FrmNivelModulo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(536, 398)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblModulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegresaUno)
        Me.Controls.Add(Me.BtnRegresaTodo)
        Me.Controls.Add(Me.BtnPasaUno)
        Me.Controls.Add(Me.BtnPasaTodo)
        Me.Controls.Add(Me.Lst2)
        Me.Controls.Add(Me.Lst1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmNivelModulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nivel Modulo"
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Fields "
    Private TMP_DISPO As New DataTable
    Private TMP_NODISPO As New DataTable
    Public CDMODULO As String = ""


#End Region
#Region "Function"

    Private Sub LlenarListas()
        TMP_NODISPO = TmpListarDatos("SELECT CDNIVEL,DSNIVEL FROM  NIVEL  WHERE  CODEMPRESA='" & codempresa & "'  AND CDNIVEL NOT IN(SELECT CDNIVEL FROM ACCESO WHERE CDMODULO='" & CDMODULO & "')")
        Lst1.DataSource = TMP_NODISPO
        Lst1.ValueMember = "CDNIVEL"
        Lst1.DisplayMember = "DSNIVEL"
        TMP_DISPO = TmpListarDatos("SELECT  A.CDNIVEL,N.DSNIVEL FROM ACCESO  A INNER JOIN NIVEL  N  ON A.CODEMPRESA=N.CODEMPRESA  AND A.CDNIVEL=N.CDNIVEL  WHERE A.CDMODULO='" & CDMODULO & "' AND A.CODEMPRESA='" & codempresa & "'")
        Lst2.DataSource = TMP_DISPO
        Lst2.ValueMember = "CDNIVEL"
        Lst2.DisplayMember = "DSNIVEL"

    End Sub


    Private Sub PasaUno()
        Try
            Dim Codigo, Descrip As String
            Codigo = Trim(Lst1.SelectedValue)
            Descrip = Trim(Lst1.Text)
            If Trim(Codigo) <> "" Then
                Dim FILA As DataRow = TMP_DISPO.NewRow
                FILA("CDNIVEL") = Codigo
                FILA("DSNIVEL") = Descrip
                TMP_DISPO.Rows.Add(FILA)
                TMP_NODISPO.Rows.RemoveAt(Lst1.SelectedIndex)

            End If
        Catch ex As Exception
            MsgBox("Escoja una Fila..")
        End Try
    End Sub
    Private Sub RegresaUno()
        Try
            Dim Codigo, Descrip As String
            Codigo = Trim(Lst2.SelectedValue)
            Descrip = Trim(Lst2.Text)
            If Trim(Codigo) <> "" Then
                Dim FILA As DataRow = TMP_NODISPO.NewRow
                FILA("CDNIVEL") = Codigo
                FILA("DSNIVEL") = Descrip
                TMP_NODISPO.Rows.Add(FILA)
                TMP_DISPO.Rows.RemoveAt(Lst2.SelectedIndex)

            End If
        Catch ex As Exception
            MsgBox("Escoja una Fila..")
        End Try
    End Sub
    Private Sub PasaTodo()
        Try
            For i As Integer = 0 To TMP_NODISPO.Rows.Count - 1
                TMP_DISPO.ImportRow(TMP_NODISPO.Rows(i))
            Next
            TMP_NODISPO.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Regresatodo()
        Try
            For i As Integer = 0 To TMP_DISPO.Rows.Count - 1
                TMP_NODISPO.ImportRow(TMP_DISPO.Rows(i))
            Next
            TMP_DISPO.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region


    Private Sub FrmNivelModulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarListas()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub BtnPasaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno.Click
        PasaUno()

    End Sub

    Private Sub BtnRegresaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresaUno.Click
        RegresaUno()

    End Sub

    Private Sub BtnPasaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo.Click
        PasaTodo()

    End Sub

    Private Sub BtnRegresaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresaTodo.Click
        Regresatodo()

    End Sub
 
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try
            For i As Integer = 0 To TMP_NODISPO.Rows.Count - 1
                Dim CDNIVEL As String
                CDNIVEL = Trim(TMP_NODISPO.Rows(i)("CDNIVEL"))
                TmpInsertDatos("DELETE  FROM   ACCESO  WHERE  CODEMPRESA='" & codempresa & "' AND CDMODULO='" & CDMODULO & "'  AND CDNIVEL='" & CDNIVEL & "'")
            Next
            For i As Integer = 0 To TMP_DISPO.Rows.Count - 1
                Dim CDNIVEL As String
                CDNIVEL = Trim(TMP_DISPO.Rows(i)("CDNIVEL"))
                If CInt(TmpListarDatos("SELECT  COUNT(*)  FROM   ACCESO  WHERE  CODEMPRESA='" & codempresa & "' AND CDMODULO='" & CDMODULO & "'  AND CDNIVEL='" & CDNIVEL & "'").Rows(0)(0)) = 0 Then
                    TmpInsertDatos("INSERT INTO ACCESO(CODEMPRESA,CDNIVEL,CDMODULO,ACTIVO) VALUES('" & codempresa & "','" & CDNIVEL & "','" & CDMODULO & "','0')")
                End If
            Next
            MsgBox("SE GUARDO CORRECTAMENTE LOS REGISTROS ...", MsgBoxStyle.Information, DesEmpresa)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
