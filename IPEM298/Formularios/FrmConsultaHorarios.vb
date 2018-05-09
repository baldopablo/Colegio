Imports System
Imports System.Collections
Public Class FrmConsultaHorarios
    Dim datacontext As New DataClassesipem2DataContext

    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim id As Integer
    Dim imagen As Image

    Public cr As New Cr_hordoc

    Private Sub FrmConsultaHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarGrilla()
        DeshabilitaControles()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Sub MostrarGrilla()


        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()

        dgrHorario.Columns.Add("", "Día Semana")
        dgrHorario.Columns.Add("", "Nombre Materia")
        dgrHorario.Columns.Add("", "Especialidad")
        dgrHorario.Columns.Add("", "Módulo")
        dgrHorario.Columns.Add("", "Hora Inicio")
        dgrHorario.Columns.Add("", "Hora Fin")
        dgrHorario.Columns.Add("", "Turno")
        dgrHorario.Columns.Add("", "Curso")


        dgrHorario.Columns(0).DataPropertyName = ""
        dgrHorario.Columns(1).DataPropertyName = ""
        dgrHorario.Columns(2).DataPropertyName = ""
        dgrHorario.Columns(3).DataPropertyName = ""
        dgrHorario.Columns(4).DataPropertyName = ""
        dgrHorario.Columns(5).DataPropertyName = ""
        dgrHorario.Columns(6).DataPropertyName = ""
        dgrHorario.Columns(7).DataPropertyName = ""


    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        If txtDNI.Text = "" Then

            MsgBox("Ingrese un DNI para la búqueda")
        Else

            Try
                'Dim BuscaHorario = (From H In DataContext.Personals Where H.DNI_pers = CInt(txtDNI.Text)).ToList()(0) 'And H.puesto_pers = "Docente"
                Dim horario = (From c In datacontext.Personal Select c.DNI_pers, c.apelliido_pers, c.nombre_pers, c.id_personal, c.puesto_pers Where DNI_pers = txtDNI.Text).ToList()(0)
                If horario.puesto_pers = "Preceptor" Or horario.puesto_pers = "Directivo" Then
                    MsgBox("El dni ingresado no corresponde a  un profesor, ingrese nuevamente")
                    txtDNI.Clear()
                    txtDNI.Select()
                    Exit Sub
                End If
                txtNombre.Text = horario.nombre_pers
                txtApellido.Text = horario.apelliido_pers
                id = horario.id_personal
                'txtId_personal.Text = BuscaHorario.id_personal
                habilitaControles()

            Catch ex As Exception
                'MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
                'LimpiarControles()
                'DeshabilitaControles()


            End Try
        End If
    End Sub

    Private Sub LimpiarControles()

        txtNombre.Text = ""
        txtApellido.Text = ""
        'txtId_personal.Text = ""
        id = Nothing
        txtDNI.Text = ""
        rbnDía.Checked = False
        rbnCurso.Checked = False
        rbnMateria.Checked = False
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
        ElseIf rbnMateria.Checked = True Then
            MostrarGrillaMateria()
        Else
            MostrarGrilla()
        End If
    End Sub

    'POR CURSO
    Private Sub MostrarGrillaCurso()
        Dim consulta = From C In datacontextvistas.vista_horario_personal Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.inicio, C.final, C.turno_textbox, C.nombre_curso Where id_personal = id And nombre_curso = cbobusqueda.Text Order By dia_semana

        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()

        dgrHorario.Columns.Add("dia_semana", "Día Semana")
        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
        dgrHorario.Columns.Add("numero", "Módulo")
        dgrHorario.Columns.Add("inicio", "Hora Inicio")
        dgrHorario.Columns.Add("final", "Hora Fin")
        dgrHorario.Columns.Add("turno_textbox", "Turno")
        dgrHorario.Columns.Add("nombre_curso", "Curso")

        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
        dgrHorario.Columns(3).DataPropertyName = "numero"
        dgrHorario.Columns(4).DataPropertyName = "inicio"
        dgrHorario.Columns(5).DataPropertyName = "final"
        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"


        dgrHorario.DataSource = consulta
        pasoconsulta(consulta)
    End Sub

    'POR DIA
    Private Sub MostrarGrillaDía()
        Dim consulta = From C In datacontextvistas.vista_horario_personal Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.inicio, C.final, C.turno_textbox, C.nombre_curso Where id_personal = id And dia_semana = cbobusqueda.Text Order By dia_semana

        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()

        dgrHorario.Columns.Add("dia_semana", "Día Semana")
        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
        dgrHorario.Columns.Add("numero", "Módulo")
        dgrHorario.Columns.Add("inicio", "Hora Inicio")
        dgrHorario.Columns.Add("final", "Hora Fin")
        dgrHorario.Columns.Add("turno_textbox", "Turno")
        dgrHorario.Columns.Add("nombre_curso", "Curso")

        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
        dgrHorario.Columns(3).DataPropertyName = "numero"
        dgrHorario.Columns(4).DataPropertyName = "inicio"
        dgrHorario.Columns(5).DataPropertyName = "final"
        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"

        dgrHorario.DataSource = consulta

        pasoconsulta(consulta)
    End Sub

    'POR MATERIA
    Private Sub MostrarGrillaMateria()
        Dim consulta = From C In datacontextvistas.vista_horario_personal Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.inicio, C.final, C.turno_textbox, C.nombre_curso Where id_personal = id And nombre_materia = cbobusqueda.Text Order By dia_semana

        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()

        dgrHorario.Columns.Add("dia_semana", "Día Semana")
        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
        dgrHorario.Columns.Add("numero", "Módulo")
        dgrHorario.Columns.Add("inicio", "Hora Inicio")
        dgrHorario.Columns.Add("final", "Hora Fin")
        dgrHorario.Columns.Add("turno_textbox", "Turno")
        dgrHorario.Columns.Add("nombre_curso", "Curso")

        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
        dgrHorario.Columns(3).DataPropertyName = "numero"
        dgrHorario.Columns(4).DataPropertyName = "inicio"
        dgrHorario.Columns(5).DataPropertyName = "final"
        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"

        dgrHorario.DataSource = consulta
        pasoconsulta(consulta)
    End Sub

    'TODOS
    Private Sub MostrarGrillaTodos()
        Dim consulta = From C In datacontextvistas.vista_horario_personal Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.inicio, C.final, C.turno_textbox, C.nombre_curso Where id_personal = id Order By dia_semana

        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()

        dgrHorario.Columns.Add("dia_semana", "Día Semana")
        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
        dgrHorario.Columns.Add("numero", "Módulo")
        dgrHorario.Columns.Add("inicio", "Hora Inicio")
        dgrHorario.Columns.Add("final", "Hora Fin")
        dgrHorario.Columns.Add("turno_textbox", "Turno")
        dgrHorario.Columns.Add("nombre_curso", "Curso")

        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
        dgrHorario.Columns(3).DataPropertyName = "numero"
        dgrHorario.Columns(4).DataPropertyName = "inicio"
        dgrHorario.Columns(5).DataPropertyName = "final"
        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"

        dgrHorario.DataSource = consulta

        pasoconsulta(consulta)

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
        Dim Datos = From C In datacontext.Curso Select C.id_curso, C.nombre_curso

        Me.cbobusqueda.DataSource = Datos
        Me.cbobusqueda.DisplayMember = "nombre_curso"
        Me.cbobusqueda.ValueMember = "id_curso"
        Me.cbobusqueda.SelectedIndex = -1
    End Sub

    Private Sub CargarMateria()
        Dim Datos = From C In datacontext.Materia Select C.id_materia, C.nombre_materia

        Me.cbobusqueda.DataSource = Datos
        Me.cbobusqueda.DisplayMember = "nombre_materia"
        Me.cbobusqueda.ValueMember = "id_materia"
        Me.cbobusqueda.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiarControles()
        DeshabilitaControles()
    End Sub

    Private Sub rbnMateria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnMateria.CheckedChanged

        cbobusqueda.Enabled = True
        CargarMateria()

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
        Dim consulta = From C In datacontextvistas.vista_horario_personal Select C.id_horario, C.id_personal, C.nombre_pers, C.apelliido_pers, C.dia_semana, C.nombre_materia, C.especialidad_textbox, C.numero, C.inicio, C.final, C.turno_textbox, C.nombre_curso Where id_personal = id Order By dia_semana

        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()

        dgrHorario.Columns.Add("dia_semana", "Día Semana")
        dgrHorario.Columns.Add("nombre_materia", "Nombre Materia")
        dgrHorario.Columns.Add("especialidad_textbox", "Especialidad")
        dgrHorario.Columns.Add("numero", "Módulo")
        dgrHorario.Columns.Add("inicio", "Hora Inicio")
        dgrHorario.Columns.Add("final", "Hora Fin")
        dgrHorario.Columns.Add("turno_textbox", "Turno")
        dgrHorario.Columns.Add("nombre_curso", "Curso")

        dgrHorario.Columns(0).DataPropertyName = "dia_semana"
        dgrHorario.Columns(1).DataPropertyName = "nombre_materia"
        dgrHorario.Columns(2).DataPropertyName = "especialidad_textbox"
        dgrHorario.Columns(3).DataPropertyName = "numero"
        dgrHorario.Columns(4).DataPropertyName = "inicio"
        dgrHorario.Columns(5).DataPropertyName = "final"
        dgrHorario.Columns(6).DataPropertyName = "turno_textbox"
        dgrHorario.Columns(7).DataPropertyName = "nombre_curso"

        dgrHorario.DataSource = consulta

        pasoconsulta(consulta)
    End Sub

    Private Sub habilitaControles()
        rbnCurso.Enabled = True
        rbnDía.Enabled = True
        rbnMateria.Enabled = True
        rbnTodos.Enabled = True
    End Sub

    Private Sub DeshabilitaControles()
        rbnCurso.Enabled = False
        rbnDía.Enabled = False
        rbnMateria.Enabled = False
        rbnTodos.Enabled = False
    End Sub


    'BOTON GESTION DE PERSONAL
    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        FrmHorariosPersonal.Show()
        'Dim frm = New FrmHorariosPersonal()
        ''frm.MdiParent = Frm_principal
        'Me.Close()
        ''frm.Show()
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        'If (Char.IsSeparator(e.KeyChar)) Then
        '    e.Handled = True
        'Else
        '    e.Handled = False
        'End If
    End Sub

    'COMENTADO PASA LAS CONSULTAS PARA EL REPORTE
    Public Sub pasoconsulta(ByVal consulta As System.Linq.IOrderedQueryable)

        '' Dim consulta=
        'Dim consulta1 = consulta
        'cr.SetDataSource(consulta1)

    End Sub

    Dim finas As New Frmreporte_hordoc
    Dim rpthordoc As New Cr_hordoc

    'BOTON IMPRIMIR
    Public Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'copia los textbox
        Try
            Dim copiatextodni As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rpthordoc.ReportDefinition.ReportObjects.Item("crtext_dni"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextodni.Text = Me.txtDNI.Text

            Dim copiatextonombre As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rpthordoc.ReportDefinition.ReportObjects.Item("crtext_nombre"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextonombre.Text = Me.txtNombre.Text

            Dim copiatextoapellido As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rpthordoc.ReportDefinition.ReportObjects.Item("crtext_apellido"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextoapellido.Text = Me.txtApellido.Text

            Dim copiatextofiltro As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rpthordoc.ReportDefinition.ReportObjects.Item("Cr_txtfiltro"), CrystalDecisions.CrystalReports.Engine.TextObject)
            If rbnDía.Checked = True Then
                copiatextofiltro.Text = rbnDía.Text
            ElseIf rbnCurso.Checked = True Then
                copiatextofiltro.Text = rbnCurso.Text
            ElseIf rbnMateria.Checked = True Then
                copiatextofiltro.Text = rbnMateria.Text
            Else
                copiatextofiltro.Text = rbnTodos.Text
            End If

        Catch ex As Exception
            MsgBox("Operación invalida")
        End Try

        'imprime un datagriedview
        Dim dt As New DataSet1
        For Each dr As DataGridViewRow In Me.dgrHorario.Rows
            dt.DataTableconsultahorario.AddDataTableconsultahorarioRow(dr.Cells("dia_semana").Value, dr.Cells("nombre_materia").Value, dr.Cells("especialidad_textbox").Value, dr.Cells("numero").Value, dr.Cells("inicio").Value, dr.Cells("final").Value, dr.Cells("turno_textbox").Value, dr.Cells("nombre_curso").Value)
        Next

        rpthordoc.SetDataSource(dt)
        'finas.CrystalReportViewer3.ReportSource = rpthordoc
        Frmreporte_hordoc.CrystalReportViewer3.ReportSource = rpthordoc
        Frmreporte_hordoc.ShowDialog()
        Frmreporte_hordoc.Dispose()
    End Sub
End Class