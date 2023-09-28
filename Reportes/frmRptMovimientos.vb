Public Class frmRptMovimientos
    Dim nromeses As Integer
    Dim fechaini, fechahas As String
    Private Sub frmRptMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt_tipom As New DataTable
        'dt_tipom = CAyuda.ListarDatos("Nsp_Sele_tipomovi", codempresa).Tables(0)
        Dim dr As DataRow

        'dr = dt_tipom.NewRow
        'dr.Item(0) = ""
        'dr.Item(1) = ">> TODOS <<"
        'dt_tipom.Rows.InsertAt(dr, 0)

        'Me.cmbtipomov.DataSource = dt_tipom
        'cmbtipomov.DisplayMember = "descripción"
        'cmbtipomov.ValueMember = "código"

        dt_tipom = New DataTable
        dt_tipom.Columns.Add("CODIGO", GetType(System.String))
        dt_tipom.Columns.Add("TIPO", GetType(System.String))

        dr = dt_tipom.NewRow
        dr.Item(0) = "3"
        dr.Item(1) = "PRODUCCION"
        dt_tipom.Rows.Add(dr)

        dr = dt_tipom.NewRow
        dr.Item(0) = "2"
        dr.Item(1) = "TRASLADO"
        dt_tipom.Rows.Add(dr)

        dr = dt_tipom.NewRow
        dr.Item(0) = "1"
        dr.Item(1) = "INGRESOS"
        dt_tipom.Rows.Add(dr)

        dr = dt_tipom.NewRow
        dr.Item(0) = "0"
        dr.Item(1) = "SALIDAS"
        dt_tipom.Rows.Add(dr)

        cmbmovi.DataSource = dt_tipom
        cmbmovi.DisplayMember = "TIPO"
        cmbmovi.ValueMember = "CODIGO"


        CAyuda.CargarDataCombo(Me.cmbalmacen, "USP_LLENAR_ALMACEN   '" & codempresa & "'", "Codigo", "Descripcion")

        cmbmovi.SelectedIndex = 0
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If CDate(dtpfinicio.Value.ToShortDateString) > CDate(dtpfin.Value.ToShortDateString) Then
            MsgBox("Fecha fuera de Rango.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        fechaini = dtpfinicio.Value.ToShortDateString & " 00:00:00"
        fechahas = dtpfin.Value.ToShortDateString & " 23:59:00"

        If TipoDocEBindingSource1.Count = 0 Then
            MsgBox("No hay Movimientos.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        Dim tipodoc As String = ""
        If TipoDocEBindingSource.Count <> 0 Then
            For Each o As TipoDocE In TipoDocEBindingSource1.List
                If tipodoc.Trim.Length = 0 Then
                    tipodoc = "'" & o.CODIGO & "'"
                Else
                    tipodoc = tipodoc & ",'" & o.CODIGO & "'"
                End If
            Next

        End If



        nromeses = DateDiff(DateInterval.Month, dtpfinicio.Value, dtpfin.Value)
        Dim NomTablaC, NomTablaD As String
        For i As Integer = 0 To nromeses

            NomTablaC = "MOVIC" & Format(DateAdd(DateInterval.Month, i, dtpfinicio.Value), "yyyyMM")
            NomTablaD = "MOVID" & Format(DateAdd(DateInterval.Month, i, dtpfin.Value), "yyyyMM")

            If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & NomTablaC & "'").Rows.Count <> 0 Then
                CAyuda.Ejecutar("SP_RPT_TIPOMOV", codempresa, cmbmovi.SelectedValue.ToString, Trim(tipodoc), cmbalmacen.SelectedValue.ToString, fechaini, fechahas, NomTablaC)
            End If
        Next
        CAyuda.Ejecutar("SP_RPT_TIPOMOV", codempresa, cmbmovi.SelectedValue.ToString, Trim(tipodoc), cmbalmacen.SelectedValue.ToString, fechaini, fechahas, "")

        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_Movimientos.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Almacen='" & Me.cmbalmacen.Text & "'")
                .set_Formulas(1, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(2, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                .set_Formulas(3, "FechaIni='" & dtpfinicio.Value.ToShortDateString & "'")
                '.set_Formulas(4, "TipoM='" & Me.cmbtipomov.Text & "'")
                .set_Formulas(5, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btndtodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndtodo.Click
        For Each var As TipoDocE In TipoDocEBindingSource.List
            TipoDocEBindingSource1.Add(var)
        Next
        TipoDocEBindingSource.Clear()
    End Sub

    Private Sub btndpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndpass.Click
        If TipoDocEBindingSource.Count = 0 Then Exit Sub
        TipoDocEBindingSource1.Add(TipoDocEBindingSource.Current)
        TipoDocEBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnipass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnipass.Click
        If TipoDocEBindingSource1.Count = 0 Then Exit Sub
        TipoDocEBindingSource.Add(TipoDocEBindingSource1.Current)
        TipoDocEBindingSource1.RemoveCurrent()

    End Sub

    Private Sub btnizpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnizpass.Click
        For Each var As TipoDocE In TipoDocEBindingSource1.List
            TipoDocEBindingSource.Add(var)
        Next
        TipoDocEBindingSource1.Clear()
    End Sub


    Private Sub cmbmovi_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmovi.SelectionChangeCommitted
        Dim dt As New DataTable
        dt = TmpListarDatos("SP_LIST_TIPOMOVBY '" & codempresa & "','" & CInt(cmbmovi.SelectedValue) & "'")
        TipoDocEBindingSource.Clear()
        TipoDocEBindingSource1.Clear()
        For Each dr As DataRow In dt.Rows
            TipoDocEBindingSource.Add(New TipoDocE(dr.Item(0), dr.Item(1)))
        Next
    End Sub
End Class