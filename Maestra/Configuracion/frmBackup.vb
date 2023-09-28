Imports System.Data.SqlClient
Public Class frmBackup
    Dim ruta As String
    Dim v As Boolean
    Private Sub btnruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnruta.Click

        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ruta = FolderBrowserDialog1.SelectedPath
            If ruta.EndsWith("\") = False Then
                ruta = ruta & "\"
            End If

            ruta = ruta & "bckNarGest" & Format(vFechaActual, "ddMMyyyy_hh_mm_ss_tt").Replace(".", "") & ".bak"
            txtruta.Text = ruta
        End If

    End Sub

    Private Sub btnbackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbackup.Click
        If ruta.Trim.Length = 0 Then
            MsgBox("No hay una ruta correcta.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        If MessageBox.Show("Desea realizar una copia de seguridad de la base de datos?", "NARSISTEMAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Me.btnruta.Enabled = False
            Me.btnbackup.Enabled = False
            Me.txtruta.Enabled = False
            v = True
            Dim hilo1 As New Threading.Thread(AddressOf Backup)
            hilo1.IsBackground = True
            hilo1.Start()

        End If
    End Sub
    Sub Backup()
        Dim sBackup As String = "BACKUP DATABASE " & bd & _
                              " TO DISK = N'" & Me.txtruta.Text.Trim & _
                              "' WITH NOFORMAT, NOINIT, NAME =N'" & bd.Trim & _
                              "' ,SKIP, STATS = 10"
        Try
            Using cnx As New SqlConnection(STRCN)
                Using cmd As New SqlCommand(sBackup, cnx)
                    cnx.Open()
                    cmd.CommandTimeout = 0
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoria.", "Copia de seguridad de base de datos", _
                                       MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al copiar la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Cursor = Cursors.Default
        Me.btnruta.Enabled = True
        Me.btnbackup.Enabled = True
        Me.txtruta.Enabled = True
        ruta = ""
        v = False
    End Sub

    Private Sub frmBackup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If v = True Then
            MsgBox("Hay un proceso en ejecucion, espere unos momentos...", MsgBoxStyle.Information, "NARSISTEMAS")
            e.Cancel = True
        End If
    End Sub

    Private Sub frmBackup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
End Class

