Public Class frmPromoDet
    Dim TMP_VENTADET As DataTable

    Dim rand As Integer



    Public VFecDoc As Date

    Private Sub frmPromoDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("SELECCIONE UN TIPO PROMOCION")
            Exit Sub
        End If


        Dim FRMX As New FrmGridTPromocion

        FRMX.TIPO = ComboBox1.SelectedIndex + 1

        FRMX.vie = Me
        'FRMX.bol = True


      

        FRMX.ShowDialog()

        VFecDoc = FRMX.grid1.Item(FRMX.grid1.CurrentRowIndex, 3)



    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim VentaC, VentD As String
        Dim MesAct, Anio As String
        MesAct = Format(VFecDoc, "MM")
        Anio = Format(VFecDoc, "yyyy")

        VentaC = "VENTC" & Anio & MesAct


        VentD = "VENTD" & Anio & MesAct



        ValorRan()
        Dim FECHAI As String
        FECHAI = String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy")

        Dim FECHAF As String
        FECHAF = String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy")


        TmpInsertDatos("DELETE FROM TMP_DETPROMOS  WHERE CORREL='" & rand & "'")


        If VERIFICA_HISTORICOVENT(VentaC) = True Then
            TmpListarDatos("SP_LISTA_PROMOCIONES  '" & ComboBox1.SelectedIndex + 1 & "','" & txtcodPromo.Text & "','" & FECHAI & "','" & FECHAF & "','" & txtdescPromo.Text & "','" & rand & "','" & VentaC & "','" & VentD & "',1")
        End If
        TmpListarDatos("SP_LISTA_PROMOCIONES  '" & ComboBox1.SelectedIndex + 1 & "','" & txtcodPromo.Text & "','" & FECHAI & "','" & FECHAF & "','" & txtdescPromo.Text & "','" & rand & "','','',0")

        TMP_VENTADET = TmpListarDatos("SP_SELECT_PROMOCIONES  '" & rand & "'")
        Grid1.DataSource = TMP_VENTADET
        FormatoGridDetVta()


        reportes()

    End Sub


    Private Function VERIFICA_HISTORICOVENT(ByVal StrHistorico As String) As Boolean
        Try
            Dim StrSql As String
            Dim rs As New DataTable
            StrSql = " EXEC   VERIFICA_HISTORICOVENT    '" & StrHistorico & "','" & codempresa & "'"
            rs = TmpListarDatos(StrSql)

            If rs.Rows.Count = 0 Then
                VERIFICA_HISTORICOVENT = False
            Else
                VERIFICA_HISTORICOVENT = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " VERIFICA_HISTORICOVENT")
        End Try

    End Function

    Sub reportes()
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_Promodeta.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_StoredProcParam(0, rand)

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub FormatoGridDetVta()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_VENTADET.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "fecdocum"
            .HeaderText = "FECHA"
            .NullText = ""
            .Width = 70
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "dstipodoc"
            .HeaderText = "TIPO DOC"
            .NullText = ""
            .Width = 100
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "nrodocu"
            .HeaderText = "NRO DOC"
            .NullText = ""
            .Width = 70
        End With

        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "cantidad"
            .HeaderText = "CANTIDAD"
            .NullText = ""
            .Width = 50
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "despres"
            .HeaderText = "PRESENT"
            .NullText = ""
            .Format = GMascaraDec(DECICANT)
            .Width = 70
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "precio"
            .HeaderText = "PRECIO"
            .NullText = ""
            .Format = GMascaraDec(DECIPREC)
            .Width = 50
        End With

        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "codarti"
            .HeaderText = "ARTICULO"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Width = 50
        End With
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "promocion"
            .HeaderText = "PROMOCION"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Width = 200
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column8, Column7, Column4, Column5, Column6})
        Grid1.TableStyles.Clear()
        Grid1.TableStyles.Add(TableStyle1)

    End Sub




End Class