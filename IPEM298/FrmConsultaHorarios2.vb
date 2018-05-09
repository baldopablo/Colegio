'Imports System.Data.SqlClient
'Imports System.Configuration
'Imports System.Windows.Forms.Form


Public Class FrmConsultaHorarios2
    '    Dim DataContext As New DataClassesipem2DataContext
    '    Dim datacontextvistas As New DataClassesdevistasDataContext

    '    'Public Forma As System.Windows.Forms.Form
    '    'Public rutareportes$ = "C:\Users\valeria\Documents\Visual Studio 2010\Projects\IPEM298\IPEM298\CrystalReportHorDoc.rpt"
    '    ''C:\Users\valeria\Documents\Visual Studio 2010\Projects\IPEM298\IPEM298\CrystalReportHorDoc.rpt


    '    Private Sub FrmConsultaHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        MostrarGrilla()
    '        DeshabilitaControles()
    '    End Sub

    '    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
    '        Me.Close()
    '    End Sub

    '    Sub MostrarGrilla()


    '        dgrHorario.AutoGenerateColumns = False
    '        dgrHorario.Columns.Clear()

    '        dgrHorario.Columns.Add("", "Día Semana")
    '        dgrHorario.Columns.Add("", "Nombre Materia")
    '        dgrHorario.Columns.Add("", "Especialidad")
    '        dgrHorario.Columns.Add("", "Módulo")
    '        dgrHorario.Columns.Add("", "Hora Inicio")
    '        dgrHorario.Columns.Add("", "Hora Fin")
    '        dgrHorario.Columns.Add("", "Turno")
    '        dgrHorario.Columns.Add("", "Curso")


    '        dgrHorario.Columns(0).DataPropertyName = ""
    '        dgrHorario.Columns(1).DataPropertyName = ""
    '        dgrHorario.Columns(2).DataPropertyName = ""
    '        dgrHorario.Columns(3).DataPropertyName = ""
    '        dgrHorario.Columns(4).DataPropertyName = ""
    '        dgrHorario.Columns(5).DataPropertyName = ""
    '        dgrHorario.Columns(6).DataPropertyName = ""
    '        dgrHorario.Columns(7).DataPropertyName = ""


    '    End Sub

    '    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

    '        If txtDNI.Text = "" Then

    '            MsgBox("Ingrese un DNI para la búqueda")
    '        Else

    '            Try
    '                Dim BuscaHorario = (From H In DataContext.Personals Where H.DNI_pers = CInt(txtDNI.Text)).ToList()(0)


    '                txtNombre.Text = BuscaHorario.nombre_pers
    '                txtApellido.Text = BuscaHorario.apelliido_pers
    '                txtId_personal.Text = BuscaHorario.id_personal
    '                habilitaControles()

    '            Catch ex As Exception
    '                MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
    '                LimpiarControles()
    '                DeshabilitaControles()


    '            End Try
    '        End If
    '    End Sub

    '    Private Sub LimpiarControles()
    '        txtNombre.Text = ""
    '        txtApellido.Text = ""
    '        txtId_personal.Text = ""
    '        txtDNI.Text = ""
    '        rbnDía.Checked = False
    '        rbnCurso.Checked = False
    '        rbnMateria.Checked = False
    '        rbnTodos.Checked = False
    '        cbobusqueda.SelectedIndex = -1
    '        MostrarGrilla()
    '    End Sub

    '    Private Sub cboBusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbobusqueda.SelectedIndexChanged
    '        If rbnCurso.Checked = True Then
    '            MostrarGrillaCurso()
    '        ElseIf rbnDía.Checked = True Then
    '            MostrarGrillaDía()
    '        ElseIf rbnMateria.Checked = True Then
    '            MostrarGrillaMateria()
    '        Else
    '            MostrarGrilla()
    '        End If
    '    End Sub

    '    Private Sub MostrarGrillaCurso()
    '        Dim consulta = From C In datacontextvistas.Vista_horario_personal2 Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = txtId_personal.Text And nombre_curso = cbobusqueda.Text Order By dia_semana

    '        dgrHorario.AutoGenerateColumns = False
    '        dgrHorario.Columns.Clear()

    '        dgrHorario.Columns.Add("dia_semana", "Día Semana")
    '        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
    '        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
    '        dgrHorario.Columns.Add("numero", "Módulo")
    '        dgrHorario.Columns.Add("hora_inicio", "Hora Inicio")
    '        dgrHorario.Columns.Add("hora_fin", "Hora Fin")
    '        dgrHorario.Columns.Add("turno_textbox", "Turno")
    '        dgrHorario.Columns.Add("nombre_curso", "Curso")

    '        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
    '        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
    '        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
    '        dgrHorario.Columns(3).DataPropertyName = "numero"
    '        dgrHorario.Columns(4).DataPropertyName = "hora_inicio"
    '        dgrHorario.Columns(5).DataPropertyName = "hora_fin"
    '        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
    '        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"


    '        dgrHorario.DataSource = consulta
    '        pasoconsulta(consulta)
    '    End Sub

    '    Private Sub MostrarGrillaDía()
    '        Dim consulta = From C In datacontextvistas.Vista_horario_personal2 Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = txtId_personal.Text And dia_semana = cbobusqueda.Text Order By dia_semana

    '        dgrHorario.AutoGenerateColumns = False
    '        dgrHorario.Columns.Clear()

    '        dgrHorario.Columns.Add("dia_semana", "Día Semana")
    '        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
    '        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
    '        dgrHorario.Columns.Add("numero", "Módulo")
    '        dgrHorario.Columns.Add("hora_inicio", "Hora Inicio")
    '        dgrHorario.Columns.Add("hora_fin", "Hora Fin")
    '        dgrHorario.Columns.Add("turno_textbox", "Turno")
    '        dgrHorario.Columns.Add("nombre_curso", "Curso")

    '        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
    '        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
    '        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
    '        dgrHorario.Columns(3).DataPropertyName = "numero"
    '        dgrHorario.Columns(4).DataPropertyName = "hora_inicio"
    '        dgrHorario.Columns(5).DataPropertyName = "hora_fin"
    '        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
    '        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"

    '        dgrHorario.DataSource = consulta
    '        pasoconsulta(consulta)

    '    End Sub

    '    Private Sub MostrarGrillaMateria()
    '        Dim consulta = From C In datacontextvistas.Vista_horario_personal2 Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = txtId_personal.Text And nombre_materia = cbobusqueda.Text Order By dia_semana

    '        dgrHorario.AutoGenerateColumns = False
    '        dgrHorario.Columns.Clear()

    '        dgrHorario.Columns.Add("dia_semana", "Día Semana")
    '        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
    '        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
    '        dgrHorario.Columns.Add("numero", "Módulo")
    '        dgrHorario.Columns.Add("hora_inicio", "Hora Inicio")
    '        dgrHorario.Columns.Add("hora_fin", "Hora Fin")
    '        dgrHorario.Columns.Add("turno_textbox", "Turno")
    '        dgrHorario.Columns.Add("nombre_curso", "Curso")

    '        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
    '        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
    '        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
    '        dgrHorario.Columns(3).DataPropertyName = "numero"
    '        dgrHorario.Columns(4).DataPropertyName = "hora_inicio"
    '        dgrHorario.Columns(5).DataPropertyName = "hora_fin"
    '        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
    '        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"

    '        dgrHorario.DataSource = consulta
    '        pasoconsulta(consulta)

    '    End Sub

    '    Private Sub MostrarGrillaTodos()
    '        Dim consulta = From C In datacontextvistas.Vista_horario_personal2 Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = txtId_personal.Text Order By dia_semana

    '        dgrHorario.AutoGenerateColumns = False
    '        dgrHorario.Columns.Clear()

    '        dgrHorario.Columns.Add("dia_semana", "Día Semana")
    '        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
    '        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
    '        dgrHorario.Columns.Add("numero", "Módulo")
    '        dgrHorario.Columns.Add("hora_inicio", "Hora Inicio")
    '        dgrHorario.Columns.Add("hora_fin", "Hora Fin")
    '        dgrHorario.Columns.Add("turno_textbox", "Turno")
    '        dgrHorario.Columns.Add("nombre_curso", "Curso")
    '        dgrHorario.Columns.Add("id_personal", "Personal")


    '        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
    '        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
    '        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
    '        dgrHorario.Columns(3).DataPropertyName = "numero"
    '        dgrHorario.Columns(4).DataPropertyName = "hora_inicio"
    '        dgrHorario.Columns(5).DataPropertyName = "hora_fin"
    '        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
    '        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"
    '        dgrHorario.Columns(8).DataPropertyName = "id_personal"



    '        dgrHorario.DataSource = consulta
    '        pasoconsulta(consulta)

    '    End Sub




    '    Private Sub CargarDías()

    '        cbobusqueda.Items.Add("Lunes")
    '        cbobusqueda.Items.Add("Martes")
    '        cbobusqueda.Items.Add("Miércoles")
    '        cbobusqueda.Items.Add("Jueves")
    '        cbobusqueda.Items.Add("Viernes")
    '        cbobusqueda.Items.Add("Sábado")

    '        cbobusqueda.SelectedIndex = -1

    '    End Sub

    '    Private Sub CargarCurso()
    '        Dim Datos = From C In DataContext.Curso Select C.id_curso, C.nombre_curso

    '        Me.cbobusqueda.DataSource = Datos
    '        Me.cbobusqueda.DisplayMember = "nombre_curso"
    '        Me.cbobusqueda.ValueMember = "id_curso"
    '        Me.cbobusqueda.SelectedIndex = -1
    '    End Sub

    '    Private Sub CargarMateria()
    '        Dim Datos = From C In DataContext.Materias Select C.id_materia, C.nombre_materia

    '        Me.cbobusqueda.DataSource = Datos
    '        Me.cbobusqueda.DisplayMember = "nombre_materia"
    '        Me.cbobusqueda.ValueMember = "id_materia"
    '        Me.cbobusqueda.SelectedIndex = -1
    '    End Sub

    '    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '        LimpiarControles()
    '        DeshabilitaControles()
    '    End Sub

    '    Private Sub rbnMateria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnMateria.CheckedChanged

    '        cbobusqueda.Enabled = True
    '        CargarMateria()

    '    End Sub

    '    Private Sub rbnTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnTodos.CheckedChanged

    '        cbobusqueda.Enabled = False
    '        cbobusqueda.SelectedIndex = -1
    '        CargarGrillaTodos()

    '    End Sub

    '    Private Sub rbnCurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnCurso.CheckedChanged
    '        cbobusqueda.Enabled = True
    '        CargarCurso()
    '    End Sub

    '    Private Sub rbnDía_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnDía.CheckedChanged

    '        cbobusqueda.Enabled = True

    '        Me.cbobusqueda.DataSource = Nothing
    '        Me.cbobusqueda.DisplayMember = Nothing
    '        Me.cbobusqueda.ValueMember = Nothing
    '        CargarDías()

    '    End Sub



    '    Private Sub CargarGrillaTodos()
    '        Dim consulta = From C In datacontextvistas.Vista_horario_personal2 Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.hora_inicio, C.hora_fin, C.turno_textbox, C.nombre_curso Where id_personal = txtId_personal.Text 'Order By dia_semana

    '        dgrHorario.AutoGenerateColumns = False
    '        dgrHorario.Columns.Clear()

    '        dgrHorario.Columns.Add("dia_semana", "Día Semana")
    '        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
    '        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
    '        dgrHorario.Columns.Add("numero", "Módulo")
    '        dgrHorario.Columns.Add("hora_inicio", "Hora Inicio")
    '        dgrHorario.Columns.Add("hora_fin", "Hora Fin")
    '        dgrHorario.Columns.Add("turno_textbox", "Turno")
    '        dgrHorario.Columns.Add("nombre_curso", "Curso")

    '        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
    '        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
    '        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
    '        dgrHorario.Columns(3).DataPropertyName = "numero"
    '        dgrHorario.Columns(4).DataPropertyName = "hora_inicio"
    '        dgrHorario.Columns(5).DataPropertyName = "hora_fin"
    '        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
    '        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"

    '        dgrHorario.DataSource = consulta
    '        pasoconsulta(consulta)
    '    End Sub

    '    Private Sub habilitaControles()
    '        rbnCurso.Enabled = True
    '        rbnDía.Enabled = True
    '        rbnMateria.Enabled = True
    '        rbnTodos.Enabled = True
    '    End Sub

    '    Private Sub DeshabilitaControles()
    '        rbnCurso.Enabled = False
    '        rbnDía.Enabled = False
    '        rbnMateria.Enabled = False
    '        rbnTodos.Enabled = False
    '    End Sub



    '    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
    '        Dim frm = New FrmHorariosPersonal()

    '        Me.Close()

    '    End Sub

    '    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress

    '        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If

    '    End Sub

    '    Public cr As New Cr_hordoc

    '    Public Sub pasoconsulta(ByVal consulta As System.Linq.IOrderedQueryable)

    '        Dim consulta1 = consulta
    '        cr.SetDataSource(consulta1)
    '    End Sub

    '    Public Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
    '        Dim r As New rpt_hordoc
    '        r.CrystalReportViewer2.ReportSource = cr
    '        r.ShowDialog()

    '    End Sub
End Class