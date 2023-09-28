Public Class frmDistribucion
    Dim TABLE_NTACREDSERV As DataTable
    Public correlx As String

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WINKEYdOWN As Integer = &H100
        Const WINKEYSYSTEM As Integer = &H104
        If ((MSG.Msg = WINKEYdOWN) Or (MSG.Msg = WINKEYSYSTEM)) Then
            Select Case (KeyData)
                Case Keys.Enter
                    If GridNotaCred.Focus = True Then
                        If TABLE_NTACREDSERV.Rows.Count > 0 Then
                            If GridNotaCred.CurrentCell.ColumnNumber = 8 Then
                                If GridNotaCred.CurrentRowIndex > -1 Then
                                    Dim FrmOpciones As New FrmOpciones
                                    FrmOpciones.ShowDialog()
                                    If FrmOpciones.DEVOLVER = True Then
                                        For i As Integer = 0 To TABLE_NTACREDSERV.Rows.Count - 1
                                            If TABLE_NTACREDSERV.Rows(i)("CORRNBR").ToString.Trim = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 1).ToString.Trim _
                                            And TABLE_NTACREDSERV.Rows(i)("NRONTACRED").ToString.Trim = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 2).ToString.Trim Then
                                                ''''''''''''''''''CAMBIAR EL ESTADO DE NTA CRED
                                                Select Case FrmOpciones.Opcion
                                                    Case 1
                                                        TABLE_NTACREDSERV.Rows(i)("ESTD_APROB") = "NO"
                                                    Case 2
                                                        TABLE_NTACREDSERV.Rows(i)("ESTD_APROB") = "SI"
                                                    Case 3
                                                        TABLE_NTACREDSERV.Rows(i)("ESTD_APROB") = "EN PROCESO"
                                                End Select

                                            End If
                                        Next
                                    End If
                                End If
                            End If




                            If GridNotaCred.CurrentCell.ColumnNumber = 0 Then
                                If GridNotaCred.CurrentRowIndex > -1 Then
                                    Dim fr As New frm_habitacion2

                                    fr.CODSOL = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 0).ToString.Trim
                                    fr.Show()
                                End If
                            End If


                            If GridNotaCred.CurrentCell.ColumnNumber = 4 Then
                                If GridNotaCred.CurrentRowIndex > -1 Then
                                    Dim fr As New frm_SolicitudServi2

                                    fr.CODSOL = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 4).ToString.Trim
                                    fr.Show()
                                End If
                            End If









                        End If
                    End If



            End Select
        End If
    End Function


    Private Sub frmDispoHab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TABLE_NTACREDSERV = CAyuda.ListarDatos("sp_select_artdistri", correlx).Tables(0)
        Me.GridNotaCred.DataSource = TABLE_NTACREDSERV



    End Sub

    Private Sub GridNotaCred_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridNotaCred.Navigate

    End Sub
End Class