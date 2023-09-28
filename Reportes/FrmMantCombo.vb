Public Class FrmMantCombo


    Public TablaCuotasLinea As New DataTable

    Dim FLAG As Integer
    Dim estado As Boolean

    Private Sub FrmMantCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    
        Call Bloqueatextbox(Me)
        Call botones(True, False, False, False, True)



        cboPeriodo.Items.Add("ENERO")
        cboPeriodo.Items.Add("FEBRERO")
        cboPeriodo.Items.Add("MARZO")
        cboPeriodo.Items.Add("ABRIL")
        cboPeriodo.Items.Add("MAYO")
        cboPeriodo.Items.Add("JUNIO")
        cboPeriodo.Items.Add("JULIO")
        cboPeriodo.Items.Add("AGOSTO")
        cboPeriodo.Items.Add("SEPTIEMBRE")
        cboPeriodo.Items.Add("OCTUBRE")
        cboPeriodo.Items.Add("NOVIEMBRE")
        cboPeriodo.Items.Add("DICIEMBRE")
        cboPeriodo.SelectedIndex = Date.Now.Month - 1

        txtEjercicio.Text = Date.Now.Year

    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)

        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR

    End Sub





    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If txtcodCombo.Text.Length = 0 Then
            MessageBox.Show("debe ingresar un codigo", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcodCombo.Focus()
            Exit Sub
        End If


        Dim TablaCuotasLinea1 As DataTable

        TablaCuotasLinea1 = CAyuda.ListarDatos("NSP_BUSQ_TMP_COMBOXARTICULO", codempresa, txtcodCombo.Text.Trim.Trim, TextBox1.Text).Tables(0)
        If TablaCuotasLinea1.Rows.Count > 0 Then
            MessageBox.Show("EL Articulo ya existe en Combo", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim TB_MAXITEM As DataTable
        Dim Minpresentacion As String
        TB_MAXITEM = TmpListarDatos("sp_Busp_minpres '" & codempresa & "','" & TextBox1.Text & "'")
        ' Dim ITEM As Integer

        Minpresentacion = TB_MAXITEM.Rows(0)(2).ToString


        Dim RptaTrans As Boolean
        RptaTrans = CAyuda.Ejecutar("NSP_ins_TMP_COMBOXARTICULO", codempresa, txtcodCombo.Text.Trim, TextBox1.Text, Minpresentacion, txtCant.Text)
        If RptaTrans Then

        End If

        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TMP_COMBOXARTICULO", codempresa, txtcodCombo.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()


    End Sub



    Public Sub FORMATO_GRID()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TablaCuotasLinea.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODARTI"
            .HeaderText = "CODARTI"
            .Width = 50
        End With


        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "DESARTI"
            .HeaderText = "DESARTI"
            .Width = 50
        End With



        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "MNPRESENT"
            .HeaderText = "MNPRESENT"
            .Width = 50
        End With


        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "CANTIDAD"
            .HeaderText = "CANTIDAD"
            .Width = 50
        End With


    
        dgCuotaLinea.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4})
        dgCuotaLinea.TableStyles.Add(TableStyle1)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub cboarticulo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If FLAG = 1 Then
        '    Dim TB_MAXITEM As DataTable

        '    TB_MAXITEM = TmpListarDatos("sp_Busp_minpres '" & codempresa & "','" & cboarticulo.SelectedValue & "'")
        '    Dim ITEM As Integer

        '    lblMinpresentacion.Text = TB_MAXITEM.Rows(0)(2).ToString
        'End If






    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
 
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, False)
        FLAG = 1
        txtcodCombo.Focus()

        btnbuscar.Enabled = False

        txtEjercicio.Text = Date.Now.Year

        Dim SQL1 As String
        SQL1 = "DELETE  FROM TMP_COMBOXARTICULO "
        If TmpInsertDatos(SQL1) = True Then
        End If

        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TMP_COMBOXARTICULO", codempresa, txtcodCombo.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()

        CkEstado.Checked = False



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        If FLAG = 1 Then
            Dim RptaTrans As Boolean
            RptaTrans = CAyuda.Ejecutar("NSP_ins_COMBO", codempresa, txtcodCombo.Text.Trim, txtdescrpCombo.Text.Trim, estado, cboPeriodo.Text, txtEjercicio.Text)
            If RptaTrans Then

            End If

        End If



        If FLAG = 2 Then
            Dim RptaTrans As Boolean
            RptaTrans = CAyuda.Ejecutar("NSP_upd_COMBO", codempresa, txtcodCombo.Text.Trim, txtdescrpCombo.Text.Trim, estado, txtEjercicio.Text, cboPeriodo.Text)
            If RptaTrans Then

            End If

        End If





        Dim RptaTrans1 As Boolean
        RptaTrans1 = CAyuda.Ejecutar("NSP_ins_COMBOXARTICULO", codempresa, txtcodCombo.Text.Trim)
        If RptaTrans1 Then

        End If


        MsgBox("SE GUARDO CORRECTAMENTE...", MsgBoxStyle.Information, DesEmpresa)

        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)

        Call BOTONES(True, False, False, False, True)


        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TMP_COMBOXARTICULO", codempresa, txtcodCombo.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()



        BTNNUEVO.Focus()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If txtcodCombo.Text.Trim = "" Then
            MsgBox("Falta el Codigo del Combo..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TablaCuotasLinea.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el combo [ " & Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 1).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_TMP_COMBOXARTICULO", codempresa, txtcodCombo.Text.Trim.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 0).ToString.Trim)
            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TMP_COMBOXARTICULO", codempresa, txtcodCombo.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID()
        End If


    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Call BOTONES(True, False, True, True, True)
        Call Bloqueatextbox(Me)

        Dim FRMX As New FRM_GRIDCOMBO
        FRMX.vie2 = Me
        FRMX.bol = True
        FRMX.ShowDialog()



    End Sub

    Private Sub CkEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkEstado.CheckedChanged


        If CkEstado.Checked = True Then
            estado = True
        Else
            estado = False
        End If


    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click

        'Dim RESPUESTA As Boolean
        'RESPUESTA = mensaje_cancelar()
        'If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)


    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click


        If txtcodCombo.Text.ToString.Trim.Length = 0 Then
            MsgBox("Debe seleccionar un registro...", MsgBoxStyle.Information, "Nar Gestion")
            Exit Sub
        End If

        Call desbloqueatextbox(Me)
        txtcodCombo.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        FLAG = 2
        txtcodCombo.Focus()
        txtcodCombo.SelectAll()

    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            Dim PROCESO As Boolean
            Dim sql As String

            sql = "nsp_dele_COMBO '" & txtcodCombo.Text & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = False Then
                Exit Sub
            Else
                MsgBox("SE ELIMINO CORRECTAMENTE EL  REGISTRO...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            End If

            'TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TXTCODPAIS.Text & "','DELETE','PAIS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            BOTONES(True, False, False, False, True)
            Call Bloqueatextbox(Me)
            Call Limpiatextbox(Me)

            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TMP_COMBOXARTICULO", codempresa, txtcodCombo.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID()


        End If


    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then

            Dim TB_MAXITEM As DataTable

            TB_MAXITEM = TmpListarDatos("sp_Busp_ARTI '" & codempresa & "','" & TextBox1.Text & "'")



            TextBox2.Text = TB_MAXITEM.Rows(0)(0).ToString
         
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class