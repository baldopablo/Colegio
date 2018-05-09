Public Class FrmConsultaHorarioNoDocente
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim id As Integer
    Dim imagen As Image

    Private Sub FrmConsultaHorarioNoDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarGrilla()
        DeshabilitaControles()
        txtDNI.Select()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Sub MostrarGrilla()


        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()

        dgrHorario.Columns.Add("", "Día Semana")
        dgrHorario.Columns.Add("", "Turno")
        dgrHorario.Columns.Add("", "Curso")
        dgrHorario.Columns(0).DataPropertyName = ""
        dgrHorario.Columns(1).DataPropertyName = ""
        dgrHorario.Columns(2).DataPropertyName = ""
       
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        If txtDNI.Text = "" Then

            MsgBox("Ingrese un DNI para la búqueda")
        Else

            Try
                Dim BuscaHorario = (From H In DataContext.Personal Where H.DNI_pers = CInt(txtDNI.Text) And H.puesto_pers <> "Docente").ToList()(0)
                txtNombre.Text = BuscaHorario.nombre_pers
                txtApellido.Text = BuscaHorario.apelliido_pers
                id = BuscaHorario.id_personal
                habilitaControles()

            Catch ex As Exception
                MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
                LimpiarControles()
                DeshabilitaControles()

            End Try
        End If
    End Sub

    Private Sub LimpiarControles()
        txtNombre.Text = ""
        txtApellido.Text = ""
        id = Nothing
        txtDNI.Text = ""
        rbnDía.Checked = False
        rbnCurso.Checked = False
        rbnTodos.Checked = False
        cbobusqueda.SelectedIndex = -1
        dgrHorario.DataSource = Nothing
        dgrHorario.Rows.Clear()
        MostrarGrilla()
    End Sub

    Private Sub cboBusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbobusqueda.SelectedIndexChanged
        If rbnCurso.Checked = True Then
            MostrarGrillaCurso()
        ElseIf rbnDía.Checked = True Then
            MostrarGrillaDía()
        Else
            MostrarGrilla()
        End If
    End Sub

    Private Sub MostrarGrillaCurso()
        Dim consulta = From C In datacontextvistas.vista_horario_personal Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = id And nombre_curso = cbobusqueda.Text Order By dia_semana

        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()
        dgrHorario.Columns.Add("dia_semana", "Día Semana")
        dgrHorario.Columns.Add("turno_textbox", "Turno")
        dgrHorario.Columns.Add("nombre_curso", "Curso")
        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
        dgrHorario.Columns(1).DataPropertyName = "turno_textbox"
        dgrHorario.Columns(2).DataPropertyName = "nombre_curso"
        dgrHorario.DataSource = consulta
    End Sub

    Private Sub MostrarGrillaDía()
        Dim consulta = From C In datacontextvistas.vista_horario_personal Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = id And dia_semana = cbobusqueda.Text Order By dia_semana
        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()
        dgrHorario.Columns.Add("dia_semana", "Día Semana")
        dgrHorario.Columns.Add("turno_textbox", "Turno")
        dgrHorario.Columns.Add("nombre_curso", "Curso")
        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
        dgrHorario.Columns(1).DataPropertyName = "turno_textbox"
        dgrHorario.Columns(2).DataPropertyName = "nombre_curso"
        dgrHorario.DataSource = consulta
    End Sub

   Private Sub MostrarGrillaTodos()
        Dim consulta = From C In datacontextvistas.vista_horario_personal Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = id Order By dia_semana
        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()
        dgrHorario.Columns.Add("dia_semana", "Día Semana")
        dgrHorario.Columns.Add("turno_textbox", "Turno")
        dgrHorario.Columns.Add("nombre_curso", "Curso")
        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
        dgrHorario.Columns(1).DataPropertyName = "turno_textbox"
        dgrHorario.Columns(2).DataPropertyName = "nombre_curso"
        dgrHorario.DataSource = consulta
    End Sub

    Private Sub CargarDías()

        cbobusqueda.Items.Add("Lunes")
        cbobusqueda.Items.Add("Martes")
        cbobusqueda.Items.Add("Miércoles")
        cbobusqueda.Items.Add("Jueves")
        cbobusqueda.Items.Add("Viernes")
        cbobusqueda.Items.Add("Sábado")
        cbobusqueda.SelectedIndex = -1

    End Sub

    Private Sub CargarCurso()
        Dim Datos = From C In DataContext.Curso Select C.id_curso, C.nombre_curso

        Me.cbobusqueda.DataSource = Datos
        Me.cbobusqueda.DisplayMember = "nombre_curso"
        Me.cbobusqueda.ValueMember = "id_curso"
        Me.cbobusqueda.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiarControles()
        DeshabilitaControles()
    End Sub

    Private Sub rbnTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnTodos.CheckedChanged
        cbobusqueda.Enabled = False
        cbobusqueda.SelectedIndex = -1
        CargarGrillaTodos()
    End Sub

    Private Sub rbnCurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnCurso.CheckedChanged
        cbobusqueda.Enabled = True
        CargarCurso()
    End Sub

    Private Sub rbnDía_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnDía.CheckedChanged
        cbobusqueda.Enabled = True
        Me.cbobusqueda.DataSource = Nothing
        Me.cbobusqueda.DisplayMember = Nothing
        Me.cbobusqueda.ValueMember = Nothing
        CargarDías()
    End Sub



    Private Sub CargarGrillaTodos()
        Dim consulta = From C In datacontextvistas.vista_horario_personal Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = id Order By dia_semana

        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()
        dgrHorario.Columns.Add("dia_semana", "Día Semana")
        dgrHorario.Columns.Add("turno_textbox", "Turno")
        dgrHorario.Columns.Add("nombre_curso", "Curso")
        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
        dgrHorario.Columns(1).DataPropertyName = "turno_textbox"
        dgrHorario.Columns(2).DataPropertyName = "nombre_curso"
        dgrHorario.DataSource = consulta
    End Sub

    Private Sub habilitaControles()
        rbnCurso.Enabled = True
        rbnDía.Enabled = True
        rbnTodos.Enabled = True
    End Sub

    Private Sub DeshabilitaControles()
        rbnCurso.Enabled = False
        rbnDía.Enabled = False
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
        FrmHorariosPersonal.Show()
        ' Dim frm = New FrmHorariosPersonal()
        'frm.MdiParent = Frm_principal
        'Me.Close()
        'frm.Show()
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If

      End Sub

    Private Sub Horario_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Horario.Enter

    End Sub
End Class