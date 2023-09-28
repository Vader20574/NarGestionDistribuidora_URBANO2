


Public Class FrmTransferiendoNextel
    Inherits System.Windows.Forms.Form

    Public FechaProcesoCab, FechaProcesoDet, FechaProceso1, Almacen As String
    Public Devolver As Boolean = True

    Dim proceso01 As Boolean
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSFERIENDO  ..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(242, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.Visible = False
        '
        'FrmEnviandoCorreo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(288, 50)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmEnviandoCorreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSFERIENDO"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Button1_Click(sender, e)

    End Sub

    Private Sub FrmCortaTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Timer1.Enabled = False
        Timer1.Stop()

        ' Shell(rutawinrar + " a " + carpeta_xml + "DATABD_SQl_XML.zip" + "  " + carpeta_xml + "*.xml", AppWinStyle.Hide)

        Dim CODPAGADOR As String = ""
        Dim TAB_PEDIDO As New DataTable

        Dim DESC_VENDEDOR As String = ""

        Dim TIPOPRECIO As String = ""
        Dim RUTA As String = ""
        Try

            TAB_PEDIDO = ListarGridPedidosNextel("SP_LISTA_TBL_PEDIDO_2  '" & VCODNEXTEL & "','" & Format(CDate(FechaProcesoCab), "dd/MM/yyyy") & "'")
        Catch ex As Exception
            Devolver = False
        End Try

        If TAB_PEDIDO.Rows.Count > 0 Then
            For x1 As Integer = 0 To TAB_PEDIDO.Rows.Count - 1

                Dim NumeroPedido As String = ""
                Try
                    NumeroPedido = TmpListarDatos("SELECT ISNULL(NROPEDIDO,0) FROM  VENDEDOR   WHERE  CODEMPRESA='" & codempresa & "'  AND CODVEND='" & TAB_PEDIDO.Rows(x1)("VC_CODVENDEDOR") & "'").Rows(0)(0).ToString.Trim


                    Dim TABVEND As DataTable
                    ' TABVEND = CAyuda.ListarDatos("NSP_BUSQVENDEDOR", codempresa, TAB_PEDIDO.Rows(x1)("VC_CODVENDEDOR")).Tables(0)

                    TABVEND = ListarGridPedidosNextel("NSP_BUSQVENDEDOR  '" & codempresa & "','" & TAB_PEDIDO.Rows(x1)("VC_CODVENDEDOR") & "'")



                    If TABVEND.Rows.Count > 0 Then
                        DESC_VENDEDOR = CStr(TABVEND.Rows(0)("VC_APELLIDOS"))
                    End If
                    proceso01 = True
                Catch ex As Exception
                    Devolver = False
                    proceso01 = False
                End Try

                Try

                    Conecta("SP_BUSC_CLIEPRINCIPAL_CODDEP    '" & codempresa & "','" & TAB_PEDIDO.Rows(x1)("VC_CODCLI") & "'", "D")
                    Dim TablaTemp As New DataTable
                    TablaTemp = ds.Tables("D")

                    If TablaTemp.Rows.Count > 0 Then
                        CODPAGADOR = TablaTemp.Rows(0)("CODIGO")
                        TIPOPRECIO = TablaTemp.Rows(0)("CODTIPOPRE")
                        RUTA = TablaTemp.Rows(0)("RUTA")
                    Else
                        CODPAGADOR = TAB_PEDIDO.Rows(x1)("VC_CODCLI")
                    End If

                Catch ex As Exception
                    Devolver = False
                    MsgBox(ex.ToString)
                End Try


                If proceso01 = True Then

                    Dim TAB_PEDIDO_DET As New DataTable
                    Try
                        TAB_PEDIDO_DET = ListarGridPedidosNextel("SP_LISTA_TBL_DETALLE_2  '" & VCODNEXTEL & "','" & Format(CDate(FechaProcesoCab), "dd/MM/yyyy") & "','" & TAB_PEDIDO.Rows(x1)("NMR_CODPEDIDO") & "'")

                    Catch ex As Exception
                        Devolver = False
                        MsgBox(ex.ToString)
                    End Try

                    If TAB_PEDIDO_DET.Rows.Count > 0 Then
                        For x2 As Integer = 0 To TAB_PEDIDO_DET.Rows.Count - 1
                            Try
                                If TAB_PEDIDO_DET.Rows(x2)("MNY_PRECIO") = 0 Then
                                    MsgBox("No Inserto este detalle pedido de nextel con numero " & TAB_PEDIDO.Rows(x1)("NMR_CODPEDIDO") & " por que el Articulo con Codigo " & TAB_PEDIDO_DET.Rows(x2)("VC_CODPROD") & " y Nombre " & TAB_PEDIDO_DET.Rows(x2)("VC_NOMBRE") & " tiene Precio cero ")
                                Else
                                    Dim TABCODPRES As DataTable
                                    TABCODPRES = CAyuda.ListarDatos("NSP_BUSCAR_COD_PRESENTACION", codempresa, TAB_PEDIDO_DET.Rows(x2)("VC_PRESENTACION")).Tables(0)
                                    Dim CODPRES As String = ""
                                    If TABCODPRES.Rows.Count > 0 Then
                                        CODPRES = CStr(TABCODPRES.Rows(0)("CODPRES"))
                                    End If


                                    CAyuda.Ejecutar("InsTMP_PEDIDO_VTA_DETxProc", codempresa, TAB_PEDIDO_DET.Rows(x2)("VC_CODPROD"), TAB_PEDIDO_DET.Rows(x2)("VC_NOMBRE"), TAB_PEDIDO_DET.Rows(x2)("NMR_CANTIDAD"), TAB_PEDIDO_DET.Rows(x2)("MNY_PRECIO"), TAB_PEDIDO_DET.Rows(x2)("MNY_PRECIO"), CODPRES, TAB_PEDIDO_DET.Rows(x2)("VC_PRESENTACION"), TAB_PEDIDO_DET.Rows(x2)("MONEDA"), VCorrelVta, CDZONA, CodUsuario, TIPOPRECIO, TAB_PEDIDO_DET.Rows(x2)("VC_TPAGO"), Format(CDate(TAB_PEDIDO_DET.Rows(x2)("DT_FECHAREGISTRO")), "dd/MM/yyyy"))
                                End If

                            Catch ex As Exception
                                Devolver = False
                                MsgBox(ex.ToString)
                            End Try
                        Next
                    End If




                    Try

                        Dim TABPEDCAB As DataTable
                        TABPEDCAB = CAyuda.ListarDatos("NSP_VERIFICA_PEDIDO_VTA_CAB", NumeroPedido.ToString()).Tables(0)

                        If TABPEDCAB.Rows.Count > 0 Then
                            MsgBox("No inserto por que el numero de pedido generado " & NumeroPedido.ToString() & " ya existe generado por este vendedor con Codigo " & TAB_PEDIDO.Rows(x1)("VC_CODVENDEDOR") & " y Nombre " & DESC_VENDEDOR)
                        Else

                            CAyuda.Ejecutar("NSP_INSERT_PEDIDOVTA_CAB", codempresa, NumeroPedido, TAB_PEDIDO.Rows(x1)("VC_CODCLI"), TAB_PEDIDO.Rows(x1)("DESCLIENTE"), "", RUTA, TAB_PEDIDO.Rows(x1)("VC_CODVENDEDOR"), TAB_PEDIDO.Rows(x1)("DT_FECHAREGISTRO"), "P", TAB_PEDIDO.Rows(x1)("VC_DIRECCION"), TAB_PEDIDO.Rows(x1)("VC_TPAGO"), CODPAGADOR, CodUsuario, VCorrelVta)

                            Dim PROCESAR As New DataTable
                            PROCESAR = ListarGridPedidosNextel("SP_UPD_PROCESADO_TBL_PEDIDO '" & VCODNEXTEL & "','" & FechaProcesoCab & "','" & TAB_PEDIDO.Rows(x1)("NMR_CODPEDIDO") & "'")

                        End If


                    Catch ex As Exception
                        Devolver = False
                        MsgBox(ex.ToString)
                    End Try

                End If


                Try
                    CAyuda.Ejecutar("NSP_DELETE_TMP_PEDIDO_VTA_DET", VCorrelVta)
                Catch ex As Exception
                    Devolver = False
                    MsgBox(ex.ToString)
                End Try

            Next

        End If

        Me.Close()

    End Sub


    Public Sub DeleteFile(ByVal FilePath As String)

        Kill(FilePath$)
        Exit Sub


    End Sub

End Class
