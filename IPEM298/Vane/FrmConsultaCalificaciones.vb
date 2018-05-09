Public Class FrmConsultaCalificaciones
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim id As Integer

    Private Sub FrmConsultaCalificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarGrilla()
        DeshabilitaControles()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Sub MostrarGrilla()


        dgrCalif.AutoGenerateColumns = False
        dgrCalif.Columns.Clear()

        dgrCalif.Columns.Add("", "Materia")
        dgrCalif.Columns.Add("", "Parcial 1")
        dgrCalif.Columns.Add("", "Fecha P1")
        dgrCalif.Columns.Add("", "Parcial 2")
        dgrCalif.Columns.Add("", "Fecha P2")
        dgrCalif.Columns.Add("", "Parcial 3")
        dgrCalif.Columns.Add("", "Fecha P3")
        dgrCalif.Columns.Add("", "Parcial 4")
        dgrCalif.Columns.Add("", "Fecha P4")
        dgrCalif.Columns.Add("", "Integrador 1")
        dgrCalif.Columns.Add("", "Fecha I1")
        dgrCalif.Columns.Add("", "Promedio 1° E")
        dgrCalif.Columns.Add("", "Parcial 5")
        dgrCalif.Columns.Add("", "Fecha P5")
        dgrCalif.Columns.Add("", "Parcial 6")
        dgrCalif.Columns.Add("", "Fecha P6")
        dgrCalif.Columns.Add("", "Parcial 7")
        dgrCalif.Columns.Add("", "Fecha P7")
        dgrCalif.Columns.Add("", "Parcial 8")
        dgrCalif.Columns.Add("", "Fecha P8")
        dgrCalif.Columns.Add("", "Integrador 2")
        dgrCalif.Columns.Add("", "Fecha I2")
        dgrCalif.Columns.Add("", "Promedio 2° E")
        dgrCalif.Columns.Add("", "Parcial 9")
        dgrCalif.Columns.Add("", "Fecha P9")
        dgrCalif.Columns.Add("", "Parcial 10")
        dgrCalif.Columns.Add("", "Fecha P10")
        dgrCalif.Columns.Add("", "Parcial 11")
        dgrCalif.Columns.Add("", "Fecha P11")
        dgrCalif.Columns.Add("", "Parcial 12")
        dgrCalif.Columns.Add("", "Fecha P12")
        dgrCalif.Columns.Add("", "Integrador 3")
        dgrCalif.Columns.Add("", "Fecha I3")
        dgrCalif.Columns.Add("", "Promedio 3° E")
        dgrCalif.Columns.Add("", "Prom Anual")
        dgrCalif.Columns.Add("", "Coloquio")
        dgrCalif.Columns.Add("", "Fecha Col")
        dgrCalif.Columns.Add("", "Exámen")
        dgrCalif.Columns.Add("", "Fecha Ex")
        dgrCalif.Columns.Add("", "Calificación Final")
        dgrCalif.Columns.Add("", "Condición")

        dgrCalif.Columns(0).DataPropertyName = ""
        dgrCalif.Columns(1).DataPropertyName = ""
        dgrCalif.Columns(2).DataPropertyName = ""
        dgrCalif.Columns(3).DataPropertyName = ""
        dgrCalif.Columns(4).DataPropertyName = ""
        dgrCalif.Columns(5).DataPropertyName = ""
        dgrCalif.Columns(6).DataPropertyName = ""
        dgrCalif.Columns(7).DataPropertyName = ""
        dgrCalif.Columns(8).DataPropertyName = ""
        dgrCalif.Columns(9).DataPropertyName = ""
        dgrCalif.Columns(10).DataPropertyName = ""
        dgrCalif.Columns(11).DataPropertyName = ""
        dgrCalif.Columns(12).DataPropertyName = ""
        dgrCalif.Columns(13).DataPropertyName = ""
        dgrCalif.Columns(14).DataPropertyName = ""
        dgrCalif.Columns(15).DataPropertyName = ""
        dgrCalif.Columns(16).DataPropertyName = ""
        dgrCalif.Columns(17).DataPropertyName = ""
        dgrCalif.Columns(18).DataPropertyName = ""
        dgrCalif.Columns(19).DataPropertyName = ""
        dgrCalif.Columns(20).DataPropertyName = ""
        dgrCalif.Columns(21).DataPropertyName = ""
        dgrCalif.Columns(22).DataPropertyName = ""
        dgrCalif.Columns(23).DataPropertyName = ""
        dgrCalif.Columns(24).DataPropertyName = ""
        dgrCalif.Columns(25).DataPropertyName = ""
        dgrCalif.Columns(26).DataPropertyName = ""
        dgrCalif.Columns(27).DataPropertyName = ""
        dgrCalif.Columns(28).DataPropertyName = ""
        dgrCalif.Columns(29).DataPropertyName = ""
        dgrCalif.Columns(30).DataPropertyName = ""
        dgrCalif.Columns(31).DataPropertyName = ""
        dgrCalif.Columns(32).DataPropertyName = ""
        dgrCalif.Columns(33).DataPropertyName = ""
        dgrCalif.Columns(34).DataPropertyName = ""
        dgrCalif.Columns(35).DataPropertyName = ""
        dgrCalif.Columns(36).DataPropertyName = ""
        dgrCalif.Columns(37).DataPropertyName = ""
        dgrCalif.Columns(38).DataPropertyName = ""
        dgrCalif.Columns(39).DataPropertyName = ""
        dgrCalif.Columns(40).DataPropertyName = ""

    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtApellido.Text = "" Then
            MsgBox("Ingrese un apellido para buscar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
        End If
        Dim BuscaAlu = (From alu In DataContext.Alumno Select alu.apellido_alu Where apellido_alu = txtApellido.Text).Any
        If BuscaAlu = False Then
            MsgBox("No existen alumnos con el apellido ingresado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
            Exit Sub
        End If
        Me.Enabled = False
        FrmBusqCali.Show()
    End Sub

    Private Sub LimpiarControles()
        txtNombre.Text = ""
        txtApellido.Text = ""
        id = Nothing
        txtDNI.Text = ""
        txtIdAlu.Text = ""
        cbobusqueda.SelectedIndex = -1
        rbnCondición.Checked = False
        rbnMateria.Checked = False
        rbnTodos.Checked = False
        'dgrCalif.DataSource = Nothing
        'dgrCalif.DataMember = Nothing
        'dgrCalif.Rows.Clear()
        dgrCalif.Columns.Clear()
        MostrarGrilla()
    End Sub

    Private Sub cboBusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbobusqueda.SelectedIndexChanged
        If rbnMateria.Checked = True Then
            MostrarGrillaMateria()

        ElseIf rbnCondición.Checked = True Then
            MostrarGrillaCondicion()

        Else

            MostrarGrilla()


        End If
    End Sub
    Private Sub CargarCondicion()

        cbobusqueda.Items.Add("Regular")
        cbobusqueda.Items.Add("Libre")
        cbobusqueda.Items.Add("Promoción")
        cbobusqueda.Items.Add("Aprobado")
        cbobusqueda.SelectedIndex = -1

    End Sub

    Private Sub rbnCondicion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnCondición.CheckedChanged
        cbobusqueda.Enabled = True
        cbobusqueda.DataSource = Nothing
        cbobusqueda.DisplayMember = Nothing
        cbobusqueda.ValueMember = Nothing
        cbobusqueda.Items.Clear()
        CargarCondicion()
    End Sub

    Private Sub CargarMateria()

        Dim Datos = From C In DataContext.Materia Select C.id_materia, C.nombre_materia Where nombre_materia <> "Ninguna"

        cbobusqueda.DataSource = Datos
        cbobusqueda.DisplayMember = "nombre_materia"
        cbobusqueda.ValueMember = "id_materia"
        cbobusqueda.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiarControles()
        DeshabilitaControles()
    End Sub

    Private Sub rbnTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnTodos.CheckedChanged
        cbobusqueda.DataSource = Nothing
        cbobusqueda.DisplayMember = Nothing
        cbobusqueda.ValueMember = Nothing
        cbobusqueda.Items.Clear()
        cbobusqueda.SelectedIndex = -1
        cbobusqueda.Text = ""
        cbobusqueda.Enabled = False
        CargarGrillaTodos()
    End Sub

    Private Sub rbnMateria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnMateria.CheckedChanged
        cbobusqueda.Enabled = True
        CargarMateria()
    End Sub



    Private Sub MostrarGrillaMateria()
        'Dim consulta = From C In DataContext.vista_calificaciones Select C.id_alumno, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = id And nombre_curso = cbobusqueda.Text Order By dia_semana
        Dim consulta = From V In datacontextvistas.vista_calificaciones Select V.id_alumno, V.nombre_alu, V.apellido_alu, V.DNI_alu, V.parcial1, V.fechaParcial1, V.parcial2, V.fechaParcial2, V.parcial3, V.fechaParcial3, V.parcial4, V.fechaParcial4, V.integrador1, V.fechaInteg1, V.promedioetapa1, V.parcial5, V.fechaParcial5, V.parcial6, V.fechaParcial6, V.parcial7, V.fechaParcial7, V.parcial8, V.fechaParcial8, V.integrador2, V.fechaInteg2, V.promedioetapa2, V.parcial9, V.fechaParcial9, V.parcial10, V.fechaParcial10, V.parcial11, V.fechaParcial11, V.parcial12, V.fechaParcial12, V.integrador3, V.fechaInteg3, V.promedioetapa3, V.promedio_anual, V.coloquio, V.fechacoloquio, V.examen, V.fechaexamen, V.calif_definitiva, V.condicion_textbox, V.nombre_materia Where id_alumno = (txtIdAlu.Text) And nombre_materia = cbobusqueda.Text Order By condicion_textbox

        'dgrCalif.Enabled = True
        dgrCalif.AutoGenerateColumns = False
        dgrCalif.Columns.Clear()

        dgrCalif.Columns.Add("nombre_materia", "Materia")
        dgrCalif.Columns.Add("parcial1", "Parcial 1")
        dgrCalif.Columns.Add("fechaParcial1", "Fecha P1")
        dgrCalif.Columns.Add("parcial2", "Parcial 2")
        dgrCalif.Columns.Add("fechaParcial2", "Fecha P2")
        dgrCalif.Columns.Add("parcial3", "Parcial 3")
        dgrCalif.Columns.Add("fechaParcial3", "Fecha P3")
        dgrCalif.Columns.Add("parcial4", "Parcial 4")
        dgrCalif.Columns.Add("fechaParcial4", "Fecha P4")
        dgrCalif.Columns.Add("integrador1", "Integrador 1")
        dgrCalif.Columns.Add("fechaInteg1", "Fecha I1")
        dgrCalif.Columns.Add("promedioetapa1", "Promedio 1° E")
        dgrCalif.Columns.Add("parcial5", "Parcial 5")
        dgrCalif.Columns.Add("fechaParcial5", "Fecha P5")
        dgrCalif.Columns.Add("parcial6", "Parcial 6")
        dgrCalif.Columns.Add("fechaParcial6", "Fecha P6")
        dgrCalif.Columns.Add("parcial7", "Parcial 7")
        dgrCalif.Columns.Add("fechaParcial7", "Fecha P7")
        dgrCalif.Columns.Add("parcial8", "Parcial 8")
        dgrCalif.Columns.Add("fechaParcial8", "Fecha P8")
        dgrCalif.Columns.Add("integrador2", "Integrador 2")
        dgrCalif.Columns.Add("fechaInteg2", "Fecha I2")
        dgrCalif.Columns.Add("promedioetapa2", "Promedio 2° E")
        dgrCalif.Columns.Add("parcial9", "Parcial 9")
        dgrCalif.Columns.Add("fechaParcial9", "Fecha P9")
        dgrCalif.Columns.Add("parcial10", "Parcial 10")
        dgrCalif.Columns.Add("fechaParcial10", "Fecha P10")
        dgrCalif.Columns.Add("parcial11", "Parcial 11")
        dgrCalif.Columns.Add("fechaParcial11", "Fecha P11")
        dgrCalif.Columns.Add("parcial12", "Parcial 12")
        dgrCalif.Columns.Add("fechaParcial12", "Fecha P12")
        dgrCalif.Columns.Add("integrador3", "Integrador 3")
        dgrCalif.Columns.Add("fechaInteg3", "Fecha I3")
        dgrCalif.Columns.Add("promedioetapa3", "Promedio 3° E")
        dgrCalif.Columns.Add("promedio_anual", "Prom Anual")
        dgrCalif.Columns.Add("coloquio", "Coloquio")
        dgrCalif.Columns.Add("fechacoloquio", "Fecha Col")
        dgrCalif.Columns.Add("examen", "Exámen")
        dgrCalif.Columns.Add("fechaexamen", "Fecha Ex")
        dgrCalif.Columns.Add("calif_definitiva", "Calificación Final")
        dgrCalif.Columns.Add("condicion_textbox", "Condición")


        dgrCalif.Columns(0).DataPropertyName = "nombre_materia"
        dgrCalif.Columns(1).DataPropertyName = "parcial1"
        dgrCalif.Columns(2).DataPropertyName = "fechaParcial1"
        dgrCalif.Columns(3).DataPropertyName = "parcial2"
        dgrCalif.Columns(4).DataPropertyName = "fechaParcial2"
        dgrCalif.Columns(5).DataPropertyName = "parcial3"
        dgrCalif.Columns(6).DataPropertyName = "fechaParcial3"
        dgrCalif.Columns(7).DataPropertyName = "parcial4"
        dgrCalif.Columns(8).DataPropertyName = "fechaParcial4"
        dgrCalif.Columns(9).DataPropertyName = "integrador1"
        dgrCalif.Columns(10).DataPropertyName = "fechaInteg1"
        dgrCalif.Columns(11).DataPropertyName = "promedioetapa1"
        dgrCalif.Columns(12).DataPropertyName = "parcial5"
        dgrCalif.Columns(13).DataPropertyName = "fechaParcial5"
        dgrCalif.Columns(14).DataPropertyName = "parcial6"
        dgrCalif.Columns(15).DataPropertyName = "fechaParcial6"
        dgrCalif.Columns(16).DataPropertyName = "parcial7"
        dgrCalif.Columns(17).DataPropertyName = "fechaParcial7"
        dgrCalif.Columns(18).DataPropertyName = "parcial8"
        dgrCalif.Columns(19).DataPropertyName = "fechaParcial8"
        dgrCalif.Columns(20).DataPropertyName = "integrador2"
        dgrCalif.Columns(21).DataPropertyName = "fechaInteg2"
        dgrCalif.Columns(22).DataPropertyName = "promedioetapa2"
        dgrCalif.Columns(23).DataPropertyName = "parcial9"
        dgrCalif.Columns(24).DataPropertyName = "fechaParcial9"
        dgrCalif.Columns(25).DataPropertyName = "parcial10"
        dgrCalif.Columns(26).DataPropertyName = "fechaParcial10"
        dgrCalif.Columns(27).DataPropertyName = "parcial11"
        dgrCalif.Columns(28).DataPropertyName = "fechaParcial11"
        dgrCalif.Columns(29).DataPropertyName = "parcial12"
        dgrCalif.Columns(30).DataPropertyName = "fechaParcial12"
        dgrCalif.Columns(31).DataPropertyName = "integrador3"
        dgrCalif.Columns(32).DataPropertyName = "fechaInteg3"
        dgrCalif.Columns(33).DataPropertyName = "promedioetapa3"
        dgrCalif.Columns(34).DataPropertyName = "promedio_anual"
        dgrCalif.Columns(35).DataPropertyName = "coloquio"
        dgrCalif.Columns(36).DataPropertyName = "fechacoloquio"
        dgrCalif.Columns(37).DataPropertyName = "examen"
        dgrCalif.Columns(38).DataPropertyName = "fechaexamen"
        dgrCalif.Columns(39).DataPropertyName = "calif_definitiva"
        dgrCalif.Columns(40).DataPropertyName = "condicion_textbox"

        dgrCalif.DataSource = consulta
    End Sub

    Private Sub MostrarGrillaCondicion()
        Dim consulta = From D In datacontextvistas.vista_calificaciones Select D.id_alumno, D.nombre_alu, D.apellido_alu, D.DNI_alu, D.parcial1, D.fechaParcial1, D.parcial2, D.fechaParcial2, D.parcial3, D.fechaParcial3, D.parcial4, D.fechaParcial4, D.integrador1, D.fechaInteg1, D.promedioetapa1, D.parcial5, D.fechaParcial5, D.parcial6, D.fechaParcial6, D.parcial7, D.fechaParcial7, D.parcial8, D.fechaParcial8, D.integrador2, D.fechaInteg2, D.promedioetapa2, D.parcial9, D.fechaParcial9, D.parcial10, D.fechaParcial10, D.parcial11, D.fechaParcial11, D.parcial12, D.fechaParcial12, D.integrador3, D.fechaInteg3, D.promedioetapa3, D.promedio_anual, D.coloquio, D.fechacoloquio, D.examen, D.fechaexamen, D.calif_definitiva, D.condicion_textbox, D.nombre_materia Where id_alumno = (txtIdAlu.Text) And condicion_textbox = cbobusqueda.Text 'Order By nombre_materia

        dgrCalif.AutoGenerateColumns = False
        dgrCalif.Columns.Clear()

        dgrCalif.Columns.Add("nombre_materia", "Materia")
        dgrCalif.Columns.Add("parcial1", "Parcial 1")
        dgrCalif.Columns.Add("fechaParcial1", "Fecha P1")
        dgrCalif.Columns.Add("parcial2", "Parcial 2")
        dgrCalif.Columns.Add("fechaParcial2", "Fecha P2")
        dgrCalif.Columns.Add("parcial3", "Parcial 3")
        dgrCalif.Columns.Add("fechaParcial3", "Fecha P3")
        dgrCalif.Columns.Add("parcial4", "Parcial 4")
        dgrCalif.Columns.Add("fechaParcial4", "Fecha P4")
        dgrCalif.Columns.Add("integrador1", "Integrador 1")
        dgrCalif.Columns.Add("fechaInteg1", "Fecha I1")
        dgrCalif.Columns.Add("promedioetapa1", "Promedio 1° E")
        dgrCalif.Columns.Add("parcial5", "Parcial 5")
        dgrCalif.Columns.Add("fechaParcial5", "Fecha P5")
        dgrCalif.Columns.Add("parcial6", "Parcial 6")
        dgrCalif.Columns.Add("fechaParcial6", "Fecha P6")
        dgrCalif.Columns.Add("parcial7", "Parcial 7")
        dgrCalif.Columns.Add("fechaParcial7", "Fecha P7")
        dgrCalif.Columns.Add("parcial8", "Parcial 8")
        dgrCalif.Columns.Add("fechaParcial8", "Fecha P8")
        dgrCalif.Columns.Add("integrador2", "Integrador 2")
        dgrCalif.Columns.Add("fechaInteg2", "Fecha I2")
        dgrCalif.Columns.Add("promedioetapa2", "Promedio 2° E")
        dgrCalif.Columns.Add("parcial9", "Parcial 9")
        dgrCalif.Columns.Add("fechaParcial9", "Fecha P9")
        dgrCalif.Columns.Add("parcial10", "Parcial 10")
        dgrCalif.Columns.Add("fechaParcial10", "Fecha P10")
        dgrCalif.Columns.Add("parcial11", "Parcial 11")
        dgrCalif.Columns.Add("fechaParcial11", "Fecha P11")
        dgrCalif.Columns.Add("parcial12", "Parcial 12")
        dgrCalif.Columns.Add("fechaParcial12", "Fecha P12")
        dgrCalif.Columns.Add("integrador3", "Integrador 3")
        dgrCalif.Columns.Add("fechaInteg3", "Fecha I3")
        dgrCalif.Columns.Add("promedioetapa3", "Promedio 3° E")
        dgrCalif.Columns.Add("promedio_anual", "Prom Anual")
        dgrCalif.Columns.Add("coloquio", "Coloquio")
        dgrCalif.Columns.Add("fechacoloquio", "Fecha Col")
        dgrCalif.Columns.Add("examen", "Exámen")
        dgrCalif.Columns.Add("fechaexamen", "Fecha Ex")
        dgrCalif.Columns.Add("calif_definitiva", "Calificación Final")
        dgrCalif.Columns.Add("condicion_textbox", "Condición")


        dgrCalif.Columns(0).DataPropertyName = "nombre_materia"
        dgrCalif.Columns(1).DataPropertyName = "parcial1"
        dgrCalif.Columns(2).DataPropertyName = "fechaParcial1"
        dgrCalif.Columns(3).DataPropertyName = "parcial2"
        dgrCalif.Columns(4).DataPropertyName = "fechaParcial2"
        dgrCalif.Columns(5).DataPropertyName = "parcial3"
        dgrCalif.Columns(6).DataPropertyName = "fechaParcial3"
        dgrCalif.Columns(7).DataPropertyName = "parcial4"
        dgrCalif.Columns(8).DataPropertyName = "fechaParcial4"
        dgrCalif.Columns(9).DataPropertyName = "integrador1"
        dgrCalif.Columns(10).DataPropertyName = "fechaInteg1"
        dgrCalif.Columns(11).DataPropertyName = "promedioetapa1"
        dgrCalif.Columns(12).DataPropertyName = "parcial5"
        dgrCalif.Columns(13).DataPropertyName = "fechaParcial5"
        dgrCalif.Columns(14).DataPropertyName = "parcial6"
        dgrCalif.Columns(15).DataPropertyName = "fechaParcial6"
        dgrCalif.Columns(16).DataPropertyName = "parcial7"
        dgrCalif.Columns(17).DataPropertyName = "fechaParcial7"
        dgrCalif.Columns(18).DataPropertyName = "parcial8"
        dgrCalif.Columns(19).DataPropertyName = "fechaParcial8"
        dgrCalif.Columns(20).DataPropertyName = "integrador2"
        dgrCalif.Columns(21).DataPropertyName = "fechaInteg2"
        dgrCalif.Columns(22).DataPropertyName = "promedioetapa2"
        dgrCalif.Columns(23).DataPropertyName = "parcial9"
        dgrCalif.Columns(24).DataPropertyName = "fechaParcial9"
        dgrCalif.Columns(25).DataPropertyName = "parcial10"
        dgrCalif.Columns(26).DataPropertyName = "fechaParcial10"
        dgrCalif.Columns(27).DataPropertyName = "parcial11"
        dgrCalif.Columns(28).DataPropertyName = "fechaParcial11"
        dgrCalif.Columns(29).DataPropertyName = "parcial12"
        dgrCalif.Columns(30).DataPropertyName = "fechaParcial12"
        dgrCalif.Columns(31).DataPropertyName = "integrador3"
        dgrCalif.Columns(32).DataPropertyName = "fechaInteg3"
        dgrCalif.Columns(33).DataPropertyName = "promedioetapa3"
        dgrCalif.Columns(34).DataPropertyName = "promedio_anual"
        dgrCalif.Columns(35).DataPropertyName = "coloquio"
        dgrCalif.Columns(36).DataPropertyName = "fechacoloquio"
        dgrCalif.Columns(37).DataPropertyName = "examen"
        dgrCalif.Columns(38).DataPropertyName = "fechaexamen"
        dgrCalif.Columns(39).DataPropertyName = "calif_definitiva"
        dgrCalif.Columns(40).DataPropertyName = "condicion_textbox"

        dgrCalif.DataSource = consulta
    End Sub

    Private Sub MostrarGrillaTodos()
        'Dim consulta = From C In DataContext.vista_horario_personal2 Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = id Order By dia_semana
        Dim consulta = From F In datacontextvistas.vista_calificaciones Select F.id_alumno, F.nombre_alu, F.apellido_alu, F.DNI_alu, F.parcial1, F.fechaParcial1, F.parcial2, F.fechaParcial2, F.parcial3, F.fechaParcial3, F.parcial4, F.fechaParcial4, F.integrador1, F.fechaInteg1, F.promedioetapa1, F.parcial5, F.fechaParcial5, F.parcial6, F.fechaParcial6, F.parcial7, F.fechaParcial7, F.parcial8, F.fechaParcial8, F.integrador2, F.fechaInteg2, F.promedioetapa2, F.parcial9, F.fechaParcial9, F.parcial10, F.fechaParcial10, F.parcial11, F.fechaParcial11, F.parcial12, F.fechaParcial12, F.integrador3, F.fechaInteg3, F.promedioetapa3, F.promedio_anual, F.coloquio, F.fechacoloquio, F.examen, F.fechaexamen, F.calif_definitiva, F.condicion_textbox, F.nombre_materia Where id_alumno = (txtIdAlu.Text) Order By nombre_materia

        dgrCalif.Enabled = True
        dgrCalif.AutoGenerateColumns = False
        dgrCalif.Columns.Clear()

        dgrCalif.Columns.Add("nombre_materia", "Materia")
        dgrCalif.Columns.Add("parcial1", "Parcial 1")
        dgrCalif.Columns.Add("fechaParcial1", "Fecha P1")
        dgrCalif.Columns.Add("parcial2", "Parcial 2")
        dgrCalif.Columns.Add("fechaParcial2", "Fecha P2")
        dgrCalif.Columns.Add("parcial3", "Parcial 3")
        dgrCalif.Columns.Add("fechaParcial3", "Fecha P3")
        dgrCalif.Columns.Add("parcial4", "Parcial 4")
        dgrCalif.Columns.Add("fechaParcial4", "Fecha P4")
        dgrCalif.Columns.Add("integrador1", "Integrador 1")
        dgrCalif.Columns.Add("fechaInteg1", "Fecha I1")
        dgrCalif.Columns.Add("promedioetapa1", "Promedio 1° E")
        dgrCalif.Columns.Add("parcial5", "Parcial 5")
        dgrCalif.Columns.Add("fechaParcial5", "Fecha P5")
        dgrCalif.Columns.Add("parcial6", "Parcial 6")
        dgrCalif.Columns.Add("fechaParcial6", "Fecha P6")
        dgrCalif.Columns.Add("parcial7", "Parcial 7")
        dgrCalif.Columns.Add("fechaParcial7", "Fecha P7")
        dgrCalif.Columns.Add("parcial8", "Parcial 8")
        dgrCalif.Columns.Add("fechaParcial8", "Fecha P8")
        dgrCalif.Columns.Add("integrador2", "Integrador 2")
        dgrCalif.Columns.Add("fechaInteg2", "Fecha I2")
        dgrCalif.Columns.Add("promedioetapa2", "Promedio 2° E")
        dgrCalif.Columns.Add("parcial9", "Parcial 9")
        dgrCalif.Columns.Add("fechaParcial9", "Fecha P9")
        dgrCalif.Columns.Add("parcial10", "Parcial 10")
        dgrCalif.Columns.Add("fechaParcial10", "Fecha P10")
        dgrCalif.Columns.Add("parcial11", "Parcial 11")
        dgrCalif.Columns.Add("fechaParcial11", "Fecha P11")
        dgrCalif.Columns.Add("parcial12", "Parcial 12")
        dgrCalif.Columns.Add("fechaParcial12", "Fecha P12")
        dgrCalif.Columns.Add("integrador3", "Integrador 3")
        dgrCalif.Columns.Add("fechaInteg3", "Fecha I3")
        dgrCalif.Columns.Add("promedioetapa3", "Promedio 3° E")
        dgrCalif.Columns.Add("promedio_anual", "Prom Anual")
        dgrCalif.Columns.Add("coloquio", "Coloquio")
        dgrCalif.Columns.Add("fechacoloquio", "Fecha Col")
        dgrCalif.Columns.Add("examen", "Exámen")
        dgrCalif.Columns.Add("fechaexamen", "Fecha Ex")
        dgrCalif.Columns.Add("calif_definitiva", "Calificación Final")
        dgrCalif.Columns.Add("condicion_textbox", "Condición")


        dgrCalif.Columns(0).DataPropertyName = "nombre_materia"
        dgrCalif.Columns(1).DataPropertyName = "parcial1"
        dgrCalif.Columns(2).DataPropertyName = "fechaParcial1"
        dgrCalif.Columns(3).DataPropertyName = "parcial2"
        dgrCalif.Columns(4).DataPropertyName = "fechaParcial2"
        dgrCalif.Columns(5).DataPropertyName = "parcial3"
        dgrCalif.Columns(6).DataPropertyName = "fechaParcial3"
        dgrCalif.Columns(7).DataPropertyName = "parcial4"
        dgrCalif.Columns(8).DataPropertyName = "fechaParcial4"
        dgrCalif.Columns(9).DataPropertyName = "integrador1"
        dgrCalif.Columns(10).DataPropertyName = "fechaInteg1"
        dgrCalif.Columns(11).DataPropertyName = "promedioetapa1"
        dgrCalif.Columns(12).DataPropertyName = "parcial5"
        dgrCalif.Columns(13).DataPropertyName = "fechaParcial5"
        dgrCalif.Columns(14).DataPropertyName = "parcial6"
        dgrCalif.Columns(15).DataPropertyName = "fechaParcial6"
        dgrCalif.Columns(16).DataPropertyName = "parcial7"
        dgrCalif.Columns(17).DataPropertyName = "fechaParcial7"
        dgrCalif.Columns(18).DataPropertyName = "parcial8"
        dgrCalif.Columns(19).DataPropertyName = "fechaParcial8"
        dgrCalif.Columns(20).DataPropertyName = "integrador2"
        dgrCalif.Columns(21).DataPropertyName = "fechaInteg2"
        dgrCalif.Columns(22).DataPropertyName = "promedioetapa2"
        dgrCalif.Columns(23).DataPropertyName = "parcial9"
        dgrCalif.Columns(24).DataPropertyName = "fechaParcial9"
        dgrCalif.Columns(25).DataPropertyName = "parcial10"
        dgrCalif.Columns(26).DataPropertyName = "fechaParcial10"
        dgrCalif.Columns(27).DataPropertyName = "parcial11"
        dgrCalif.Columns(28).DataPropertyName = "fechaParcial11"
        dgrCalif.Columns(29).DataPropertyName = "parcial12"
        dgrCalif.Columns(30).DataPropertyName = "fechaParcial12"
        dgrCalif.Columns(31).DataPropertyName = "integrador3"
        dgrCalif.Columns(32).DataPropertyName = "fechaInteg3"
        dgrCalif.Columns(33).DataPropertyName = "promedioetapa3"
        dgrCalif.Columns(34).DataPropertyName = "promedio_anual"
        dgrCalif.Columns(35).DataPropertyName = "coloquio"
        dgrCalif.Columns(36).DataPropertyName = "fechacoloquio"
        dgrCalif.Columns(37).DataPropertyName = "examen"
        dgrCalif.Columns(38).DataPropertyName = "fechaexamen"
        dgrCalif.Columns(39).DataPropertyName = "calif_definitiva"
        dgrCalif.Columns(40).DataPropertyName = "condicion_textbox"

        dgrCalif.DataSource = consulta
    End Sub

    Private Sub CargarGrillaTodos()
        Dim consulta = From V In datacontextvistas.vista_calificaciones Select V.id_alumno, V.nombre_alu, V.apellido_alu, V.DNI_alu, V.parcial1, V.fechaParcial1, V.parcial2, V.fechaParcial2, V.parcial3, V.fechaParcial3, V.parcial4, V.fechaParcial4, V.integrador1, V.fechaInteg1, V.promedioetapa1, V.parcial5, V.fechaParcial5, V.parcial6, V.fechaParcial6, V.parcial7, V.fechaParcial7, V.parcial8, V.fechaParcial8, V.integrador2, V.fechaInteg2, V.promedioetapa2, V.parcial9, V.fechaParcial9, V.parcial10, V.fechaParcial10, V.parcial11, V.fechaParcial11, V.parcial12, V.fechaParcial12, V.integrador3, V.fechaInteg3, V.promedioetapa3, V.promedio_anual, V.coloquio, V.fechacoloquio, V.examen, V.fechaexamen, V.calif_definitiva, V.condicion_textbox, V.nombre_materia Where id_alumno = (txtIdAlu.Text) Order By nombre_materia

        dgrCalif.Enabled = True
        dgrCalif.AutoGenerateColumns = False
        dgrCalif.Columns.Clear()

        dgrCalif.Columns.Add("nombre_materia", "Materia")
        dgrCalif.Columns.Add("parcial1", "Parcial 1")
        dgrCalif.Columns.Add("fechaParcial1", "Fecha P1")
        dgrCalif.Columns.Add("parcial2", "Parcial 2")
        dgrCalif.Columns.Add("fechaParcial2", "Fecha P2")
        dgrCalif.Columns.Add("parcial3", "Parcial 3")
        dgrCalif.Columns.Add("fechaParcial3", "Fecha P3")
        dgrCalif.Columns.Add("parcial4", "Parcial 4")
        dgrCalif.Columns.Add("fechaParcial4", "Fecha P4")
        dgrCalif.Columns.Add("integrador1", "Integrador 1")
        dgrCalif.Columns.Add("fechaInteg1", "Fecha I1")
        dgrCalif.Columns.Add("promedioetapa1", "Promedio 1° E")
        dgrCalif.Columns.Add("parcial5", "Parcial 5")
        dgrCalif.Columns.Add("fechaParcial5", "Fecha P5")
        dgrCalif.Columns.Add("parcial6", "Parcial 6")
        dgrCalif.Columns.Add("fechaParcial6", "Fecha P6")
        dgrCalif.Columns.Add("parcial7", "Parcial 7")
        dgrCalif.Columns.Add("fechaParcial7", "Fecha P7")
        dgrCalif.Columns.Add("parcial8", "Parcial 8")
        dgrCalif.Columns.Add("fechaParcial8", "Fecha P8")
        dgrCalif.Columns.Add("integrador2", "Integrador 2")
        dgrCalif.Columns.Add("fechaInteg2", "Fecha I2")
        dgrCalif.Columns.Add("promedioetapa2", "Promedio 2° E")
        dgrCalif.Columns.Add("parcial9", "Parcial 9")
        dgrCalif.Columns.Add("fechaParcial9", "Fecha P9")
        dgrCalif.Columns.Add("parcial10", "Parcial 10")
        dgrCalif.Columns.Add("fechaParcial10", "Fecha P10")
        dgrCalif.Columns.Add("parcial11", "Parcial 11")
        dgrCalif.Columns.Add("fechaParcial11", "Fecha P11")
        dgrCalif.Columns.Add("parcial12", "Parcial 12")
        dgrCalif.Columns.Add("fechaParcial12", "Fecha P12")
        dgrCalif.Columns.Add("integrador3", "Integrador 3")
        dgrCalif.Columns.Add("fechaInteg3", "Fecha I3")
        dgrCalif.Columns.Add("promedioetapa3", "Promedio 3° E")
        dgrCalif.Columns.Add("promedio_anual", "Prom Anual")
        dgrCalif.Columns.Add("coloquio", "Coloquio")
        dgrCalif.Columns.Add("fechacoloquio", "Fecha Col")
        dgrCalif.Columns.Add("examen", "Exámen")
        dgrCalif.Columns.Add("fechaexamen", "Fecha Ex")
        dgrCalif.Columns.Add("calif_definitiva", "Calificación Final")
        dgrCalif.Columns.Add("condicion_textbox", "Condición")


        dgrCalif.Columns(0).DataPropertyName = "nombre_materia"
        dgrCalif.Columns(1).DataPropertyName = "parcial1"
        dgrCalif.Columns(2).DataPropertyName = "fechaParcial1"
        dgrCalif.Columns(3).DataPropertyName = "parcial2"
        dgrCalif.Columns(4).DataPropertyName = "fechaParcial2"
        dgrCalif.Columns(5).DataPropertyName = "parcial3"
        dgrCalif.Columns(6).DataPropertyName = "fechaParcial3"
        dgrCalif.Columns(7).DataPropertyName = "parcial4"
        dgrCalif.Columns(8).DataPropertyName = "fechaParcial4"
        dgrCalif.Columns(9).DataPropertyName = "integrador1"
        dgrCalif.Columns(10).DataPropertyName = "fechaInteg1"
        dgrCalif.Columns(11).DataPropertyName = "promedioetapa1"
        dgrCalif.Columns(12).DataPropertyName = "parcial5"
        dgrCalif.Columns(13).DataPropertyName = "fechaParcial5"
        dgrCalif.Columns(14).DataPropertyName = "parcial6"
        dgrCalif.Columns(15).DataPropertyName = "fechaParcial6"
        dgrCalif.Columns(16).DataPropertyName = "parcial7"
        dgrCalif.Columns(17).DataPropertyName = "fechaParcial7"
        dgrCalif.Columns(18).DataPropertyName = "parcial8"
        dgrCalif.Columns(19).DataPropertyName = "fechaParcial8"
        dgrCalif.Columns(20).DataPropertyName = "integrador2"
        dgrCalif.Columns(21).DataPropertyName = "fechaInteg2"
        dgrCalif.Columns(22).DataPropertyName = "promedioetapa2"
        dgrCalif.Columns(23).DataPropertyName = "parcial9"
        dgrCalif.Columns(24).DataPropertyName = "fechaParcial9"
        dgrCalif.Columns(25).DataPropertyName = "parcial10"
        dgrCalif.Columns(26).DataPropertyName = "fechaParcial10"
        dgrCalif.Columns(27).DataPropertyName = "parcial11"
        dgrCalif.Columns(28).DataPropertyName = "fechaParcial11"
        dgrCalif.Columns(29).DataPropertyName = "parcial12"
        dgrCalif.Columns(30).DataPropertyName = "fechaParcial12"
        dgrCalif.Columns(31).DataPropertyName = "integrador3"
        dgrCalif.Columns(32).DataPropertyName = "fechaInteg3"
        dgrCalif.Columns(33).DataPropertyName = "promedioetapa3"
        dgrCalif.Columns(34).DataPropertyName = "promedio_anual"
        dgrCalif.Columns(35).DataPropertyName = "coloquio"
        dgrCalif.Columns(36).DataPropertyName = "fechacoloquio"
        dgrCalif.Columns(37).DataPropertyName = "examen"
        dgrCalif.Columns(38).DataPropertyName = "fechaexamen"
        dgrCalif.Columns(39).DataPropertyName = "calif_definitiva"
        dgrCalif.Columns(40).DataPropertyName = "condicion_textbox"

        dgrCalif.DataSource = consulta
    End Sub

    Private Sub habilitaControles()
        rbnMateria.Enabled = True
        rbnCondición.Enabled = True
        rbnTodos.Enabled = True
    End Sub

    Private Sub DeshabilitaControles()
        rbnMateria.Enabled = False
        rbnCondición.Enabled = False
        rbnTodos.Enabled = False
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim frm As New frmReporte
        'Forma = Me
        'Me.Hide()
        'frm.CrystalReportVieewe1.SelectionFormula = "{vista_horario_personal.id_personal}'" &_txtid_personal.text &"'"

        'frm.Show()
        'en el módulo general
        'Public Forma as system.Windows.Forms.Form
        'Public rutareportes$ ="Ruta de los reportes"
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        FrmCalificaciones2.Show()
        Me.Close()
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
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