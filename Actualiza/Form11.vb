Imports Servicios.Implementacion

Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        '***NORMAL ***************************************************************************************/

        Dim TablaDircli As DataTable
        Dim TB_VALIDAR_FINMES As DataTable
        Dim TB_VALIDAR_VENTAXCOBRAR As DataTable

        TablaDircli = CAyuda.ListarDatos("SP_RECORRER_VENTACABFE", codempresa.Trim, cbTipoDoc.SelectedValue, Me.txtNroDoc1.Text, Me.txtNroDoc2.Text).Tables(0)

        Dim MES As String
        Dim AÑO As String

        If TablaDircli.Rows.Count > 0 Then
            For ContB As Integer = 0 To TablaDircli.Rows.Count - 1
                Dim Sql As String
                Sql = "update_cab_anuFE '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & codempresa & "'"
                If TmpInsertDatos(Sql) = True Then

                    If EMIELECTRONIC = True Then

                        If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "01" Or TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "03" Then

                            Dim LETRADOC As String = ""

                            If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "01" Then
                                LETRADOC = "F"
                            End If
                            If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "03" Then
                                LETRADOC = "B"
                            End If
                            If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "06" Then
                                LETRADOC = "F"
                            End If

                            Dim SERIE2 As String
                            Dim FormatNroDoc As String
                            FormatNroDoc = Format(CDbl(TablaDircli.Rows(ContB)("NRODOCU").ToString), "0##-########")
                            Dim NUMSERIE As String
                            NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                            SERIE2 = LETRADOC + NUMSERIE

                            Dim NRODOCSIN As String
                            NRODOCSIN = CStr(Microsoft.VisualBasic.Right(TablaDircli.Rows(ContB)("NRODOCU").ToString, 8))
                            Dim NRODOCFINAL As String
                            NRODOCFINAL = SERIE2 + "-" + NRODOCSIN

                            Dim gestordetipoNegocio As New GestorDeFacturacionElectronica
                            gestordetipoNegocio.AnularFE(SERIE2, NRODOCSIN, TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim)

                        End If
                    End If
                End If

            Next

        End If


        MsgBox("SE ANULO")
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargaCombo()

    End Sub


    Private Sub CargaCombo()

        CAyuda.CargarDataCombo(cbTipoDoc, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")

    End Sub



End Class