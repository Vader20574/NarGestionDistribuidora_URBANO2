
Public Class frmBusPlanillaOrden
    Dim dt As New DataTable
    Dim ListaP As New List(Of PlanillaOrdenE)
    Public Nro As Integer
    Public Devuelve As Boolean

    Private Sub frmBusPlanillaOrden_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()
    End Sub

    Private Sub frmBusPlanillaOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = CAyuda.ListarDatos("SP_BUS_PLANIORDEN", codempresa).Tables(0)
        Dim oPla As PlanillaOrdenE
        For Each fila As DataRow In dt.Rows
            oPla = New PlanillaOrdenE
            oPla.NroPlanilla = CType(fila(0), Integer)
            oPla.Fecha = CType(fila(1), Date)
            oPla.TotalBas = CType(fila(2), Double)
            ListaP.Add(oPla)
        Next

        Me.dgvlista.DataSource = ListaP
    End Sub

    Public Function Buscar_Planilla(ByVal o As PlanillaOrdenE) As Boolean
        If o.NroPlanilla = Me.txtOrdenDespacho.Text.Trim Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        If DtIni.Checked = True And dtFin.Checked = True Then
            Me.dgvlista.DataSource = ListaP.FindAll(AddressOf Buscar_Fecha)
        End If
    End Sub
    Private Function Buscar_Fecha(ByVal o As PlanillaOrdenE) As Boolean
        If o.Fecha > DtIni.Value And o.Fecha < dtFin.Value Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtOrdenDespacho_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrdenDespacho.TextChanged
        If txtOrdenDespacho.Text.Trim.Length <> 0 Then
            Me.dgvlista.DataSource = ListaP.FindAll(AddressOf Buscar_Planilla)
        Else
            Me.dgvlista.DataSource = ListaP
        End If
    End Sub

    Private Sub dgvlista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvlista.DoubleClick
        Nro = CType(Me.dgvlista.Item(0, Me.dgvlista.CurrentRow.Index).Value, Integer)
        Me.Devuelve = True
        Me.Close()
    End Sub


    Private Sub txtOrdenDespacho_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrdenDespacho.KeyDown
        If e.KeyCode = Keys.Enter Then
            Nro = CType(Me.dgvlista.Item(0, Me.dgvlista.CurrentRow.Index).Value, Integer)
            Me.Devuelve = True
            Me.Close()
        End If
    End Sub
End Class