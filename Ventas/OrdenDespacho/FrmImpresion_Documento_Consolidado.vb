Public Class FrmImpresion_Documento_Consolidado
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenDesp As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnConsolProd As System.Windows.Forms.Button
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents btnConsolClie As System.Windows.Forms.Button
    Friend WithEvents ChkPorPantalla As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpresion_Documento_Consolidado))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtOrdenDesp = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnConsolProd = New System.Windows.Forms.Button
        Me.btnConsolClie = New System.Windows.Forms.Button
        Me.Rpt1 = New AxCrystal.AxCrystalReport
        Me.ChkPorPantalla = New System.Windows.Forms.CheckBox
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nro Orden de Despacho: "
        '
        'txtOrdenDesp
        '
        Me.txtOrdenDesp.Enabled = False
        Me.txtOrdenDesp.Location = New System.Drawing.Point(156, 16)
        Me.txtOrdenDesp.Name = "txtOrdenDesp"
        Me.txtOrdenDesp.Size = New System.Drawing.Size(100, 20)
        Me.txtOrdenDesp.TabIndex = 38
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(264, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(54, 26)
        Me.btnBuscar.TabIndex = 39
        '
        'btnConsolProd
        '
        Me.btnConsolProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsolProd.Location = New System.Drawing.Point(54, 52)
        Me.btnConsolProd.Name = "btnConsolProd"
        Me.btnConsolProd.Size = New System.Drawing.Size(202, 44)
        Me.btnConsolProd.TabIndex = 40
        Me.btnConsolProd.Text = "Imprimir consolidado de Producto"
        '
        'btnConsolClie
        '
        Me.btnConsolClie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsolClie.Location = New System.Drawing.Point(54, 102)
        Me.btnConsolClie.Name = "btnConsolClie"
        Me.btnConsolClie.Size = New System.Drawing.Size(202, 44)
        Me.btnConsolClie.TabIndex = 41
        Me.btnConsolClie.Text = "Imprimir consolidado de Cliente"
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(284, 150)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 42
        '
        'ChkPorPantalla
        '
        Me.ChkPorPantalla.Checked = True
        Me.ChkPorPantalla.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPorPantalla.Location = New System.Drawing.Point(6, 162)
        Me.ChkPorPantalla.Name = "ChkPorPantalla"
        Me.ChkPorPantalla.Size = New System.Drawing.Size(104, 24)
        Me.ChkPorPantalla.TabIndex = 43
        Me.ChkPorPantalla.Text = "Por Pantalla"
        '
        'FrmImpresion_Documento_Consolidado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(511, 190)
        Me.Controls.Add(Me.ChkPorPantalla)
        Me.Controls.Add(Me.Rpt1)
        Me.Controls.Add(Me.btnConsolClie)
        Me.Controls.Add(Me.btnConsolProd)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtOrdenDesp)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmImpresion_Documento_Consolidado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Consolidado"
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Dim rand As Integer
    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub FrmImpresion_Documento_Consolidado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ValorRan()

    End Sub
#Region "FUNCIONES"


    Dim fecha As Date

    Dim GUIAD As String
    Dim GUIAC As String
    Sub CargarReporte()

        If TmpInsertDatos("NSP_INS_TMP_REPORTCONSOLPROD  '" & codempresa & "','" & txtOrdenDesp.Text.Trim & "'") = False Then
            MsgBox("ERROR EN LA CONSULTA..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
        End If

        Exit Sub


        'Dim TABLE_CONSOL As New DataTable
        'Dim TABLE_CONSOLCAB As New DataTable
        'Dim TABLE_RUTA As New DataTable
        'Dim TABLEMAX As New DataTable
        'Dim UndPed As Double
        'Dim ResultMax, ResultMin As Double
        'Dim Residuo As Double
        'Dim EquiMax As Double
        'Dim Despres As String
        'Dim FechaDoc, FecSalida, HoraSalida, Transportista, Chofer, Ayudante As String
        'Dim Destino As String = ""
        'Dim CantPaquete, CantUND As String

        'TABLE_CONSOL = TmpListarDatos("NSP_LISTAR_PEDIDOS_UND2   '" & codempresa & "','" & txtOrdenDesp.Text.Trim & "','" & NROPTOVTA & "' ")
        'TABLE_CONSOLCAB = TmpListarDatos("NSP_LISTAR_ORDEN_DESPACHO2  '" & codempresa & "','" & txtOrdenDesp.Text.Trim & "'")

        'If TABLE_CONSOL.Rows.Count = 0 Then
        '    MsgBox("No se encontraron Datos de la orden de Despacho..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        '    Exit Sub
        'End If
        'TABLE_RUTA = TmpListarDatos("NSP_LISTAR_RUTA_DESPACHO  '" & codempresa & "','" & txtOrdenDesp.Text.Trim & "'")

        'For i As Integer = 0 To TABLE_RUTA.Rows.Count - 1
        '    If Destino.Trim = "" Then
        '        Destino = TABLE_RUTA.Rows(i)("DESCRIPCION").tostring.Trim
        '    Else
        '        Destino = Destino & " / " & TABLE_RUTA.Rows(i)("DESCRIPCION").tostring.Trim
        '    End If
        'Next
        'FechaDoc = Format(CDate(TABLE_CONSOLCAB.Rows(0)("FECDOCUM").ToString.Trim), "dd/MM/yyyy")
        'FecSalida = Format(CDate(TABLE_CONSOLCAB.Rows(0)("FECDESPACHO").ToString.Trim), "dd/MM/yyyy")
        'HoraSalida = Format(CDate(TABLE_CONSOLCAB.Rows(0)("HORASALIDA").ToString.Trim), "dd/MM/yyyy hh:mm:ss")
        'Transportista = TABLE_CONSOLCAB.Rows(0)("TRANSPORTISTA").ToString.Trim
        'Chofer = TABLE_CONSOLCAB.Rows(0)("CHOFER").ToString.Trim
        'Ayudante = TABLE_CONSOLCAB.Rows(0)("AYUDANTE").ToString.Trim

        'TmpInsertDatos("DELETE  FROM TMP_REPORT_CONSOL_PRODUCTO WHERE CODEMPRESA='" & codempresa & "' AND NRODESPACHO='" & txtOrdenDesp.Text.Trim & "'")
        'For i As Integer = 0 To TABLE_CONSOL.Rows.Count - 1
        '    If CDbl(TABLE_CONSOL.Rows(i)("UNIDADES").ToString.Trim) > 0 Then
        '        TABLEMAX = TmpListarDatos("NSP_MAX_EQUIVALENTE  '" & codempresa & "','" & TABLE_CONSOL.Rows(i)("CODARTI").ToString.Trim & "','" & TABLE_CONSOL.Rows(i)("UNIDADES").ToString.Trim & "'")
        '        If TABLEMAX.Rows.Count > 0 Then
        '            UndPed = CInt(TABLE_CONSOL.Rows(i)("UNIDADES").ToString.Trim)
        '            Despres = TABLEMAX.Rows(0)("DESPRES").ToString.Trim
        '            If TABLEMAX.Rows.Count > 0 Then
        '                EquiMax = TABLEMAX.Rows(0)("EQUIVALENCIA").ToString.Trim
        '            Else
        '                EquiMax = 0
        '            End If
        '            Dim max() As String
        '            max = CStr((UndPed / EquiMax)).Split(".")
        '            ResultMax = max.GetValue(0)
        '            CantPaquete = ResultMax & "  " & TABLEMAX.Rows(0)("DESPRES").ToString.Trim
        '            ResultMin = (UndPed - (ResultMax * EquiMax))
        '            If ResultMin > 0 Then
        '                TABLEMAX = TmpListarDatos("NSP_MIN_EQUIVALENTE  '" & codempresa & "','" & TABLE_CONSOL.Rows(i)("CODARTI").ToString.Trim & "','" & ResultMin & "'")
        '                CantUND = ResultMin & "  " & TABLEMAX.Rows(0)("DESPRES").ToString.Trim
        '            Else
        '                CantUND = ""
        '            End If

        '        End If
        '        TmpInsertDatos("NSP_INSERT_TMPREPORTCONSOLPROD   '" & codempresa & "','" & txtOrdenDesp.Text.Trim & "','" & FechaDoc & "','" & FecSalida & "','" & HoraSalida & "' ,'" & Destino & "','" & Transportista & "','" & Chofer & "','" & Ayudante & "','" & TABLE_CONSOL.Rows(i)("CODALMACEN").tostring.Trim & "','" & TABLE_CONSOL.Rows(i)("CODARTI").tostring.Trim & "','" & TABLE_CONSOL.Rows(i)("DESARTI").tostring.Trim & "','" & TABLE_CONSOL.Rows(i)("UNIDADES").tostring.Trim & "',  '" & CantPaquete & "','" & CantUND & "' ,'" & TABLE_CONSOL.Rows(i)("TOTBAS").tostring.Trim & "','" & TABLE_CONSOL.Rows(i)("PESO").tostring.Trim & "' ")
        '    End If

        'Next
    End Sub





#End Region

    Private Sub btnConsolProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsolProd.Click

        If txtOrdenDesp.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL NUMERO DE ORDEN DE DESPACHO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            txtOrdenDesp.Focus()
            Exit Sub
        End If
        'CargarReporte()
        '------------------------------------

        If GUIAC = "" Then
            GUIAC = "0"
        End If

        If GUIAD = "" Then
            GUIAD = "0"
        End If

        Dim ORDENDESPACHO As String
        ORDENDESPACHO = txtOrdenDesp.Text
        Try
            Rpt1.WindowShowExportBtn = True
            Rpt1.WindowShowPrintBtn = True
            Rpt1.WindowShowPrintSetupBtn = True
            Rpt1.set_StoredProcParam(0, codempresa)
            Rpt1.set_StoredProcParam(1, ORDENDESPACHO)
            Rpt1.set_StoredProcParam(2, 1)
            Rpt1.set_StoredProcParam(3, GUIAC)
            Rpt1.set_StoredProcParam(4, GUIAD)

            Rpt1.set_Formulas(0, "Empresa='" & fecha & "'")
            Rpt1.ReportFileName = rutareporte + CType("Rpt_Consolidado_Producto.rpt", String)
            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            If ChkPorPantalla.CheckState = CheckState.Unchecked Then
                Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
            Else
                Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            End If
            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
            Rpt1.Action = 1
            Rpt1.Reset()
            'TmpListarDatos("NSP_UPDATE_IMPCONSOL_ORDEN_DESPACHO   'Rpt_Consolidado_Producto" & codempresa & "' , '" & txtOrdenDesp.Text.Trim & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub


    Private Sub btnConsolClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsolClie.Click

        If txtOrdenDesp.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL NUMERO DE ORDEN DE DESPACHO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            txtOrdenDesp.Focus()
            Exit Sub
        End If

        If GUIAC = "" Then
            GUIAC = "0"
        End If

        If GUIAD = "" Then
            GUIAD = "0"
        End If

        Dim ORDENDESPACHO As String
        ORDENDESPACHO = txtOrdenDesp.Text

        Dim VentaC, VentD As String
        Dim MesAct, Anio As String
        MesAct = Format(fecha, "MM")
        Anio = Format(fecha, "yyyy")

        VentaC = "VENTC" & Anio & MesAct
        VentD = "VENTD" & Anio & MesAct

        TmpInsertDatos("DELETE FROM TMP_SUMXTIPOPAGO WHERE CORREL=" & rand.ToString)
        If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", VentaC, codempresa).Tables(0).Rows.Count > 0 Then
            CAyuda.Ejecutar("INSERT_TMP_SUMXTIPOPAGO", ORDENDESPACHO, VentaC, rand, 1)
        End If


        CAyuda.Ejecutar("INSERT_TMP_SUMXTIPOPAGO", ORDENDESPACHO, VentaC, rand, 0)
        CAyuda.Ejecutar("INSERT_TMP_PORCDESC", ORDENDESPACHO, VentaC, GUIAD, rand)
        CAyuda.Ejecutar("SP_INS_TMP_CANTCLIEDEP", codempresa, ORDENDESPACHO, rand, GUIAD)
        CAyuda.Ejecutar("SP_INS_TMP_CANTCLIEPRI", codempresa, ORDENDESPACHO, rand, GUIAD)




        If TIPODESC = True Then
            TmpInsertDatos("DELETE FROM TMP_CONSOLIDADOS_CLIENTES WHERE CORREL=" & rand.ToString)
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", VentaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("NSP_INSERT_CONSOLIDADOS_CLIENTE", codempresa, ORDENDESPACHO, 1, PORCDESC, rand, VentaC, VentD, GUIAC, GUIAD, 1)
            End If
            CAyuda.Ejecutar("NSP_INSERT_CONSOLIDADOS_CLIENTE", codempresa, ORDENDESPACHO, 1, PORCDESC, rand, VentaC, VentD, GUIAC, GUIAD, 0)

            Try
                Rpt1.WindowShowExportBtn = True
                Rpt1.WindowShowPrintBtn = True
                Rpt1.WindowShowPrintSetupBtn = True
                Rpt1.set_StoredProcParam(0, rand)

                Rpt1.ReportFileName = rutareporte + CType("Rpt_Consolidado_Cliente.rpt", String)
                Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

                If ChkPorPantalla.CheckState = CheckState.Unchecked Then
                    Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
                Else
                    Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
                End If
                Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
                Rpt1.Action = 1
                Rpt1.Reset()
                'TmpListarDatos("NSP_UPDATE_IMPCONSOL_ORDEN_DESPACHO   '" & codempresa & "' , '" & txtOrdenDesp.Text.Trim & "'")

            Catch ex As Exception
                MsgBox(ex.Message)
                MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If


        If TIPODESC = False Then
            TmpInsertDatos("DELETE FROM TMP_CONSOLIDADOS_CLIENTES WHERE CORREL=" & rand.ToString)
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", VentaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("NSP_INSERT_CONSOLIDADOS_CLIENTE3", codempresa, ORDENDESPACHO, 1, PORCDESC, rand, VentaC, VentD, GUIAC, GUIAD, 1)
            End If
            CAyuda.Ejecutar("NSP_INSERT_CONSOLIDADOS_CLIENTE3", codempresa, ORDENDESPACHO, 1, PORCDESC, rand, VentaC, VentD, GUIAC, GUIAD, 0)


            Try
                Rpt1.WindowShowExportBtn = True
                Rpt1.WindowShowPrintBtn = True
                Rpt1.WindowShowPrintSetupBtn = True
                Rpt1.set_StoredProcParam(0, rand)

                Rpt1.ReportFileName = rutareporte + CType("Rpt_Consolidado_Cliente2.rpt", String)
                Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

                If ChkPorPantalla.CheckState = CheckState.Unchecked Then
                    Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
                Else
                    Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
                End If
                Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
                Rpt1.Action = 1
                Rpt1.Reset()
                'TmpListarDatos("NSP_UPDATE_IMPCONSOL_ORDEN_DESPACHO   '" & codempresa & "' , '" & txtOrdenDesp.Text.Trim & "'")

            Catch ex As Exception
                MsgBox(ex.Message)
                MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim o As New FrmBusquedaDeOrdenDespacho2
        o.TIPO = "F"
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        txtOrdenDesp.Text = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        fecha = CDate(o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 0))
        GUIAC = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 4)
        GUIAD = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 5)

    End Sub

End Class
