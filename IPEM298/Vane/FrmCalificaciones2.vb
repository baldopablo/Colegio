Public Class FrmCalificaciones2
    Dim datacontext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext

    Public vble_idalu As Integer
    Public vble_especialidad As String

    'LOAD DEL FORM
    Private Sub FrmCalificaciones2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'CARGAR COMBO MATERIAS SEGUN ESPECIALIDAD DEL ALUMNO ELEGIDO
    Public Sub cargar_materias()
        Dim esp = (From e In datacontextvistas.vista_alum_xcurso Select e.DNI_alu, e.especialidad Where DNI_alu = txtDNI.Text).ToList()(0)
        vble_especialidad = esp.especialidad

        Dim Datos = From C In datacontext.Materia Select C.id_materia, C.nombre_materia, C.especialidad_textbox Where especialidad_textbox = vble_especialidad

        Me.Cbomateria.DataSource = Datos
        Me.Cbomateria.DisplayMember = "nombre_materia"
        Me.Cbomateria.ValueMember = "id_materia"
        Me.Cbomateria.SelectedIndex = -1
    End Sub

    'BOTON BUSCAR
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim BuscaAlu = (From alu In datacontext.Alumno Select alu.apellido_alu Where apellido_alu = txtapellido.Text).Any
        If BuscaAlu = False Then
            MsgBox("No existen alumnos con el apellido ingresado")
            Exit Sub
        End If
        FrmBusqAlu1.Show()
    End Sub

    'CARGA LA GRILLA CON LAS NOTAS DE LA MATERIA SELECCIONADA
    Private Sub ActualizaGrillaCalif()
        Dim consulta = From V In datacontextvistas.vista_calificaciones Select V.id_alumno, V.nombre_alu, V.apellido_alu, V.DNI_alu, V.parcial1, V.fechaParcial1, V.parcial2, V.fechaParcial2, V.parcial3, V.fechaParcial3, V.parcial4, V.fechaParcial4, V.integrador1, V.fechaInteg1, V.promedioetapa1, V.parcial5, V.fechaParcial5, V.parcial6, V.fechaParcial6, V.parcial7, V.fechaParcial7, V.parcial8, V.fechaParcial8, V.integrador2, V.fechaInteg2, V.promedioetapa2, V.parcial9, V.fechaParcial9, V.parcial10, V.fechaParcial10, V.parcial11, V.fechaParcial11, V.parcial12, V.fechaParcial12, V.integrador3, V.fechaInteg3, V.promedioetapa3, V.promedio_anual, V.coloquio, V.fechacoloquio, V.examen, V.fechaexamen, V.calif_definitiva, V.condicion_textbox, V.nombre_materia Where id_alumno = vble_idalu And nombre_materia = Cbomateria.Text

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

        Dgrcalificaciones.DataSource = consulta
        'dgrCalificaciones.ClearSelection()

    End Sub

    'CARGA LOS DATOS DE LA GRILLA EN LOS CAMPOS
    Private Sub Pasadatos()
        If Dgrcalificaciones.Rows.Count > 0 Then
            txtParcial1.Text = Dgrcalificaciones.Item("parcial1", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial2.Text = Dgrcalificaciones.Item("parcial2", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial3.Text = Dgrcalificaciones.Item("parcial3", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial4.Text = Dgrcalificaciones.Item("parcial4", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial5.Text = Dgrcalificaciones.Item("parcial5", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial6.Text = Dgrcalificaciones.Item("parcial6", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial7.Text = Dgrcalificaciones.Item("parcial7", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial8.Text = Dgrcalificaciones.Item("parcial8", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial9.Text = Dgrcalificaciones.Item("parcial9", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial10.Text = Dgrcalificaciones.Item("parcial10", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial11.Text = Dgrcalificaciones.Item("parcial11", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtParcial12.Text = Dgrcalificaciones.Item("parcial12", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtPromE1.Text = Dgrcalificaciones.Item("promedioetapa1", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtPromE2.Text = Dgrcalificaciones.Item("promedioetapa2", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtPromE3.Text = Dgrcalificaciones.Item("promedioetapa3", Dgrcalificaciones.SelectedRows(0).Index).Value
            'txtredondeo.Text = Dgrcalificaciones.Item("promedioetapa1", Dgrcalificaciones.SelectedRows(0).Index).Value
            'txtRendondeo2.Text = Dgrcalificaciones.Item("promedioetapa2", Dgrcalificaciones.SelectedRows(0).Index).Value
            'txtRedondeo3.Text = Dgrcalificaciones.Item("promedioetapa3", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtPromAnual.Text = Dgrcalificaciones.Item("promedio_anual", Dgrcalificaciones.SelectedRows(0).Index).Value
            'txtRedondeoAnual.Text = Dgrcalificaciones.Item("promedio_anual", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtColoquio.Text = Dgrcalificaciones.Item("coloquio", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtInteg1.Text = Dgrcalificaciones.Item("integrador1", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtInteg2.Text = Dgrcalificaciones.Item("integrador2", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtInteg3.Text = Dgrcalificaciones.Item("integrador3", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtExamen.Text = Dgrcalificaciones.Item("examen", Dgrcalificaciones.SelectedRows(0).Index).Value
            txtCalifDef.Text = Dgrcalificaciones.Item("calif_definitiva", Dgrcalificaciones.SelectedRows(0).Index).Value
            'txtRendonFinal.Text = Dgrcalificaciones.Item("calif_definitiva", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP1.Text = Dgrcalificaciones.Item("fechaParcial1", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP2.Text = Dgrcalificaciones.Item("fechaParcial2", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP3.Text = Dgrcalificaciones.Item("fechaParcial3", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP4.Text = Dgrcalificaciones.Item("fechaParcial4", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP5.Text = Dgrcalificaciones.Item("fechaParcial5", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP6.Text = Dgrcalificaciones.Item("fechaParcial6", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP7.Text = Dgrcalificaciones.Item("fechaParcial7", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP8.Text = Dgrcalificaciones.Item("fechaParcial8", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP9.Text = Dgrcalificaciones.Item("fechaParcial9", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP10.Text = Dgrcalificaciones.Item("fechaParcial10", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP11.Text = Dgrcalificaciones.Item("fechaParcial11", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpP12.Text = Dgrcalificaciones.Item("fechaParcial12", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpInteg1.Text = Dgrcalificaciones.Item("fechaInteg1", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpInteg2.Text = Dgrcalificaciones.Item("fechaInteg2", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpInteg3.Text = Dgrcalificaciones.Item("fechaInteg3", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpColoquio.Text = Dgrcalificaciones.Item("fechacoloquio", Dgrcalificaciones.SelectedRows(0).Index).Value
            dtpExamen.Text = Dgrcalificaciones.Item("fechaexamen", Dgrcalificaciones.SelectedRows(0).Index).Value
            cboCondicion.Text = Dgrcalificaciones.Item("condicion_textbox", Dgrcalificaciones.SelectedRows(0).Index).Value
        End If
    End Sub

    'BOTON GUARDAR
    Private Sub cmdGuardarCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardarCF.Click
        If txtParcial1.Text = " " Or txtParcial2.Text = " " Or txtParcial3.Text = " " Or txtParcial4.Text = " " Or txtParcial5.Text = " " Or txtParcial6.Text = " " Or txtParcial7.Text = " " Or txtParcial8.Text = " " Or txtParcial9.Text = " " Or txtParcial10.Text = " " Or txtParcial11.Text = " " Or txtParcial12.Text = " " Or txtInteg1.Text = " " Or txtInteg2.Text = " " Or txtInteg3.Text = " " Or txtredondeo.Text = " " Or txtRendondeo2.Text = " " Or txtRedondeo3.Text = " " Or txtRedondeoAnual.Text = " " Or txtColoquio.Text = " " Or txtExamen.Text = " " Or txtRendonFinal.Text = " " Then
            MsgBox("Los campos no pueden estar vacios")
        Else

            If validarCalificación(Val(txtParcial1.Text), Val(txtParcial2.Text), Val(txtParcial3.Text), Val(txtParcial4.Text), Val(txtInteg1.Text)) = "califmala" Then
                Exit Sub
            End If

            If validarCalificación(Val(txtParcial5.Text), Val(txtParcial6.Text), Val(txtParcial7.Text), Val(txtParcial8.Text), Val(txtInteg2.Text)) = "califmala" Then
                Exit Sub
            End If

            If validarCalificación(Val(txtParcial9.Text), Val(txtParcial10.Text), Val(txtParcial11.Text), Val(txtParcial12.Text), Val(txtInteg3.Text)) = "califmala" Then
                Exit Sub
            End If

            calcularprom(txtParcial1, txtParcial2, txtParcial3, txtParcial4, txtInteg1, txtPromE1)
            calcularprom(txtParcial5, txtParcial6, txtParcial7, txtParcial8, txtInteg2, txtPromE2)
            calcularprom(txtParcial9, txtParcial10, txtParcial11, txtParcial12, txtInteg3, txtPromE3)
            calcularpromanual()
            calcularcalifdef()

            Dim materia1 As Integer = Cbomateria.SelectedValue
            Dim actualizaA = (From C In datacontext.Alumno_x_materia Where C.id_alumno = vble_idalu And C.id_materia = materia1).ToList()(0)

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
            actualizaA.promedioetapa1 = CDbl(txtPromE1.Text)
            actualizaA.promedioetapa2 = CDbl(txtPromE2.Text)
            actualizaA.promedioetapa3 = CDbl(txtPromE3.Text)
            actualizaA.promedio_anual = CDbl(txtPromAnual.Text)
            actualizaA.coloquio = txtColoquio.Text
            actualizaA.examen = txtExamen.Text
            actualizaA.fechacoloquio = dtpColoquio.Text
            actualizaA.fechaexamen = dtpExamen.Text
            actualizaA.calif_definitiva = CDbl(txtCalifDef.Text)
            actualizaA.condicion_textbox = cboCondicion.Text

            datacontext.SubmitChanges()
            MsgBox("Se guardaron los cambios")
            ActualizaGrillaCalif()
            Pasadatos()
            End If
    End Sub

    'CALULA PROMEDIO DE LAS ETAPAS
    Private Sub calcularprom(ByVal p1 As Object, ByVal p2 As Object, ByVal p3 As Object, ByVal p4 As Object, ByVal i1 As Object, ByVal prom As Object)
        Dim e1 As Double
        Dim cantidad As Integer = 0
        If p1.Text <> 0 Then
            e1 = e1 + Val(p1.Text)
            cantidad += 1
        End If
        If p2.Text <> 0 Then
            e1 = e1 + Val(p2.Text)
            cantidad += 1
        End If
        If p3.Text <> 0 Then
            e1 = e1 + Val(p3.Text)
            cantidad += 1
        End If
        If p4.Text <> 0 Then
            e1 = e1 + Val(p4.Text)
            cantidad += 1
        End If
        If i1.Text <> 0 Then
            e1 = e1 + Val(i1.Text)
            cantidad += 1
        End If
        If cantidad = 0 Then
            prom.text = (e1 / 1)
        Else
            prom.text = (e1 / cantidad)
        End If
    End Sub

    'CALCULA EL PROMEDIO ANUAL
    Private Sub calcularpromanual()
        Dim pa As Double
        pa = Val(txtPromE1.Text) + Val(txtPromE2.Text) + Val(txtPromE3.Text)
        txtPromAnual.Text = (pa / 3)
    End Sub

    'CALCULAR CALIFICACION DEFINITIVA
    Private Sub calcularcalifdef()
        If CDbl(txtPromAnual.Text) >= 6 Then
            txtCalifDef.Text = CDbl(txtPromAnual.Text)
        ElseIf CInt(txtColoquio.Text) <> 0 Then
            txtCalifDef.Text = CInt(txtColoquio.Text)
        ElseIf CInt(txtExamen.Text) <> 0 Then
            txtCalifDef.Text = CInt(txtExamen.Text)
        Else
            txtCalifDef.Text = 0
        End If
    End Sub

    'CONSULTAR MATERIA
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_consultar_mat.Click
        If Cbomateria.Text = "" Then
            MsgBox("Elija materia")
            Exit Sub
        End If
        GroupBox1.Enabled = False
        Dim materia As Integer = Cbomateria.SelectedValue
        Dim validaexista = (From v In datacontext.Alumno_x_materia Select v.id_alumno, v.id_materia Where id_alumno = vble_idalu And id_materia = materia).Any

        If validaexista = True Then
            ActualizaGrillaCalif()
            Pasadatos()
            Select Case MsgBox("Va a modificar las notas", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Modificaciòn de notas")
                Case MsgBoxResult.Ok
                    GroupBox_calificaciones.Enabled = True
                Case MsgBoxResult.Cancel
                    GroupBox_calificaciones.Enabled = False
                    Exit Sub
            End Select
        Else
            ponerCeros()
            alta()
            GroupBox_calificaciones.Enabled = True
        End If
    End Sub

    'DA DE ALTA EL ALUMNO EN LA TABLA ALU X MATERIA
    Private Sub alta()
        Try
            Dim Alu = New Alumno_x_materia
            Alu.id_alumno = vble_idalu
            Alu.id_materia = Cbomateria.SelectedValue
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
            Alu.promedioetapa1 = txtPromE1.Text
            Alu.promedioetapa2 = txtPromE2.Text
            Alu.promedioetapa3 = txtPromE3.Text
            'Alu.promedioetapa1 = txtredondeo.Text
            'Alu.promedioetapa2 = txtRendondeo2.Text
            'Alu.promedioetapa3 = txtRedondeo3.Text
            Alu.promedio_anual = txtPromAnual.Text
            'Alu.promedio_anual = txtRedondeoAnual.Text
            Alu.coloquio = txtColoquio.Text
            Alu.examen = txtExamen.Text
            Alu.fechacoloquio = dtpColoquio.Text
            Alu.fechaexamen = dtpExamen.Text
            Alu.calif_definitiva = txtCalifDef.Text
            'Alu.calif_definitiva = txtRendonFinal.Text
            Alu.condicion_textbox = cboCondicion.Text
            datacontext.Alumno_x_materia.InsertOnSubmit(Alu)
            datacontext.SubmitChanges()
            MsgBox("Se ha dado de alta el registro correctamente", vbInformation)

        Catch ex As Exception
            If txtParcial1.Text = " " Or txtParcial2.Text = " " Or txtParcial3.Text = " " Or txtParcial4.Text = " " Or txtParcial5.Text = " " Or txtParcial6.Text = " " Or txtParcial7.Text = " " Or txtParcial8.Text = " " Or txtParcial9.Text = " " Or txtParcial10.Text = " " Or txtParcial11.Text = " " Or txtParcial12.Text = " " Or txtInteg1.Text = " " Or txtInteg2.Text = " " Or txtInteg3.Text = " " Or txtredondeo.Text = " " Or txtRendondeo2.Text = " " Or txtRedondeo3.Text = " " Or txtRedondeoAnual.Text = " " Or txtColoquio.Text = " " Or txtExamen.Text = " " Or txtRendonFinal.Text = " " Then
                MsgBox("Los campos no pueden estar vacios")
            Else
            End If
        End Try
    End Sub

    'CARGA CEROS EN LOS CAMPOS
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
        txtPromE1.Text = "0"
        txtPromE2.Text = "0"
        txtPromE3.Text = "0"
        'txtredondeo.Text = "0"
        'txtRendondeo2.Text = "0"
        'txtRedondeo3.Text = "0"
        txtPromAnual.Text = "0"

        'txtRedondeoAnual.Text = "0"
        txtColoquio.Text = "0"
        txtExamen.Text = "0"
        txtCalifDef.Text = "0"
        'txtRendonFinal.Text = "0"
        cboCondicion.SelectedIndex = 0
    End Sub

    'BOTON CANCELAR
    Private Sub cmdCancelarCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelarCF.Click
        GroupBox1.Enabled = True
        LimpiarControlesCalif()
        GroupBox_calificaciones.Enabled = False
    End Sub

    'LIMPIAR CALIFICACIONES
    Private Sub LimpiarControlesCalif()
        Cbomateria.SelectedIndex = -1
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

    'LIMPIA BUSQUEDA
    Private Sub limpiarControlesBusca()
        txtnombre.Text = ""
        vble_idalu = 0
        txtapellido.Text = ""
        txtDNI.Text = ""
    End Sub

    'BOTON LIMPIAR
    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        limpiarControlesBusca()
        LimpiarControlesCalif()
        GroupBox_materia.Enabled = False
    End Sub

    'VALIDAR NOTAS
    Private Function validarCalificación(ByVal nump1 As Double, ByVal nump2 As Double, ByVal nump3 As Double, ByVal nump4 As Double, ByVal nump5 As Double)
        If nump1 < 0 Or nump1 > 10 Or nump2 < 0 Or nump2 > 10 Or nump3 < 0 Or nump3 > 10 Or nump4 < 0 Or nump4 > 10 Or nump5 < 0 Or nump5 > 10 Then
            MsgBox("La calificación no puede ser inferior a 0 o mayor a 10")
            Return "califmala"
        Else
            Return "califbuena"
        End If
    End Function

    'BOTON ELIMINAR
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Select Case MsgBox("Va a eliminar una materia del alumno", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Modificaciòn alumno")
            Case MsgBoxResult.Ok
                Dim eliminar = (From C In datacontext.Alumno_x_materia Where C.id_alumno = CInt(vble_idalu)).ToList()(0)
                datacontext.Alumno_x_materia.DeleteOnSubmit(eliminar)
                datacontext.SubmitChanges()
                MsgBox("El registro ha sido eliminado!")
                GroupBox_calificaciones.Enabled = False
                LimpiarControlesCalif()
            Case MsgBoxResult.Cancel
                Exit Sub
        End Select
    End Sub

    'BOTON SALIR
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_salir_calif2.Click
        Me.Close()
    End Sub

    'VALIDA SOLO LETRAS EN APELLIDO
    Private Sub txtapellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

End Class