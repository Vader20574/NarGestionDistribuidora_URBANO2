Imports System.Data.SqlClient

Public Class frm_gridguia
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents Ds_gridclie21 As mantenimiento.ds_gridclie2
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents talmacen As System.Windows.Forms.TextBox
    Friend WithEvents tcliente As System.Windows.Forms.TextBox
    Friend WithEvents tnroguia As System.Windows.Forms.TextBox
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.talmacen = New System.Windows.Forms.TextBox
        Me.tcliente = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tnroguia = New System.Windows.Forms.TextBox
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        'Me.Ds_gridclie21 = New mantenimiento.ds_gridclie2
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Ds_gridclie21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(432, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Por Fechas"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(120, 48)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker2.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker1.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(16, 50)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(96, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Por Rangos"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(16, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(96, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Todos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.talmacen)
        Me.GroupBox2.Controls.Add(Me.tcliente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tnroguia)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 104)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de Filtro"
        '
        'talmacen
        '
        Me.talmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.talmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.talmacen.Location = New System.Drawing.Point(88, 74)
        Me.talmacen.Name = "talmacen"
        Me.talmacen.Size = New System.Drawing.Size(296, 21)
        Me.talmacen.TabIndex = 6
        Me.talmacen.Text = ""
        '
        'tcliente
        '
        Me.tcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcliente.Location = New System.Drawing.Point(88, 48)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.Size = New System.Drawing.Size(296, 21)
        Me.tcliente.TabIndex = 5
        Me.tcliente.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Almacén :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nro Guía :"
        '
        'tnroguia
        '
        Me.tnroguia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnroguia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnroguia.Location = New System.Drawing.Point(88, 22)
        Me.tnroguia.Name = "tnroguia"
        Me.tnroguia.Size = New System.Drawing.Size(168, 21)
        Me.tnroguia.TabIndex = 2
        Me.tnroguia.Text = ""
        '
        'Grid1
        '
        Me.Grid1.CaptionText = "Registro de Guías"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(16, 120)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(656, 392)
        Me.Grid1.TabIndex = 2
        Me.Grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "cliente"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "codigo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Cliente"
        Me.DataGridTextBoxColumn2.MappingName = "apellidop"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Almacén"
        Me.DataGridTextBoxColumn3.MappingName = "razon"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 140
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn4.MappingName = "ruc"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 72
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Estado"
        Me.DataGridTextBoxColumn5.MappingName = "apellidom"
        Me.DataGridTextBoxColumn5.Width = 50
        '
        'Ds_gridclie21
        '
        'Me.Ds_gridclie21.DataSetName = "ds_gridclie2"
        'Me.Ds_gridclie21.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'frm_gridguia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(688, 525)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_gridguia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta por Guías"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Ds_gridclie21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public AFrmGuiaDir As New FRMGUIADIRECTA
    Public AFrmGuiaTran As New FrmGuiaTransp
    Public ADblNroGuiaTran As Double
    'Public AObjBus As New ClsInterface
    Public Establecer_Almacen As Boolean
    Dim almacen As String


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If Me.RadioButton1.Checked = True Then
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
        Else
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = True
        End If
    End Sub
    Sub CARGARGRILLA()
        Try
            Dim cn As New SqlConnection(STRCN)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()


            Dim cmd As New SqlCommand("sp_TraerGuiasTransportista", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@empresa", codempresa.Trim).SqlDbType = SqlDbType.VarChar
            Dim DT As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(DT)

            Me.Grid1.DataSource = DT
            DataGridTableStyle1.MappingName = DT.TableName
            DataGridTableStyle1.GridColumnStyles(0).MappingName = "codigo"
            DataGridTableStyle1.GridColumnStyles(1).MappingName = "apellidop"
            DataGridTableStyle1.GridColumnStyles(2).MappingName = "razon"
            DataGridTableStyle1.GridColumnStyles(3).MappingName = "ruc"
            DataGridTableStyle1.GridColumnStyles(4).MappingName = "apellidom"

            Me.Grid1.TableStyles.Add(DataGridTableStyle1)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                          ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If Grid1.Focus() = True Then
                        If AFrmGuiaTran.AIntValor = 1 Then
                            PasaDatosGuiaTran()
                        Else
                            pasadatos()
                        End If
                    End If

            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Sub Llena()
        Try

            Dim dt As New DataTable


            Dim AStrFecIni, AStrFecFin As String
            AStrFecIni = Format(Me.DateTimePicker1.Value, "dd/MM/yy") & " 00:00:00"
            AStrFecFin = Format(Me.DateTimePicker2.Value, "dd/MM/yy") & " 23:59:59"

            tnroguia.Focus()
            'Me.Ds_gridclie21.Clear()
            Dim NROGUIA As Integer
            'NROGUIA = IIf(tnroguia.Text = "", 0, tnroguia.Text)
            If NROGUIA <> 0 Then
                'tnroguia.Text = Format(NROGUIA, "0000000")
            End If
            If Establecer_Almacen = True Then
                almacen = Trim(AFrmGuiaDir.calmacen.SelectedValue.ToString())
            Else
                almacen = Trim(AFrmGuiaTran.calmacen.SelectedValue.ToString())
            End If
            If AFrmGuiaTran.AIntValor <> 1 Then

                If Me.RadioButton1.Checked = True Then

                    Conecta("select" _
                   & " LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7)" _
                   & " as codigo,RTRIM(LTRIM(cl.razonsocial))+ ' ' + PATERNO + ' ' + MATERNO + ' ' + NOMBRES as apellidop,a.desalmacen as razon,c.fecha as ruc ,'apellidom'= CASE c.estado when 1 then 'A' when 0 then '' end from guiacab c,cliente cl,almacen a where c.codcliente=cl.codcliente and c.codalmacen=a.codalmacen and c.codempresa='" & codempresa & "' and cl.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "'  and cl.estado=0 and a.estado=0 and LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7) like '" & Me.tnroguia.Text & "%' and cl.razonsocial like '" & Me.tcliente.Text & "%' and a.desalmacen like '" & Me.talmacen.Text & "%' and (cl.razonsocial<>'' or cl.paterno<>'') and c.codalmacen ='" & almacen.ToString & "'", "filtro")

                    oda.Fill(dt)

                    If ds.Tables("filtro").Rows.Count = 0 Then


                        Conecta("select" _
                    & " LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7)" _
                    & " as codigo,(cl.paterno+''+cl.materno+''+cl.nombres) as apellidop,a.desalmacen as razon,c.fecha as ruc from guiacab c,cliente cl,almacen a where c.codcliente=cl.codcliente and c.codalmacen=a.codalmacen and c.codempresa='" & codempresa & "' and cl.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "'  and cl.estado=0 and a.estado=0 and RIGHT(c.nroguia,7) like '" & Me.tnroguia.Text & "%' and (cl.paterno like '" & Me.tcliente.Text & "%' or cl.materno like '" & Me.tcliente.Text & "%' or cl.nombres like '" & Me.tcliente.Text & "%') and a.desalmacen like '" & Me.talmacen.Text & "%' and cl.razonsocial='' and c.codalmacen = '" & almacen.ToString & "'", "filtro2")

                        oda.Fill(dt)
                    Else
                        oda.Fill(dt)
                    End If
                Else

                    If Me.tcliente.Text = "" Then
                        Conecta("select LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7) as codigo,RTRIM(LTRIM(cl.razonsocial))+ ' ' + PATERNO + ' ' + MATERNO + ' ' + NOMBRES as apellidop,a.desalmacen as razon,c.fecha as ruc ,'apellidom'= CASE c.estado when 1 then 'A' when 0 then '' end from guiacab c,cliente cl,almacen a where c.codcliente=cl.codcliente and c.codalmacen=a.codalmacen and c.codempresa='" & codempresa.Trim & "' and cl.codempresa='" & codempresa.Trim & "' and a.codempresa='" & codempresa.Trim & "'  and cl.estado=0 and a.estado=0 and LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7) like '" & Me.tnroguia.Text & "%' and cl.razonsocial like '" & Me.tcliente.Text & "%' and a.desalmacen like '" & Me.talmacen.Text & "%' and (cl.razonsocial<>''OR cl.paterno <> '') and c.fecha >= '" & AStrFecIni & "' and c.fecha <='" & AStrFecFin & "'and c.codalmacen = '" & almacen.ToString & "'", "filtro")
                    Else
                        Conecta("select LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7) as codigo,RTRIM(LTRIM(cl.razonsocial))+ ' ' + PATERNO + ' ' + MATERNO + ' ' + NOMBRES as apellidop,a.desalmacen as razon,c.fecha as ruc ,'apellidom'= CASE c.estado when 1 then 'A' when 0 then '' end from guiacab c,cliente cl,almacen a where c.codcliente=cl.codcliente and c.codalmacen=a.codalmacen and c.codempresa='" & codempresa.Trim & "' and cl.codempresa='" & codempresa.Trim & "' and a.codempresa='" & codempresa.Trim & "'  and cl.estado=0 and a.estado=0 and LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7) like '" & Me.tnroguia.Text & "%' and cl.razonsocial like '" & Me.tcliente.Text & "%' and a.desalmacen like '" & Me.talmacen.Text & "%' and (cl.razonsocial<>''OR cl.paterno <> '') and c.fecha >= '" & AStrFecIni & "' and c.fecha <='" & AStrFecFin & "'and c.codalmacen = '" & almacen.ToString & "'", "filtro")
                    End If
                    If ds.Tables("filtro").Rows.Count = 0 Then

                        Conecta("select" _
                                  & " LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7)" _
                                  & " as codigo,(cl.paterno+' '+cl.materno+', '+cl.nombres) as apellidop,a.desalmacen as razon,c.fecha as ruc from guiacab c,cliente cl,almacen a where c.codcliente=cl.codcliente and c.codalmacen=a.codalmacen and c.codempresa='" & codempresa & "' and cl.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "'   and cl.estado=0 and a.estado=0 and RIGHT(c.nroguia,7) like '" & Me.tnroguia.Text & "%' and (cl.paterno like '" & Me.tcliente.Text & "%' or cl.materno like '" & Me.tcliente.Text & "%' or cl.nombres like '" & Me.tcliente.Text & "%') and a.desalmacen like '" & Me.talmacen.Text & "%' and cl.razonsocial='' and c.fecha >= '" & AStrFecIni & "' and c.fecha <='" & AStrFecFin & "' and c.codalmacen = '" & almacen.ToString & "'", "filtro2")

                        oda.Fill(dt)
                    Else
                        oda.Fill(dt)
                    End If
                End If


                Me.Grid1.DataSource = dt
                DataGridTableStyle1.MappingName = dt.TableName
                DataGridTableStyle1.GridColumnStyles(0).MappingName = "codigo"
                DataGridTableStyle1.GridColumnStyles(1).MappingName = "apellidop"
                DataGridTableStyle1.GridColumnStyles(2).MappingName = "razon"
                DataGridTableStyle1.GridColumnStyles(3).MappingName = "ruc"
                DataGridTableStyle1.GridColumnStyles(4).MappingName = "apellidom"

                Me.Grid1.TableStyles.Add(DataGridTableStyle1)

            Else
                'If Me.RadioButton1.Checked = True Then

                '    Conecta("select" _
                '                 & " LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7)" _
                '                 & " as codigo,cl.razonsocial as apellidop,c.FECH_INI_TRAS as razon,c.fecha as ruc ,'apellidom'= CASE c.estado when 1 then 'A' when 0 then '' end from guiaTranCab c,cliente cl,almacen a where c.codcliente=cl.codcliente and c.codalmacen=a.codalmacen and c.codempresa='" & Codempresa & "' and cl.codempresa='" & Codempresa & "' and a.codempresa='" & Codempresa & "'  and cl.estado=0 and a.estado=0 and RIGHT(c.nroguia,7) like '" & Me.tnroguia.Text & "%' and cl.razonsocial like '" & Me.tcliente.Text & "%' and a.desalmacen like '" & Me.talmacen.Text & "%' and cl.razonsocial<>'' and c.codalmacen = '" & almacen.ToString & "'", "filtro")

                '    oda.Fill(DT)

                '    If ds.Tables("filtro").Rows.Count = 0 Then
                '        Conecta("select" _
                ' & " LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7)" _
                ' & " as codigo,(cl.paterno+''+cl.materno+''+cl.nombres) as apellidop,c.FECH_INI_TRAS as razon,c.fecha as ruc from guiatrancab c,cliente cl,almacen a where c.codcliente=cl.codcliente and c.codalmacen=a.codalmacen and c.codempresa='" & Codempresa & "' and cl.codempresa='" & Codempresa & "' and a.codempresa='" & Codempresa & "'  and cl.estado=0 and a.estado=0 and RIGHT(c.nroguia,7) like '" & Me.tnroguia.Text & "%' and (cl.paterno like '" & Me.tcliente.Text & "%' or cl.materno like '" & Me.tcliente.Text & "%' or cl.nombres like '" & Me.tcliente.Text & "%') and a.desalmacen like '" & Me.talmacen.Text & "%' and cl.razonsocial='' and c.codalmacen = '" & almacen.ToString & "'", "filtro2")

                '        oda.Fill(DT)
                '    Else
                '        oda.Fill(DT)
                '    End If
                'Else
                '    conecta2("select LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7) as codigo,cl.razonsocial as apellidop,c.FECH_INI_TRAS as razon,c.fecha as ruc ,'apellidom'= CASE c.estado when 1 then 'A' when 0 then '' end from guiaTrancab c,cliente cl,almacen a where c.codcliente=cl.codcliente and c.codalmacen=a.codalmacen and c.codempresa='" & Codempresa & "' and cl.codempresa='" & Codempresa & "' and a.codempresa='" & Codempresa & "'  and cl.estado=0 and a.estado=0 and RIGHT(c.nroguia,7) like '" & Me.tnroguia.Text & "%' and cl.razonsocial like '" & Me.tcliente.Text & "%' and a.desalmacen like '" & Me.talmacen.Text & "%' and cl.razonsocial<>'' and c.fecha >= '" & AStrFecIni & "' and c.fecha <='" & AStrFecFin & "' and c.codalmacen = '" & almacen.ToString & "'", "filtro")
                '    oda.Fill(DT)
                '    If ds.Tables("filtro").Rows.Count = 0 Then
                '        Conecta("select" _
                ' & " LEFT(RIGHT('000'+CONVERT(VARCHAR, C.nroguia),10),3)+'-'+RIGHT(RIGHT('000'+CONVERT(VARCHAR, nroguia),10),7)" _
                ' & " as codigo,(cl.paterno+' '+cl.materno+', '+cl.nombres) as apellidop,c.FECH_INI_TRAS as razon,c.fecha as ruc from guiatrancab c,cliente cl,almacen a where c.codcliente=cl.codcliente and c.codalmacen=a.codalmacen and c.codempresa='" & Codempresa & "' and cl.codempresa='" & Codempresa & "' and a.codempresa='" & Codempresa & "'   and cl.estado=0 and a.estado=0 and RIGHT(c.nroguia,7) like '" & Me.tnroguia.Text & "%' and (cl.paterno like '" & Me.tcliente.Text & "%' or cl.materno like '" & Me.tcliente.Text & "%' or cl.nombres like '" & Me.tcliente.Text & "%') and a.desalmacen like '" & Me.talmacen.Text & "%' and cl.razonsocial='' and c.fecha >= '" & AStrFecIni & "' and c.fecha <='" & AStrFecFin & "' and c.codalmacen = '" & almacen.ToString & "'", "filtro2")

                '        oda.Fill(DT)
                '    Else
                '        oda.Fill(DT)
                '    End If
                'End If
                CARGARGRILLA()
            End If





        Catch ex As Exception
            MsgBox("El la caja de almacen de salida esta vacia ,..presione el boton nuevo para volver a cargar", MsgBoxStyle.Information, "Nar Gestion")
        End Try


    End Sub
    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        If AFrmGuiaTran.AIntValor = 1 Then
            PasaDatosGuiaTran()
        Else
            pasadatos()
        End If
        If Establecer_Almacen = True Then
            pasadatos()
        Else
            PasaDatosGuiaTran()
        End If
    End Sub
    Sub pasadatos()
        Try
            VAR1 = Grid1.Item(Grid1.CurrentRowIndex, 0)
            NroGuiaDir = Integer.Parse(Strings.Left(Grid1.Item(Grid1.CurrentRowIndex, 0), 3) & "" & Strings.Right(Grid1.Item(Grid1.CurrentRowIndex, 0), 7))
            Conecta("select FECHA,NROGUIA,codtranspor,CODTIPOPAGOTRANS,NRO_INSCR,rucconductor,marca,fec_initrans,observacion,placa,brevete,destinatario,do_destino,do_partida,desconductor,FECH_INI_TRAS,CAMBIO,codmon,CODTIPOPRE,codvend,cdusuario,codcliente,CODTIPOPAGO,CODALMACEN,distritop,provinciap,distritod,provinciad,codtipoguia,estado ,Nroboleta,RUCCLIENTE,DESCLIENTE,DIRCLIENTE,NRODOCREFACTURA from GUIACAB where codempresa='" & codempresa & "' and nroguia=" & NroGuiaDir & "", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                AFrmGuiaDir.correl = Trim(ds.Tables("llena").Rows(0)("NROGUIA"))
                AFrmGuiaDir.provp = Trim(ds.Tables("llena").Rows(0)(25))
                AFrmGuiaDir.provd = Trim(ds.Tables("llena").Rows(0)(27))
                AFrmGuiaDir.distd = Trim(ds.Tables("llena").Rows(0)(26))
                AFrmGuiaDir.distp = Trim(ds.Tables("llena").Rows(0)(24))

                AFrmGuiaDir.DateTimePicker1.Value = Trim(ds.Tables("llena").Rows(0)(0))
                AFrmGuiaDir.txtnumeroguia.Text = Strings.Right(Trim(ds.Tables("llena").Rows(0)(1)), 7)
                AFrmGuiaDir.txtnumeroguia2.Text = Strings.Left(Strings.Right("000" + ds.Tables("llena").Rows(0)(1), 10), 3)
                AFrmGuiaDir.codtransp = Trim(ds.Tables("llena").Rows(0)(2))
                AFrmGuiaDir.cbotipopago.SelectedValue = Trim(ds.Tables("llena").Rows(0)(3))
                AFrmGuiaDir.nrocert = Trim(ds.Tables("llena").Rows(0)(4))
                AFrmGuiaDir.ructransp = Trim(ds.Tables("llena").Rows(0)(5))
                AFrmGuiaDir.marca = Trim(ds.Tables("llena").Rows(0)(6))
                AFrmGuiaDir.fechatras = Trim(ds.Tables("llena").Rows(0)(7))
                AFrmGuiaDir.obv = Trim(ds.Tables("llena").Rows(0)(8))
                AFrmGuiaDir.placa = Trim(ds.Tables("llena").Rows(0)(9))
                AFrmGuiaDir.brevete = Trim(ds.Tables("llena").Rows(0)(10))
                AFrmGuiaDir.dest = Trim(ds.Tables("llena").Rows(0)(11))
                AFrmGuiaDir.domd = Trim(ds.Tables("llena").Rows(0)(12))
                AFrmGuiaDir.domp = Trim(ds.Tables("llena").Rows(0)(13))
                AFrmGuiaDir.desctransp = Trim(ds.Tables("llena").Rows(0)(14))
                AFrmGuiaDir.txtcambio.Text = Trim(ds.Tables("llena").Rows(0)(16))
                'AFrmGuiaDir.cmoneda.SelectedValue = Trim(ds.Tables("llena").Rows(0)(17))
                AFrmGuiaDir.cbotipopre.SelectedValue = Trim(ds.Tables("llena").Rows(0)(18))
                AFrmGuiaDir.cbovendedor.Enabled = True
                AFrmGuiaDir.cbovendedor.SelectedValue = Trim(ds.Tables("llena").Rows(0)(19))
                AFrmGuiaDir.cbovendedor.Enabled = False
                AFrmGuiaDir.txtcodcliente.Text = Trim(ds.Tables("llena").Rows(0)(21))

                AFrmGuiaDir.cbotipopago.SelectedValue = Trim(ds.Tables("llena").Rows(0)(22))
                AFrmGuiaDir.calmacen.SelectedValue = Trim(ds.Tables("llena").Rows(0)(23))
                AFrmGuiaDir.cbotipodoc.SelectedValue = Trim(ds.Tables("llena").Rows(0)(28))
                AFrmGuiaDir.EstaDocGuiaDir = Trim(ds.Tables("llena").Rows(0)(29))
                AFrmGuiaDir.txtboleta.Text = Trim(ds.Tables("llena").Rows(0)("Nroboleta"))
                '    AFrmGuiaDir.valoriza_tipo()

                AFrmGuiaDir.txtruc.Text = CAyuda.ValidaNullSTring(ds.Tables("llena").Rows(0)("RUCCLIENTE"))
                AFrmGuiaDir.txtdescliente.Text = CAyuda.ValidaNullSTring(ds.Tables("llena").Rows(0)("DESCLIENTE"))
                AFrmGuiaDir.txtdireccion.Text = CAyuda.ValidaNullSTring(ds.Tables("llena").Rows(0)("DIRCLIENTE"))
                AFrmGuiaDir.x = CAyuda.ValidaNullSTring(ds.Tables("llena").Rows(0)("BREVETE"))
                AFrmGuiaDir.txtnumoc1.Text = Strings.Left(CAyuda.ValidaNullSTring(ds.Tables("llena").Rows(0)("NRODOCREFACTURA")), 3)
                AFrmGuiaDir.txtnumoc.Text = Strings.Right(CAyuda.ValidaNullSTring(ds.Tables("llena").Rows(0)("NRODOCREFACTURA")), 7)
                AFrmGuiaDir.BTNGUARDAR.Enabled = False
                AFrmGuiaDir.BTNELIMINAR.Enabled = True

                If CAyuda.ValidaNullSTring(ds.Tables("llena").Rows(0)("DESCLIENTE")) = "" Then
                    AFrmGuiaDir.llenacliente()
                End If

                AFrmGuiaDir.correl = NroGuiaDir




            End If

            'AFrmGuiaDir.grid1.Enabled = True 

            Dim sql As String
            Dim PROCESO As Boolean


            sql = "NSP_ins_guiadet_ATEMP '" & NroGuiaDir & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)

            AFrmGuiaDir.cargagrilla()

            AFrmGuiaDir.btnobs.Enabled = True

            Me.Close()

        Catch x As Exception
            '    MessageBox.Show(x.Message)
        End Try
    End Sub
    Private Sub frm_gridguia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Llena()


    End Sub
    Private Sub tnroguia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnroguia.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Llena()
        End If
    End Sub
    Sub PasaDatosGuiaTran()
        Try
            Dim ATblGuia As New DataTable
            ATblGuia.Clear()
            VAR1 = Grid1.Item(Grid1.CurrentRowIndex, 0)
            'ADblNroGuiaTran = Grid1.Item(Grid1.CurrentRowIndex, 0)
            ADblNroGuiaTran = Integer.Parse(Strings.Left(Grid1.Item(Grid1.CurrentRowIndex, 0), 3) & "" & Strings.Right(Grid1.Item(Grid1.CurrentRowIndex, 0), 7))
            ATblGuia = CAyuda.ListarDatos("NSP_SELECT_LISTAGUIATRANSCAB", codempresa, ADblNroGuiaTran).Tables(0)
            If ATblGuia.Rows.Count > 0 Then


                'AFrmGuiaTran.txtnumeroguia.Text = Trim(ATblGuia.Rows(0)("NROGUIA"))
                AFrmGuiaTran.txtnumeroguia.Text = Strings.Right(ATblGuia.Rows(0)("NROGUIA"), 7)
                AFrmGuiaTran.txtnumeroguia2.Text = Strings.Left(Strings.Right("000" + ATblGuia.Rows(0)("NROGUIA"), 10), 3)
                AFrmGuiaTran.DateTimePicker1.Value = Trim(ATblGuia.Rows(0)("FECHA"))
                AFrmGuiaTran.DateTimePicker2.Value = Trim(ATblGuia.Rows(0)("FECH_INI_TRAS"))
                AFrmGuiaTran.cbotipopre.SelectedValue = ATblGuia.Rows(0)("CODTIPOPRE")
                AFrmGuiaTran.cbotipopago.SelectedValue = Trim(ATblGuia.Rows(0)("CODTIPOPAGO"))
                AFrmGuiaTran.calmacen.SelectedValue = Trim(ATblGuia.Rows(0)("CODALMACEN"))
                AFrmGuiaTran.txtcodcliente.Text = Trim(ATblGuia.Rows(0)("codcliente"))

                'AFrmGuiaTran.cbotipopago.SelectedValue = Trim(ATblGuia.Rows(0)(3))
                AFrmGuiaTran.AStrDomP = Trim(ATblGuia.Rows(0)("Domici_Partida"))
                AFrmGuiaTran.AStrDistP = Trim(ATblGuia.Rows(0)("distritoPart"))
                AFrmGuiaTran.AStrProvP = Trim(ATblGuia.Rows(0)("provinciaPart"))
                AFrmGuiaTran.AStrDomD = Trim(ATblGuia.Rows(0)("Domicio_Destino"))
                AFrmGuiaTran.AStrProvD = Trim(ATblGuia.Rows(0)("ProvinciaDest"))
                AFrmGuiaTran.AStrDistD = Trim(ATblGuia.Rows(0)("distritoDest"))
                AFrmGuiaTran.AStrRemi = Trim(ATblGuia.Rows(0)("Remitente"))
                AFrmGuiaTran.AStrRucRemi = Trim(ATblGuia.Rows(0)("RucRemite"))
                AFrmGuiaTran.AStrDniRemi = Trim(ATblGuia.Rows(0)("DniRemite"))
                AFrmGuiaTran.AStrDestina = Trim(ATblGuia.Rows(0)("Destinatario"))
                AFrmGuiaTran.AStrRucDestina = Trim(ATblGuia.Rows(0)("RucDesti"))
                AFrmGuiaTran.AStrDniDestina = Trim(ATblGuia.Rows(0)("DniDEsti"))
                AFrmGuiaTran.AStrCodtransp = Trim(ATblGuia.Rows(0)("codtranspor"))
                AFrmGuiaTran.AStrRuctransp = Trim(ATblGuia.Rows(0)("rucconductor"))
                AFrmGuiaTran.AStrDesctransp = Trim(ATblGuia.Rows(0)("Desconductor"))
                AFrmGuiaTran.AStrBrevete = Trim(ATblGuia.Rows(0)("brevete"))
                AFrmGuiaTran.AStrMarca = Trim(ATblGuia.Rows(0)("marca"))
                AFrmGuiaTran.AStrPlaca = Trim(ATblGuia.Rows(0)("placa"))
                AFrmGuiaTran.AStrNrocert = Trim(ATblGuia.Rows(0)("NRO_INSCR"))
                AFrmGuiaTran.ABoolEstadoDoc = Trim(ATblGuia.Rows(0)("ESTADO"))
                AFrmGuiaDir.x = Trim(ATblGuia.Rows(0)("brevete"))

                AFrmGuiaTran.AStrConfigVeh = Trim(ATblGuia.Rows(0)("ConfigVeh"))
                AFrmGuiaTran.AStrEmpresaSubCont = Trim(ATblGuia.Rows(0)("EmpresaSubCont"))
                AFrmGuiaTran.AStrRucEmpSubCont = Trim(ATblGuia.Rows(0)("RucEmpSubCont"))
                AFrmGuiaTran.AStrObvs = Trim(ATblGuia.Rows(0)("observacion"))
                AFrmGuiaTran.txtdescliente.Text = Trim(ATblGuia.Rows(0)("Nombre"))
                AFrmGuiaTran.txtruc.Text = Trim(ATblGuia.Rows(0)("ruc"))
                AFrmGuiaTran.txtdireccion.Text = Trim(ATblGuia.Rows(0)("direccion"))
                AFrmGuiaTran.AStrEstadoDoc = Trim(ATblGuia.Rows(0)("ESTADODOC"))
                AFrmGuiaTran.BTNGUARDAR.Enabled = False
                AFrmGuiaTran.BTNELIMINAR.Enabled = True
                AFrmGuiaTran.btnobs.Enabled = True
                AFrmGuiaTran.ATblDet = (CAyuda.ListarDatos("NSP_SELECT_LISTAGUIATRANCPARAM", ADblNroGuiaTran, codempresa).Tables(0))
                AFrmGuiaTran.DTGGUITRAN.DataSource = AFrmGuiaTran.ATblDet
                AFrmGuiaTran.FormatGrid()
            End If
            Me.Close()
        Catch x As Exception
            '    MessageBox.Show(x.Message)
        End Try
    End Sub
    Private Sub frm_gridguia_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.tnroguia.Focus()
    End Sub

    Private Sub tnroguia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tnroguia.TextChanged

    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub

    Private Sub tcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcliente.TextChanged

    End Sub

    Private Sub tcliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Llena()
        End If
    End Sub

    Private Sub talmacen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles talmacen.TextChanged

    End Sub

    Private Sub talmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles talmacen.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Llena()
        End If
    End Sub
End Class
