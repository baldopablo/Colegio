Public Class Frm_consultar_usuarios
    Dim datacontext As New DataClassesipem2DataContext

    'LOAD DEL FORM
    Private Sub Frm_consultar_usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub

    'CARGA LA GRILLA
    Private Sub cargar_grilla()
        Dim user = From u In datacontext.Usuario1 Select u.id_personal, u.id_usuario, u.nombre_usuario, u.contraseña, u.perfil

        Dg_todosusuarios.Columns.Add("id_usuario", "Id")
        Dg_todosusuarios.Columns.Add("id_personal", "Id Personal")
        Dg_todosusuarios.Columns.Add("nombre_usuario", "Alias")
        Dg_todosusuarios.Columns.Add("contraseña", "Pass")
        Dg_todosusuarios.Columns.Add("perfil", "Perfil")

        Dg_todosusuarios.Columns(0).DataPropertyName = "id_usuario"
        Dg_todosusuarios.Columns(1).DataPropertyName = "id_personal"
        Dg_todosusuarios.Columns(2).DataPropertyName = "nombre_usuario"
        Dg_todosusuarios.Columns(3).DataPropertyName = "contraseña"
        Dg_todosusuarios.Columns(4).DataPropertyName = "perfil"

        Dg_todosusuarios.Columns(0).Visible = False
        Dg_todosusuarios.Columns(1).Visible = False

        Dg_todosusuarios.DataSource = user
        Dg_todosusuarios.ClearSelection()
    End Sub

    'BOTON SALIR
    Private Sub Btn_volver_listusuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_volver_listusuarios.Click
        Me.Close()
    End Sub
End Class