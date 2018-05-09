Public Class FrmCalificaciones
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim id1 As Integer
    Dim id2 As Integer

   
    'LOAD DEL FORM
    Private Sub FrmCalificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarGrilla()
        rbnactualizar.Checked = True
        iniciarControlesControlesBuscaAlu2()
        rbnbusqueda.Checked = False
        Dim Datos = From C In DataContext.Materias Select C.id_materia, C.nombre_materia

        Me.cboMateria.DataSource = Datos
        Me.cboMateria.DisplayMember = "nombre_materia"
        Me.cboMateria.ValueMember = "id_materia"
        Me.cboMateria.SelectedIndex = -1

        If rbnactualizar.Checked = True Then
            rbnbusqueda.Checked = False
        Else
            rbnbusqueda.Checked = True
            rbnactualizar.Checked = False
        End If
    End Sub

    'ARMA GRILLA
    Sub MostrarGrilla()


        dgrCalificaciones.AutoGenerateColumns = False
        dgrCalificaciones.Columns.Clear()

        dgrCalificaciones.Columns.Add("", "Materia")
        dgrCalificaciones.Columns.Add("", "Parcial 1")
        dgrCalificaciones.Columns.Add("", "Fecha P1")
        dgrCalificaciones.Columns.Add("", "Parcial 2")
        dgrCalificaciones.Columns.Add("", "Fecha P2")
        dgrCalificaciones.Columns.Add("", "Parcial 3")
        dgrCalificaciones.Columns.Add("", "Fecha P3")
        dgrCalificaciones.Columns.Add("", "Parcial 4")
        dgrCalificaciones.Columns.Add("", "Fecha P4")
        dgrCalificaciones.Columns.Add("", "Integrador 1")
        dgrCalificaciones.Columns.Add("", "Fecha I1")
        dgrCalificaciones.Columns.Add("", "Promedio 1° E")
        dgrCalificaciones.Columns.Add("", "Parcial 5")
        dgrCalificaciones.Columns.Add("", "Fecha P5")
        dgrCalificaciones.Columns.Add("", "Parcial 6")
        dgrCalificaciones.Columns.Add("", "Fecha P6")
        dgrCalificaciones.Columns.Add("", "Parcial 7")
        dgrCalificaciones.Columns.Add("", "Fecha P7")
        dgrCalificaciones.Columns.Add("", "Parcial 8")
        dgrCalificaciones.Columns.Add("", "Fecha P8")
        dgrCalificaciones.Columns.Add("", "Integrador 2")
        dgrCalificaciones.Columns.Add("", "Fecha I2")
        dgrCalificaciones.Columns.Add("", "Promedio 2° E")
        dgrCalificaciones.Columns.Add("", "Parcial 9")
        dgrCalificaciones.Columns.Add("", "Fecha P9")
        dgrCalificaciones.Columns.Add("", "Parcial 10")
        dgrCalificaciones.Columns.Add("", "Fecha P10")
        dgrCalificaciones.Columns.Add("", "Parcial 11")
        dgrCalificaciones.Columns.Add("", "Fecha P11")
        dgrCalificaciones.Columns.Add("", "Parcial 12")
        dgrCalificaciones.Columns.Add("", "Fecha P12")
        dgrCalificaciones.Columns.Add("", "Integrador 3")
        dgrCalificaciones.Columns.Add("", "Fecha I3")
        dgrCalificaciones.Columns.Add("", "Promedio 3° E")
        dgrCalificaciones.Columns.Add("", "Prom Anual")
        dgrCalificaciones.Columns.Add("", "Coloquio")
        dgrCalificaciones.Columns.Add("", "Fecha Col")
        dgrCalificaciones.Columns.Add("", "Exámen")
        dgrCalificaciones.Columns.Add("", "Fecha Ex")
        dgrCalificaciones.Columns.Add("", "Calificación Final")
        dgrCalificaciones.Columns.Add("", "Condición")


        dgrCalificaciones.Columns(0).DataPropertyName = ""
        dgrCalificaciones.Columns(1).DataPropertyName = ""
        dgrCalificaciones.Columns(2).DataPropertyName = ""
        dgrCalificaciones.Columns(3).DataPropertyName = ""
        dgrCalificaciones.Columns(4).DataPropertyName = ""
        dgrCalificaciones.Columns(5).DataPropertyName = ""
        dgrCalificaciones.Columns(6).DataPropertyName = ""
        dgrCalificaciones.Columns(7).DataPropertyName = ""
        dgrCalificaciones.Columns(8).DataPropertyName = ""
        dgrCalificaciones.Columns(9).DataPropertyName = ""
        dgrCalificaciones.Columns(10).DataPropertyName = ""
        dgrCalificaciones.Columns(11).DataPropertyName = ""
        dgrCalificaciones.Columns(12).DataPropertyName = ""
        dgrCalificaciones.Columns(13).DataPropertyName = ""
        dgrCalificaciones.Columns(14).DataPropertyName = ""
        dgrCalificaciones.Columns(15).DataPropertyName = ""
        dgrCalificaciones.Columns(16).DataPropertyName = ""
        dgrCalificaciones.Columns(17).DataPropertyName = ""
        dgrCalificaciones.Columns(18).DataPropertyName = ""
        dgrCalificaciones.Columns(19).DataPropertyName = ""
        dgrCalificaciones.Columns(20).DataPropertyName = ""
        dgrCalificaciones.Columns(21).DataPropertyName = ""
        dgrCalificaciones.Columns(22).DataPropertyName = ""
        dgrCalificaciones.Columns(23).DataPropertyName = ""
        dgrCalificaciones.Columns(24).DataPropertyName = ""
        dgrCalificaciones.Columns(25).DataPropertyName = ""
        dgrCalificaciones.Columns(26).DataPropertyName = ""
        dgrCalificaciones.Columns(27).DataPropertyName = ""
        dgrCalificaciones.Columns(28).DataPropertyName = ""
        dgrCalificaciones.Columns(29).DataPropertyName = ""
        dgrCalificaciones.Columns(30).DataPropertyName = ""
        dgrCalificaciones.Columns(31).DataPropertyName = ""
        dgrCalificaciones.Columns(32).DataPropertyName = ""
        dgrCalificaciones.Columns(33).DataPropertyName = ""
        dgrCalificaciones.Columns(34).DataPropertyName = ""
        dgrCalificaciones.Columns(35).DataPropertyName = ""
        dgrCalificaciones.Columns(36).DataPropertyName = ""
        dgrCalificaciones.Columns(37).DataPropertyName = ""
        dgrCalificaciones.Columns(38).DataPropertyName = ""
        dgrCalificaciones.Columns(39).DataPropertyName = ""
        dgrCalificaciones.Columns(40).DataPropertyName = ""



    End Sub

    'BOTON SALIR
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    'BOTON BUSCAR ALUMNO
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Me.Enabled = False
        FrmBusqAlu1.Show()
    End Sub

    'LIMPIA PRIMERA ETAPA
    Private Sub LimpiarControlesPrimeraEtapa()
        txtParcial1.Text = ""
        txtParcial2.Text = ""
        txtParcial3.Text = ""
        txtParcial4.Text = ""
        txtInteg1.Text = ""
        txtPromE1.Text = ""
        dtpP1.Text = ""
        dtpP2.Text = ""
        dtpP3.Text = ""
        dtpP4.Text = ""
        dtpInteg1.Text = ""
    End Sub

    'LIMPIA SEGUNDA ETAPA
    Private Sub LimpiarControlesSegundaEtapa()
        txtParcial5.Text = ""
        txtParcial6.Text = ""
        txtParcial7.Text = ""
        txtParcial8.Text = ""
        txtInteg2.Text = ""
        txtPromE2.Text = ""
        dtpP5.Text = ""
        dtpP6.Text = ""
        dtpP7.Text = ""
        dtpP8.Text = ""
        dtpInteg2.Text = ""
    End Sub

    'LIMPIA TERCERA ETAPA
    Private Sub LimpiarControlesTerceraEtapa()
        txtParcial9.Text = ""
        txtParcial10.Text = ""
        txtParcial11.Text = ""
        txtParcial12.Text = ""
        txtInteg3.Text = ""
        txtPromE3.Text = ""
        dtpP9.Text = ""
        dtpP10.Text = ""
        dtpP11.Text = ""
        dtpP12.Text = ""
        dtpInteg3.Text = ""
        'dtpPromE3.Text = ""
    End Sub

    'LIMPIA FINALES
    Private Sub LimpiarControlesCalifFinales()
        txtPromAnual.Text = ""
        txtColoquio.Text = ""
        txtExamen.Text = ""
        txtCalifDef.Text = ""
        cboCondicion.SelectedItem = -1
        dtpColoquio.Text = ""
        dtpExamen.Text = ""
    End Sub

    'BOTON CANCELAR
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtDNI.Text = ""
        cboMateria.Text = ""
        cboMateria.Enabled = False
        cmdBuscar.Enabled = True
        cmdLimpiar.Enabled = False
    End Sub

    Private Sub cmdCancelarE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiarControlesPrimeraEtapa()
    End Sub

    Private Sub cmdCancelarE2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiarControlesSegundaEtapa()
    End Sub

    Private Sub cmdCancelarE3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiarControlesTerceraEtapa()
    End Sub

    Private Sub cmdCancelarCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiarControlesCalifFinales()
    End Sub

    'BOTON CALCULAR PROM E1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCalcular1.Click
        If txtParcial1.Text = "" Or txtParcial2.Text = "" Or txtParcial3.Text = "" Or txtParcial4.Text = "" Or txtInteg1.Text = "" Then
            MsgBox("Debe completar todos los campos de la primera etapa para calcular el promedio")
        Else

            Dim N As Double
            N = Val(txtParcial1.Text) + Val(txtParcial2.Text) + Val(txtParcial3.Text) + Val(txtParcial4.Text) + Val(txtInteg1.Text)
            txtPromE1.Text = N / 5
            Dim x = CInt(txtPromE1.Text)
            txtredondeo.Text = Str(Math.Round(x, 2))
            Redondeo1()
        End If


    End Sub

    'CALCULA REDONDEO 1
    Sub Redondeo1()
        Dim num As Double
        num = Math.Round(Val(txtPromE1.Text) / 5, 2) * 5
    End Sub

    'BOTON CALCULAR PROM E2
    Private Sub cboCalcular2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCalcular2.Click
        If txtParcial5.Text = "" Or txtParcial6.Text = "" Or txtParcial7.Text = "" Or txtParcial8.Text = "" Or txtInteg2.Text = "" Then
            MsgBox("Debe completar todos los campos de la primera etapa para calcular el promedio")
        Else
            validarCalificación2()
            Dim N As Double
            N = Val(txtParcial5.Text) + Val(txtParcial6.Text) + Val(txtParcial7.Text) + Val(txtParcial8.Text) + Val(txtInteg2.Text)
            txtPromE2.Text = N / 5
            Dim x = CInt(txtPromE2.Text)
            txtRendondeo2.Text = Str(Math.Round(x, 2))
            Redondeo2()
        End If
    End Sub

    'CALCULA REDONDEO 2
    Sub Redondeo2()
        Dim num As Double
        num = Math.Round(Val(txtPromE2.Text) / 5, 2) * 5
    End Sub

    'BOTON CALCULAR PROM E3
    Private Sub cboCalcular3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCalcular3.Click
        If txtParcial9.Text = "" Or txtParcial10.Text = "" Or txtParcial11.Text = "" Or txtParcial12.Text = "" Or txtInteg3.Text = "" Then
            MsgBox("Debe completar todos los campos de la primera etapa para calcular el promedio")
        Else
            validarCalificación3()
            Dim N As Double
            N = Val(txtParcial9.Text) + Val(txtParcial10.Text) + Val(txtParcial11.Text) + Val(txtParcial12.Text) + Val(txtInteg3.Text)
            txtPromE3.Text = N / 5
            Dim x = CInt(txtPromE3.Text)
            txtRedondeo3.Text = Str(Math.Round(x, 2))
            Redondeo2()
        End If
    End Sub

    'CALCULA REDONDEO 3
    Sub Redondeo3()
        Dim num As Double
        num = Math.Round(Val(txtPromE3.Text) / 5, 2) * 5
    End Sub

    'BOTON CALCULAR PROM ANUAL
    Private Sub cmdPromAnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPromAnual.Click
        If txtredondeo.Text = "" Or txtRendondeo2.Text = "" Or txtRedondeo3.Text = "" Then
            MsgBox("Deben estar completos todos los promedios para calcular el promedio final")
        Else
            Dim N As Double
            N = Val(txtredondeo.Text) + Val(txtRendondeo2.Text) + Val(txtRedondeo3.Text)
            txtPromAnual.Text = N / 3
            Dim x = CInt(txtPromAnual.Text)
            txtRedondeoAnual.Text = Str(Math.Round(x, 2))
            RedondeoAnual()
        End If
    End Sub

    'CALCULA REDONDEO ANUAL
    Sub RedondeoAnual()
        Dim num As Double
        num = Math.Round(Val(txtPromAnual.Text) / 5, 2) * 5
    End Sub

    'BOTON CALCULAR FINAL
    Private Sub cboCalcularFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCalcularFinal.Click
        If txtRedondeoAnual.Text = "" Or txtColoquio.Text = "" Or txtExamen.Text = "" Then

            MsgBox("Deben estar completas todas las calificaciones finales para calcular la calificación definitiva")
        Else
            validarCalificación4()
            Dim N As Double
            N = Val(txtRedondeoAnual.Text) + Val(txtColoquio.Text) + Val(txtExamen.Text)
            txtCalifDef.Text = N / 3
            Dim x = CInt(txtCalifDef.Text)
            txtRendonFinal.Text = Str(Math.Round(x, 2))
            RedondeoFinal()
        End If
    End Sub

    'CALCULA FINAL
    Sub RedondeoFinal()
        Dim num As Double
        num = Math.Round(Val(txtCalifDef.Text) / 5, 2) * 5
    End Sub

    'VALIDACIONES
    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtParcial1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial1.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial1.Text
        num = Val(txtParcial1.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial1.Text = ""
        End If
    End Sub
    Private Sub validarCalificación1()
        Dim numP1 As Double
        Dim numP2 As Double
        Dim numP3 As Double
        Dim numP4 As Double
        Dim numP5 As Double
        numP1 = Val(txtParcial1.Text)
        numP2 = Val(txtParcial2.Text)
        numP3 = Val(txtParcial3.Text)
        numP4 = Val(txtParcial4.Text)
        numP5 = Val(txtInteg1.Text)
        If numP1 < 0 Or numP1 > 10 Or numP2 < 0 Or numP2 > 10 Or numP3 < 0 Or numP3 > 10 Or numP4 < 0 Or numP4 > 10 Or numP5 < 0 Or numP5 > 10 Then
            MsgBox("La calificación no puede ser inferior a 0 o mayor a 10")
            txtParcial1.Text = ""
            txtParcial2.Text = ""
            txtParcial3.Text = ""
            txtParcial4.Text = ""
            txtInteg1.Text = ""
        End If
    End Sub
    Private Sub validarCalificación2()
        Dim numP1 As Double
        Dim numP2 As Double
        Dim numP3 As Double
        Dim numP4 As Double
        Dim numP5 As Double
        numP1 = Val(txtParcial5.Text)
        numP2 = Val(txtParcial6.Text)
        numP3 = Val(txtParcial7.Text)
        numP4 = Val(txtParcial8.Text)
        numP5 = Val(txtInteg2.Text)
        If numP1 < 0 Or numP1 > 10 Or numP2 < 0 Or numP2 > 10 Or numP3 < 0 Or numP3 > 10 Or numP4 < 0 Or numP4 > 10 Or numP5 < 0 Or numP5 > 10 Then
            MsgBox("La calificación no puede ser inferior a 0 o mayor a 10")
            txtParcial5.Text = ""
            txtParcial6.Text = ""
            txtParcial7.Text = ""
            txtParcial8.Text = ""
            txtInteg2.Text = ""
            txtPromE2.Text = ""
            txtRendondeo2.Text = ""
        End If
    End Sub
    Private Sub validarCalificación3()
        Dim numP1 As Double
        Dim numP2 As Double
        Dim numP3 As Double
        Dim numP4 As Double
        Dim numP5 As Double
        numP1 = Val(txtParcial9.Text)
        numP2 = Val(txtParcial10.Text)
        numP3 = Val(txtParcial11.Text)
        numP4 = Val(txtParcial12.Text)
        numP5 = Val(txtInteg3.Text)
        If numP1 < 0 Or numP1 > 10 Or numP2 < 0 Or numP2 > 10 Or numP3 < 0 Or numP3 > 10 Or numP4 < 0 Or numP4 > 10 Or numP5 < 0 Or numP5 > 10 Then
            MsgBox("La calificación no puede ser inferior a 0 o mayor a 10")
            txtParcial9.Text = ""
            txtParcial10.Text = ""
            txtParcial11.Text = ""
            txtParcial12.Text = ""
            txtInteg3.Text = ""
            txtPromE3.Text = ""
            txtRedondeo3.Text = ""
        End If
    End Sub
    Private Sub validarCalificación4()

        Dim numP1 As Double
        Dim numP2 As Double

        numP1 = Val(txtColoquio.Text)
        numP2 = Val(txtExamen.Text)
        If numP1 < 0 Or numP1 > 10 Or numP2 < 0 Or numP2 > 10 Then
            MsgBox("La calificación no puede ser inferior a 0 o mayor a 10")
            txtColoquio.Text = ""
            txtExamen.Text = ""
            txtRedondeoAnual.Text = ""
            txtPromAnual.Text = ""

        End If
    End Sub
    Private Sub txtParcial2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial2.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial2.Text
        num = Val(txtParcial2.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial2.Text = ""
        End If
    End Sub
    Private Sub txtParcial3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial3.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial3.Text
        num = Val(txtParcial3.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial3.Text = ""
        End If
    End Sub
    Private Sub txtParcial4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial4.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial4.Text
        num = Val(txtParcial4.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial4.Text = ""
        End If
    End Sub
    Private Sub txtParcial5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial5.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial5.Text
        num = Val(txtParcial5.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial5.Text = ""
        End If
    End Sub
    Private Sub txtParcial6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial6.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial6.Text
        num = Val(txtParcial6.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial6.Text = ""
        End If
    End Sub
    Private Sub txtParcial7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial7.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial7.Text
        num = Val(txtParcial7.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial7.Text = ""
        End If
    End Sub
    Private Sub txtParcial8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial8.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial8.Text
        num = Val(txtParcial8.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial8.Text = ""
        End If
    End Sub
    Private Sub txtParcial9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial9.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial9.Text
        num = Val(txtParcial9.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial9.Text = ""
        End If
    End Sub
    Private Sub txtParcial10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial10.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial10.Text
        num = Val(txtParcial10.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial10.Text = ""
        End If
    End Sub
    Private Sub txtParcial11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial11.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial11.Text
        num = Val(txtParcial11.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial11.Text = ""
        End If
    End Sub
    Private Sub txtParcial12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcial12.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtParcial12.Text
        num = Val(txtParcial12.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtParcial12.Text = ""
        End If
    End Sub
    Private Sub txtInteg1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInteg1.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtInteg1.Text
        num = Val(txtInteg1.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtInteg1.Text = ""
        End If
    End Sub
    Private Sub txtInteg2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInteg2.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtInteg2.Text
        num = Val(txtInteg2.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtInteg2.Text = ""
        End If
    End Sub
    Private Sub txtInteg3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInteg3.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtInteg3.Text
        num = Val(txtInteg3.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtInteg3.Text = ""
        End If
    End Sub
    Private Sub txtColoquio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtColoquio.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtColoquio.Text
        num = Val(txtColoquio.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtColoquio.Text = ""
        End If
    End Sub
    Private Sub txtExamen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExamen.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        Dim num As Double
        TestString = txtExamen.Text
        num = Val(txtExamen.Text)
        If Len(TestString) > 1 Then

            MsgBox("La calificación no puede tener más de dos dígitos")
            txtExamen.Text = ""
        End If
    End Sub

    Private Sub habilitarcontrolesBuscarAlu1()
        cmdBuscar.Enabled = True
        cmdLimpiar.Enabled = True
    End Sub

    Private Sub DeshabilitarcontrolesBuscarAlu1()
        cboMateria.Enabled = False
        cmdBuscar.Enabled = False
        cmdLimpiar.Enabled = False
    End Sub

    Private Sub HabilitaControlesCalific()
        txtParcial1.Enabled = True
        txtParcial2.Enabled = True
        txtParcial3.Enabled = True
        txtParcial4.Enabled = True
        txtParcial5.Enabled = True
        txtParcial6.Enabled = True
        txtParcial7.Enabled = True
        txtParcial8.Enabled = True
        txtParcial9.Enabled = True
        txtParcial10.Enabled = True
        txtParcial11.Enabled = True
        txtParcial12.Enabled = True
        txtInteg1.Enabled = True
        txtInteg2.Enabled = True
        txtInteg3.Enabled = True
        txtColoquio.Enabled = True
        txtExamen.Enabled = True
        dtpP1.Enabled = True
        dtpP2.Enabled = True
        dtpP3.Enabled = True
        dtpP4.Enabled = True
        dtpP5.Enabled = True
        dtpP6.Enabled = True
        dtpP7.Enabled = True
        dtpP8.Enabled = True
        dtpP9.Enabled = True
        dtpP10.Enabled = True
        dtpP11.Enabled = True
        dtpP12.Enabled = True
        dtpInteg1.Enabled = True
        dtpInteg2.Enabled = True
        dtpInteg3.Enabled = True
        dtpColoquio.Enabled = True
        dtpExamen.Enabled = True
        cboCalcular1.Enabled = True
        cboCalcular2.Enabled = True
        cboCalcular3.Enabled = True
        cboCalcularFinal.Enabled = True
        cmdPromAnual.Enabled = True
        cboCondicion.Enabled = True
        cmdGuardarCF.Enabled = True
        cmdCancelarCF.Enabled = True
    End Sub

    Private Sub LimpiarControlesCalif()
        txtIdAlu1.Text = ""
        cboMateria.SelectedIndex = -1
        txtParcial1.Text = ""
        dtpP1.Text = ""
        txtParcial2.Text = ""
        dtpP2.Text = ""
        txtParcial3.Text = ""
        dtpP3.Text = ""
        txtParcial4.Text = ""
        dtpP4.Text = ""
        txtParcial5.Text = ""
        dtpP5.Text = ""
        txtParcial6.Text = ""
        dtpP6.Text = ""
        txtParcial7.Text = ""
        dtpP7.Text = ""
        txtParcial8.Text = ""
        dtpP8.Text = ""
        txtParcial9.Text = ""
        dtpP9.Text = ""
        txtParcial10.Text = ""
        dtpP10.Text = ""
        txtParcial11.Text = ""
        dtpP11.Text = ""
        txtParcial12.Text = ""
        dtpP12.Text = ""
        txtInteg1.Text = ""
        txtInteg2.Text = ""
        txtInteg3.Text = ""
        dtpInteg1.Text = ""
        dtpInteg2.Text = ""
        dtpInteg3.Text = ""
        txtredondeo.Text = ""
        txtRendondeo2.Text = ""
        txtRedondeo3.Text = ""
        txtRedondeoAnual.Text = ""
        txtColoquio.Text = ""
        txtExamen.Text = ""
        dtpColoquio.Text = ""
        dtpExamen.Text = ""
        txtRendonFinal.Text = ""
        cboCondicion.SelectedIndex = -1
    End Sub

    Private Sub DesHabilitaControlesCalific()
        txtParcial1.Enabled = False
        txtParcial2.Enabled = False
        txtParcial3.Enabled = False
        txtParcial4.Enabled = False
        txtParcial5.Enabled = False
        txtParcial6.Enabled = False
        txtParcial7.Enabled = False
        txtParcial8.Enabled = False
        txtParcial9.Enabled = False
        txtParcial10.Enabled = False
        txtParcial11.Enabled = False
        txtParcial12.Enabled = False
        txtInteg1.Enabled = False
        txtInteg2.Enabled = False
        txtInteg3.Enabled = False
        txtColoquio.Enabled = False
        txtExamen.Enabled = False
        dtpP1.Enabled = False
        dtpP2.Enabled = False
        dtpP3.Enabled = False
        dtpP4.Enabled = False
        dtpP5.Enabled = False
        dtpP6.Enabled = False
        dtpP7.Enabled = False
        dtpP8.Enabled = False
        dtpP9.Enabled = False
        dtpP10.Enabled = False
        dtpP11.Enabled = False
        dtpP12.Enabled = False
        dtpInteg1.Enabled = False
        dtpInteg2.Enabled = False
        dtpInteg3.Enabled = False
        dtpColoquio.Enabled = False
        dtpExamen.Enabled = False
        cboCalcular1.Enabled = False
        cboCalcular2.Enabled = False
        cboCalcular3.Enabled = False
        cboCalcularFinal.Enabled = False
        cmdPromAnual.Enabled = False
        cboCondicion.Enabled = False
        cmdGuardarCF.Enabled = False
        cmdCancelarCF.Enabled = False
    End Sub

    Private Sub HabilitaControlesBuscaAlu2()
        cmdBuscar2.Enabled = True
    End Sub

    Private Sub iniciarControlesControlesBuscaAlu2()
        cmdEditar.Enabled = False
        cmdEliminar.Enabled = False
        cmdActualizar.Enabled = False
        cmdCancelargr.Enabled = False
        dgrCalificaciones.Enabled = False
    End Sub

    Private Sub desHabilitaControlesBuscaAlu2()
        txtBuscar2.Enabled = False
        cmdBuscar2.Enabled = False
        cmdVer.Enabled = False
    End Sub

    'RADIO BUTTON BUSQUEDA
    Private Sub rbnbusqueda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnbusqueda.CheckedChanged
        habilitarcontrolesBuscarAlu1()
        desHabilitaControlesBuscaAlu2()
        DesHabilitaControlesCalific()
    End Sub

    'RADIO BUTTON CALIFICACION
    Private Sub rbnCalif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        HabilitaControlesCalific()
        desHabilitaControlesBuscaAlu2()
        DeshabilitarcontrolesBuscarAlu1()
    End Sub

    'RADIO BUTTON ACTUALIZA
    Private Sub rbnactualizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnactualizar.CheckedChanged
        HabilitaControlesBuscaAlu2()
        DesHabilitaControlesCalific()
        DeshabilitarcontrolesBuscarAlu1()
    End Sub

    Private Sub cmdBuscar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar2.Click
        Me.Enabled = False
        FrmBusqAlu2.Show()
    End Sub

    Private Sub cmdVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVer.Click

        Try
            Dim BuscaAlu = (From alu In datacontextvistas.vista_calificaciones Where alu.id_alumno = (txtIdAlu.Text)).ToList()(0)
            ActualizaGrillaCalif()
        Catch ex As Exception
            MsgBox("El alumno no tiene calificaciones cargadas!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
            limpiarControlesActualiza()
        End Try


    End Sub

    Private Sub ActualizaGrillaCalif()
        Dim consulta = From V In datacontextvistas.vista_calificaciones Select V.id_alumno, V.nombre_alu, V.apellido_alu, V.DNI_alu, V.parcial1, V.fechaParcial1, V.parcial2, V.fechaParcial2, V.parcial3, V.fechaParcial3, V.parcial4, V.fechaParcial4, V.integrador1, V.fechaInteg1, V.promedioetapa1, V.parcial5, V.fechaParcial5, V.parcial6, V.fechaParcial6, V.parcial7, V.fechaParcial7, V.parcial8, V.fechaParcial8, V.integrador2, V.fechaInteg2, V.promedioetapa2, V.parcial9, V.fechaParcial9, V.parcial10, V.fechaParcial10, V.parcial11, V.fechaParcial11, V.parcial12, V.fechaParcial12, V.integrador3, V.fechaInteg3, V.promedioetapa3, V.promedio_anual, V.coloquio, V.fechacoloquio, V.examen, V.fechaexamen, V.calif_definitiva, V.condicion_textbox, V.nombre_materia Where id_alumno = (txtIdAlu.Text)

        dgrCalificaciones.Enabled = True
        dgrCalificaciones.AutoGenerateColumns = False
        dgrCalificaciones.Columns.Clear()

        dgrCalificaciones.Columns.Add("nombre_materia", "Materia")
        dgrCalificaciones.Columns.Add("parcial1", "Parcial 1")
        dgrCalificaciones.Columns.Add("fechaParcial1", "Fecha P1")
        dgrCalificaciones.Columns.Add("parcial2", "Parcial 2")
        dgrCalificaciones.Columns.Add("fechaParcial2", "Fecha P2")
        dgrCalificaciones.Columns.Add("parcial3", "Parcial 3")
        dgrCalificaciones.Columns.Add("fechaParcial3", "Fecha P3")
        dgrCalificaciones.Columns.Add("parcial4", "Parcial 4")
        dgrCalificaciones.Columns.Add("fechaParcial4", "Fecha P4")
        dgrCalificaciones.Columns.Add("integrador1", "Integrador 1")
        dgrCalificaciones.Columns.Add("fechaInteg1", "Fecha I1")
        dgrCalificaciones.Columns.Add("promedioetapa1", "Promedio 1° E")
        dgrCalificaciones.Columns.Add("parcial5", "Parcial 5")
        dgrCalificaciones.Columns.Add("fechaParcial5", "Fecha P5")
        dgrCalificaciones.Columns.Add("parcial6", "Parcial 6")
        dgrCalificaciones.Columns.Add("fechaParcial6", "Fecha P6")
        dgrCalificaciones.Columns.Add("parcial7", "Parcial 7")
        dgrCalificaciones.Columns.Add("fechaParcial7", "Fecha P7")
        dgrCalificaciones.Columns.Add("parcial8", "Parcial 8")
        dgrCalificaciones.Columns.Add("fechaParcial8", "Fecha P8")
        dgrCalificaciones.Columns.Add("integrador2", "Integrador 2")
        dgrCalificaciones.Columns.Add("fechaInteg2", "Fecha I2")
        dgrCalificaciones.Columns.Add("promedioetapa2", "Promedio 2° E")
        dgrCalificaciones.Columns.Add("parcial9", "Parcial 9")
        dgrCalificaciones.Columns.Add("fechaParcial9", "Fecha P9")
        dgrCalificaciones.Columns.Add("parcial10", "Parcial 10")
        dgrCalificaciones.Columns.Add("fechaParcial10", "Fecha P10")
        dgrCalificaciones.Columns.Add("parcial11", "Parcial 11")
        dgrCalificaciones.Columns.Add("fechaParcial11", "Fecha P11")
        dgrCalificaciones.Columns.Add("parcial12", "Parcial 12")
        dgrCalificaciones.Columns.Add("fechaParcial12", "Fecha P12")
        dgrCalificaciones.Columns.Add("integrador3", "Integrador 3")
        dgrCalificaciones.Columns.Add("fechaInteg3", "Fecha I3")
        dgrCalificaciones.Columns.Add("promedioetapa3", "Promedio 3° E")
        dgrCalificaciones.Columns.Add("promedio_anual", "Prom Anual")
        dgrCalificaciones.Columns.Add("coloquio", "Coloquio")
        dgrCalificaciones.Columns.Add("fechacoloquio", "Fecha Col")
        dgrCalificaciones.Columns.Add("examen", "Exámen")
        dgrCalificaciones.Columns.Add("fechaexamen", "Fecha Ex")
        dgrCalificaciones.Columns.Add("calif_definitiva", "Calificación Final")
        dgrCalificaciones.Columns.Add("condicion_textbox", "Condición")


        dgrCalificaciones.Columns(0).DataPropertyName = "nombre_materia"
        dgrCalificaciones.Columns(1).DataPropertyName = "parcial1"
        dgrCalificaciones.Columns(2).DataPropertyName = "fechaParcial1"
        dgrCalificaciones.Columns(3).DataPropertyName = "parcial2"
        dgrCalificaciones.Columns(4).DataPropertyName = "fechaParcial2"
        dgrCalificaciones.Columns(5).DataPropertyName = "parcial3"
        dgrCalificaciones.Columns(6).DataPropertyName = "fechaParcial3"
        dgrCalificaciones.Columns(7).DataPropertyName = "parcial4"
        dgrCalificaciones.Columns(8).DataPropertyName = "fechaParcial4"
        dgrCalificaciones.Columns(9).DataPropertyName = "integrador1"
        dgrCalificaciones.Columns(10).DataPropertyName = "fechaInteg1"
        dgrCalificaciones.Columns(11).DataPropertyName = "promedioetapa1"
        dgrCalificaciones.Columns(12).DataPropertyName = "parcial5"
        dgrCalificaciones.Columns(13).DataPropertyName = "fechaParcial5"
        dgrCalificaciones.Columns(14).DataPropertyName = "parcial6"
        dgrCalificaciones.Columns(15).DataPropertyName = "fechaParcial6"
        dgrCalificaciones.Columns(16).DataPropertyName = "parcial7"
        dgrCalificaciones.Columns(17).DataPropertyName = "fechaParcial7"
        dgrCalificaciones.Columns(18).DataPropertyName = "parcial8"
        dgrCalificaciones.Columns(19).DataPropertyName = "fechaParcial8"
        dgrCalificaciones.Columns(20).DataPropertyName = "integrador2"
        dgrCalificaciones.Columns(21).DataPropertyName = "fechaInteg2"
        dgrCalificaciones.Columns(22).DataPropertyName = "promedioetapa2"
        dgrCalificaciones.Columns(23).DataPropertyName = "parcial9"
        dgrCalificaciones.Columns(24).DataPropertyName = "fechaParcial9"
        dgrCalificaciones.Columns(25).DataPropertyName = "parcial10"
        dgrCalificaciones.Columns(26).DataPropertyName = "fechaParcial10"
        dgrCalificaciones.Columns(27).DataPropertyName = "parcial11"
        dgrCalificaciones.Columns(28).DataPropertyName = "fechaParcial11"
        dgrCalificaciones.Columns(29).DataPropertyName = "parcial12"
        dgrCalificaciones.Columns(30).DataPropertyName = "fechaParcial12"
        dgrCalificaciones.Columns(31).DataPropertyName = "integrador3"
        dgrCalificaciones.Columns(32).DataPropertyName = "fechaInteg3"
        dgrCalificaciones.Columns(33).DataPropertyName = "promedioetapa3"
        dgrCalificaciones.Columns(34).DataPropertyName = "promedio_anual"
        dgrCalificaciones.Columns(35).DataPropertyName = "coloquio"
        dgrCalificaciones.Columns(36).DataPropertyName = "fechacoloquio"
        dgrCalificaciones.Columns(37).DataPropertyName = "examen"
        dgrCalificaciones.Columns(38).DataPropertyName = "fechaexamen"
        dgrCalificaciones.Columns(39).DataPropertyName = "calif_definitiva"
        dgrCalificaciones.Columns(40).DataPropertyName = "condicion_textbox"

        dgrCalificaciones.DataSource = consulta
        dgrCalificaciones.ClearSelection()

    End Sub

    Private Sub Pasadatos()
        If dgrCalificaciones.SelectedRows.Count > 0 Then
            txtParcial1.Text = dgrCalificaciones.Item("parcial1", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial2.Text = dgrCalificaciones.Item("parcial2", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial3.Text = dgrCalificaciones.Item("parcial3", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial4.Text = dgrCalificaciones.Item("parcial4", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial5.Text = dgrCalificaciones.Item("parcial5", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial6.Text = dgrCalificaciones.Item("parcial6", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial7.Text = dgrCalificaciones.Item("parcial7", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial8.Text = dgrCalificaciones.Item("parcial8", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial9.Text = dgrCalificaciones.Item("parcial9", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial10.Text = dgrCalificaciones.Item("parcial10", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial11.Text = dgrCalificaciones.Item("parcial11", dgrCalificaciones.SelectedRows(0).Index).Value
            txtParcial12.Text = dgrCalificaciones.Item("parcial12", dgrCalificaciones.SelectedRows(0).Index).Value
            txtredondeo.Text = dgrCalificaciones.Item("promedioetapa1", dgrCalificaciones.SelectedRows(0).Index).Value
            txtRendondeo2.Text = dgrCalificaciones.Item("promedioetapa2", dgrCalificaciones.SelectedRows(0).Index).Value
            txtRedondeo3.Text = dgrCalificaciones.Item("promedioetapa3", dgrCalificaciones.SelectedRows(0).Index).Value
            txtRedondeoAnual.Text = dgrCalificaciones.Item("promedio_anual", dgrCalificaciones.SelectedRows(0).Index).Value
            txtColoquio.Text = dgrCalificaciones.Item("coloquio", dgrCalificaciones.SelectedRows(0).Index).Value
            txtInteg1.Text = dgrCalificaciones.Item("integrador1", dgrCalificaciones.SelectedRows(0).Index).Value
            txtInteg2.Text = dgrCalificaciones.Item("integrador2", dgrCalificaciones.SelectedRows(0).Index).Value
            txtInteg3.Text = dgrCalificaciones.Item("integrador3", dgrCalificaciones.SelectedRows(0).Index).Value
            txtExamen.Text = dgrCalificaciones.Item("examen", dgrCalificaciones.SelectedRows(0).Index).Value
            txtRendonFinal.Text = dgrCalificaciones.Item("calif_definitiva", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP1.Text = dgrCalificaciones.Item("fechaParcial1", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP2.Text = dgrCalificaciones.Item("fechaParcial2", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP3.Text = dgrCalificaciones.Item("fechaParcial3", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP4.Text = dgrCalificaciones.Item("fechaParcial4", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP5.Text = dgrCalificaciones.Item("fechaParcial5", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP6.Text = dgrCalificaciones.Item("fechaParcial6", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP7.Text = dgrCalificaciones.Item("fechaParcial7", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP8.Text = dgrCalificaciones.Item("fechaParcial8", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP9.Text = dgrCalificaciones.Item("fechaParcial9", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP10.Text = dgrCalificaciones.Item("fechaParcial10", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP11.Text = dgrCalificaciones.Item("fechaParcial11", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpP12.Text = dgrCalificaciones.Item("fechaParcial12", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpInteg1.Text = dgrCalificaciones.Item("fechaInteg1", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpInteg2.Text = dgrCalificaciones.Item("fechaInteg2", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpInteg3.Text = dgrCalificaciones.Item("fechaInteg3", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpColoquio.Text = dgrCalificaciones.Item("fechacoloquio", dgrCalificaciones.SelectedRows(0).Index).Value
            dtpExamen.Text = dgrCalificaciones.Item("fechaexamen", dgrCalificaciones.SelectedRows(0).Index).Value
            cboCondicion.Text = dgrCalificaciones.Item("condicion_textbox", dgrCalificaciones.SelectedRows(0).Index).Value
        End If
    End Sub


    Private Sub dgrCalificaciones_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrCalificaciones.CellClick
        cmdEliminar.Enabled = True
        cmdEditar.Enabled = True
    End Sub

    Private Sub limpiarControlesActualiza()
        txtNombre2.Text = ""
        txtApellido2.Text = ""
        txtIdAlu.Text = ""
        txtBuscar2.Text = ""
        cmdCancelargr.Enabled = False
        cmdVer.Enabled = False

    End Sub

    Private Sub cmdCancelargr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelargr.Click
        limpiarControlesActualiza()
        dgrCalificaciones.Columns.Clear()
        dgrCalificaciones.Rows.Clear()
        MostrarGrilla()
        cmdBuscar2.Enabled = True
        cmdVer.Enabled = False
        iniciarControlesControlesBuscaAlu2()
    End Sub


    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Pasadatos()
        HabilitaControlesCalific()
        cmdGuardarCF.Enabled = False
        cmdActualizar.Enabled = True
        cmdEditar.Enabled = False
    End Sub

    Private Sub cmdGuardarCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarCF.Click

        Try
            Dim buscaAlu = (From al In datacontextvistas.vista_calificaciones Where al.id_alumno = CInt(txtIdAlu1.Text) And al.nombre_materia = (cboMateria.Text)).ToList()(0)
            MsgBox("El alumno ya tiene calificaciones cargadas en esa materia, puede agregar calificaciones o editarlas.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Alias")
            rbnactualizar.Checked = True
            rbnbusqueda.Checked = False
            LimpiarControlesCalif()
            cboMateria.Enabled = True
        Catch ex As Exception
            If txtParcial1.Text = " " Or txtParcial2.Text = " " Or txtParcial3.Text = " " Or txtParcial4.Text = " " Or txtParcial5.Text = " " Or txtParcial6.Text = " " Or txtParcial7.Text = " " Or txtParcial8.Text = " " Or txtParcial9.Text = " " Or txtParcial10.Text = " " Or txtParcial11.Text = " " Or txtParcial12.Text = " " Or txtInteg1.Text = " " Or txtInteg2.Text = " " Or txtInteg3.Text = " " Or txtredondeo.Text = " " Or txtRendondeo2.Text = " " Or txtRedondeo3.Text = " " Or txtRedondeoAnual.Text = " " Or txtColoquio.Text = " " Or txtExamen.Text = " " Or txtRendonFinal.Text = " " Then
                MsgBox("Los campos no pueden estar vacios")
            Else

                Dim Alu = New Alumno_x_materia

                Alu.id_alumno = CInt(txtIdAlu1.Text)
                Alu.id_materia = cboMateria.SelectedValue
                Alu.parcial1 = txtParcial1.Text
                Alu.fechaParcial1 = dtpP1.Text
                Alu.parcial2 = txtParcial2.Text
                Alu.fechaParcial2 = dtpP2.Text
                Alu.parcial3 = txtParcial3.Text
                Alu.fechaParcial3 = dtpP3.Text
                Alu.parcial4 = txtParcial4.Text
                Alu.fechaParcial4 = dtpP4.Text
                Alu.parcial5 = txtParcial5.Text
                Alu.fechaParcial5 = dtpP5.Text
                Alu.parcial6 = txtParcial6.Text
                Alu.fechaParcial6 = dtpP6.Text
                Alu.parcial7 = txtParcial7.Text
                Alu.fechaParcial7 = dtpP7.Text
                Alu.parcial8 = txtParcial8.Text
                Alu.fechaParcial8 = dtpP8.Text
                Alu.parcial9 = txtParcial9.Text
                Alu.fechaParcial9 = dtpP9.Text
                Alu.parcial10 = txtParcial10.Text
                Alu.fechaParcial10 = dtpP10.Text
                Alu.parcial11 = txtParcial11.Text
                Alu.fechaParcial11 = dtpP11.Text
                Alu.parcial12 = txtParcial12.Text
                Alu.fechaParcial12 = dtpP12.Text
                Alu.integrador1 = txtInteg1.Text
                Alu.integrador2 = txtInteg2.Text
                Alu.integrador3 = txtInteg3.Text
                Alu.fechaInteg1 = dtpInteg1.Text
                Alu.fechaInteg2 = dtpInteg2.Text
                Alu.fechaInteg3 = dtpInteg3.Text
                Alu.promedioetapa1 = txtredondeo.Text
                Alu.promedioetapa2 = txtRendondeo2.Text
                Alu.promedioetapa3 = txtRedondeo3.Text
                Alu.promedio_anual = txtRedondeoAnual.Text
                Alu.coloquio = txtColoquio.Text
                Alu.examen = txtExamen.Text
                Alu.fechacoloquio = dtpColoquio.Text
                Alu.fechaexamen = dtpExamen.Text
                Alu.calif_definitiva = txtRendonFinal.Text
                Alu.condicion_textbox = cboCondicion.Text



                DataContext.Alumno_x_materia.InsertOnSubmit(Alu)
                DataContext.SubmitChanges()
                MsgBox("Se ha dado de alta el registro correctamente", vbInformation)
                LimpiarControlesCalif()
                DesHabilitaControlesCalific()
                limpiarControlesBusca()
                DeshabilitarcontrolesBuscarAlu1()
            End If
        End Try

    End Sub

    Private Sub limpiarControlesBusca()
        txtnombre.Text = ""
        txtIdAlu1.Text = ""
        txtapellido.Text = ""
        txtDNI.Text = ""
        cboMateria.SelectedIndex = -1
    End Sub

    Private Sub ponerCeros()

        txtParcial1.Text = "0"
        txtParcial2.Text = "0"
        txtParcial3.Text = "0"
        txtParcial4.Text = "0"
        txtParcial5.Text = "0"
        txtParcial6.Text = "0"
        txtParcial7.Text = "0"
        txtParcial8.Text = "0"
        txtParcial9.Text = "0"
        txtParcial10.Text = "0"
        txtParcial11.Text = "0"
        txtParcial12.Text = "0"
        txtInteg1.Text = "0"
        txtInteg2.Text = "0"
        txtInteg3.Text = "0"
        txtredondeo.Text = "0"
        txtRendondeo2.Text = "0"
        txtRedondeo3.Text = "0"
        txtRedondeoAnual.Text = "0"
        txtColoquio.Text = "0"
        txtExamen.Text = "0"
        txtRendonFinal.Text = "0"
    End Sub

    Private Sub cmdCancelarCF_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelarCF.Click
        limpiarControlesBusca()
        DeshabilitarcontrolesBuscarAlu1()
        LimpiarControlesCalif()
        DesHabilitaControlesCalific()
    End Sub

    Private Sub cboMateria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMateria.Click
        HabilitaControlesCalific()
        ponerCeros()
    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click

        If txtParcial1.Text = " " Or txtParcial2.Text = " " Or txtParcial3.Text = " " Or txtParcial4.Text = " " Or txtParcial5.Text = " " Or txtParcial6.Text = " " Or txtParcial7.Text = " " Or txtParcial8.Text = " " Or txtParcial9.Text = " " Or txtParcial10.Text = " " Or txtParcial11.Text = " " Or txtParcial12.Text = " " Or txtInteg1.Text = " " Or txtInteg2.Text = " " Or txtInteg3.Text = " " Or txtredondeo.Text = " " Or txtRendondeo2.Text = " " Or txtRedondeo3.Text = " " Or txtRedondeoAnual.Text = " " Or txtColoquio.Text = " " Or txtExamen.Text = " " Or txtRendonFinal.Text = " " Then
            MsgBox("Los campos no pueden estar vacios")
        Else

            Dim actualizaA = (From C In DataContext.Alumno_x_materia Where C.id_alumno = CInt(txtIdAlu.Text) Select C).Single

            actualizaA.parcial1 = txtParcial1.Text
            actualizaA.fechaParcial1 = dtpP1.Text
            actualizaA.parcial2 = txtParcial2.Text
            actualizaA.fechaParcial2 = dtpP2.Text
            actualizaA.parcial3 = txtParcial3.Text
            actualizaA.fechaParcial3 = dtpP3.Text
            actualizaA.parcial4 = txtParcial4.Text
            actualizaA.fechaParcial4 = dtpP4.Text
            actualizaA.parcial5 = txtParcial5.Text
            actualizaA.fechaParcial5 = dtpP5.Text
            actualizaA.parcial6 = txtParcial6.Text
            actualizaA.fechaParcial6 = dtpP6.Text
            actualizaA.parcial7 = txtParcial7.Text
            actualizaA.fechaParcial7 = dtpP7.Text
            actualizaA.parcial8 = txtParcial8.Text
            actualizaA.fechaParcial8 = dtpP8.Text
            actualizaA.parcial9 = txtParcial9.Text
            actualizaA.fechaParcial9 = dtpP9.Text
            actualizaA.parcial10 = txtParcial10.Text
            actualizaA.fechaParcial10 = dtpP10.Text
            actualizaA.parcial11 = txtParcial11.Text
            actualizaA.fechaParcial11 = dtpP11.Text
            actualizaA.parcial12 = txtParcial12.Text
            actualizaA.fechaParcial12 = dtpP12.Text
            actualizaA.integrador1 = txtInteg1.Text
            actualizaA.integrador2 = txtInteg2.Text
            actualizaA.integrador3 = txtInteg3.Text
            actualizaA.fechaInteg1 = dtpInteg1.Text
            actualizaA.fechaInteg2 = dtpInteg2.Text
            actualizaA.fechaInteg3 = dtpInteg3.Text
            actualizaA.promedioetapa1 = txtredondeo.Text
            actualizaA.promedioetapa2 = txtRendondeo2.Text
            actualizaA.promedioetapa3 = txtRedondeo3.Text
            actualizaA.promedio_anual = txtRedondeoAnual.Text
            actualizaA.coloquio = txtColoquio.Text
            actualizaA.examen = txtExamen.Text
            actualizaA.fechacoloquio = dtpColoquio.Text
            actualizaA.fechaexamen = dtpExamen.Text
            actualizaA.calif_definitiva = txtRendonFinal.Text
            actualizaA.condicion_textbox = cboCondicion.Text
            DataContext.SubmitChanges()

            MsgBox("Los cambios se han realizado correctamente")
            LimpiarControlesCalif()
            limpiarControlesActualiza()
            MostrarGrilla()
            iniciarControlesControlesBuscaAlu2()
            DesHabilitaControlesCalific()
            limpiarControlesBusca()
            DeshabilitarcontrolesBuscarAlu1()
        End If
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim eliminar = (From C In DataContext.Alumno_x_materia Where C.id_alumno = CInt(txtIdAlu.Text)).ToList()(0)
        DataContext.Alumno_x_materia.DeleteOnSubmit(eliminar)
        DataContext.SubmitChanges()
        MsgBox("El registro ha sido eliminado!")
        limpiarControlesActualiza()
        desHabilitaControlesBuscaAlu2()
        iniciarControlesControlesBuscaAlu2()
        cmdBuscar2.Enabled = True
        MostrarGrilla()
        cmdEliminar.Enabled = False
    End Sub

    
End Class