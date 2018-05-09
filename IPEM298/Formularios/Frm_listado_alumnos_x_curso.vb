Public Class Frm_listado_alumnos_x_curso
    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim datacontext As New DataClassesipem2DataContext
    'LOAD DEL FORM
    Private Sub Frm_listado_alumnos_x_curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'RADIO BUTTON MAÑANA
    Private Sub Rbt_mna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_mna.CheckedChanged
        Dim vble_turno As String
        If rbn_mna.Checked = True Then
            vble_turno = rbn_mna.Text
            CargarCombos(vble_turno)
        End If

    End Sub

    'RADIO BUTTON TARDE
    Private Sub Rbt_tde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_tde.CheckedChanged
        Dim vble_turno As String
        If rbn_tde.Checked = True Then
            vble_turno = rbn_tde.Text
            CargarCombos(vble_turno)
        End If
    End Sub

    'RADIO BUTTON NOCHE
    Private Sub Rbt_noche_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbn_noche.CheckedChanged
        Dim vble_turno As String
        If rbn_noche.Checked = True Then
            vble_turno = rbn_noche.Text
            CargarCombos(vble_turno)
        End If
    End Sub

    'CARGA LOS COMBOS DE CURSO Y MODULO SEGUN TURNO
    Private Sub CargarCombos(ByVal turno As String)
        'Dim datos_curso = (From c In datacontextvistas.VistaProfxMateria Join d In datacontextvistas.vista_modulocurso On c.id_curso Equals d.id_curso Select c.id_curso, c.nombre_curso, c.id_personal, d.turno_textbox Where id_personal = vble_id_pers And turno_textbox = turno.ToString).Distinct

        Dim datosc = (From c In datacontextvistas.vista_modulocurso Select c.id_curso, c.nombre_curso, c.turno_textbox Where turno_textbox = turno.ToString And nombre_curso <> "IN").Distinct
        Me.cbocurso.DataSource = datosc
        Me.cbocurso.DisplayMember = "nombre_curso"
        Me.cbocurso.ValueMember = "id_curso"
        Me.cbocurso.SelectedIndex = -1
    End Sub

    'CARGA GRILLA
    Private Sub cargagrilla()
        Try

            Dim listadoalu = (From l In datacontextvistas.vista_alum_xcurso Select l.nombre_alu, l.apellido_alu, l.DNI_alu, l.nombre_curso Where nombre_curso = cbocurso.Text).ToList

        dg_alumnosxcurso.AutoGenerateColumns = False
        dg_alumnosxcurso.Columns.Clear()

        dg_alumnosxcurso.Columns.Add("nombre_alu", "Nombre")
        dg_alumnosxcurso.Columns.Add("apellido_alu", "Apellido")
        dg_alumnosxcurso.Columns.Add("DNI_alu", "Dni")

        dg_alumnosxcurso.Columns(0).DataPropertyName = "nombre_alu"
        dg_alumnosxcurso.Columns(1).DataPropertyName = "apellido_alu"
        dg_alumnosxcurso.Columns(2).DataPropertyName = "DNI_alu"

            dg_alumnosxcurso.DataSource = listadoalu
        Catch ex As Exception
            MsgBox("El curso elegido no tiene alumnos asignados")
        End Try
    End Sub

    'BOTON CONSULTAR
    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        cargagrilla()
    End Sub

    'BOTON SALIR
    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    'RBN TODOS
    Private Sub rbntodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbntodos.CheckedChanged
        dg_alumnosxcurso.Columns.Clear()
        Dim alutodos = From a In datacontext.Alumno Select a.nombre_alu, a.apellido_alu, a.DNI_alu
        cargagrillatodos(alutodos)
    End Sub

    'CARGA GRILLA TODOS
    Private Sub cargagrillatodos(ByVal consulta1 As System.Linq.IOrderedQueryable)
        dg_alumnosxcurso.Columns.Add("apellido_alu", "Apellido")
        dg_alumnosxcurso.Columns.Add("nombre_alu", "Nombre")
        dg_alumnosxcurso.Columns.Add("DNI_alu", "Dni")

        dg_alumnosxcurso.Columns(0).DataPropertyName = "apellido_alu"
        dg_alumnosxcurso.Columns(1).DataPropertyName = "nombre_alu"
        dg_alumnosxcurso.Columns(2).DataPropertyName = "DNI_alu"

        dg_alumnosxcurso.DataSource = consulta1
        dg_alumnosxcurso.ClearSelection()
    End Sub

    'CARGA GRILLA DE ALUMNOS SIN ASIGNAR
    Private Sub rbnsinasignar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnsinasignar.CheckedChanged
        dg_alumnosxcurso.Columns.Clear()
        Dim sinasig = From s In datacontextvistas.Vista_alumnos_no_asignados_curso Select s.DNI_alu, s.nombre_alu, s.apellido_alu
        cargagrillatodos(sinasig)
    End Sub

    'RBN INACTIVOS
    Private Sub rbninactivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbninactivo.CheckedChanged
        dg_alumnosxcurso.Columns.Clear()
        Dim inactivos = (From i In datacontextvistas.vista_alum_xcurso Select i.apellido_alu, i.nombre_alu, i.DNI_alu, i.nombre_curso Where nombre_curso = "IN").Distinct
        cargagrillatodos(inactivos)
    End Sub
End Class