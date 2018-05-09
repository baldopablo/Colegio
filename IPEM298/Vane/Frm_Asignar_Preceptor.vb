Public Class Frm_Asignar_Preceptor
    Dim datacontext As New DataClassesipem2DataContext
    Dim vbleidxdni As Integer
    Dim vblenombrecurso As String
    'LOAD DEL FORM
    Private Sub Frm_Asignar_Preceptor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cargacurso = From cc In datacontext.Curso

        cbo_curso.DataSource = cargacurso
        cbo_curso.DisplayMember = "nombre_curso"
        cbo_curso.ValueMember = "id_curso"
        cbo_curso.SelectedIndex = -1
        cargagrilla()
    End Sub

    'CARGA GRILLA
    Sub cargagrilla()
        Dim busca = (From i In datacontext.Personal Select i.id_personal, i.DNI_pers, i.nombre_pers, i.apelliido_pers Where DNI_pers = FrmPersonal.txtDNI.Text).ToList()(0)
        vbleidxdni = busca.id_personal
        Txt_apellido_asig_precep.Text = busca.apelliido_pers
        Txt_nombre_asig_precep.Text = busca.nombre_pers

        Dim cursos = From c In datacontext.Curso Select c.id_personal, c.id_curso, c.nombre_curso Where id_personal = vbleidxdni
        Dg_cursos_asignados_a_precep.AutoGenerateColumns = False
        Dg_cursos_asignados_a_precep.Columns.Clear()

        Dg_cursos_asignados_a_precep.Columns.Add("id_curso", "Id")
        Dg_cursos_asignados_a_precep.Columns.Add("id_personal", "Id-Pers")
        Dg_cursos_asignados_a_precep.Columns.Add("nombre_curso", "Curso")

        Dg_cursos_asignados_a_precep.Columns(0).DataPropertyName = "id_curso"
        Dg_cursos_asignados_a_precep.Columns(1).DataPropertyName = "id_personal"
        Dg_cursos_asignados_a_precep.Columns(2).DataPropertyName = "nombre_curso"

        Dg_cursos_asignados_a_precep.Columns(0).Visible = False
        Dg_cursos_asignados_a_precep.Columns(1).Visible = False

        Dg_cursos_asignados_a_precep.DataSource = cursos
        Dg_cursos_asignados_a_precep.ClearSelection()
    End Sub

    'BOTON ACTUALIZAR
    Private Sub btn_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actualizar.Click
        If cbo_curso.Text = "" Then
            MsgBox("Elija el curso que quiera asignar")
            Exit Sub
        End If
        Dim actualizacurso = (From ac In datacontext.Curso Where ac.nombre_curso = cbo_curso.Text).ToList()(0)
        actualizacurso.id_personal = vbleidxdni
        datacontext.SubmitChanges()
        cargagrilla()
    End Sub

    'BOTON QUITAR ASIGNACION
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        Dim actualizacurso = (From ac In datacontext.Curso Where ac.nombre_curso = vblenombrecurso).ToList()(0)
        actualizacurso.id_personal = CInt(13)
        datacontext.SubmitChanges()
        MsgBox("Se ha quitado el curso")
        cargagrilla()
        btn_quitar.Enabled = False
        btn_actualizar.Enabled = True
        GroupBox2.Enabled = True
    End Sub

    'BOTON VOLVER
    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    'CLICK SOBRE GRILLA
    Private Sub Dg_cursos_asignados_a_precep_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_cursos_asignados_a_precep.CellClick
        If Dg_cursos_asignados_a_precep.SelectedRows.Count > 0 Then
            vblenombrecurso = Dg_cursos_asignados_a_precep.Item("nombre_curso", Dg_cursos_asignados_a_precep.SelectedRows(0).Index).Value
        End If

        MsgBox("Puede desasignar el curso del preceptor")
        btn_quitar.Enabled = True
        GroupBox2.Enabled = False
        btn_actualizar.Enabled = False
    End Sub

    'BOTON CANCELAR
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cbo_curso.SelectedIndex = -1
        Dg_cursos_asignados_a_precep.ClearSelection()
        btn_quitar.Enabled = False
    End Sub

    'BOTON VER LISTADO DE CURSOS LIBRES
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Frm_listado_cursos_libres.Show()
    End Sub
End Class