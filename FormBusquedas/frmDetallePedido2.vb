Public Class frmDetallePedido2
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
    Friend WithEvents LblTotalPeso As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblTotalSoles As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgdetalle As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgdetalle = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.LblTotalPeso = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblTotalSoles = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        CType(Me.dgdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgdetalle
        '
        Me.dgdetalle.DataMember = ""
        Me.dgdetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgdetalle.Location = New System.Drawing.Point(3, 16)
        Me.dgdetalle.Name = "dgdetalle"
        Me.dgdetalle.ReadOnly = True
        Me.dgdetalle.Size = New System.Drawing.Size(909, 211)
        Me.dgdetalle.TabIndex = 0
        Me.dgdetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgdetalle
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TABLE"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ITEM"
        Me.DataGridTextBoxColumn1.MappingName = "ITEM"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "ALMACEN"
        Me.DataGridTextBoxColumn2.MappingName = "CODALMACEN"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn3.MappingName = "CODARTI"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "DESCRIPCION"
        Me.DataGridTextBoxColumn4.MappingName = "DESARTI"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "UNIDADES"
        Me.DataGridTextBoxColumn5.MappingName = "UNIDADES"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "PRES. PAQ."
        Me.DataGridTextBoxColumn6.MappingName = "PRESPAQ"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "PRES.UND."
        Me.DataGridTextBoxColumn7.MappingName = "PRESUND"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "PRECIO PROM."
        Me.DataGridTextBoxColumn8.MappingName = "PRECIO"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "PESO PROMED."
        Me.DataGridTextBoxColumn9.MappingName = "PESO"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "UNI.FALT."
        Me.DataGridTextBoxColumn10.MappingName = "UNDFALTANTE"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'LblTotalPeso
        '
        Me.LblTotalPeso.BackColor = System.Drawing.Color.White
        Me.LblTotalPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPeso.Location = New System.Drawing.Point(552, 277)
        Me.LblTotalPeso.Name = "LblTotalPeso"
        Me.LblTotalPeso.Size = New System.Drawing.Size(100, 23)
        Me.LblTotalPeso.TabIndex = 3
        Me.LblTotalPeso.Text = "0.00"
        Me.LblTotalPeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(480, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Peso : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalSoles
        '
        Me.LblTotalSoles.BackColor = System.Drawing.Color.White
        Me.LblTotalSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalSoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSoles.Location = New System.Drawing.Point(816, 277)
        Me.LblTotalSoles.Name = "LblTotalSoles"
        Me.LblTotalSoles.Size = New System.Drawing.Size(100, 23)
        Me.LblTotalSoles.TabIndex = 5
        Me.LblTotalSoles.Text = "0.00"
        Me.LblTotalSoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(704, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Total Soles S/.: "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgdetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(907, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detalle de Pedidos"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(302, 273)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(143, 32)
        Me.btnaceptar.TabIndex = 6
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'frmDetallePedido2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(930, 312)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTotalPeso)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblTotalSoles)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetallePedido2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles"
        CType(Me.dgdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public corre As Integer
    Public pedido As Decimal
    Dim dt As New DataTable

    Dim CODPROMO As String
    Dim CODTIPOPRE As String
    Dim FECHA As String
    Dim TIPOPAGO As String
    Dim CODCLIDEP As String

    Dim dt4 As DataTable
    Dim dt5 As DataTable
    Dim dt6 As DataTable
    Dim dt7 As DataTable
    Dim dt8 As DataTable
    Dim dt9 As DataTable
    Dim dt10 As DataTable
    Dim dt11 As DataTable

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WINKEYdOWN As Integer = &H100
        Const WINKEYSYSTEM As Integer = &H104
        If ((MSG.Msg = WINKEYdOWN) Or (MSG.Msg = WINKEYSYSTEM)) Then
            Select Case (KeyData)
                Case Keys.Enter
                    If dgdetalle.Focus = True Then
                        If dt.Rows.Count > 0 Then
                            If dgdetalle.CurrentCell.ColumnNumber = 0 Then
                                If dgdetalle.CurrentRowIndex > -1 Then
                                    Dim FrmOpciones As New FrmOpciones
                                    FrmOpciones.ShowDialog()
                                    If FrmOpciones.DEVOLVER = True Then
                                        For i As Integer = 0 To dt.Rows.Count - 1
                                            If dt.Rows(i)("NUM_PEDIDO").ToString.Trim = dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim Then
                                                ''''''''''''''''''CAMBIAR EL ESTADO DE NTA CRED



                                                Select Case FrmOpciones.Opcion
                                                    Case 1
                                                        dt.Rows(i)("ESTADO") = "NO"
                                                    Case 2
                                                        dt.Rows(i)("ESTADO") = "SI"
                                                    Case 3
                                                        dt.Rows(i)("ESTADO") = "EN PROCESO"
                                                End Select
                                                'RecalcularMonto()


                                                Dim dt3 As DataTable
                                                dt3 = CAyuda.ListarDatos("SP_SELECT_CABPED", dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim).Tables(0)

                                                If dt3.Rows.Count > 0 Then
                                                    'CODPROMO = dt.Rows(0)("ESTD_APROB").ToString
                                                    CODTIPOPRE = dt3.Rows(0)("CODTIPOPRE").ToString
                                                    FECHA = dt3.Rows(0)("FECHA").ToString
                                                    TIPOPAGO = dt3.Rows(0)("CODTIPOPAGO").ToString
                                                    CODCLIDEP = dt3.Rows(0)("CODCLIENTE").ToString
                                                End If

                                                Dim DT2 As DataTable
                                                DT2 = CAyuda.ListarDatos("SP_CDZONA", dgdetalle.Item(dgdetalle.CurrentRowIndex, 3).ToString.Trim).Tables(0)

                                                Dim ZONA As String = ""
                                                If DT2.Rows.Count > 0 Then
                                                    'CODPROMO = dt.Rows(0)("ESTD_APROB").ToString
                                                    ZONA = DT2.Rows(0)("CDZONA").ToString

                                                End If


                                                dt4 = CAyuda.ListarDatos("SP_VERIFICAR_PROMOCION", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, CInt(dgdetalle.Item(dgdetalle.CurrentRowIndex, 6).ToString.Trim), ZONA, CODCLIDEP).Tables(0)
                                                If dt4.Rows(0)(0).ToString.Trim.Length > 0 Then
                                                    MsgBox("ESE PRODUCTO TIENE PROMOCION NORMAL XTIPOPRE")
                                                End If
                                                If dt4.Rows(0)(1).ToString.Trim.Length > 0 Then
                                                    MsgBox("ESE PRODUCTO TIENE PROMOCION NORMAL XCLIENTE")
                                                End If



                                                dt5 = CAyuda.ListarDatos("SP_VERIFICAR_SUBPROMOCION", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP).Tables(0)

                                                If dt5.Rows(0)(0).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA XTIPOPRE")
                                                End If

                                                If dt5.Rows(0)(1).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA XCLIENTE")
                                                End If



                                                dt6 = CAyuda.ListarDatos("SP_VERIFICAR_PROMODESOLESSIN", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim), ZONA, CODCLIDEP).Tables(0)

                                                If dt6.Rows(0)(0).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SIN ESCALA XTIPOPRE")
                                                End If

                                                If dt6.Rows(0)(1).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SIN ESCALA XCLIENTE")
                                                End If




                                                dt7 = CAyuda.ListarDatos("SP_VERIFICAR_PROMODESOLESCON", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim), ZONA, CODCLIDEP).Tables(0)
                                                If dt7.Rows(0)(0).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION CON ESCALA XTIPOPRE")
                                                End If

                                                If dt7.Rows(0)(1).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION CON ESCALA XCLIENTE")
                                                End If


                                                dt8 = CAyuda.ListarDatos("SP_VERIFICAR_SUBCATPROMSINXSUBCAT", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim)).Tables(0)

                                                If dt8.Rows(0)(0).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA SOLES XTIPOPRE SIN ESCALA POR SUBCATEGORIA")
                                                End If

                                                If dt8.Rows(0)(1).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA SOLES XCLIENTE SIN ESCALA POR SUBCATEGORIA")
                                                End If

                                                dt9 = CAyuda.ListarDatos("SP_VERIFICAR_SUBCATPROMSINXCAT", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim)).Tables(0)

                                                If dt9.Rows(0)(0).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA SOLES XTIPOPRE SIN ESCALA POR CATEGORIA")
                                                End If

                                                If dt9.Rows(0)(1).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA SOLES XCLIENTE SIN ESCALA POR CATEGORIA")
                                                End If


                                                dt10 = CAyuda.ListarDatos("SP_VERIFICAR_SUBCATPROMCONXSUBCAT", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim)).Tables(0)

                                                If dt10.Rows(0)(0).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA SOLES XTIPOPRE CON ESCALA POR SUBCATEGORIA ")
                                                End If

                                                If dt10.Rows(0)(1).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA SOLES XCLIENTE CON ESCALA POR SUBCATEGORIA ")
                                                End If


                                                dt11 = CAyuda.ListarDatos("SP_VERIFICAR_SUBCATPROMCONXCAT", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim)).Tables(0)

                                                If dt11.Rows(0)(0).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA SOLES XTIPOPRE CON ESCALA POR CATEGORIA")
                                                End If

                                                If dt11.Rows(0)(1).ToString.Trim.Length > 0 Then
                                                    MsgBox("PROMOCION SUB CATEGORIA SOLES XCLIENTE CON ESCALA POR CATEGORIA")
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

    Private Sub frmDetallePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tot, tope As Decimal
        dt = CAyuda.ListarDatos("SP_LIST_DET_PEDI2", codempresa, corre, pedido).Tables(0)
        Me.dgdetalle.DataSource = dt
        For Each dr As DataRow In dt.Rows
            tot = tot + dr.Item(10)
            tope = tope + dr.Item(8)
        Next
        LblTotalPeso.Text = Format(tope, "0.00")
        LblTotalSoles.Text = Format(tot, "0.00")
        FORMATO_GRIDDET()



    End Sub

    Private Sub FORMATO_GRIDDET()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = "Table"
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "ITEM"
            .HeaderText = "Item"
            .Width = 35
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODALMACEN"
            .HeaderText = "Almacen"
            .NullText = ""
            .Width = 50
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "CODARTI"
            .HeaderText = "Codigo"
            .Width = 75
        End With
        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "DESARTI"
            .HeaderText = "Descripcion"
            .Width = 200
        End With

        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "UNIDADES"
            .HeaderText = "Unidades"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column6 As New DataGridTextBoxColumn
        With column6
            .MappingName = "PRESPAQ"
            .HeaderText = "Pres. Paq."
            .Width = 120
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column8 As New DataGridTextBoxColumn
        With column8
            .MappingName = "PRESUND"
            .HeaderText = "Pres. Und."
            .Width = 100
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With

        Dim column9 As New DataGridTextBoxColumn
        With column9
            .MappingName = "PRECIO"
            .HeaderText = "Precio Promedio"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column10 As New DataGridTextBoxColumn
        With column10
            .MappingName = "PESO"
            .HeaderText = "Peso Promedio"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column11 As New DataGridTextBoxColumn
        With column11
            .MappingName = "UNDFALTANTE"
            .HeaderText = "Unidades Faltantes"
            .Width = 75
            .NullText = ""
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With

        Dim column12 As New DataGridTextBoxColumn
        With column12
            .MappingName = "TOTBAS"
            .HeaderText = "TOTAL"
            .Alignment = HorizontalAlignment.Right
            .Width = 100
            .Format = GMascaraDec(DECIRESU)
        End With

        Dim column13 As New DataGridTextBoxColumn
        With column13
            .MappingName = "NUM_PEDIDO"
            .HeaderText = "NUM_PEDIDO"
            .Alignment = HorizontalAlignment.Right
            .Width = 100
            .Format = GMascaraDec(DECIRESU)
        End With

        Dim column14 As New DataGridTextBoxColumn
        With column14
            .MappingName = "ESTADO"
            .HeaderText = "ESTADO"
            .Alignment = HorizontalAlignment.Right
            .Width = 100
            .Format = GMascaraDec(DECIRESU)
        End With


        dgdetalle.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column14, column13, column1, column2, column3, column4, column5, column6, column8, column9, column10, column11, column12})
        dgdetalle.TableStyles.Add(TableStyle1)


    End Sub


    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click




        Dim DT2 As DataTable
        DT2 = CAyuda.ListarDatos("SP_CDZONA", dgdetalle.Item(dgdetalle.CurrentRowIndex, 3).ToString.Trim).Tables(0)

        Dim ZONA As String = ""
        If DT2.Rows.Count > 0 Then
            'CODPROMO = dt.Rows(0)("ESTD_APROB").ToString
            ZONA = DT2.Rows(0)("CDZONA").ToString

        End If

        If dt.Rows.Count = 0 Then
            Exit Sub
        End If

        'For i As Integer = 0 To dt.Rows.Count - 1
        '    If dt.Rows(i)("ESTADO").ToString.Trim = "SI" Then
        '        TmpInsertDatos("SP_ELIMINAR_PEDIDO_VTA_DET  '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt.Rows(i)("CODARTI").ToString.Trim & "','" & corre & "'")
        '    End If
        'Next

        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ESTADO").ToString.Trim = "SI" Then


                Dim dt3 As DataTable
                dt3 = CAyuda.ListarDatos("SP_SELECT_CABPED", dt.Rows(i)("NUM_PEDIDO").ToString.Trim).Tables(0)

                If dt3.Rows.Count > 0 Then
                    'CODPROMO = dt.Rows(0)("ESTD_APROB").ToString
                    CODTIPOPRE = dt3.Rows(0)("CODTIPOPRE").ToString
                    FECHA = dt3.Rows(0)("FECHA").ToString
                    TIPOPAGO = dt3.Rows(0)("CODTIPOPAGO").ToString
                    CODCLIDEP = dt3.Rows(0)("CODCLIENTE").ToString
                End If


                dt4 = CAyuda.ListarDatos("SP_VERIFICAR_PROMOCION", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, CInt(dgdetalle.Item(dgdetalle.CurrentRowIndex, 6).ToString.Trim), ZONA, CODCLIDEP).Tables(0)
                dt5 = CAyuda.ListarDatos("SP_VERIFICAR_SUBPROMOCION", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP).Tables(0)
                dt6 = CAyuda.ListarDatos("SP_VERIFICAR_PROMODESOLESSIN", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim), ZONA, CODCLIDEP).Tables(0)
                dt7 = CAyuda.ListarDatos("SP_VERIFICAR_PROMODESOLESCON", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim), ZONA, CODCLIDEP).Tables(0)

                dt8 = CAyuda.ListarDatos("SP_VERIFICAR_SUBCATPROMSINXSUBCAT", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim)).Tables(0)
                dt9 = CAyuda.ListarDatos("SP_VERIFICAR_SUBCATPROMSINXCAT", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim)).Tables(0)
                dt10 = CAyuda.ListarDatos("SP_VERIFICAR_SUBCATPROMCONXSUBCAT", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim)).Tables(0)
                dt11 = CAyuda.ListarDatos("SP_VERIFICAR_SUBCATPROMCONXCAT", codempresa, dgdetalle.Item(dgdetalle.CurrentRowIndex, 4).ToString.Trim, CODTIPOPRE, FECHA, TIPOPAGO, dgdetalle.Item(dgdetalle.CurrentRowIndex, 1).ToString.Trim, ZONA, CODCLIDEP, CDbl(dgdetalle.Item(dgdetalle.CurrentRowIndex, 12).ToString.Trim)).Tables(0)



                TmpInsertDatos("SP_ELIMINAR_PEDIDO_VTA_DET  '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt.Rows(i)("CODARTI").ToString.Trim & "','" & corre & "'")



                If dt4.Rows(0)(0).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_PROMOCION  '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt4.Rows(0)(0).ToString.Trim & "','" & corre & "'")
                End If

                If dt4.Rows(0)(1).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_PROMOCION  '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt4.Rows(0)(1).ToString.Trim & "','" & corre & "'")
                End If

                If dt5.Rows(0)(0).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBPROMOCION  '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt5.Rows(0)(0).ToString.Trim & "','" & CODCLIDEP & "','" & corre & "'")
                End If
                If dt5.Rows(0)(1).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBPROMOCION  '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt5.Rows(0)(1).ToString.Trim & "','" & CODCLIDEP & "','" & corre & "'")
                End If

                If dt6.Rows(0)(0).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_PROMOSOLESSIN  '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt6.Rows(0)(0).ToString.Trim & "','" & corre & "'")
                End If
                If dt6.Rows(0)(1).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_PROMOSOLESSIN  '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt6.Rows(0)(1).ToString.Trim & "','" & corre & "'")
                End If

                If dt7.Rows(0)(0).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_PROMOSOLESCON '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt7.Rows(0)(0).ToString.Trim & "','" & corre & "'")
                End If
                If dt7.Rows(0)(1).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_PROMOSOLESCON '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt7.Rows(0)(1).ToString.Trim & "','" & corre & "'")
                End If



                If dt8.Rows(0)(0).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBCATPROMSINXSUBCAT '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt8.Rows(0)(0).ToString.Trim & "','" & corre & "'")
                End If
                If dt8.Rows(0)(1).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBCATPROMSINXSUBCAT '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt8.Rows(0)(1).ToString.Trim & "','" & corre & "'")
                End If

                If dt9.Rows(0)(0).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBCATPROMSINXCAT '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt9.Rows(0)(0).ToString.Trim & "','" & corre & "'")
                End If
                If dt9.Rows(0)(1).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBCATPROMSINXCAT '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt9.Rows(0)(1).ToString.Trim & "','" & corre & "'")
                End If


                If dt10.Rows(0)(0).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBCATPROMCONXSUBCAT '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt10.Rows(0)(0).ToString.Trim & "','" & corre & "'")
                End If
                If dt10.Rows(0)(1).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBCATPROMCONXSUBCAT '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt10.Rows(0)(1).ToString.Trim & "','" & corre & "'")
                End If


                If dt11.Rows(0)(0).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBCATPROMCONXCAT '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt11.Rows(0)(0).ToString.Trim & "','" & corre & "'")
                End If
                If dt11.Rows(0)(1).ToString.Trim.Length > 0 Then
                    TmpInsertDatos("SP_RECALCULAR_SUBCATPROMCONXCAT '" & codempresa & "','" & dt.Rows(i)("NUM_PEDIDO").ToString.Trim & "','" & dt11.Rows(0)(1).ToString.Trim & "','" & corre & "'")
                End If



            End If
        Next

        Me.Close()

    End Sub

    Private Sub dgdetalle_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgdetalle.Navigate

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
