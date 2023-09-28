Public Class FrmPedidosPorClaro

    Dim TAB_PEDIDO_CAB As New DataTable


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click


        TAB_PEDIDO_CAB = CAyuda.ListarDatos("SP_LISTA_PEDIDOCLAROXFECHA  ", codempresa, Me.DateTimePicker1.Value().ToString("dd/MM/yyyy")).Tables(0)

        Grid1.DataSource = TAB_PEDIDO_CAB

    End Sub

    Private Sub FrmPedidosPorClaro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WINKEYdOWN As Integer = &H100
        Const WINKEYSYSTEM As Integer = &H104
        If ((MSG.Msg = WINKEYdOWN) Or (MSG.Msg = WINKEYSYSTEM)) Then
            Select Case (KeyData)
                Case Keys.Enter
                    If Grid1.Focus = True Then
                        If TAB_PEDIDO_CAB.Rows.Count > 0 Then
                            If Grid1.CurrentCell.ColumnNumber = 4 Then
                                If Grid1.CurrentRowIndex > -1 Then
                                    Dim FrmOpciones As New FrmOpcionesA
                                    FrmOpciones.ShowDialog()
                                    If FrmOpciones.DEVOLVER = True Then

                                        For i As Integer = 0 To TAB_PEDIDO_CAB.Rows.Count - 1
                                            If TAB_PEDIDO_CAB.Rows(i)("NUM_PEDIDO").ToString.Trim = Grid1.Item(Grid1.CurrentRowIndex, 0).ToString.Trim Then
                                                ''''''''''''''''''CAMBIAR EL ESTADO DE NTA CRED

                                                Dim Sql As String

                                                Dim PROCESO As String

                                                Sql = "SP_UPDATE_PEDIDO_VTA_CAB '" & TAB_PEDIDO_CAB.Rows(i)("NUM_PEDIDO").ToString.Trim & "'"
                                                PROCESO = TmpInsertDatos(Sql)
                                                If PROCESO = True Then
                                                    '                                                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodigo.Text & "','UPDATE','TIPODOC','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                                                    TAB_PEDIDO_CAB = CAyuda.ListarDatos("SP_LISTA_PEDIDOCLAROXFECHA  ", codempresa, Me.DateTimePicker1.Value().ToString("dd/MM/yyyy")).Tables(0)

                                                    Grid1.DataSource = TAB_PEDIDO_CAB



                                                End If

                                            End If
                                        Next

                                    End If
                                End If
                            End If
                        End If
                    End If


            End Select
        End If
    End Function
End Class