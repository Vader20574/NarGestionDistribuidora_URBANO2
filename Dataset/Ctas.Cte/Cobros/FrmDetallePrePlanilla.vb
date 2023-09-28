Public Class FrmDetallePrePlanilla
    Dim dt As DataTable
    Public nropreplan As Integer


    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = CAyuda.ListarDatos("SP_SELECT_DETALLEPREPLAN", codempresa, nropreplan).Tables(0)
        Me.dgdetalle.DataSource = dt

        FORMATO_GRIDDET()

    End Sub

    Private Sub dgdetalle_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgdetalle.Navigate

    End Sub


    Private Sub FORMATO_GRIDDET()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = "Table"
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODTIPODOC"
            .HeaderText = "CodtipoDoc"
            .Width = 75
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "NRODOCU"
            .HeaderText = "Nrodoc"
            .NullText = ""
            .Width = 75
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "TOTCREDBAS"
            .HeaderText = "Total"
            .Width = 75
        End With
        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "SALDOBAS"
            .HeaderText = "Saldo"
            .Width = 75
        End With

        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "PAGCREDBAS"
            .HeaderText = "Pago"
            .Width = 75

        End With
      
        dgdetalle.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5})
        dgdetalle.TableStyles.Add(TableStyle1)


    End Sub






End Class