Imports System.IO







Public Class Frm_Ventas_EfectVend
    Public RAN As String



    Public fechaini As String

    Public fechahas As String


    Dim listaP As New List(Of Efectividad)

    Dim ruta As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim RptaTrans As Boolean
        RptaTrans = CAyuda.Ejecutar("UPDATE_TMP_REPO_EFECTIVID_VEND_1", TextBox1.Text, TextBox2.Text, TextBox3.Text, CInt(TextBox4.Text), TextBox5.Text, TextBox6.Text, RAN)
        If RptaTrans Then

        End If


        Dim TablaCuotasLinea As New System.Data.DataTable

        TablaCuotasLinea = CAyuda.ListarDatos("SP_SELECT_EFECTIVID_VEND_1", RAN).Tables(0)
        Me.dgvlista.DataSource = TablaCuotasLinea


    End Sub

    Private Sub Frm_Ventas_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim TablaCuotasLinea As New System.Data.DataTable

        TablaCuotasLinea = CAyuda.ListarDatos("SP_SELECT_EFECTIVID_VEND_1", RAN).Tables(0)
        Me.dgvlista.DataSource = TablaCuotasLinea

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvlista.DoubleClick
        Dim indexf As Integer
        indexf = dgvlista.CurrentRow.Index
        TextBox1.Text = Me.dgvlista.Item(0, indexf).Value.ToString.Trim
        TextBox2.Text = Me.dgvlista.Item(1, indexf).Value.ToString.Trim
        TextBox3.Text = Me.dgvlista.Item(2, indexf).Value.ToString.Trim
        TextBox4.Text = Me.dgvlista.Item(3, indexf).Value.ToString.Trim
        TextBox5.Text = Me.dgvlista.Item(4, indexf).Value.ToString.Trim
        TextBox6.Text = Me.dgvlista.Item(5, indexf).Value.ToString.Trim
        TextBox7.Text = Me.dgvlista.Item(6, indexf).Value.ToString.Trim

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Reporte("Reporte_Venta_Efectividad_1.rpt")

    End Sub


    Sub Reporte(ByVal rpt As String)
        'Dim var1, var2 As String
        'If cmbfuerza.SelectedIndex = -1 Then
        '    var1 = "Todos"
        'Else
        '    var1 = cmbfuerza.Text
        'End If

        'If cmbruta.SelectedIndex = -1 Then
        '    var2 = "Todos"
        'Else
        '    var2 = cmbruta.Text
        'End If
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & rpt
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "FechaIni='" & fechaini & "'")
                .set_Formulas(3, "FechaH='" & fechahas & "'")
                .set_Formulas(4, "Fuerza='" & TextBox7.Text & "'")
                .set_Formulas(5, "Ruta='" & VAR2 & "'")
                .set_StoredProcParam(0, RAN)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Dim TablaCuotasLinea As New System.Data.DataTable


        TmpInsertDatos("DELETE FROM TMP_RPT_REPO_EFECTIVID_VEND_1  WHERE CORREL='" & RAN & "'")


        txtruta.Text = ""

        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.ruta = Me.OpenFileDialog1.FileName.ToString
            Me.txtruta.Text = ruta

            Try
                listaP.Clear()
                Dim excel() As String = File.ReadAllLines(ruta.Trim)

                Dim linea() As String

                Dim TipoP As New List(Of String)


                For a As Integer = 0 To excel.Length - 1
                    linea = Split(excel(a), ",")


                    'Dim o As New Efectividad
                    'o.CATEGORIA = linea(0)
                    'o.SUBCATEGORIA = linea(1)
                    'o.PRODUCTO = linea(2)
                    'o.PTOS = IIf(Decimal.TryParse(linea(3), precio) = True, precio, 0)

                    'o.CODVEND = linea(4)
                    'o.DESVEND = linea(5)
                    'o.CORREL = linea(6)

                    'listaP.Add(o)

                    If linea(0) = "" Then
                        TablaCuotasLinea = CAyuda.ListarDatos("SP_SELECT_EFECTIVID_VEND_1", RAN).Tables(0)
                        Me.dgvlista.DataSource = TablaCuotasLinea
                        Exit Sub
                    End If


                    Dim RptaTrans As Boolean
                    RptaTrans = CAyuda.Ejecutar("UPDATE_TMP_REPO_EFECTIVID_VEND_1", linea(0), linea(1), linea(2), CDbl(linea(3)), linea(4), linea(5), linea(6))
                    If RptaTrans Then

                    End If


                Next

                TablaCuotasLinea = CAyuda.ListarDatos("SP_SELECT_EFECTIVID_VEND_1", RAN).Tables(0)
                Me.dgvlista.DataSource = TablaCuotasLinea


            Catch ex As Exception
                MessageBox.Show("- Verifique que el archivo no este en uso y/o" & vbNewLine & " el archivo contenga el formato indicado.", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If

    End Sub
End Class