Public Class frmRptPlanOrdenD1
    Public tipo As Integer = 1

    Dim rand As Integer





    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click







        If txtnumero.Text.Trim.Length = 0 Then
            Exit Sub
        End If



        'DTTABLE = TmpListarDatos("SP_BUSQ_PLANDESC '" & txtnumero.Text.Trim & "'")

        'If DTTABLE.Rows.Count > 0 Then
        '    fecha = CDate(DTTABLE.Rows(0)(1).ToString)

        '    MesAct = Format(fecha, "MM")
        '    Anio = Format(fecha, "yyyy")

        '    VentaC = "VENTC" & Anio & MesAct
        '    VentD = "VENTD" & Anio & MesAct

        '    GUIAC = "GUIAC" & Anio & MesAct
        '    GUIAD = "GUIAD" & Anio & MesAct


        '    CAyuda.Ejecutar("INSERT_TMP_PORCDESC", txtnumero.Text.Trim, VentaC, GUIAD, rand)

        'Else
        '    MsgBox("NO EXISTE LA PLANILLA")
        '    Exit Sub
        'End If


        If tipo = 1 Then
            Try
                With AxCrystalReport1
                    .ReportFileName = RutaRptInv & "Rpt_Plani_Despacho.rpt"
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                    .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                    .set_StoredProcParam(0, codempresa)
                    .set_StoredProcParam(1, txtnumero.Text.Trim)
                    .WindowState = Crystal.WindowStateConstants.crptMaximized
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf tipo = 2 Then
            Try
                With AxCrystalReport1
                    .ReportFileName = RutaRptInv & "Rpt_Plani_DespachoDescF.rpt"
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                    .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                    .set_StoredProcParam(0, codempresa)
                    .set_StoredProcParam(1, txtnumero.Text.Trim)
                    .WindowState = Crystal.WindowStateConstants.crptMaximized
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            If tipo = 5 Then
                Try
                    With AxCrystalReport1
                        .ReportFileName = RutaRptInv & "Rpt_Plan_Pago_Provee.rpt"
                        .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                        .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                        .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                        .set_StoredProcParam(0, codempresa)
                        .set_StoredProcParam(1, txtnumero.Text.Trim)
                        .WindowState = Crystal.WindowStateConstants.crptMaximized
                        .Destination = Crystal.DestinationConstants.crptToWindow
                        .Action = 1
                        .Reset()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf tipo = 4 Then
                Try
                    With AxCrystalReport1
                        .ReportFileName = RutaRptInv & "Rpt_Plan_Ord_Venta.rpt"
                        .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                        .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                        .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                        .set_StoredProcParam(0, codempresa)
                        .set_StoredProcParam(1, txtnumero.Text.Trim)
                        .WindowState = Crystal.WindowStateConstants.crptMaximized
                        .Destination = Crystal.DestinationConstants.crptToWindow
                        .Action = 1
                        .Reset()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf tipo = 3 Then
                Try
                    With AxCrystalReport1
                        .ReportFileName = RutaRptInv & "Rpt_Plan_Ord_Venta.rpt"
                        .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                        .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                        .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                        .set_StoredProcParam(0, codempresa)
                        .set_StoredProcParam(1, txtnumero.Text.Trim)
                        .WindowState = Crystal.WindowStateConstants.crptMaximized
                        .Destination = Crystal.DestinationConstants.crptToWindow
                        .Action = 1
                        .Reset()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else

                Try
                    With AxCrystalReport1
                        .ReportFileName = RutaRptInv & "Rpt_Plan_Ord_Venta_1.rpt"
                        .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                        .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                        .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                        .set_StoredProcParam(0, codempresa)
                        .set_StoredProcParam(1, txtnumero.Text.Trim)
                        .WindowState = Crystal.WindowStateConstants.crptMaximized
                        .Destination = Crystal.DestinationConstants.crptToWindow
                        .Action = 1
                        .Reset()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub frmRptPlanOrdenD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValorRan()
    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function



    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class