Imports System.Transactions
Public Class frmFindia

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If MessageBox.Show("Desea realizar el fin de dia/mes ?", "NARSISTEMAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim Fecha As String
        Dim v As Boolean
        Dim datavalidafindia As New DataTable
        Fecha = Format(CDate(FECHAPROC.Trim), "dd/MM/yyyy")
        Dim FechaProcesoCab, FechaProcesoDet, fechaFinal As String

        fechaFinal = DateAdd(DateInterval.Day, 1, CDate(FECHAPROC))
        '' FIN DIA DE VENTAS
        FechaProcesoCab = "VENTC" & Format(CDate(FECHAPROC), "yyyy") & Format(CDate(FECHAPROC), "MM")
        FechaProcesoDet = "VENTD" & Format(CDate(FECHAPROC), "yyyy") & Format(CDate(FECHAPROC), "MM")


        Using trx As New TransactionScope
            Try
                datavalidafindia = TmpListarDatos("VALIDAR_FIN_DE_DIA  '" & Fecha & "','" & codempresa & "'")
                If datavalidafindia.Rows(0)(0).ToString > 0 Then
                    If TmpListarDatos("VERIFICA_HISTORICOVENT   '" & FechaProcesoCab.Trim & "','" & codempresa & "'").Rows.Count = 0 Then
                        TmpInsertDatos("CREA_TABLA_VENTAHIST    '" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "','" & codempresa & "'")
                        TmpInsertDatos("INSERTAR_HISTORICO  '" & codempresa & "','" & Format(CDate(FECHAPROC), "dd/MM/yyyy") & "','" & Format(CDate(fechaFinal), "dd/MM/yyyy") & "'  ,'" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "'  ")
                        TmpInsertDatos("ELIMINAR_REG_VENTC_VENTADET   '" & Format(CDate(FECHAPROC), "dd/MM/yyyy") & "' ,'" & Format(CDate(fechaFinal), "dd/MM/yyyy") & "','" & codempresa & "'")
                        v = True
                    Else
                        TmpInsertDatos("INSERTAR_HISTORICO  '" & codempresa & "','" & Format(CDate(FECHAPROC), "dd/MM/yyyy") & "','" & Format(CDate(fechaFinal), "dd/MM/yyyy") & "'   ,'" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "'  ")
                        TmpInsertDatos("ELIMINAR_REG_VENTC_VENTADET   '" & Format(CDate(FECHAPROC), "dd/MM/yyyy") & "','" & Format(CDate(fechaFinal), "dd/MM/yyyy") & "','" & codempresa & "'")
                        v = True
                    End If

                Else
                    lbnotas.Items.Add("No hay ventas para realizar el fin de dia...")
                End If

                FechaProcesoCab = "MOVIC" & Format(CDate(FECHAPROC), "yyyy") & Format(CDate(FECHAPROC), "MM")
                FechaProcesoDet = "MOVID" & Format(CDate(FECHAPROC), "yyyy") & Format(CDate(FECHAPROC), "MM")

                datavalidafindia = New DataTable
                datavalidafindia = TmpListarDatos("VALIDAR_MOVI_FIN_DE_DIA '" & Fecha & "','" & codempresa & "'")
                If datavalidafindia.Rows(0)(0).ToString > 0 Then
                    If TmpListarDatos("VERIFICA_HISTORICOMOVI   '" & codempresa & "','" & FechaProcesoCab.Trim & "'").Rows.Count = 0 Then
                        TmpInsertDatos("CREA_TABLA_MOVIHIST    '" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "','" & codempresa & "'")
                        TmpInsertDatos("INSERTAR_HISTORICO_MOVI  '" & codempresa & "','" & Format(CDate(FECHAPROC), "dd/MM/yyyy") & "','" & Format(CDate(fechaFinal), "dd/MM/yyyy") & "'  ,'" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "'  ")
                        TmpInsertDatos("ELIMINAR_REG_MOVICAB_MOVIDET   '" & Format(CDate(FECHAPROC), "dd/MM/yyyy") & "' ,'" & Format(CDate(fechaFinal), "dd/MM/yyyy") & "','" & codempresa & "'")
                        v = True
                    Else
                        TmpInsertDatos("INSERTAR_HISTORICO_MOVI  '" & codempresa & "','" & Format(CDate(FECHAPROC), "dd/MM/yyyy") & "','" & Format(CDate(fechaFinal), "dd/MM/yyyy") & "'  ,'" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "'  ")
                        TmpInsertDatos("ELIMINAR_REG_MOVICAB_MOVIDET   '" & Format(CDate(FECHAPROC), "dd/MM/yyyy") & "' ,'" & Format(CDate(fechaFinal), "dd/MM/yyyy") & "','" & codempresa & "'")
                        v = True
                    End If

                Else
                    lbnotas.Items.Add("No hay movimientos para realizar fin de dia...")
                End If


                If v = True Then
                    TmpInsertDatos("SP_CIERRE_FIN_MES  '" & codempresa & "','" & NROPTOVTA & "','" & fechaFinal & "'")
                End If
                trx.Complete()
                MsgBox("Se finalizo con exito el fin de día...", MsgBoxStyle.Information, "NARSISTEMAS")
                MsgBox("La apliacion cerrara para aplicar los cambios.", MsgBoxStyle.Information, "NARSISTEMAS")
                End
            Catch ex As Exception
                lbnotas.Items.Add(ex.Message.ToString())
                MsgBox("No se pudo finalizar la operación...", MsgBoxStyle.Information, "NARSISTEMAS")
            End Try
        End Using



    End Sub

    Private Sub frmFindia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblfechaproc.Text = FECHAPROC
        Me.txtmesproceso.Text = Mes(CDate(FECHAPROC).Month) & " de " & CDate(FECHAPROC).Year
        Me.lblfechaact.Text = Fecha_Actual().ToShortDateString

        If CDate(FECHAPROC) < CDate(lblfechaact.Text) Then
            Me.lbnotas.Items.Add("Nota : La fecha de proceso se encuentra desactualizada." & vbNewLine & " - Cerrar los historicos, realizando el fín de dia.")
            lblfechaproc.ForeColor = Color.Red
            Me.txtmesproceso.ForeColor = Color.Red
        Else
            lblfechaproc.ForeColor = Color.Blue
            Me.txtmesproceso.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Function Mes(ByVal cod As Integer) As String
        Select Case cod
            Case 1 : Return "Enero"
            Case 2 : Return "Febrero"
            Case 3 : Return "Marzo"
            Case 4 : Return "Abril"
            Case 5 : Return "Mayo"
            Case 6 : Return "Junio"
            Case 7 : Return "Julio"
            Case 8 : Return "Agosto"
            Case 9 : Return "Setiembre"
            Case 10 : Return "Octubre"
            Case 11 : Return "Noviembre"
            Case 12 : Return "Diciembre"
        End Select
        Return ""
    End Function
End Class