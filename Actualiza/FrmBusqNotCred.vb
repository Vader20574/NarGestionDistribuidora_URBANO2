Imports System.Data.SqlClient
Imports System.Data
Imports VB = Microsoft.VisualBasic
Public Class FrmBusqNotCred
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents DBListar As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Ds_gridclie21 As NarGestionDistribuidora.ds_gridclie2
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBusqNotCred))
        Me.DBListar = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Ds_gridclie21 = New NarGestionDistribuidora.ds_gridclie2
        CType(Me.DBListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_gridclie21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBListar
        '
        Me.DBListar.DataMember = ""
        Me.DBListar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBListar.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBListar.Location = New System.Drawing.Point(16, 48)
        Me.DBListar.Name = "DBListar"
        Me.DBListar.ReadOnly = True
        Me.DBListar.Size = New System.Drawing.Size(592, 264)
        Me.DBListar.TabIndex = 4
        Me.DBListar.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DBListar
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "cliente"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cliente"
        Me.DataGridTextBoxColumn1.MappingName = "apellidom"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 330
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nro Doc"
        Me.DataGridTextBoxColumn2.MappingName = "nombre"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Estado"
        Me.DataGridTextBoxColumn3.MappingName = "ruc"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "TABLA"
        Me.DataGridTextBoxColumn4.MappingName = "apellidop"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nro Doc:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(472, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 21)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'Ds_gridclie21
        '
        Me.Ds_gridclie21.DataSetName = "ds_gridclie2"
        Me.Ds_gridclie21.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'FrmBusqNotCred
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(626, 320)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DBListar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(632, 352)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(632, 352)
        Me.Name = "FrmBusqNotCred"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Registros de Venta"
        CType(Me.DBListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_gridclie21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public VIE As New FrmNotaCredito
    Public AObjBus As New ClsAyuda
    Public ATbldet As New DataTable
    Public ADblNroR As New Double
    Dim IDCODIGO As Double
    Dim cn As New SqlConnection(STRCN)
    Private Sub FrmBusqNotCred_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Dt As New DataTable

        AboolCargarValor = False
        LimpiarFormularios(Me)
        Me.Ds_gridclie21.cliente.Clear()
        'Guarda("NSP_SELECT_LISTARDOCNOTCRED '" & CDNTACREDP.ToString() & "','" & NROPTOVTA.ToString.Trim & "','" & Format(VIE.dtpfecha.Value, "dd/MM/yy") & "'")
        CAyuda.Ejecutar("NSP_SELECT_LISTARDOCNOTCRED", CDNTACREDP.ToString(), NROPTOVTA.ToString.Trim, Format(VIE.dtpfecha.Value, "dd/MM/yy"))

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()

        Dim da As New SqlDataAdapter("select descliente ,nrodocu ,estado ,tabla  from tmp_buscafact where descliente like '" & Me.TextBox1.Text.Trim.ToUpper & "%' and nrodocu like '" & Me.TextBox2.Text.Trim.ToUpper & "%' order by nrodocu", cn)


        'conecta_AUX("select descliente as apellidom,nrodocu as nombre,estado as ruc,tabla as apellidop from tmp_buscafact where descliente like '" & Me.TextBox1.Text.Trim.ToUpper & "%' and nrodocu like '" & Me.TextBox2.Text.Trim.ToUpper & "%' order by nrodocu", "llena")


        da.Fill(Dt)
        Me.DBListar.DataSource = Dt
        DataGridTableStyle1.MappingName = Dt.TableName
        DataGridTableStyle1.GridColumnStyles(0).MappingName = "DESCLIENTE"
        DataGridTableStyle1.GridColumnStyles(1).MappingName = "NRODOCU"
        DataGridTableStyle1.GridColumnStyles(2).MappingName = "Estado"
        DataGridTableStyle1.GridColumnStyles(3).MappingName = "tabla"
        Me.DBListar.TableStyles.Add(DataGridTableStyle1)

    End Sub


    'Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
    '                             ByVal keyData As Keys) As Boolean
    '    Const WM_KEYDOWN As Integer = &H100
    '    Const WM_SYSKEYDOWN As Integer = &H104
    '    If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
    '        Select Case (keyData)
    '            Case Keys.Enter
    '                If DBListar.Focus = True Then

    '                    'Conecta("select * from TMP_NTACREDDET where codtipodoc='" & TipDocNtaCred.ToString & "' and nrodocu='" & DBListar.Item(DBListar.CurrentRowIndex, 1) & "' and corrnbr='" & VIE.ADblCORRELATIVO & "'", "llena")
    '                    'If ds.Tables("llena").Rows.Count > 0 Then
    '                    '    MessageBox.Show("Registro ya ingresado", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    '    Exit Function
    '                    'End If

    '                    'IDCODIGO = CDbl(DBListar.Item(DBListar.CurrentRowIndex, 1))

    '                    'Tabla = DBListar.Item(DBListar.CurrentRowIndex, 3)
    '                    'AboolCargarValor = True
    '                    'Me.Close()


    '                End If
    '            Case Keys.Escape
    '                Me.Close()
    '        End Select
    '    End If

    '    Return MyBase.ProcessCmdKey(msg, keyData)
    'End Function
    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.GhostWhite
            .MappingName = ATbldet.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Cliente"
            .MappingName = "DESCLIENTE"
            .Width = 235
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Número"
            .MappingName = "NRODOCU"
            .Width = 100
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "Esatdo Doc."
            .MappingName = "Estado"
            .Width = 80
        End With

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3})
        DBListar.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then 'Asc(e.KeyChar) = 13 Then
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            Dim da As New SqlDataAdapter("select descliente ,nrodocu ,estado ,tabla  from tmp_buscafact where descliente like '" & Me.TextBox1.Text.Trim.ToUpper & "%' and nrodocu like '" & Me.TextBox2.Text.Trim.ToUpper & "%' order by nrodocu", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Me.DBListar.DataSource = dt
            'Me.Ds_gridclie21.cliente.Clear()
            'conecta_AUX("select descliente as apellidom,nrodocu as nombre,estado as ruc,tabla as apellidop from tmp_buscafact where descliente like '" & Me.TextBox1.Text.Trim.ToUpper & "%' and nrodocu like '" & Me.TextBox2.Text.Trim.ToUpper & "%' order by nrodocu", "llena")
            'oda.Fill(Me.Ds_gridclie21.cliente)
            'Me.DBListar.Refresh()
            'ocn.Close()
        End If
    End Sub

    Private Sub DBListar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DBListar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Conecta("select * from TMP_NTACREDDET where codtipodoc='" & CDNTACREDP.ToString & "' and nrodocu='" & DBListar.Item(DBListar.CurrentRowIndex, 1) & "' and corrnbr='" & VIE.ADblCORRELATIVO & "'", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                MessageBox.Show("Registro ya ingresado", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            IDCODIGO = CDbl(DBListar.Item(DBListar.CurrentRowIndex, 1))

            Tabla = DBListar.Item(DBListar.CurrentRowIndex, 3)
            AboolCargarValor = True
            Me.Close()

        End If
    End Sub

    Private Sub DBListar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBListar.DoubleClick
        Conecta("select * from TMP_NTACREDDET where codtipodoc='" & CDNTACREDP.ToString & "' and nrodocu='" & DBListar.Item(DBListar.CurrentRowIndex, 1) & "' and corrnbr='" & VIE.ADblCORRELATIVO & "'", "llena")
        If ds.Tables("llena").Rows.Count > 0 Then
            MessageBox.Show("Registro ya ingresado", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        IDCODIGO = CDbl(DBListar.Item(DBListar.CurrentRowIndex, 1))

        Tabla = DBListar.Item(DBListar.CurrentRowIndex, 3)
        AboolCargarValor = True
        Me.Close()

    End Sub
End Class
