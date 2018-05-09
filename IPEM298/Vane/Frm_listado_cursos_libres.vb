Public Class Frm_listado_cursos_libres
    Dim datacontext As New DataClassesipem2DataContext
    'LOAD DEL FORM
    Private Sub Frm_listado_cursos_libres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargargrilla()
    End Sub

    'CARGA LA GRILLA
    Private Sub cargargrilla()
        Dim cursoslibres = From cl In datacontext.Curso Select cl.id_curso, cl.id_personal, cl.nombre_curso Where id_personal = CInt(13)

        Dg_cursoslibres.AutoGenerateColumns = False
        Dg_cursoslibres.Columns.Clear()

        Dg_cursoslibres.Columns.Add("id_curso", "Id")
        Dg_cursoslibres.Columns.Add("id_personal", "Id-Pers")
        Dg_cursoslibres.Columns.Add("nombre_curso", "Curso")

        Dg_cursoslibres.Columns(0).DataPropertyName = "id_curso"
        Dg_cursoslibres.Columns(1).DataPropertyName = "id_personal"
        Dg_cursoslibres.Columns(2).DataPropertyName = "nombre_curso"

        Dg_cursoslibres.Columns(0).Visible = False
        Dg_cursoslibres.Columns(1).Visible = False

        Dg_cursoslibres.DataSource = cursoslibres
        Dg_cursoslibres.ClearSelection()


    End Sub

    'BOTON VOLVER
    Private Sub Btn_volver_cursoslibres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_volver_cursoslibres.Click
        Me.Close()
    End Sub
End Class