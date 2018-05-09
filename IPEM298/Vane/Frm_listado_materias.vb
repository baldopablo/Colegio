Public Class Frm_listado_materias
    Dim datacontext As New DataClassesipem2DataContext

    'LOAD DEL FORM
    Private Sub Frm_listado_materias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargargrilla()
    End Sub

    'CARGA GRILLA
    Private Sub cargargrilla()
        Dim traematerias = (From m In datacontext.Materia Select m.id_materia, m.nombre_materia, m.codigo_materia, m.especialidad_textbox).ToList ' Where nombre_materia = "Matematica"

        Dg_todasmaterias.AutoGenerateColumns = False
        Dg_todasmaterias.Columns.Clear()

        Dg_todasmaterias.Columns.Add("codigo_materia", "Código")
        Dg_todasmaterias.Columns.Add("nombre_materia", "Nombre")
        Dg_todasmaterias.Columns.Add("especialidad_textbox", "Especialidad")
        Dg_todasmaterias.Columns.Add("id_materia", "Id")

        Dg_todasmaterias.Columns(0).DataPropertyName = "codigo_materia"
        Dg_todasmaterias.Columns(1).DataPropertyName = "nombre_materia"
        Dg_todasmaterias.Columns(2).DataPropertyName = "especialidad_textbox"
        Dg_todasmaterias.Columns(3).DataPropertyName = "id_materia"

        Dg_todasmaterias.Columns(3).Visible = False

        Dg_todasmaterias.DataSource = traematerias
        Dg_todasmaterias.ClearSelection()
    End Sub

    'BOTON VOLVER
    Private Sub Btn_volver_listmat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_volver_listmat.Click
        Me.Close()
    End Sub

End Class