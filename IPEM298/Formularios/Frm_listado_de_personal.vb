Public Class Frm_listado_de_personal
    Dim datacontext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext

    'LOAD DEL FORM
    Private Sub Frm_listado_de_personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'CARGAR GRILLA
    Private Sub cargargrilla(ByVal sql As System.Linq.IOrderedQueryable, ByVal ape As Boolean, ByVal nom As Boolean, ByVal dni As Boolean, ByVal mat As Boolean, ByVal cur As Boolean, ByVal pue As Boolean)

        dg_personal.AutoGenerateColumns = False
        dg_personal.Columns.Clear()

        dg_personal.Columns.Add("apelliido_pers", "Apellido")
        dg_personal.Columns.Add("nombre_pers", "Nombre")
        dg_personal.Columns.Add("DNI_pers", "Dni")
        dg_personal.Columns.Add("nombre_materia", "Materia")
        dg_personal.Columns.Add("nombre_curso", "Curso")
        dg_personal.Columns.Add("puesto_pers", "Puesto")

        dg_personal.Columns(0).DataPropertyName = "apelliido_pers"
        dg_personal.Columns(1).DataPropertyName = "nombre_pers"
        dg_personal.Columns(2).DataPropertyName = "DNI_pers"
        dg_personal.Columns(3).DataPropertyName = "nombre_materia"
        dg_personal.Columns(4).DataPropertyName = "nombre_curso"
        dg_personal.Columns(5).DataPropertyName = "puesto_pers"

        dg_personal.Columns(0).Visible = ape
        dg_personal.Columns(1).Visible = nom
        dg_personal.Columns(2).Visible = dni
        dg_personal.Columns(3).Visible = mat
        dg_personal.Columns(4).Visible = cur
        dg_personal.Columns(5).Visible = pue


        dg_personal.DataSource = sql

    End Sub

    'CARGA COMBO CON PUESTO
    Private Sub Cargarpuesto()

        cbobusqueda.Items.Add("Docente")
        cbobusqueda.Items.Add("Preceptor")
        cbobusqueda.Items.Add("Directivo")
        cbobusqueda.Items.Add("Docente y preceptor")
        cbobusqueda.Items.Add("Docente y directivo")
        cbobusqueda.SelectedIndex = -1

    End Sub

    'CARGA COMBO CON CURSO
    Private Sub CargarCurso()
        Dim Datos = From C In datacontext.Curso Select C.id_curso, C.nombre_curso

        Me.cbobusqueda.DataSource = Datos
        Me.cbobusqueda.DisplayMember = "nombre_curso"
        Me.cbobusqueda.ValueMember = "id_curso"
        Me.cbobusqueda.SelectedIndex = -1
    End Sub

    'CARGA COMBO CON MATERIAS
    Private Sub CargarMateria()
        Dim Datos = From C In datacontext.Materia Select C.id_materia, C.nombre_materia

        Me.cbobusqueda.DataSource = Datos
        Me.cbobusqueda.DisplayMember = "nombre_materia"
        Me.cbobusqueda.ValueMember = "id_materia"
        Me.cbobusqueda.SelectedIndex = -1
    End Sub

    'RBN MATERIA
    Private Sub rbnmateria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnmateria.CheckedChanged
        dg_personal.Columns.Clear()
        CargarMateria()
    End Sub

    'RBN CURSO
    Private Sub rbncurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbncurso.CheckedChanged
        dg_personal.Columns.Clear()
        CargarCurso()
    End Sub

    'RBN PUESTO
    Private Sub rbnpuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnpuesto.CheckedChanged
        dg_personal.Columns.Clear()
        cbobusqueda.Enabled = True

        Me.cbobusqueda.DataSource = Nothing
        Me.cbobusqueda.DisplayMember = Nothing
        Me.cbobusqueda.ValueMember = Nothing
        cbobusqueda.Items.Clear()
        Cargarpuesto()
    End Sub

    'RBN TODOS
    Private Sub rbntodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbntodos.CheckedChanged
        dg_personal.Columns.Clear()
        'cbobusqueda.Items.Clear()
        cbobusqueda.Enabled = False
        cbobusqueda.SelectedIndex = -1
        Dim todos = From t In datacontext.Personal Select t.apelliido_pers, t.nombre_pers, t.DNI_pers, t.puesto_pers
        'Dim todos = From d In datacontextvistas.Vista_profesor_x_materia Select d.apelliido_pers, d.nombre_pers, d.nombre_curso, d.DNI_pers, d.nombre_materia, d.puesto_pers
        cargargrilla(todos, True, True, True, False, False, True)
    End Sub

    'CLICK SOBRE COMBO
    Private Sub cbobusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbobusqueda.SelectedIndexChanged
        Try
            If rbncurso.Checked = True Then
                Dim curso = From d In datacontextvistas.Vista_profesor_x_materia Select d.apelliido_pers, d.nombre_pers, d.nombre_curso, d.DNI_pers, d.nombre_materia, d.puesto_pers Where nombre_curso = cbobusqueda.Text
                cargargrilla(curso, True, True, True, True, False, True)
                ' MostrarGrillaCurso()
            ElseIf rbnpuesto.Checked = True Then
                Dim puesto = From d In datacontextvistas.Vista_profesor_x_materia Select d.apelliido_pers, d.nombre_pers, d.nombre_curso, d.DNI_pers, d.nombre_materia, d.puesto_pers Where puesto_pers = cbobusqueda.Text
                cargargrilla(puesto, True, True, True, True, True, False)
                'MostrarGrillaDía()
            ElseIf rbnmateria.Checked = True Then
                Dim materia = From d In datacontextvistas.Vista_profesor_x_materia Select d.apelliido_pers, d.nombre_pers, d.nombre_curso, d.DNI_pers, d.nombre_materia, d.puesto_pers Where nombre_materia = cbobusqueda.Text
                cargargrilla(materia, True, True, True, False, True, True)
                ' MostrarGrillaMateria()
            Else
                Dim todos = From t In datacontext.Personal Select t.apelliido_pers, t.nombre_pers, t.DNI_pers, t.puesto_pers
                'Dim todos = From d In datacontextvistas.Vista_profesor_x_materia Select d.apelliido_pers, d.nombre_pers, d.nombre_curso, d.DNI_pers, d.nombre_materia, d.puesto_pers
                cargargrilla(todos, True, True, True, False, False, True)
                ' MostrarGrilla()
            End If
        Catch ex As Exception
            MsgBox("Consulta inválida, seleccione otro item")
        End Try
    End Sub

    'BOTON SALIR
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class